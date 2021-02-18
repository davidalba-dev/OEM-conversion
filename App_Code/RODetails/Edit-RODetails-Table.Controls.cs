
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_RODetails_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_RODetails_Table
{
  

#region "Section 1: Place your customizations here."

    
public class RODetailsTableControlRow : BaseRODetailsTableControlRow
{
      
        // The BaseRODetailsTableControlRow implements code for a ROW within the
        // the RODetailsTableControl table.  The BaseRODetailsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of RODetailsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class RODetailsTableControl : BaseRODetailsTableControl
{
    // The BaseRODetailsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The RODetailsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the RODetailsTableControlRow control on the Edit_RODetails_Table page.
// Do not modify this class. Instead override any method in RODetailsTableControlRow.
public class BaseRODetailsTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseRODetailsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in RODetailsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in RODetailsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
              this.ROItemDesc.TextChanged += ROItemDesc_TextChanged;
            
              this.ROLineType.TextChanged += ROLineType_TextChanged;
            
              this.ROLocation.TextChanged += ROLocation_TextChanged;
            
              this.RONo.TextChanged += RONo_TextChanged;
            
              this.ROPartNo.TextChanged += ROPartNo_TextChanged;
            
              this.ROQuantity.TextChanged += ROQuantity_TextChanged;
            
              this.ROSellPrice.TextChanged += ROSellPrice_TextChanged;
            
              this.ROStepDate.TextChanged += ROStepDate_TextChanged;
            
              this.ROStepDesc.TextChanged += ROStepDesc_TextChanged;
            
              this.ROStepHours.TextChanged += ROStepHours_TextChanged;
            
              this.ROStepTechnician.TextChanged += ROStepTechnician_TextChanged;
            
              this.SessionID.TextChanged += SessionID_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.RODetails record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = RODetailsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseRODetailsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new RODetailsRecord();
            
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
        
                
                
                SetROItemDesc();
                SetROItemDescLabel();
                SetROLineType();
                SetROLineTypeLabel();
                SetROLocation();
                SetROLocationLabel();
                SetRONo();
                SetRONoLabel();
                SetROPartNo();
                SetROPartNoLabel();
                SetROQuantity();
                SetROQuantityLabel();
                SetROSellPrice();
                SetROSellPriceLabel();
                SetROStepDate();
                SetROStepDateLabel();
                SetROStepDesc();
                SetROStepDescLabel();
                SetROStepHours();
                SetROStepHoursLabel();
                SetROStepTechnician();
                SetROStepTechnicianLabel();
                
                SetSessionID();
                SetSessionIDLabel();
                
                SetDeleteRowButton();
              
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
        
        
        public virtual void SetROItemDesc()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROItemDesc.ID))
            {
            
                this.ROItemDesc.Text = this.PreviousUIData[this.ROItemDesc.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROItemDesc TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROItemDesc is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROItemDescSpecified) {
                								
                // If the ROItemDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROItemDesc);
                                
                this.ROItemDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROItemDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROItemDesc.Text = RODetailsTable.ROItemDesc.Format(RODetailsTable.ROItemDesc.DefaultValue);
            		
            }
            
              this.ROItemDesc.TextChanged += ROItemDesc_TextChanged;
                               
        }
                
        public virtual void SetROLineType()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROLineType.ID))
            {
            
                this.ROLineType.Text = this.PreviousUIData[this.ROLineType.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROLineType TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROLineType is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLineTypeSpecified) {
                								
                // If the ROLineType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROLineType);
                                
                this.ROLineType.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLineType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLineType.Text = RODetailsTable.ROLineType.Format(RODetailsTable.ROLineType.DefaultValue);
            		
            }
            
              this.ROLineType.TextChanged += ROLineType_TextChanged;
                               
        }
                
        public virtual void SetROLocation()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROLocation.ID))
            {
            
                this.ROLocation.Text = this.PreviousUIData[this.ROLocation.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROLocation TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROLocation is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROLocationSpecified) {
                								
                // If the ROLocation is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROLocation);
                                
                this.ROLocation.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROLocation is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROLocation.Text = RODetailsTable.ROLocation.Format(RODetailsTable.ROLocation.DefaultValue);
            		
            }
            
              this.ROLocation.TextChanged += ROLocation_TextChanged;
                               
        }
                
        public virtual void SetRONo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RONo.ID))
            {
            
                this.RONo.Text = this.PreviousUIData[this.RONo.ID].ToString();
              
                return;
            }
            
                    
            // Set the RONo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.RONo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RONoSpecified) {
                								
                // If the RONo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.RONo.ToString();
                            
                this.RONo.Text = formattedValue;
                   
            } 
            
            else {
            
                // RONo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RONo.Text = RODetailsTable.RONo.DefaultValue;
            		
            }
            
              this.RONo.TextChanged += RONo_TextChanged;
                               
        }
                
        public virtual void SetROPartNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROPartNo.ID))
            {
            
                this.ROPartNo.Text = this.PreviousUIData[this.ROPartNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROPartNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROPartNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROPartNoSpecified) {
                								
                // If the ROPartNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.ROPartNo.ToString();
                            
                this.ROPartNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROPartNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROPartNo.Text = RODetailsTable.ROPartNo.DefaultValue;
            		
            }
            
              this.ROPartNo.TextChanged += ROPartNo_TextChanged;
                               
        }
                
        public virtual void SetROQuantity()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROQuantity.ID))
            {
            
                this.ROQuantity.Text = this.PreviousUIData[this.ROQuantity.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROQuantity TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROQuantity is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROQuantitySpecified) {
                								
                // If the ROQuantity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROQuantity);
                                
                this.ROQuantity.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROQuantity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROQuantity.Text = RODetailsTable.ROQuantity.Format(RODetailsTable.ROQuantity.DefaultValue);
            		
            }
            
              this.ROQuantity.TextChanged += ROQuantity_TextChanged;
                               
        }
                
        public virtual void SetROSellPrice()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROSellPrice.ID))
            {
            
                this.ROSellPrice.Text = this.PreviousUIData[this.ROSellPrice.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROSellPrice TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROSellPrice is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROSellPriceSpecified) {
                								
                // If the ROSellPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROSellPrice, @"C");
                                
                this.ROSellPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROSellPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROSellPrice.Text = RODetailsTable.ROSellPrice.Format(RODetailsTable.ROSellPrice.DefaultValue, @"C");
            		
            }
            
              this.ROSellPrice.TextChanged += ROSellPrice_TextChanged;
                               
        }
                
        public virtual void SetROStepDate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROStepDate.ID))
            {
            
                this.ROStepDate.Text = this.PreviousUIData[this.ROStepDate.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROStepDate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROStepDate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROStepDateSpecified) {
                								
                // If the ROStepDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROStepDate, @"g");
                                
                this.ROStepDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROStepDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROStepDate.Text = RODetailsTable.ROStepDate.Format(RODetailsTable.ROStepDate.DefaultValue, @"g");
            		
            }
            
              this.ROStepDate.TextChanged += ROStepDate_TextChanged;
                               
        }
                
        public virtual void SetROStepDesc()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROStepDesc.ID))
            {
            
                this.ROStepDesc.Text = this.PreviousUIData[this.ROStepDesc.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROStepDesc TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROStepDesc is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROStepDescSpecified) {
                								
                // If the ROStepDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROStepDesc);
                                
                this.ROStepDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROStepDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROStepDesc.Text = RODetailsTable.ROStepDesc.Format(RODetailsTable.ROStepDesc.DefaultValue);
            		
            }
            
              this.ROStepDesc.TextChanged += ROStepDesc_TextChanged;
                               
        }
                
        public virtual void SetROStepHours()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROStepHours.ID))
            {
            
                this.ROStepHours.Text = this.PreviousUIData[this.ROStepHours.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROStepHours TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROStepHours is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROStepHoursSpecified) {
                								
                // If the ROStepHours is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROStepHours);
                                
                this.ROStepHours.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROStepHours is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROStepHours.Text = RODetailsTable.ROStepHours.Format(RODetailsTable.ROStepHours.DefaultValue);
            		
            }
            
              this.ROStepHours.TextChanged += ROStepHours_TextChanged;
                               
        }
                
        public virtual void SetROStepTechnician()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ROStepTechnician.ID))
            {
            
                this.ROStepTechnician.Text = this.PreviousUIData[this.ROStepTechnician.ID].ToString();
              
                return;
            }
            
                    
            // Set the ROStepTechnician TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.ROStepTechnician is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ROStepTechnicianSpecified) {
                								
                // If the ROStepTechnician is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.ROStepTechnician);
                                
                this.ROStepTechnician.Text = formattedValue;
                   
            } 
            
            else {
            
                // ROStepTechnician is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ROStepTechnician.Text = RODetailsTable.ROStepTechnician.Format(RODetailsTable.ROStepTechnician.DefaultValue);
            		
            }
            
              this.ROStepTechnician.TextChanged += ROStepTechnician_TextChanged;
                               
        }
                
        public virtual void SetSessionID()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.SessionID.ID))
            {
            
                this.SessionID.Text = this.PreviousUIData[this.SessionID.ID].ToString();
              
                return;
            }
            
                    
            // Set the SessionID TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.RODetails database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.RODetails record retrieved from the database.
            // this.SessionID is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SessionIDSpecified) {
                								
                // If the SessionID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(RODetailsTable.SessionID);
                                
                this.SessionID.Text = formattedValue;
                   
            } 
            
            else {
            
                // SessionID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SessionID.Text = RODetailsTable.SessionID.Format(RODetailsTable.SessionID.DefaultValue);
            		
            }
            
              this.SessionID.TextChanged += SessionID_TextChanged;
                               
        }
                
        public virtual void SetROItemDescLabel()
                  {
                  
                        this.ROItemDescLabel.Text = EvaluateFormula("\"Item Description\"");
                      
                    
        }
                
        public virtual void SetROLineTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetROLocationLabel()
                  {
                  
                    
        }
                
        public virtual void SetRONoLabel()
                  {
                  
                    
        }
                
        public virtual void SetROPartNoLabel()
                  {
                  
                        this.ROPartNoLabel.Text = EvaluateFormula("\"Part Number\"");
                      
                    
        }
                
        public virtual void SetROQuantityLabel()
                  {
                  
                        this.ROQuantityLabel.Text = EvaluateFormula("\"Quantity\"");
                      
                    
        }
                
        public virtual void SetROSellPriceLabel()
                  {
                  
                        this.ROSellPriceLabel.Text = EvaluateFormula("\"Sell Price\"");
                      
                    
        }
                
        public virtual void SetROStepDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetROStepDescLabel()
                  {
                  
                    
        }
                
        public virtual void SetROStepHoursLabel()
                  {
                  
                    
        }
                
        public virtual void SetROStepTechnicianLabel()
                  {
                  
                    
        }
                
        public virtual void SetSessionIDLabel()
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
                ((RODetailsTableControl)MiscUtils.GetParentControlObject(this, "RODetailsTableControl")).DataChanged = true;
                ((RODetailsTableControl)MiscUtils.GetParentControlObject(this, "RODetailsTableControl")).ResetData = true;
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
        
            GetROItemDesc();
            GetROLineType();
            GetROLocation();
            GetRONo();
            GetROPartNo();
            GetROQuantity();
            GetROSellPrice();
            GetROStepDate();
            GetROStepDesc();
            GetROStepHours();
            GetROStepTechnician();
            GetSessionID();
        }
        
        
        public virtual void GetROItemDesc()
        {
            
            // Retrieve the value entered by the user on the ROItemDesc ASP:TextBox, and
            // save it into the ROItemDesc field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROItemDesc.Text, RODetailsTable.ROItemDesc);							
                          
                      
        }
                
        public virtual void GetROLineType()
        {
            
            // Retrieve the value entered by the user on the ROLineType ASP:TextBox, and
            // save it into the ROLineType field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROLineType.Text, RODetailsTable.ROLineType);							
                          
                      
        }
                
        public virtual void GetROLocation()
        {
            
            // Retrieve the value entered by the user on the ROLocation ASP:TextBox, and
            // save it into the ROLocation field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROLocation.Text, RODetailsTable.ROLocation);							
                          
                      
        }
                
        public virtual void GetRONo()
        {
            
            // Retrieve the value entered by the user on the RONo ASP:TextBox, and
            // save it into the RONo field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.RONo.Text, RODetailsTable.RONo);							
                          
                      
        }
                
        public virtual void GetROPartNo()
        {
            
            // Retrieve the value entered by the user on the ROPartNo ASP:TextBox, and
            // save it into the ROPartNo field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROPartNo.Text, RODetailsTable.ROPartNo);							
                          
                      
        }
                
        public virtual void GetROQuantity()
        {
            
            // Retrieve the value entered by the user on the ROQuantity ASP:TextBox, and
            // save it into the ROQuantity field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROQuantity.Text, RODetailsTable.ROQuantity);							
                          
                      
        }
                
        public virtual void GetROSellPrice()
        {
            
            // Retrieve the value entered by the user on the ROSellPrice ASP:TextBox, and
            // save it into the ROSellPrice field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROSellPrice.Text, RODetailsTable.ROSellPrice);							
                          
                      
        }
                
        public virtual void GetROStepDate()
        {
            
            // Retrieve the value entered by the user on the ROStepDate ASP:TextBox, and
            // save it into the ROStepDate field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROStepDate.Text, RODetailsTable.ROStepDate);							
                          
                      
        }
                
        public virtual void GetROStepDesc()
        {
            
            // Retrieve the value entered by the user on the ROStepDesc ASP:TextBox, and
            // save it into the ROStepDesc field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROStepDesc.Text, RODetailsTable.ROStepDesc);							
                          
                      
        }
                
        public virtual void GetROStepHours()
        {
            
            // Retrieve the value entered by the user on the ROStepHours ASP:TextBox, and
            // save it into the ROStepHours field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROStepHours.Text, RODetailsTable.ROStepHours);							
                          
                      
        }
                
        public virtual void GetROStepTechnician()
        {
            
            // Retrieve the value entered by the user on the ROStepTechnician ASP:TextBox, and
            // save it into the ROStepTechnician field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ROStepTechnician.Text, RODetailsTable.ROStepTechnician);							
                          
                      
        }
                
        public virtual void GetSessionID()
        {
            
            // Retrieve the value entered by the user on the SessionID ASP:TextBox, and
            // save it into the SessionID field in DataSource DatabaseAYS_OEM%dbo.RODetails record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.SessionID.Text, RODetailsTable.SessionID);							
                          
                      
        }
                

      // To customize, override this method in RODetailsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersRODetailsTableControl = false;
            hasFiltersRODetailsTableControl = hasFiltersRODetailsTableControl && false; // suppress warning
      
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
          RODetailsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((RODetailsTableControl)MiscUtils.GetParentControlObject(this, "RODetailsTableControl")).DataChanged = true;
            ((RODetailsTableControl)MiscUtils.GetParentControlObject(this, "RODetailsTableControl")).ResetData = true;
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
            
        public virtual void SetViewRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        RODetailsTableControl tc= ((RODetailsTableControl)MiscUtils.GetParentControlObject(this, "RODetailsTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((RODetailsTableControlRow)this);
                    }
                    this.Visible = false;
                    tc.SetFormulaControls();                    
                }
              
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
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../RODetails/Edit-RODetails.aspx?RODetails={PK}";
            
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
            
            string url = @"../RODetails/Show-RODetails.aspx?RODetails={PK}";
            
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
            
            
        
        protected virtual void ROItemDesc_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROLineType_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROLocation_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void RONo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROPartNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROQuantity_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROSellPrice_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROStepDate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROStepDesc_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROStepHours_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ROStepTechnician_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void SessionID_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseRODetailsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseRODetailsTableControlRow_Rec"] = value;
            }
        }
        
        public RODetailsRecord DataSource {
            get {
                return (RODetailsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox ROItemDesc {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROItemDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROItemDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROItemDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROLineType {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLineType");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLineTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLineTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROLocation {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLocation");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROLocationLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLocationLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox RONo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONo");
            }
        }
            
        public System.Web.UI.WebControls.Literal RONoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RONoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROPartNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPartNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROPartNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPartNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROQuantity {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQuantity");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROQuantityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROQuantityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROSellPrice {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSellPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROSellPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROSellPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROStepDate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStepDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROStepDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStepDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROStepDesc {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStepDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROStepDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStepDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROStepHours {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStepHours");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROStepHoursLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStepHoursLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROStepTechnician {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStepTechnician");
            }
        }
            
        public System.Web.UI.WebControls.Literal ROStepTechnicianLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROStepTechnicianLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SelectRow {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow");
            }
        }              
            
        public System.Web.UI.WebControls.TextBox SessionID {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SessionID");
            }
        }
            
        public System.Web.UI.WebControls.Literal SessionIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SessionIDLabel");
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
        RODetailsRecord rec = null;
             
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
    RODetailsRecord rec = null;
    
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

        
        public virtual RODetailsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return RODetailsTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the RODetailsTableControl control on the Edit_RODetails_Table page.
