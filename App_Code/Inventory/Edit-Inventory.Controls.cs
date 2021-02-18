
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Inventory.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Inventory
{
  

#region "Section 1: Place your customizations here."

    
public class InventoryRecordControl : BaseInventoryRecordControl
{
      
        // The BaseInventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the InventoryRecordControl control on the Edit_Inventory page.
// Do not modify this class. Instead override any method in InventoryRecordControl.
public class BaseInventoryRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseInventoryRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in InventoryRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in InventoryRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.InvCategory.SelectedIndexChanged += InvCategory_SelectedIndexChanged;
            
              this.InvVendNo1.SelectedIndexChanged += InvVendNo1_SelectedIndexChanged;
            
              this.Inventory_active.CheckedChanged += Inventory_active_CheckedChanged;
            
              this.InvAvgBuyPrice.TextChanged += InvAvgBuyPrice_TextChanged;
            
              this.InvItemDesc.TextChanged += InvItemDesc_TextChanged;
            
              this.InvMake.TextChanged += InvMake_TextChanged;
            
              this.InvPartNo.TextChanged += InvPartNo_TextChanged;
            
              this.InvSellPrice0.TextChanged += InvSellPrice0_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = InventoryTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "InventoryRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new InventoryRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            InventoryRecord[] recList = InventoryTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = InventoryTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetInvAvgBuyPrice();
                SetInvAvgBuyPriceLabel();
                SetInvCategory();
                SetInvCategoryLabel();
                SetInventory_active();
                SetInventory_activeLabel();
                SetInvItemDesc();
                SetInvItemDescLabel();
                SetInvMake();
                SetInvMakeLabel();
                SetInvNotes();
                SetInvNotesLabel();
                SetInvPartNo();
                SetInvPartNoLabel();
                SetInvSellPrice0();
                SetInvSellPrice0Label();
                SetInvVendNo1();
                SetInvVendNo1Label();
                

      

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
        
        
        public virtual void SetInvAvgBuyPrice()
        {
            
                    
            // Set the InvAvgBuyPrice TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvAvgBuyPrice is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvAvgBuyPriceSpecified) {
                								
                // If the InvAvgBuyPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvAvgBuyPrice, @"C");
                                
                this.InvAvgBuyPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvAvgBuyPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvAvgBuyPrice.Text = InventoryTable.InvAvgBuyPrice.Format(InventoryTable.InvAvgBuyPrice.DefaultValue, @"C");
            		
            }
            
              this.InvAvgBuyPrice.TextChanged += InvAvgBuyPrice_TextChanged;
                               
        }
                
        public virtual void SetInvCategory()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the InvCategory DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvCategory is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetInvCategory();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.InvCategorySpecified)
            {
                            
                // If the InvCategory is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.InvCategory;
                
            }
            else
            {
                
                // InvCategory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = InventoryTable.InvCategory.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateInvCategoryDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetInventory_active()
        {
            
                    
            // Set the Inventory_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.Inventory_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Inventory_activeSpecified) {
                							
                // If the Inventory_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.Inventory_active.Checked = this.DataSource.Inventory_active;
                    				
            } else {
            
                // Inventory_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.Inventory_active.Checked = InventoryTable.Inventory_active.ParseValue(InventoryTable.Inventory_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetInvItemDesc()
        {
            
                    
            // Set the InvItemDesc TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvItemDesc is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvItemDescSpecified) {
                								
                // If the InvItemDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvItemDesc);
                                
                this.InvItemDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvItemDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvItemDesc.Text = InventoryTable.InvItemDesc.Format(InventoryTable.InvItemDesc.DefaultValue);
            		
            }
            
              this.InvItemDesc.TextChanged += InvItemDesc_TextChanged;
                               
        }
                
        public virtual void SetInvMake()
        {
            
                    
            // Set the InvMake TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMake is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMakeSpecified) {
                								
                // If the InvMake is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMake);
                                
                this.InvMake.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMake.Text = InventoryTable.InvMake.Format(InventoryTable.InvMake.DefaultValue);
            		
            }
            
              this.InvMake.TextChanged += InvMake_TextChanged;
                               
        }
                
        public virtual void SetInvNotes()
        {
            
                    
            // Set the InvNotes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvNotes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvNotesSpecified) {
                								
                // If the InvNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvNotes);
                                                
                this.InvNotes.Content = formattedValue;
                 
            } 
            
            else {
            
                // InvNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                    
            this.InvNotes.Content = InventoryTable.InvNotes.Format(InventoryTable.InvNotes.DefaultValue);
          		
            }
                               
        }
                
        public virtual void SetInvPartNo()
        {
            
                    
            // Set the InvPartNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPartNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPartNoSpecified) {
                								
                // If the InvPartNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPartNo);
                                
                this.InvPartNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPartNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPartNo.Text = InventoryTable.InvPartNo.Format(InventoryTable.InvPartNo.DefaultValue);
            		
            }
            
              this.InvPartNo.TextChanged += InvPartNo_TextChanged;
                               
        }
                
        public virtual void SetInvSellPrice0()
        {
            
                    
            // Set the InvSellPrice0 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice0 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice0Specified) {
                								
                // If the InvSellPrice0 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice0, @"C");
                                
                this.InvSellPrice0.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice0.Text = InventoryTable.InvSellPrice0.Format(InventoryTable.InvSellPrice0.DefaultValue, @"C");
            		
            }
            
              this.InvSellPrice0.TextChanged += InvSellPrice0_TextChanged;
                               
        }
                
        public virtual void SetInvVendNo1()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the InvVendNo1 DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendNo1 is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetInvVendNo1();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.InvVendNo1Specified)
            {
                            
                // If the InvVendNo1 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.InvVendNo1.ToString();
                
            }
            else
            {
                
                // InvVendNo1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = InventoryTable.InvVendNo1.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateInvVendNo1DropDownList(selectedValue, 1000);              
                
                  
        }
                
        public virtual void SetInvAvgBuyPriceLabel()
                  {
                  
                        this.InvAvgBuyPriceLabel.Text = EvaluateFormula("\"Avg Buy Price\"");
                      
                    
        }
                
        public virtual void SetInvCategoryLabel()
                  {
                  
                        this.InvCategoryLabel.Text = EvaluateFormula("\"Category\"");
                      
                    
        }
                
        public virtual void SetInventory_activeLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvItemDescLabel()
                  {
                  
                        this.InvItemDescLabel.Text = EvaluateFormula("\"Item Description\"");
                      
                    
        }
                
        public virtual void SetInvMakeLabel()
                  {
                  
                        this.InvMakeLabel.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void SetInvNotesLabel()
                  {
                  
                        this.InvNotesLabel.Text = EvaluateFormula("\"Notes\"");
                      
                    
        }
                
        public virtual void SetInvPartNoLabel()
                  {
                  
                        this.InvPartNoLabel.Text = EvaluateFormula("\"Part Number\"");
                      
                    
        }
                
        public virtual void SetInvSellPrice0Label()
                  {
                  
                        this.InvSellPrice0Label.Text = EvaluateFormula("\"Sell Price\"");
                      
                    
        }
                
        public virtual void SetInvVendNo1Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.InvVendNo1Label.Text = "Some value";
                    
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "InventoryRecordControlPanel");
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
        
            GetInvAvgBuyPrice();
            GetInvCategory();
            GetInventory_active();
            GetInvItemDesc();
            GetInvMake();
            GetInvNotes();
            GetInvPartNo();
            GetInvSellPrice0();
            GetInvVendNo1();
        }
        
        
        public virtual void GetInvAvgBuyPrice()
        {
            
            // Retrieve the value entered by the user on the InvAvgBuyPrice ASP:TextBox, and
            // save it into the InvAvgBuyPrice field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvAvgBuyPrice.Text, InventoryTable.InvAvgBuyPrice);							
                          
                      
        }
                
        public virtual void GetInvCategory()
        {
         // Retrieve the value entered by the user on the InvCategory ASP:DropDownList, and
            // save it into the InvCategory field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.InvCategory), InventoryTable.InvCategory);			
                			 
        }
                
        public virtual void GetInventory_active()
        {	
        		
            // Retrieve the value entered by the user on the Inventory_active ASP:CheckBox, and
            // save it into the Inventory_active field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Inventory_active = this.Inventory_active.Checked;						
                    
        }
                
        public virtual void GetInvItemDesc()
        {
            
            // Retrieve the value entered by the user on the InvItemDesc ASP:TextBox, and
            // save it into the InvItemDesc field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvItemDesc.Text, InventoryTable.InvItemDesc);							
                          
                      
        }
                
        public virtual void GetInvMake()
        {
            
            // Retrieve the value entered by the user on the InvMake ASP:TextBox, and
            // save it into the InvMake field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMake.Text, InventoryTable.InvMake);							
                          
                      
        }
                
        public virtual void GetInvNotes()
        {
            
            // Retrieve the value entered by the user on the InvNotes ASP:TextBox, and
            // save it into the InvNotes field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvNotes.Content, InventoryTable.InvNotes);							
                          
                      
        }
                
        public virtual void GetInvPartNo()
        {
            
            // Retrieve the value entered by the user on the InvPartNo ASP:TextBox, and
            // save it into the InvPartNo field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvPartNo.Text, InventoryTable.InvPartNo);							
                          
                      
        }
                
        public virtual void GetInvSellPrice0()
        {
            
            // Retrieve the value entered by the user on the InvSellPrice0 ASP:TextBox, and
            // save it into the InvSellPrice0 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvSellPrice0.Text, InventoryTable.InvSellPrice0);							
                          
                      
        }
                
        public virtual void GetInvVendNo1()
        {
         // Retrieve the value entered by the user on the InvVendNo1 ASP:DropDownList, and
            // save it into the InvVendNo1 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.InvVendNo1), InventoryTable.InvVendNo1);			
                			 
        }
                

      // To customize, override this method in InventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersInventoryRecordControl = false;
            hasFiltersInventoryRecordControl = hasFiltersInventoryRecordControl && false; // suppress warning
      
            WhereClause wc;
            InventoryTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Inventory"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Inventory"));
            }
            HttpContext.Current.Session["QueryString in Edit-Inventory"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(InventoryTable.InvKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(InventoryTable.InvKey));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(InventoryTable.InvKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            InventoryTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersInventoryRecordControl = false;
            hasFiltersInventoryRecordControl = hasFiltersInventoryRecordControl && false; // suppress warning
      
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
          InventoryTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_InvCategoryDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_InvVendNo1DropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Vendors table.
            // Examples:
            // wc.iAND(VendorsTable.VendNo, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(VendorsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.VendorsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Vendors_.Vend_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.VendorsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Vendors_.vendor_repair"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the InvCategory list.
        protected virtual void PopulateInvCategoryDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.InvCategory.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.InvCategory.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_InvCategoryDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_InvCategoryDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                

            // Create the ORDER BY clause to sort based on the displayed value.
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(InventoryTable.InvCategory, OrderByItem.OrderDir.Asc);

            ArrayList listDuplicates = new ArrayList();

            // Populate the dropdown list in the sort order specified above.
            if (wc.RunQuery)
            {
                foreach (string itemValue in InventoryTable.GetValues(InventoryTable.InvCategory, wc, orderBy, maxItems)) {
                    // Create the dropdown list item and add it to the list.
                    string fvalue = InventoryTable.InvCategory.Format(itemValue);
                    if (fvalue == null || fvalue.Trim() == "") fvalue = itemValue;				

                    if (fvalue == null) {
                        fvalue = "";
                    }

                    fvalue = fvalue.Trim();

                    if ( fvalue.Length > 50 ) {
                         fvalue = fvalue.Substring(0, 50) + "...";
                    }

                    ListItem dupItem = this.InvCategory.Items.FindByText(fvalue);
								
                    if (dupItem != null) {
                        listDuplicates.Add(fvalue);
                        if (!string.IsNullOrEmpty(dupItem.Value))
                        {
                            dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                        }
                    }

                    ListItem newItem = new ListItem(fvalue, itemValue);
                    this.InvCategory.Items.Add(newItem);

                    if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(itemValue)) {
                        newItem.Text = fvalue + " (ID " + itemValue.Substring(0, Math.Min(itemValue.Length,38)) + ")";
                    }
                }
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.InvCategory, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.InvCategory, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.InvCategory, InventoryTable.InvCategory.Format(selectedValue)))
            {
                string fvalue = InventoryTable.InvCategory.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.InvCategory, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        // Fill the InvVendNo1 list.
        protected virtual void PopulateInvVendNo1DropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.InvVendNo1.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.InvVendNo1.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_InvVendNo1DropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_InvVendNo1DropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(VendorsTable.VendName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the InvVendNo1DropDownList.
            VendorsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = VendorsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (VendorsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.VendNoSpecified) 
                        {
                            cvalue = itemValue.VendNo.ToString().ToString();
                            if (counter < maxItems && this.InvVendNo1.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = InventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InventoryTable.InvVendNo1);
                                if(_isExpandableNonCompositeForeignKey && InventoryTable.InvVendNo1.IsApplyDisplayAs)
                                    fvalue = InventoryTable.GetDFKA(itemValue, InventoryTable.InvVendNo1);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(VendorsTable.VendNo);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.InvVendNo1.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.InvVendNo1.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.InvVendNo1, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.InvVendNo1, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Vendors.VendNo = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(VendorsTable.VendNo, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    VendorsRecord[] rc = VendorsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        VendorsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.VendNoSpecified)
                            cvalue = itemValue.VendNo.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = InventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InventoryTable.InvVendNo1);
                        if(_isExpandableNonCompositeForeignKey && InventoryTable.InvVendNo1.IsApplyDisplayAs)
                            fvalue = InventoryTable.GetDFKA(itemValue, InventoryTable.InvVendNo1);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(VendorsTable.VendNo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.InvVendNo1, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void InvCategory_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[InvCategory.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[InvCategory.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.InvCategory.Items.Add(new ListItem(displayText, val));
	            this.InvCategory.SelectedIndex = this.InvCategory.Items.Count - 1;
	            this.Page.Session.Remove(InvCategory.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(InvCategory.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void InvVendNo1_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[InvVendNo1.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[InvVendNo1.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.InvVendNo1.Items.Add(new ListItem(displayText, val));
	            this.InvVendNo1.SelectedIndex = this.InvVendNo1.Items.Count - 1;
	            this.Page.Session.Remove(InvVendNo1.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(InvVendNo1.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void Inventory_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void InvAvgBuyPrice_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvItemDesc_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMake_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvNotes_TextChanged(object sender, EventArgs args)
        {
                    
                // this event handler is not supported since InvNotes is an Ajax HTML Editor.
              
              }
            
        protected virtual void InvPartNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvSellPrice0_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseInventoryRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseInventoryRecordControl_Rec"] = value;
            }
        }
        
        public InventoryRecord DataSource {
            get {
                return (InventoryRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox InvAvgBuyPrice {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvAvgBuyPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvAvgBuyPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvAvgBuyPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList InvCategory {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCategory");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvCategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox Inventory_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Inventory_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal Inventory_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Inventory_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvItemDesc {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvItemDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvItemDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvItemDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMake {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMakeLabel");
            }
        }
        
              public AjaxControlToolkit.HTMLEditor.Editor InvNotes {
              get {
                  return (AjaxControlToolkit.HTMLEditor.Editor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNotes");
                  }
              }
          
        public System.Web.UI.WebControls.Literal InvNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvPartNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPartNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPartNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPartNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvSellPrice0 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice0");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice0Label");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList InvVendNo1 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendNo1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo1Label");
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
        InventoryRecord rec = null;
             
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
    InventoryRecord rec = null;
    
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

        
        public virtual InventoryRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return InventoryTable.GetRecord(this.RecordUniqueId, true);
              
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

  