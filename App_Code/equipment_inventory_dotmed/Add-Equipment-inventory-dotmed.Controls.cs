
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Equipment_inventory_dotmed.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_Equipment_inventory_dotmed
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_inventory_dotmedRecordControl : BaseEquipment_inventory_dotmedRecordControl
{
      
        // The BaseEquipment_inventory_dotmedRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_inventory_dotmedRecordControl control on the Add_Equipment_inventory_dotmed page.
// Do not modify this class. Instead override any method in Equipment_inventory_dotmedRecordControl.
public class BaseEquipment_inventory_dotmedRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_inventory_dotmedRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_inventory_dotmedRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Equipment_inventory_dotmedRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.dotmed_auto_accept.CheckedChanged += dotmed_auto_accept_CheckedChanged;
            
              this.dotmed_auto_reject.CheckedChanged += dotmed_auto_reject_CheckedChanged;
            
              this.dotmed_avail_parts.CheckedChanged += dotmed_avail_parts_CheckedChanged;
            
              this.dotmed_make_offer.CheckedChanged += dotmed_make_offer_CheckedChanged;
            
              this.dotmed_paypal.CheckedChanged += dotmed_paypal_CheckedChanged;
            
              this.dotmed_will_rent.CheckedChanged += dotmed_will_rent_CheckedChanged;
            
              this.dotmed_depth.TextChanged += dotmed_depth_TextChanged;
            
              this.dotmed_height.TextChanged += dotmed_height_TextChanged;
            
              this.dotmed_paypal_shipping.TextChanged += dotmed_paypal_shipping_TextChanged;
            
              this.dotmed_weight.TextChanged += dotmed_weight_TextChanged;
            
              this.dotmed_width.TextChanged += dotmed_width_TextChanged;
            
              this.inventory_id.TextChanged += inventory_id_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_inventory_dotmedTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Equipment_inventory_dotmedRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Equipment_inventory_dotmedRecord[] recList = Equipment_inventory_dotmedTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Equipment_inventory_dotmedRecord)Equipment_inventory_dotmedRecord.Copy(recList[0], false);
                  
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
        
                Setdotmed_auto_accept();
                Setdotmed_auto_acceptLabel();
                Setdotmed_auto_reject();
                Setdotmed_auto_rejectLabel();
                Setdotmed_avail_parts();
                Setdotmed_avail_partsLabel();
                Setdotmed_depth();
                Setdotmed_depthLabel();
                Setdotmed_height();
                Setdotmed_heightLabel();
                Setdotmed_make_offer();
                Setdotmed_make_offerLabel();
                Setdotmed_paypal();
                Setdotmed_paypal_shipping();
                Setdotmed_paypal_shippingLabel();
                Setdotmed_paypalLabel();
                Setdotmed_weight();
                Setdotmed_weightLabel();
                Setdotmed_width();
                Setdotmed_widthLabel();
                Setdotmed_will_rent();
                Setdotmed_will_rentLabel();
                Setinventory_id();
                

      

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
        
        
        public virtual void Setdotmed_auto_accept()
        {
            
                    
            // Set the dotmed_auto_accept CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_auto_accept is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_auto_acceptSpecified) {
                							
                // If the dotmed_auto_accept is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.dotmed_auto_accept.Checked = this.DataSource.dotmed_auto_accept;
                    				
            } else {
            
                // dotmed_auto_accept is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.dotmed_auto_accept.Checked = Equipment_inventory_dotmedTable.dotmed_auto_accept.ParseValue(Equipment_inventory_dotmedTable.dotmed_auto_accept.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setdotmed_auto_reject()
        {
            
                    
            // Set the dotmed_auto_reject CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_auto_reject is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_auto_rejectSpecified) {
                							
                // If the dotmed_auto_reject is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.dotmed_auto_reject.Checked = this.DataSource.dotmed_auto_reject;
                    				
            } else {
            
                // dotmed_auto_reject is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.dotmed_auto_reject.Checked = Equipment_inventory_dotmedTable.dotmed_auto_reject.ParseValue(Equipment_inventory_dotmedTable.dotmed_auto_reject.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setdotmed_avail_parts()
        {
            
                    
            // Set the dotmed_avail_parts CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_avail_parts is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_avail_partsSpecified) {
                							
                // If the dotmed_avail_parts is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.dotmed_avail_parts.Checked = this.DataSource.dotmed_avail_parts;
                    				
            } else {
            
                // dotmed_avail_parts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.dotmed_avail_parts.Checked = Equipment_inventory_dotmedTable.dotmed_avail_parts.ParseValue(Equipment_inventory_dotmedTable.dotmed_avail_parts.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setdotmed_depth()
        {
            
                    
            // Set the dotmed_depth TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_depth is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_depthSpecified) {
                								
                // If the dotmed_depth is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_dotmedTable.dotmed_depth);
                                
                this.dotmed_depth.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_depth is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_depth.Text = Equipment_inventory_dotmedTable.dotmed_depth.Format(Equipment_inventory_dotmedTable.dotmed_depth.DefaultValue);
            		
            }
            
              this.dotmed_depth.TextChanged += dotmed_depth_TextChanged;
                               
        }
                
        public virtual void Setdotmed_height()
        {
            
                    
            // Set the dotmed_height TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_height is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_heightSpecified) {
                								
                // If the dotmed_height is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_dotmedTable.dotmed_height);
                                
                this.dotmed_height.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_height is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_height.Text = Equipment_inventory_dotmedTable.dotmed_height.Format(Equipment_inventory_dotmedTable.dotmed_height.DefaultValue);
            		
            }
            
              this.dotmed_height.TextChanged += dotmed_height_TextChanged;
                               
        }
                
        public virtual void Setdotmed_make_offer()
        {
            
                    
            // Set the dotmed_make_offer CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_make_offer is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_make_offerSpecified) {
                							
                // If the dotmed_make_offer is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.dotmed_make_offer.Checked = this.DataSource.dotmed_make_offer;
                    				
            } else {
            
                // dotmed_make_offer is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.dotmed_make_offer.Checked = Equipment_inventory_dotmedTable.dotmed_make_offer.ParseValue(Equipment_inventory_dotmedTable.dotmed_make_offer.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setdotmed_paypal()
        {
            
                    
            // Set the dotmed_paypal CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_paypal is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_paypalSpecified) {
                							
                // If the dotmed_paypal is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.dotmed_paypal.Checked = this.DataSource.dotmed_paypal;
                    				
            } else {
            
                // dotmed_paypal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.dotmed_paypal.Checked = Equipment_inventory_dotmedTable.dotmed_paypal.ParseValue(Equipment_inventory_dotmedTable.dotmed_paypal.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setdotmed_paypal_shipping()
        {
            
                    
            // Set the dotmed_paypal_shipping TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_paypal_shipping is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_paypal_shippingSpecified) {
                								
                // If the dotmed_paypal_shipping is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_dotmedTable.dotmed_paypal_shipping, @"C");
                                
                this.dotmed_paypal_shipping.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_paypal_shipping is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_paypal_shipping.Text = Equipment_inventory_dotmedTable.dotmed_paypal_shipping.Format(Equipment_inventory_dotmedTable.dotmed_paypal_shipping.DefaultValue, @"C");
            		
            }
            
              this.dotmed_paypal_shipping.TextChanged += dotmed_paypal_shipping_TextChanged;
                               
        }
                
        public virtual void Setdotmed_weight()
        {
            
                    
            // Set the dotmed_weight TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_weight is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_weightSpecified) {
                								
                // If the dotmed_weight is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_dotmedTable.dotmed_weight);
                                
                this.dotmed_weight.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_weight is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_weight.Text = Equipment_inventory_dotmedTable.dotmed_weight.Format(Equipment_inventory_dotmedTable.dotmed_weight.DefaultValue);
            		
            }
            
              this.dotmed_weight.TextChanged += dotmed_weight_TextChanged;
                               
        }
                
        public virtual void Setdotmed_width()
        {
            
                    
            // Set the dotmed_width TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_width is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_widthSpecified) {
                								
                // If the dotmed_width is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_dotmedTable.dotmed_width);
                                
                this.dotmed_width.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_width is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_width.Text = Equipment_inventory_dotmedTable.dotmed_width.Format(Equipment_inventory_dotmedTable.dotmed_width.DefaultValue);
            		
            }
            
              this.dotmed_width.TextChanged += dotmed_width_TextChanged;
                               
        }
                
        public virtual void Setdotmed_will_rent()
        {
            
                    
            // Set the dotmed_will_rent CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_will_rent is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_will_rentSpecified) {
                							
                // If the dotmed_will_rent is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.dotmed_will_rent.Checked = this.DataSource.dotmed_will_rent;
                    				
            } else {
            
                // dotmed_will_rent is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.dotmed_will_rent.Checked = Equipment_inventory_dotmedTable.dotmed_will_rent.ParseValue(Equipment_inventory_dotmedTable.dotmed_will_rent.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setinventory_id()
        {
            
                    
            // Set the inventory_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.inventory_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the inventory_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.inventory_id.ToString();
                            
                this.inventory_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // inventory_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.inventory_id.Text = EvaluateFormula("URL(\"equipment_inventory_id\")", this.DataSource);
            		
            }
            
              this.inventory_id.TextChanged += inventory_id_TextChanged;
                               
        }
                
        public virtual void Setdotmed_auto_acceptLabel()
                  {
                  
                        this.dotmed_auto_acceptLabel.Text = EvaluateFormula("\"Automatic Accept\"");
                      
                    
        }
                
        public virtual void Setdotmed_auto_rejectLabel()
                  {
                  
                        this.dotmed_auto_rejectLabel.Text = EvaluateFormula("\"Automatic Reject\"");
                      
                    
        }
                
        public virtual void Setdotmed_avail_partsLabel()
                  {
                  
                        this.dotmed_avail_partsLabel.Text = EvaluateFormula("\"Available as Parts\"");
                      
                    
        }
                
        public virtual void Setdotmed_depthLabel()
                  {
                  
                        this.dotmed_depthLabel.Text = EvaluateFormula("\"Depth\"");
                      
                    
        }
                
        public virtual void Setdotmed_heightLabel()
                  {
                  
                        this.dotmed_heightLabel.Text = EvaluateFormula("\"Height\"");
                      
                    
        }
                
        public virtual void Setdotmed_make_offerLabel()
                  {
                  
                        this.dotmed_make_offerLabel.Text = EvaluateFormula("\"Make Offer\"");
                      
                    
        }
                
        public virtual void Setdotmed_paypal_shippingLabel()
                  {
                  
                        this.dotmed_paypal_shippingLabel.Text = EvaluateFormula("\"Paypal Shipping\"");
                      
                    
        }
                
        public virtual void Setdotmed_paypalLabel()
                  {
                  
                        this.dotmed_paypalLabel.Text = EvaluateFormula("\"Paypal\"");
                      
                    
        }
                
        public virtual void Setdotmed_weightLabel()
                  {
                  
                        this.dotmed_weightLabel.Text = EvaluateFormula("\"Weight\"");
                      
                    
        }
                
        public virtual void Setdotmed_widthLabel()
                  {
                  
                        this.dotmed_widthLabel.Text = EvaluateFormula("\"Width\"");
                      
                    
        }
                
        public virtual void Setdotmed_will_rentLabel()
                  {
                  
                        this.dotmed_will_rentLabel.Text = EvaluateFormula("\"Will Rent\"");
                      
                    
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
        
            Getdotmed_auto_accept();
            Getdotmed_auto_reject();
            Getdotmed_avail_parts();
            Getdotmed_depth();
            Getdotmed_height();
            Getdotmed_make_offer();
            Getdotmed_paypal();
            Getdotmed_paypal_shipping();
            Getdotmed_weight();
            Getdotmed_width();
            Getdotmed_will_rent();
            Getinventory_id();
        }
        
        
        public virtual void Getdotmed_auto_accept()
        {	
        		
            // Retrieve the value entered by the user on the dotmed_auto_accept ASP:CheckBox, and
            // save it into the dotmed_auto_accept field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.dotmed_auto_accept = this.dotmed_auto_accept.Checked;						
                    
        }
                
        public virtual void Getdotmed_auto_reject()
        {	
        		
            // Retrieve the value entered by the user on the dotmed_auto_reject ASP:CheckBox, and
            // save it into the dotmed_auto_reject field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.dotmed_auto_reject = this.dotmed_auto_reject.Checked;						
                    
        }
                
        public virtual void Getdotmed_avail_parts()
        {	
        		
            // Retrieve the value entered by the user on the dotmed_avail_parts ASP:CheckBox, and
            // save it into the dotmed_avail_parts field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.dotmed_avail_parts = this.dotmed_avail_parts.Checked;						
                    
        }
                
        public virtual void Getdotmed_depth()
        {
            
            // Retrieve the value entered by the user on the dotmed_depth ASP:TextBox, and
            // save it into the dotmed_depth field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.dotmed_depth.Text, Equipment_inventory_dotmedTable.dotmed_depth);							
                          
                      
        }
                
        public virtual void Getdotmed_height()
        {
            
            // Retrieve the value entered by the user on the dotmed_height ASP:TextBox, and
            // save it into the dotmed_height field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.dotmed_height.Text, Equipment_inventory_dotmedTable.dotmed_height);							
                          
                      
        }
                
        public virtual void Getdotmed_make_offer()
        {	
        		
            // Retrieve the value entered by the user on the dotmed_make_offer ASP:CheckBox, and
            // save it into the dotmed_make_offer field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.dotmed_make_offer = this.dotmed_make_offer.Checked;						
                    
        }
                
        public virtual void Getdotmed_paypal()
        {	
        		
            // Retrieve the value entered by the user on the dotmed_paypal ASP:CheckBox, and
            // save it into the dotmed_paypal field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.dotmed_paypal = this.dotmed_paypal.Checked;						
                    
        }
                
        public virtual void Getdotmed_paypal_shipping()
        {
            
            // Retrieve the value entered by the user on the dotmed_paypal_shipping ASP:TextBox, and
            // save it into the dotmed_paypal_shipping field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.dotmed_paypal_shipping.Text, Equipment_inventory_dotmedTable.dotmed_paypal_shipping);							
                          
                      
        }
                
        public virtual void Getdotmed_weight()
        {
            
            // Retrieve the value entered by the user on the dotmed_weight ASP:TextBox, and
            // save it into the dotmed_weight field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.dotmed_weight.Text, Equipment_inventory_dotmedTable.dotmed_weight);							
                          
                      
        }
                
        public virtual void Getdotmed_width()
        {
            
            // Retrieve the value entered by the user on the dotmed_width ASP:TextBox, and
            // save it into the dotmed_width field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.dotmed_width.Text, Equipment_inventory_dotmedTable.dotmed_width);							
                          
                      
        }
                
        public virtual void Getdotmed_will_rent()
        {	
        		
            // Retrieve the value entered by the user on the dotmed_will_rent ASP:CheckBox, and
            // save it into the dotmed_will_rent field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.dotmed_will_rent = this.dotmed_will_rent.Checked;						
                    
        }
                
        public virtual void Getinventory_id()
        {
            
            // Retrieve the value entered by the user on the inventory_id ASP:TextBox, and
            // save it into the inventory_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.inventory_id.Text, Equipment_inventory_dotmedTable.inventory_id);							
                          
                      
        }
                

      // To customize, override this method in Equipment_inventory_dotmedRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventory_dotmedRecordControl = false;
            hasFiltersEquipment_inventory_dotmedRecordControl = hasFiltersEquipment_inventory_dotmedRecordControl && false; // suppress warning
      
            WhereClause wc;
            Equipment_inventory_dotmedTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Equipment_inventory_dotmed"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Equipment-inventory-dotmed"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Equipment_inventory_dotmedTable.equipment_inventory_dotmed_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Equipment_inventory_dotmedTable.equipment_inventory_dotmed_id));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Equipment_inventory_dotmedTable.equipment_inventory_dotmed_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_inventory_dotmedTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEquipment_inventory_dotmedRecordControl = false;
            hasFiltersEquipment_inventory_dotmedRecordControl = hasFiltersEquipment_inventory_dotmedRecordControl && false; // suppress warning
      
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
          Equipment_inventory_dotmedTable.DeleteRecord(pkValue);
          
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
        
        protected virtual void dotmed_auto_accept_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void dotmed_auto_reject_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void dotmed_avail_parts_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void dotmed_make_offer_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void dotmed_paypal_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void dotmed_will_rent_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void dotmed_depth_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void dotmed_height_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void dotmed_paypal_shipping_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void dotmed_weight_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void dotmed_width_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void inventory_id_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseEquipment_inventory_dotmedRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_inventory_dotmedRecordControl_Rec"] = value;
            }
        }
        
        public Equipment_inventory_dotmedRecord DataSource {
            get {
                return (Equipment_inventory_dotmedRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.CheckBox dotmed_auto_accept {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_auto_accept");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_auto_acceptLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_auto_acceptLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox dotmed_auto_reject {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_auto_reject");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_auto_rejectLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_auto_rejectLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox dotmed_avail_parts {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_avail_parts");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_avail_partsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_avail_partsLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox dotmed_depth {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_depth");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_depthLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_depthLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox dotmed_height {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_height");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_heightLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_heightLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox dotmed_make_offer {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_make_offer");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_make_offerLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_make_offerLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox dotmed_paypal {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_paypal");
            }
        }
            
        public System.Web.UI.WebControls.TextBox dotmed_paypal_shipping {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_paypal_shipping");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_paypal_shippingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_paypal_shippingLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal dotmed_paypalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_paypalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox dotmed_weight {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_weight");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_weightLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_weightLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox dotmed_width {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_width");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_widthLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_widthLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox dotmed_will_rent {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_will_rent");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_will_rentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_will_rentLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox inventory_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_id");
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
        Equipment_inventory_dotmedRecord rec = null;
             
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
    Equipment_inventory_dotmedRecord rec = null;
    
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

        
        public virtual Equipment_inventory_dotmedRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new Equipment_inventory_dotmedRecord();
            
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

  