// Do not modify this class. Instead override any method in RODetailsTableControl.
public class BaseRODetailsTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseRODetailsTableControl()
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
                if  (this.InSession(this.ROLineTypeFromFilter)) 				
                    initialVal = this.GetFromSession(this.ROLineTypeFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROLineTypeFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ROLineTypeFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROLineTypeToFilter)) 				
                    initialVal = this.GetFromSession(this.ROLineTypeToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROLineTypeTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ROLineTypeToFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ROPartNoFilter)) 				
                    initialVal = this.GetFromSession(this.ROPartNoFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ROPartNo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] ROPartNoFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in ROPartNoFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.ROPartNoFilter.Items.Add(item);
                            this.ROPartNoFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.ROPartNoFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
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
        
              // Show confirmation message on Click
              this.DeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "OEMConversion") + "\"));");
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
          
                    this.AddButton.Click += AddButton_Click;
                        
                    this.DeleteButton.Click += DeleteButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SaveButton.Click += SaveButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
              this.ROPartNoFilter.SelectedIndexChanged += ROPartNoFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.RODetailsRecord);
                      this.DataSource = (RODetailsRecord[])(alist.ToArray(myrec));
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
                    foreach (RODetailsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.RODetailsRecord);
                    this.DataSource = (RODetailsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual RODetailsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(RODetailsTable.Column1, true);          
            // selCols.Add(RODetailsTable.Column2, true);          
            // selCols.Add(RODetailsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return RODetailsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                RODetailsTable databaseTable = new RODetailsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(RODetailsRecord)) as RODetailsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(RODetailsTable.Column1, true);          
            // selCols.Add(RODetailsTable.Column2, true);          
            // selCols.Add(RODetailsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return RODetailsTable.GetRecordCount(join, where);
            else
            {
                RODetailsTable databaseTable = new RODetailsTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODetailsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            RODetailsTableControlRow recControl = (RODetailsTableControlRow)(repItem.FindControl("RODetailsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                SetOrderSort();
                
                
                
                SetROLineTypeLabel1();
                
                
                SetROPartNoFilter();
                SetROPartNoLabel1();
                
                
                SetSearchText();
                SetSortByLabel();
                
                
                SetAddButton();
              
                SetDeleteButton();
              
                SetResetButton();
              
                SetSaveButton();
              
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

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(RODetailsTable.RONo, this.DataSource);
            this.Page.PregetDfkaRecords(RODetailsTable.ROPartNo, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SaveButton"));
                                
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


            
            this.ROPartNoFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
            this.ROLineTypeFromFilter.Text = "";
            
            this.ROLineTypeToFilter.Text = "";
            
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
    
            // Bind the buttons for RODetailsTableControl pagination.
        
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
              
            foreach (RODetailsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (RODetailsTableControlRow recCtl in this.GetRecordControls()){
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
            RODetailsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.ROLineTypeFromFilter)) {
                        
                //Check to see if the Byte value entered for the filter is valid.
                if (Convert.ToInt32(this.ROLineTypeFromFilter.Text) > 255) {
                    string errMssg = this.Page.GetResourceValue("Val:ValueTooLong", "OEMConversion");
                    errMssg = errMssg.Replace("{FieldName}", "ROLineTypeFromFilter");
                    BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this.ROLineTypeFromFilter, "BUTTON_CLICK_MESSAGE", errMssg);
                }
                            
                wc.iAND(RODetailsTable.ROLineType, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(this.ROLineTypeFromFilter, this.GetFromSession(this.ROLineTypeFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROLineTypeToFilter)) {
                        
                //Check to see if the Byte value entered for the filter is valid.
                if (Convert.ToInt32(this.ROLineTypeToFilter.Text) > 255) {
                    string errMssg = this.Page.GetResourceValue("Val:ValueTooLong", "OEMConversion");
                    errMssg = errMssg.Replace("{FieldName}", "ROLineTypeToFilter");
                    BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this.ROLineTypeToFilter, "BUTTON_CLICK_MESSAGE", errMssg);
                }
                            
                wc.iAND(RODetailsTable.ROLineType, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(this.ROLineTypeToFilter, this.GetFromSession(this.ROLineTypeToFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ROPartNoFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.ROPartNoFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.ROPartNoFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(RODetailsTable.ROPartNo, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
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
      
      cols.Add(RODetailsTable.ROPartNo, true);
      
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
            RODetailsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String ROLineTypeFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROLineTypeFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROLineTypeFromFilterSelectedValue)) {

              
                wc.iAND(RODetailsTable.ROLineType, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, ROLineTypeFromFilterSelectedValue, false, false);
                      
      }
                      
      String ROLineTypeToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROLineTypeToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROLineTypeToFilterSelectedValue)) {

              
                wc.iAND(RODetailsTable.ROLineType, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, ROLineTypeToFilterSelectedValue, false, false);
                      
      }
                      
      String ROPartNoFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ROPartNoFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ROPartNoFilterSelectedValue)) {

              
        if (ROPartNoFilterSelectedValue != null){
                        string[] ROPartNoFilteritemListFromSession = ROPartNoFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in ROPartNoFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(RODetailsTable.ROPartNo, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
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
      
      cols.Add(RODetailsTable.ROPartNo, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(RODetailsTable.ROPartNo, true);
      
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
            OEMConversion.Business.RODetailsRecord[] recordList  = RODetailsTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (RODetailsRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(RODetailsTable.ROPartNo);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(RODetailsTable.ROPartNo.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, RODetailsTable.ROPartNo.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RODetailsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RODetailsTableControlRow recControl = (RODetailsTableControlRow)(repItem.FindControl("RODetailsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      RODetailsRecord rec = new RODetailsRecord();
        
                        if (recControl.ROItemDesc.Text != "") {
                            rec.Parse(recControl.ROItemDesc.Text, RODetailsTable.ROItemDesc);
                  }
                
                        if (recControl.ROLineType.Text != "") {
                            rec.Parse(recControl.ROLineType.Text, RODetailsTable.ROLineType);
                  }
                
                        if (recControl.ROLocation.Text != "") {
                            rec.Parse(recControl.ROLocation.Text, RODetailsTable.ROLocation);
                  }
                
                        if (recControl.RONo.Text != "") {
                            rec.Parse(recControl.RONo.Text, RODetailsTable.RONo);
                  }
                
                        if (recControl.ROPartNo.Text != "") {
                            rec.Parse(recControl.ROPartNo.Text, RODetailsTable.ROPartNo);
                  }
                
                        if (recControl.ROQuantity.Text != "") {
                            rec.Parse(recControl.ROQuantity.Text, RODetailsTable.ROQuantity);
                  }
                
                        if (recControl.ROSellPrice.Text != "") {
                            rec.Parse(recControl.ROSellPrice.Text, RODetailsTable.ROSellPrice);
                  }
                
                        if (recControl.ROStepDate.Text != "") {
                            rec.Parse(recControl.ROStepDate.Text, RODetailsTable.ROStepDate);
                  }
                
                        if (recControl.ROStepDesc.Text != "") {
                            rec.Parse(recControl.ROStepDesc.Text, RODetailsTable.ROStepDesc);
                  }
                
                        if (recControl.ROStepHours.Text != "") {
                            rec.Parse(recControl.ROStepHours.Text, RODetailsTable.ROStepHours);
                  }
                
                        if (recControl.ROStepTechnician.Text != "") {
                            rec.Parse(recControl.ROStepTechnician.Text, RODetailsTable.ROStepTechnician);
                  }
                
                        if (recControl.SessionID.Text != "") {
                            rec.Parse(recControl.SessionID.Text, RODetailsTable.SessionID);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new RODetailsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.RODetailsRecord);
                this.DataSource = (RODetailsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(RODetailsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(RODetailsTableControlRow rec)            
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
        
        public virtual void SetROLineTypeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetROPartNoLabel1()
                  {
                  
                        this.ROPartNoLabel1.Text = EvaluateFormula("\"Part Number\"");
                      
                    
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
            
        public virtual void SetROPartNoFilter()
        {
            
            ArrayList ROPartNoFilterselectedFilterItemList = new ArrayList();
            string ROPartNoFilteritemsString = null;
            if (this.InSession(this.ROPartNoFilter))
                ROPartNoFilteritemsString = this.GetFromSession(this.ROPartNoFilter);
            
            if (ROPartNoFilteritemsString != null)
            {
                string[] ROPartNoFilteritemListFromSession = ROPartNoFilteritemsString.Split(',');
                foreach (string item in ROPartNoFilteritemListFromSession)
                {
                    ROPartNoFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateROPartNoFilter(MiscUtils.GetSelectedValueList(this.ROPartNoFilter, ROPartNoFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../ServiceCodes/ServiceCodes-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ROPartNoFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ServCode")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ROPartNoFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ROPartNoFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
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
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Item Description {Txt:Ascending}"), "ROItemDesc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Item Description {Txt:Descending}"), "ROItemDesc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Line Type {Txt:Ascending}"), "ROLineType Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Line Type {Txt:Descending}"), "ROLineType Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Location {Txt:Ascending}"), "ROLocation Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Location {Txt:Descending}"), "ROLocation Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Number {Txt:Ascending}"), "RONo Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Number {Txt:Descending}"), "RONo Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Part Number {Txt:Ascending}"), "ROPartNo Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Part Number {Txt:Descending}"), "ROPartNo Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Quantity {Txt:Ascending}"), "ROQuantity Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Quantity {Txt:Descending}"), "ROQuantity Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Sell Price {Txt:Ascending}"), "ROSellPrice Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Sell Price {Txt:Descending}"), "ROSellPrice Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Step Date {Txt:Ascending}"), "ROStepDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Step Date {Txt:Descending}"), "ROStepDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Step Description {Txt:Ascending}"), "ROStepDesc Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Step Description {Txt:Descending}"), "ROStepDesc Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Step Technician {Txt:Ascending}"), "ROStepTechnician Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Step Technician {Txt:Descending}"), "ROStepTechnician Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Totalprice {Txt:Ascending}"), "ro_totalprice Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("RO Totalprice {Txt:Descending}"), "ro_totalprice Desc"));
              
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
            
        // Get the filters' data for ROPartNoFilter.
                
        protected virtual void PopulateROPartNoFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_ROPartNoFilter();            
            this.ROPartNoFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ROPartNoFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            ServiceCodesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = ServiceCodesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (ServiceCodesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ServCodeSpecified) 
                        {
                            cvalue = itemValue.ServCode.ToString();
                            if (counter < maxItems && this.ROPartNoFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = RODetailsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RODetailsTable.ROPartNo);
                                if(_isExpandableNonCompositeForeignKey && RODetailsTable.ROPartNo.IsApplyDisplayAs)
                                     fvalue = RODetailsTable.GetDFKA(itemValue, RODetailsTable.ROPartNo);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(ServiceCodesTable.ServCode);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ROPartNoFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ROPartNoFilter.Items.Add(newItem);

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
            
            
            this.ROPartNoFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.ROPartNoFilter.Items.Count == 0)
                this.ROPartNoFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.ROPartNoFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_ROPartNoFilter()
        {
            // Create a where clause for the filter ROPartNoFilter.
            // This function is called by the Populate method to load the items 
            // in the ROPartNoFilterQuickSelector
        
            ArrayList ROPartNoFilterselectedFilterItemList = new ArrayList();
            string ROPartNoFilteritemsString = null;
            if (this.InSession(this.ROPartNoFilter))
                ROPartNoFilteritemsString = this.GetFromSession(this.ROPartNoFilter);
            
            if (ROPartNoFilteritemsString != null)
            {
                string[] ROPartNoFilteritemListFromSession = ROPartNoFilteritemsString.Split(',');
                foreach (string item in ROPartNoFilteritemListFromSession)
                {
                    ROPartNoFilterselectedFilterItemList.Add(item);
                }
            }
              
            ROPartNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROPartNoFilter, ROPartNoFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (ROPartNoFilterselectedFilterItemList == null || ROPartNoFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in ROPartNoFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(ServiceCodesTable.ServCode, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
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
                    bool added = (this.AddNewRecord > 0);
                    this.LoadData();
                    this.DataBind();					
                    
                    if (added) this.SetFocusToAddedRow();
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("RODetailsTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RODetailsTableControlRow recControl = (RODetailsTableControlRow)repItem.FindControl("RODetailsTableControlRow");
                if(recControl.IsNewRecord) {
                    foreach (Control field in recControl.Controls) {
                    if (field.Visible && this.Page.IsControlEditable(field, false)) {
                        //set focus on the first editable field in the new row
                        field.Focus();
                        UpdatePanel updPan = (UpdatePanel)this.Page.FindControlRecursively("UpdatePanel1");
                        if (updPan != null) updPan.Update();
                        return;
                        }
                    }
                    return;
                }
            }
        }
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            this.SaveToSession(this.ROLineTypeFromFilter, this.ROLineTypeFromFilter.Text);
                  
            this.SaveToSession(this.ROLineTypeToFilter, this.ROLineTypeToFilter.Text);
                  
            ArrayList ROPartNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROPartNoFilter, null);
            string ROPartNoFilterSessionString = "";
            if (ROPartNoFilterselectedFilterItemList != null){
                foreach (string item in ROPartNoFilterselectedFilterItemList){
                    ROPartNoFilterSessionString = String.Concat(ROPartNoFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.ROPartNoFilter, ROPartNoFilterSessionString);
                  
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
                  
      this.SaveToSession("ROLineTypeFromFilter_Ajax", this.ROLineTypeFromFilter.Text);
              
      this.SaveToSession("ROLineTypeToFilter_Ajax", this.ROLineTypeToFilter.Text);
              
            ArrayList ROPartNoFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ROPartNoFilter, null);
            string ROPartNoFilterSessionString = "";
            if (ROPartNoFilterselectedFilterItemList != null){
                foreach (string item in ROPartNoFilterselectedFilterItemList){
                    ROPartNoFilterSessionString = String.Concat(ROPartNoFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("ROPartNoFilter_Ajax", ROPartNoFilterSessionString);
          
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.ROLineTypeFromFilter);
            this.RemoveFromSession(this.ROLineTypeToFilter);
            this.RemoveFromSession(this.ROPartNoFilter);
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

            string orderByStr = (string)ViewState["RODetailsTableControl_OrderBy"];
          
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
                this.ViewState["RODetailsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetAddButton()                
              
        {
        
   
        }
            
        public virtual void SetDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetSaveButton()                
              
        {
        
                    this.SaveButton.Attributes.Add("onclick", "SubmitHRefOnce(this, \"" + this.Page.GetResourceValue("Txt:SaveRecord", "OEMConversion") + "\");");
                  
   
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
    
      
            if (MiscUtils.IsValueSelected(ROLineTypeFromFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROLineTypeToFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ROPartNoFilter))
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
        

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void AddButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
        public virtual void DeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
                this.SetFormulaControls();
          
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
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.ROPartNoFilter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
              this.ROLineTypeFromFilter.Text = "";
            
              this.ROLineTypeToFilter.Text = "";
            
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
        public virtual void SaveButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
        
              if (!this.Page.IsPageRefresh)
              {
                  this.SaveData();
              }

          this.Page.CommitTransaction(sender);
          // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
           
                foreach (RODetailsTableControlRow recCtl in this.GetRecordControls()){
                     
                    recCtl.IsNewRecord = false;
                }
      
          // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
          
                this.DeletedRecordIds = null;
            
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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in RODetailsTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(RODetailsTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (RODetailsTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && RODetailsTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(RODetailsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(RODetailsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void ROPartNoFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = RODetailsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  RODetailsRecord[] DataSource {
             
            get {
                return (RODetailsRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton AddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AddButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteButton");
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
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROLineTypeFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLineTypeFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal ROLineTypeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLineTypeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ROLineTypeToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROLineTypeToFilter");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ROPartNoFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPartNoFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal ROPartNoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ROPartNoLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SaveButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SaveButton");
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
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ToggleAll");
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
                RODetailsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        RODetailsRecord rec = null;
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
                RODetailsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        RODetailsRecord rec = null;
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
          
        public virtual int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (RODetailsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual RODetailsTableControlRow GetSelectedRecordControl()
        {
        RODetailsTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual RODetailsTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (RODetailsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow != null && recControl.SelectRow.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (RODetailsTableControlRow[])(selectedList.ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_RODetails_Table.RODetailsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            RODetailsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (RODetailsTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.SelectRow.Checked = false;
                
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

        public virtual RODetailsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "RODetailsTableControlRow");
	          List<RODetailsTableControlRow> list = new List<RODetailsTableControlRow>();
	          foreach (RODetailsTableControlRow recCtrl in recCtrls) {
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

  