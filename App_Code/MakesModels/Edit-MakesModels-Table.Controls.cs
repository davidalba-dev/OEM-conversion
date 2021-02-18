
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_MakesModels_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_MakesModels_Table
{
  

#region "Section 1: Place your customizations here."

    
public class MakesModelsTableControlRow : BaseMakesModelsTableControlRow
{
      
        // The BaseMakesModelsTableControlRow implements code for a ROW within the
        // the MakesModelsTableControl table.  The BaseMakesModelsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of MakesModelsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class MakesModelsTableControl : BaseMakesModelsTableControl
{
    // The BaseMakesModelsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The MakesModelsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the MakesModelsTableControlRow control on the Edit_MakesModels_Table page.
// Do not modify this class. Instead override any method in MakesModelsTableControlRow.
public class BaseMakesModelsTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseMakesModelsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in MakesModelsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in MakesModelsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
              this.LastExtraction.CheckedChanged += LastExtraction_CheckedChanged;
            
              this.ModelCopyAttach.CheckedChanged += ModelCopyAttach_CheckedChanged;
            
              this.ModelCopyNotes.CheckedChanged += ModelCopyNotes_CheckedChanged;
            
              this.ModelExclude.CheckedChanged += ModelExclude_CheckedChanged;
            
              this.ModelExportInclude.CheckedChanged += ModelExportInclude_CheckedChanged;
            
              this.ModelExportRecordChanged.CheckedChanged += ModelExportRecordChanged_CheckedChanged;
            
              this.ModelIgnoreSerialNoRules.CheckedChanged += ModelIgnoreSerialNoRules_CheckedChanged;
            
              this.ModelPreapproved.CheckedChanged += ModelPreapproved_CheckedChanged;
            
              this.Category.TextChanged += Category_TextChanged;
            
              this.Make.TextChanged += Make_TextChanged;
            
              this.Model.TextChanged += Model_TextChanged;
            
              this.ModelBin.TextChanged += ModelBin_TextChanged;
            
              this.ModelDateRecordUpdated.TextChanged += ModelDateRecordUpdated_TextChanged;
            
              this.ModelDesc.TextChanged += ModelDesc_TextChanged;
            
              this.ModelHandling.TextChanged += ModelHandling_TextChanged;
            
              this.ModelLabor.TextChanged += ModelLabor_TextChanged;
            
              this.ModelMarkupRate.TextChanged += ModelMarkupRate_TextChanged;
            
              this.ModelNotes.TextChanged += ModelNotes_TextChanged;
            
              this.ModelPackCode.TextChanged += ModelPackCode_TextChanged;
            
              this.ModelParts.TextChanged += ModelParts_TextChanged;
            
              this.ModelReference1.TextChanged += ModelReference1_TextChanged;
            
              this.ModelReference2.TextChanged += ModelReference2_TextChanged;
            
              this.ModelReference3.TextChanged += ModelReference3_TextChanged;
            
              this.ModelReference4.TextChanged += ModelReference4_TextChanged;
            
              this.ModelReplaceCostNew.TextChanged += ModelReplaceCostNew_TextChanged;
            
              this.ModelReplaceCostRefurbished.TextChanged += ModelReplaceCostRefurbished_TextChanged;
            
              this.ModelShipping.TextChanged += ModelShipping_TextChanged;
            
              this.ModelSubcontractNotes.TextChanged += ModelSubcontractNotes_TextChanged;
            
              this.ModelTravel.TextChanged += ModelTravel_TextChanged;
            
              this.ModelVendNo.TextChanged += ModelVendNo_TextChanged;
            
              this.ModelWarranty.TextChanged += ModelWarranty_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = MakesModelsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseMakesModelsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new MakesModelsRecord();
            
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
        
                SetCategory();
                SetCategoryLabel();
                
                
                SetLastExtraction();
                SetLastExtractionLabel();
                SetMake();
                SetMakeLabel();
                SetModel();
                SetModelBin();
                SetModelBinLabel();
                SetModelCopyAttach();
                SetModelCopyAttachLabel();
                SetModelCopyNotes();
                SetModelCopyNotesLabel();
                SetModelDateRecordUpdated();
                SetModelDateRecordUpdatedLabel();
                SetModelDesc();
                SetModelDescLabel();
                SetModelExclude();
                SetModelExcludeLabel();
                SetModelExportInclude();
                SetModelExportIncludeLabel();
                SetModelExportRecordChanged();
                SetModelExportRecordChangedLabel();
                SetModelHandling();
                SetModelHandlingLabel();
                SetModelIgnoreSerialNoRules();
                SetModelIgnoreSerialNoRulesLabel();
                SetModelLabel();
                SetModelLabor();
                SetModelLaborLabel();
                SetModelMarkupRate();
                SetModelMarkupRateLabel();
                SetModelNotes();
                SetModelNotesLabel();
                SetModelPackCode();
                SetModelPackCodeLabel();
                SetModelParts();
                SetModelPartsLabel();
                SetModelPreapproved();
                SetModelPreapprovedLabel();
                SetModelReference1();
                SetModelReference1Label();
                SetModelReference2();
                SetModelReference2Label();
                SetModelReference3();
                SetModelReference3Label();
                SetModelReference4();
                SetModelReference4Label();
                SetModelReplaceCostNew();
                SetModelReplaceCostNewLabel();
                SetModelReplaceCostRefurbished();
                SetModelReplaceCostRefurbishedLabel();
                SetModelShipping();
                SetModelShippingLabel();
                SetModelSubcontractNotes();
                SetModelSubcontractNotesLabel();
                SetModelTravel();
                SetModelTravelLabel();
                SetModelVendNo();
                SetModelVendNoLabel();
                SetModelWarranty();
                SetModelWarrantyLabel();
                
                
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
        
        
        public virtual void SetCategory()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Category.ID))
            {
            
                this.Category.Text = this.PreviousUIData[this.Category.ID].ToString();
              
                return;
            }
            
                    
            // Set the Category TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.Category is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CategorySpecified) {
                								
                // If the Category is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.Category.ToString();
                            
                this.Category.Text = formattedValue;
                   
            } 
            
            else {
            
                // Category is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Category.Text = MakesModelsTable.Category.DefaultValue;
            		
            }
            
              this.Category.TextChanged += Category_TextChanged;
                               
        }
                
        public virtual void SetLastExtraction()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LastExtraction.ID))
            {
                this.LastExtraction.Checked = Convert.ToBoolean(this.PreviousUIData[this.LastExtraction.ID]);
                return;
            }	
            
                    
            // Set the LastExtraction CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.LastExtraction is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastExtractionSpecified) {
                							
                // If the LastExtraction is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.LastExtraction.Checked = this.DataSource.LastExtraction;
                    				
            } else {
            
                // LastExtraction is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.LastExtraction.Checked = MakesModelsTable.LastExtraction.ParseValue(MakesModelsTable.LastExtraction.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetMake()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Make.ID))
            {
            
                this.Make.Text = this.PreviousUIData[this.Make.ID].ToString();
              
                return;
            }
            
                    
            // Set the Make TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.Make is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MakeSpecified) {
                								
                // If the Make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.Make);
                                
                this.Make.Text = formattedValue;
                   
            } 
            
            else {
            
                // Make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Make.Text = MakesModelsTable.Make.Format(MakesModelsTable.Make.DefaultValue);
            		
            }
            
              this.Make.TextChanged += Make_TextChanged;
                               
        }
                
        public virtual void SetModel()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Model.ID))
            {
            
                this.Model.Text = this.PreviousUIData[this.Model.ID].ToString();
              
                return;
            }
            
                    
            // Set the Model TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.Model is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelSpecified) {
                								
                // If the Model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.Model);
                                
                this.Model.Text = formattedValue;
                   
            } 
            
            else {
            
                // Model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Model.Text = MakesModelsTable.Model.Format(MakesModelsTable.Model.DefaultValue);
            		
            }
            
              this.Model.TextChanged += Model_TextChanged;
                               
        }
                
        public virtual void SetModelBin()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelBin.ID))
            {
            
                this.ModelBin.Text = this.PreviousUIData[this.ModelBin.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelBin TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelBin is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelBinSpecified) {
                								
                // If the ModelBin is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelBin);
                                
                this.ModelBin.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelBin is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelBin.Text = MakesModelsTable.ModelBin.Format(MakesModelsTable.ModelBin.DefaultValue);
            		
            }
            
              this.ModelBin.TextChanged += ModelBin_TextChanged;
                               
        }
                
        public virtual void SetModelCopyAttach()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelCopyAttach.ID))
            {
                this.ModelCopyAttach.Checked = Convert.ToBoolean(this.PreviousUIData[this.ModelCopyAttach.ID]);
                return;
            }	
            
                    
            // Set the ModelCopyAttach CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelCopyAttach is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelCopyAttachSpecified) {
                							
                // If the ModelCopyAttach is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ModelCopyAttach.Checked = this.DataSource.ModelCopyAttach;
                    				
            } else {
            
                // ModelCopyAttach is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ModelCopyAttach.Checked = MakesModelsTable.ModelCopyAttach.ParseValue(MakesModelsTable.ModelCopyAttach.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetModelCopyNotes()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelCopyNotes.ID))
            {
                this.ModelCopyNotes.Checked = Convert.ToBoolean(this.PreviousUIData[this.ModelCopyNotes.ID]);
                return;
            }	
            
                    
            // Set the ModelCopyNotes CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelCopyNotes is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelCopyNotesSpecified) {
                							
                // If the ModelCopyNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ModelCopyNotes.Checked = this.DataSource.ModelCopyNotes;
                    				
            } else {
            
                // ModelCopyNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ModelCopyNotes.Checked = MakesModelsTable.ModelCopyNotes.ParseValue(MakesModelsTable.ModelCopyNotes.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetModelDateRecordUpdated()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelDateRecordUpdated.ID))
            {
            
                this.ModelDateRecordUpdated.Text = this.PreviousUIData[this.ModelDateRecordUpdated.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelDateRecordUpdated TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelDateRecordUpdated is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelDateRecordUpdatedSpecified) {
                								
                // If the ModelDateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelDateRecordUpdated, @"g");
                                
                this.ModelDateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelDateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelDateRecordUpdated.Text = MakesModelsTable.ModelDateRecordUpdated.Format(MakesModelsTable.ModelDateRecordUpdated.DefaultValue, @"g");
            		
            }
            
              this.ModelDateRecordUpdated.TextChanged += ModelDateRecordUpdated_TextChanged;
                               
        }
                
        public virtual void SetModelDesc()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelDesc.ID))
            {
            
                this.ModelDesc.Text = this.PreviousUIData[this.ModelDesc.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelDesc TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelDesc is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelDescSpecified) {
                								
                // If the ModelDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelDesc);
                                
                this.ModelDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelDesc.Text = MakesModelsTable.ModelDesc.Format(MakesModelsTable.ModelDesc.DefaultValue);
            		
            }
            
              this.ModelDesc.TextChanged += ModelDesc_TextChanged;
                               
        }
                
        public virtual void SetModelExclude()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelExclude.ID))
            {
                this.ModelExclude.Checked = Convert.ToBoolean(this.PreviousUIData[this.ModelExclude.ID]);
                return;
            }	
            
                    
            // Set the ModelExclude CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelExclude is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelExcludeSpecified) {
                							
                // If the ModelExclude is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ModelExclude.Checked = this.DataSource.ModelExclude;
                    				
            } else {
            
                // ModelExclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ModelExclude.Checked = MakesModelsTable.ModelExclude.ParseValue(MakesModelsTable.ModelExclude.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetModelExportInclude()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelExportInclude.ID))
            {
                this.ModelExportInclude.Checked = Convert.ToBoolean(this.PreviousUIData[this.ModelExportInclude.ID]);
                return;
            }	
            
                    
            // Set the ModelExportInclude CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelExportInclude is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelExportIncludeSpecified) {
                							
                // If the ModelExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ModelExportInclude.Checked = this.DataSource.ModelExportInclude;
                    				
            } else {
            
                // ModelExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ModelExportInclude.Checked = MakesModelsTable.ModelExportInclude.ParseValue(MakesModelsTable.ModelExportInclude.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetModelExportRecordChanged()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelExportRecordChanged.ID))
            {
                this.ModelExportRecordChanged.Checked = Convert.ToBoolean(this.PreviousUIData[this.ModelExportRecordChanged.ID]);
                return;
            }	
            
                    
            // Set the ModelExportRecordChanged CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelExportRecordChanged is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelExportRecordChangedSpecified) {
                							
                // If the ModelExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ModelExportRecordChanged.Checked = this.DataSource.ModelExportRecordChanged;
                    				
            } else {
            
                // ModelExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ModelExportRecordChanged.Checked = MakesModelsTable.ModelExportRecordChanged.ParseValue(MakesModelsTable.ModelExportRecordChanged.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetModelHandling()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelHandling.ID))
            {
            
                this.ModelHandling.Text = this.PreviousUIData[this.ModelHandling.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelHandling TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelHandling is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelHandlingSpecified) {
                								
                // If the ModelHandling is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelHandling, @"C");
                                
                this.ModelHandling.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelHandling is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelHandling.Text = MakesModelsTable.ModelHandling.Format(MakesModelsTable.ModelHandling.DefaultValue, @"C");
            		
            }
            
              this.ModelHandling.TextChanged += ModelHandling_TextChanged;
                               
        }
                
        public virtual void SetModelIgnoreSerialNoRules()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelIgnoreSerialNoRules.ID))
            {
                this.ModelIgnoreSerialNoRules.Checked = Convert.ToBoolean(this.PreviousUIData[this.ModelIgnoreSerialNoRules.ID]);
                return;
            }	
            
                    
            // Set the ModelIgnoreSerialNoRules CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelIgnoreSerialNoRules is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelIgnoreSerialNoRulesSpecified) {
                							
                // If the ModelIgnoreSerialNoRules is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ModelIgnoreSerialNoRules.Checked = this.DataSource.ModelIgnoreSerialNoRules;
                    				
            } else {
            
                // ModelIgnoreSerialNoRules is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ModelIgnoreSerialNoRules.Checked = MakesModelsTable.ModelIgnoreSerialNoRules.ParseValue(MakesModelsTable.ModelIgnoreSerialNoRules.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetModelLabor()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelLabor.ID))
            {
            
                this.ModelLabor.Text = this.PreviousUIData[this.ModelLabor.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelLabor TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelLabor is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelLaborSpecified) {
                								
                // If the ModelLabor is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelLabor, @"C");
                                
                this.ModelLabor.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelLabor is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelLabor.Text = MakesModelsTable.ModelLabor.Format(MakesModelsTable.ModelLabor.DefaultValue, @"C");
            		
            }
            
              this.ModelLabor.TextChanged += ModelLabor_TextChanged;
                               
        }
                
        public virtual void SetModelMarkupRate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelMarkupRate.ID))
            {
            
                this.ModelMarkupRate.Text = this.PreviousUIData[this.ModelMarkupRate.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelMarkupRate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelMarkupRate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelMarkupRateSpecified) {
                								
                // If the ModelMarkupRate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelMarkupRate);
                                
                this.ModelMarkupRate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelMarkupRate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelMarkupRate.Text = MakesModelsTable.ModelMarkupRate.Format(MakesModelsTable.ModelMarkupRate.DefaultValue);
            		
            }
            
              this.ModelMarkupRate.TextChanged += ModelMarkupRate_TextChanged;
                               
        }
                
        public virtual void SetModelNotes()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelNotes.ID))
            {
            
                this.ModelNotes.Text = this.PreviousUIData[this.ModelNotes.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelNotes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelNotes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelNotesSpecified) {
                								
                // If the ModelNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelNotes);
                                
                this.ModelNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelNotes.Text = MakesModelsTable.ModelNotes.Format(MakesModelsTable.ModelNotes.DefaultValue);
            		
            }
            
              this.ModelNotes.TextChanged += ModelNotes_TextChanged;
                               
        }
                
        public virtual void SetModelPackCode()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelPackCode.ID))
            {
            
                this.ModelPackCode.Text = this.PreviousUIData[this.ModelPackCode.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelPackCode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelPackCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelPackCodeSpecified) {
                								
                // If the ModelPackCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelPackCode);
                                
                this.ModelPackCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelPackCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelPackCode.Text = MakesModelsTable.ModelPackCode.Format(MakesModelsTable.ModelPackCode.DefaultValue);
            		
            }
            
              this.ModelPackCode.TextChanged += ModelPackCode_TextChanged;
                               
        }
                
        public virtual void SetModelParts()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelParts.ID))
            {
            
                this.ModelParts.Text = this.PreviousUIData[this.ModelParts.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelParts TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelParts is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelPartsSpecified) {
                								
                // If the ModelParts is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelParts, @"C");
                                
                this.ModelParts.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelParts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelParts.Text = MakesModelsTable.ModelParts.Format(MakesModelsTable.ModelParts.DefaultValue, @"C");
            		
            }
            
              this.ModelParts.TextChanged += ModelParts_TextChanged;
                               
        }
                
        public virtual void SetModelPreapproved()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelPreapproved.ID))
            {
                this.ModelPreapproved.Checked = Convert.ToBoolean(this.PreviousUIData[this.ModelPreapproved.ID]);
                return;
            }	
            
                    
            // Set the ModelPreapproved CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelPreapproved is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelPreapprovedSpecified) {
                							
                // If the ModelPreapproved is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.ModelPreapproved.Checked = this.DataSource.ModelPreapproved;
                    				
            } else {
            
                // ModelPreapproved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.ModelPreapproved.Checked = MakesModelsTable.ModelPreapproved.ParseValue(MakesModelsTable.ModelPreapproved.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetModelReference1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelReference1.ID))
            {
            
                this.ModelReference1.Text = this.PreviousUIData[this.ModelReference1.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelReference1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReference1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReference1Specified) {
                								
                // If the ModelReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReference1);
                                
                this.ModelReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReference1.Text = MakesModelsTable.ModelReference1.Format(MakesModelsTable.ModelReference1.DefaultValue);
            		
            }
            
              this.ModelReference1.TextChanged += ModelReference1_TextChanged;
                               
        }
                
        public virtual void SetModelReference2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelReference2.ID))
            {
            
                this.ModelReference2.Text = this.PreviousUIData[this.ModelReference2.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelReference2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReference2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReference2Specified) {
                								
                // If the ModelReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReference2);
                                
                this.ModelReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReference2.Text = MakesModelsTable.ModelReference2.Format(MakesModelsTable.ModelReference2.DefaultValue);
            		
            }
            
              this.ModelReference2.TextChanged += ModelReference2_TextChanged;
                               
        }
                
        public virtual void SetModelReference3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelReference3.ID))
            {
            
                this.ModelReference3.Text = this.PreviousUIData[this.ModelReference3.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelReference3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReference3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReference3Specified) {
                								
                // If the ModelReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReference3);
                                
                this.ModelReference3.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReference3.Text = MakesModelsTable.ModelReference3.Format(MakesModelsTable.ModelReference3.DefaultValue);
            		
            }
            
              this.ModelReference3.TextChanged += ModelReference3_TextChanged;
                               
        }
                
        public virtual void SetModelReference4()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelReference4.ID))
            {
            
                this.ModelReference4.Text = this.PreviousUIData[this.ModelReference4.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelReference4 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReference4 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReference4Specified) {
                								
                // If the ModelReference4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReference4);
                                
                this.ModelReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReference4.Text = MakesModelsTable.ModelReference4.Format(MakesModelsTable.ModelReference4.DefaultValue);
            		
            }
            
              this.ModelReference4.TextChanged += ModelReference4_TextChanged;
                               
        }
                
        public virtual void SetModelReplaceCostNew()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelReplaceCostNew.ID))
            {
            
                this.ModelReplaceCostNew.Text = this.PreviousUIData[this.ModelReplaceCostNew.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelReplaceCostNew TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReplaceCostNew is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReplaceCostNewSpecified) {
                								
                // If the ModelReplaceCostNew is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReplaceCostNew, @"C");
                                
                this.ModelReplaceCostNew.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReplaceCostNew is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReplaceCostNew.Text = MakesModelsTable.ModelReplaceCostNew.Format(MakesModelsTable.ModelReplaceCostNew.DefaultValue, @"C");
            		
            }
            
              this.ModelReplaceCostNew.TextChanged += ModelReplaceCostNew_TextChanged;
                               
        }
                
        public virtual void SetModelReplaceCostRefurbished()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelReplaceCostRefurbished.ID))
            {
            
                this.ModelReplaceCostRefurbished.Text = this.PreviousUIData[this.ModelReplaceCostRefurbished.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelReplaceCostRefurbished TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelReplaceCostRefurbished is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelReplaceCostRefurbishedSpecified) {
                								
                // If the ModelReplaceCostRefurbished is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelReplaceCostRefurbished, @"C");
                                
                this.ModelReplaceCostRefurbished.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelReplaceCostRefurbished is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelReplaceCostRefurbished.Text = MakesModelsTable.ModelReplaceCostRefurbished.Format(MakesModelsTable.ModelReplaceCostRefurbished.DefaultValue, @"C");
            		
            }
            
              this.ModelReplaceCostRefurbished.TextChanged += ModelReplaceCostRefurbished_TextChanged;
                               
        }
                
        public virtual void SetModelShipping()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelShipping.ID))
            {
            
                this.ModelShipping.Text = this.PreviousUIData[this.ModelShipping.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelShipping TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelShipping is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelShippingSpecified) {
                								
                // If the ModelShipping is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelShipping, @"C");
                                
                this.ModelShipping.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelShipping is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelShipping.Text = MakesModelsTable.ModelShipping.Format(MakesModelsTable.ModelShipping.DefaultValue, @"C");
            		
            }
            
              this.ModelShipping.TextChanged += ModelShipping_TextChanged;
                               
        }
                
        public virtual void SetModelSubcontractNotes()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelSubcontractNotes.ID))
            {
            
                this.ModelSubcontractNotes.Text = this.PreviousUIData[this.ModelSubcontractNotes.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelSubcontractNotes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelSubcontractNotes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelSubcontractNotesSpecified) {
                								
                // If the ModelSubcontractNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelSubcontractNotes);
                                
                this.ModelSubcontractNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelSubcontractNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelSubcontractNotes.Text = MakesModelsTable.ModelSubcontractNotes.Format(MakesModelsTable.ModelSubcontractNotes.DefaultValue);
            		
            }
            
              this.ModelSubcontractNotes.TextChanged += ModelSubcontractNotes_TextChanged;
                               
        }
                
        public virtual void SetModelTravel()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelTravel.ID))
            {
            
                this.ModelTravel.Text = this.PreviousUIData[this.ModelTravel.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelTravel TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelTravel is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelTravelSpecified) {
                								
                // If the ModelTravel is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelTravel, @"C");
                                
                this.ModelTravel.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelTravel is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelTravel.Text = MakesModelsTable.ModelTravel.Format(MakesModelsTable.ModelTravel.DefaultValue, @"C");
            		
            }
            
              this.ModelTravel.TextChanged += ModelTravel_TextChanged;
                               
        }
                
        public virtual void SetModelVendNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelVendNo.ID))
            {
            
                this.ModelVendNo.Text = this.PreviousUIData[this.ModelVendNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelVendNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelVendNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelVendNoSpecified) {
                								
                // If the ModelVendNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelVendNo);
                                
                this.ModelVendNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelVendNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelVendNo.Text = MakesModelsTable.ModelVendNo.Format(MakesModelsTable.ModelVendNo.DefaultValue);
            		
            }
            
              this.ModelVendNo.TextChanged += ModelVendNo_TextChanged;
                               
        }
                
        public virtual void SetModelWarranty()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ModelWarranty.ID))
            {
            
                this.ModelWarranty.Text = this.PreviousUIData[this.ModelWarranty.ID].ToString();
              
                return;
            }
            
                    
            // Set the ModelWarranty TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.MakesModels database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.MakesModels record retrieved from the database.
            // this.ModelWarranty is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ModelWarrantySpecified) {
                								
                // If the ModelWarranty is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(MakesModelsTable.ModelWarranty);
                                
                this.ModelWarranty.Text = formattedValue;
                   
            } 
            
            else {
            
                // ModelWarranty is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ModelWarranty.Text = MakesModelsTable.ModelWarranty.Format(MakesModelsTable.ModelWarranty.DefaultValue);
            		
            }
            
              this.ModelWarranty.TextChanged += ModelWarranty_TextChanged;
                               
        }
                
        public virtual void SetCategoryLabel()
                  {
                  
                    
        }
                
        public virtual void SetLastExtractionLabel()
                  {
                  
                    
        }
                
        public virtual void SetMakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelBinLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelCopyAttachLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelCopyNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelDateRecordUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelDescLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelExcludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelExportIncludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelHandlingLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelIgnoreSerialNoRulesLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelLaborLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelMarkupRateLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelPackCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelPartsLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelPreapprovedLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelReference1Label()
                  {
                  
                    
        }
                
        public virtual void SetModelReference2Label()
                  {
                  
                    
        }
                
        public virtual void SetModelReference3Label()
                  {
                  
                    
        }
                
        public virtual void SetModelReference4Label()
                  {
                  
                    
        }
                
        public virtual void SetModelReplaceCostNewLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelReplaceCostRefurbishedLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelShippingLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelSubcontractNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelTravelLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelVendNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetModelWarrantyLabel()
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
                ((MakesModelsTableControl)MiscUtils.GetParentControlObject(this, "MakesModelsTableControl")).DataChanged = true;
                ((MakesModelsTableControl)MiscUtils.GetParentControlObject(this, "MakesModelsTableControl")).ResetData = true;
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
        
            GetCategory();
            GetLastExtraction();
            GetMake();
            GetModel();
            GetModelBin();
            GetModelCopyAttach();
            GetModelCopyNotes();
            GetModelDateRecordUpdated();
            GetModelDesc();
            GetModelExclude();
            GetModelExportInclude();
            GetModelExportRecordChanged();
            GetModelHandling();
            GetModelIgnoreSerialNoRules();
            GetModelLabor();
            GetModelMarkupRate();
            GetModelNotes();
            GetModelPackCode();
            GetModelParts();
            GetModelPreapproved();
            GetModelReference1();
            GetModelReference2();
            GetModelReference3();
            GetModelReference4();
            GetModelReplaceCostNew();
            GetModelReplaceCostRefurbished();
            GetModelShipping();
            GetModelSubcontractNotes();
            GetModelTravel();
            GetModelVendNo();
            GetModelWarranty();
        }
        
        
        public virtual void GetCategory()
        {
            
            // Retrieve the value entered by the user on the Category ASP:TextBox, and
            // save it into the Category field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Category.Text, MakesModelsTable.Category);							
                          
                      
        }
                
        public virtual void GetLastExtraction()
        {	
        		
            // Retrieve the value entered by the user on the LastExtraction ASP:CheckBox, and
            // save it into the LastExtraction field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.LastExtraction = this.LastExtraction.Checked;						
                    
        }
                
        public virtual void GetMake()
        {
            
            // Retrieve the value entered by the user on the Make ASP:TextBox, and
            // save it into the Make field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Make.Text, MakesModelsTable.Make);							
                          
                      
        }
                
        public virtual void GetModel()
        {
            
            // Retrieve the value entered by the user on the Model ASP:TextBox, and
            // save it into the Model field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Model.Text, MakesModelsTable.Model);							
                          
                      
        }
                
        public virtual void GetModelBin()
        {
            
            // Retrieve the value entered by the user on the ModelBin ASP:TextBox, and
            // save it into the ModelBin field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelBin.Text, MakesModelsTable.ModelBin);							
                          
                      
        }
                
        public virtual void GetModelCopyAttach()
        {	
        		
            // Retrieve the value entered by the user on the ModelCopyAttach ASP:CheckBox, and
            // save it into the ModelCopyAttach field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ModelCopyAttach = this.ModelCopyAttach.Checked;						
                    
        }
                
        public virtual void GetModelCopyNotes()
        {	
        		
            // Retrieve the value entered by the user on the ModelCopyNotes ASP:CheckBox, and
            // save it into the ModelCopyNotes field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ModelCopyNotes = this.ModelCopyNotes.Checked;						
                    
        }
                
        public virtual void GetModelDateRecordUpdated()
        {
            
            // Retrieve the value entered by the user on the ModelDateRecordUpdated ASP:TextBox, and
            // save it into the ModelDateRecordUpdated field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelDateRecordUpdated.Text, MakesModelsTable.ModelDateRecordUpdated);							
                          
                      
        }
                
        public virtual void GetModelDesc()
        {
            
            // Retrieve the value entered by the user on the ModelDesc ASP:TextBox, and
            // save it into the ModelDesc field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelDesc.Text, MakesModelsTable.ModelDesc);							
                          
                      
        }
                
        public virtual void GetModelExclude()
        {	
        		
            // Retrieve the value entered by the user on the ModelExclude ASP:CheckBox, and
            // save it into the ModelExclude field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ModelExclude = this.ModelExclude.Checked;						
                    
        }
                
        public virtual void GetModelExportInclude()
        {	
        		
            // Retrieve the value entered by the user on the ModelExportInclude ASP:CheckBox, and
            // save it into the ModelExportInclude field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ModelExportInclude = this.ModelExportInclude.Checked;						
                    
        }
                
        public virtual void GetModelExportRecordChanged()
        {	
        		
            // Retrieve the value entered by the user on the ModelExportRecordChanged ASP:CheckBox, and
            // save it into the ModelExportRecordChanged field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ModelExportRecordChanged = this.ModelExportRecordChanged.Checked;						
                    
        }
                
        public virtual void GetModelHandling()
        {
            
            // Retrieve the value entered by the user on the ModelHandling ASP:TextBox, and
            // save it into the ModelHandling field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelHandling.Text, MakesModelsTable.ModelHandling);							
                          
                      
        }
                
        public virtual void GetModelIgnoreSerialNoRules()
        {	
        		
            // Retrieve the value entered by the user on the ModelIgnoreSerialNoRules ASP:CheckBox, and
            // save it into the ModelIgnoreSerialNoRules field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ModelIgnoreSerialNoRules = this.ModelIgnoreSerialNoRules.Checked;						
                    
        }
                
        public virtual void GetModelLabor()
        {
            
            // Retrieve the value entered by the user on the ModelLabor ASP:TextBox, and
            // save it into the ModelLabor field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelLabor.Text, MakesModelsTable.ModelLabor);							
                          
                      
        }
                
        public virtual void GetModelMarkupRate()
        {
            
            // Retrieve the value entered by the user on the ModelMarkupRate ASP:TextBox, and
            // save it into the ModelMarkupRate field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelMarkupRate.Text, MakesModelsTable.ModelMarkupRate);							
                          
                      
        }
                
        public virtual void GetModelNotes()
        {
            
            // Retrieve the value entered by the user on the ModelNotes ASP:TextBox, and
            // save it into the ModelNotes field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelNotes.Text, MakesModelsTable.ModelNotes);							
                          
                      
        }
                
        public virtual void GetModelPackCode()
        {
            
            // Retrieve the value entered by the user on the ModelPackCode ASP:TextBox, and
            // save it into the ModelPackCode field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelPackCode.Text, MakesModelsTable.ModelPackCode);							
                          
                      
        }
                
        public virtual void GetModelParts()
        {
            
            // Retrieve the value entered by the user on the ModelParts ASP:TextBox, and
            // save it into the ModelParts field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelParts.Text, MakesModelsTable.ModelParts);							
                          
                      
        }
                
        public virtual void GetModelPreapproved()
        {	
        		
            // Retrieve the value entered by the user on the ModelPreapproved ASP:CheckBox, and
            // save it into the ModelPreapproved field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.ModelPreapproved = this.ModelPreapproved.Checked;						
                    
        }
                
        public virtual void GetModelReference1()
        {
            
            // Retrieve the value entered by the user on the ModelReference1 ASP:TextBox, and
            // save it into the ModelReference1 field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelReference1.Text, MakesModelsTable.ModelReference1);							
                          
                      
        }
                
        public virtual void GetModelReference2()
        {
            
            // Retrieve the value entered by the user on the ModelReference2 ASP:TextBox, and
            // save it into the ModelReference2 field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelReference2.Text, MakesModelsTable.ModelReference2);							
                          
                      
        }
                
        public virtual void GetModelReference3()
        {
            
            // Retrieve the value entered by the user on the ModelReference3 ASP:TextBox, and
            // save it into the ModelReference3 field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelReference3.Text, MakesModelsTable.ModelReference3);							
                          
                      
        }
                
        public virtual void GetModelReference4()
        {
            
            // Retrieve the value entered by the user on the ModelReference4 ASP:TextBox, and
            // save it into the ModelReference4 field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelReference4.Text, MakesModelsTable.ModelReference4);							
                          
                      
        }
                
        public virtual void GetModelReplaceCostNew()
        {
            
            // Retrieve the value entered by the user on the ModelReplaceCostNew ASP:TextBox, and
            // save it into the ModelReplaceCostNew field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelReplaceCostNew.Text, MakesModelsTable.ModelReplaceCostNew);							
                          
                      
        }
                
        public virtual void GetModelReplaceCostRefurbished()
        {
            
            // Retrieve the value entered by the user on the ModelReplaceCostRefurbished ASP:TextBox, and
            // save it into the ModelReplaceCostRefurbished field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelReplaceCostRefurbished.Text, MakesModelsTable.ModelReplaceCostRefurbished);							
                          
                      
        }
                
        public virtual void GetModelShipping()
        {
            
            // Retrieve the value entered by the user on the ModelShipping ASP:TextBox, and
            // save it into the ModelShipping field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelShipping.Text, MakesModelsTable.ModelShipping);							
                          
                      
        }
                
        public virtual void GetModelSubcontractNotes()
        {
            
            // Retrieve the value entered by the user on the ModelSubcontractNotes ASP:TextBox, and
            // save it into the ModelSubcontractNotes field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelSubcontractNotes.Text, MakesModelsTable.ModelSubcontractNotes);							
                          
                      
        }
                
        public virtual void GetModelTravel()
        {
            
            // Retrieve the value entered by the user on the ModelTravel ASP:TextBox, and
            // save it into the ModelTravel field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelTravel.Text, MakesModelsTable.ModelTravel);							
                          
                      
        }
                
        public virtual void GetModelVendNo()
        {
            
            // Retrieve the value entered by the user on the ModelVendNo ASP:TextBox, and
            // save it into the ModelVendNo field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelVendNo.Text, MakesModelsTable.ModelVendNo);							
                          
                      
        }
                
        public virtual void GetModelWarranty()
        {
            
            // Retrieve the value entered by the user on the ModelWarranty ASP:TextBox, and
            // save it into the ModelWarranty field in DataSource DatabaseAYS_OEM%dbo.MakesModels record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ModelWarranty.Text, MakesModelsTable.ModelWarranty);							
                          
                      
        }
                

      // To customize, override this method in MakesModelsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersMakesModelsTableControl = false;
            hasFiltersMakesModelsTableControl = hasFiltersMakesModelsTableControl && false; // suppress warning
      
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
          MakesModelsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((MakesModelsTableControl)MiscUtils.GetParentControlObject(this, "MakesModelsTableControl")).DataChanged = true;
            ((MakesModelsTableControl)MiscUtils.GetParentControlObject(this, "MakesModelsTableControl")).ResetData = true;
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
        MakesModelsTableControl tc= ((MakesModelsTableControl)MiscUtils.GetParentControlObject(this, "MakesModelsTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((MakesModelsTableControlRow)this);
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
            
            string url = @"../MakesModels/Edit-MakesModels.aspx?MakesModels={PK}";
            
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
            
            string url = @"../MakesModels/Show-MakesModels.aspx?MakesModels={PK}";
            
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
            
            
        
        protected virtual void LastExtraction_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ModelCopyAttach_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ModelCopyNotes_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ModelExclude_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ModelExportInclude_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ModelExportRecordChanged_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ModelIgnoreSerialNoRules_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void ModelPreapproved_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void Category_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Make_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Model_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelBin_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelDateRecordUpdated_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelDesc_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelHandling_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelLabor_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelMarkupRate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelNotes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelPackCode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelParts_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelReference1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelReference2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelReference3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelReference4_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelReplaceCostNew_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelReplaceCostRefurbished_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelShipping_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelSubcontractNotes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelTravel_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelVendNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ModelWarranty_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseMakesModelsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseMakesModelsTableControlRow_Rec"] = value;
            }
        }
        
        public MakesModelsRecord DataSource {
            get {
                return (MakesModelsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox Category {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Category");
            }
        }
            
        public System.Web.UI.WebControls.Literal CategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CategoryLabel");
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
        
        public System.Web.UI.WebControls.CheckBox LastExtraction {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastExtraction");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastExtractionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastExtractionLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Make {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Make");
            }
        }
            
        public System.Web.UI.WebControls.Literal MakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Model {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Model");
            }
        }
            
        public System.Web.UI.WebControls.TextBox ModelBin {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelBin");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelBinLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelBinLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ModelCopyAttach {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelCopyAttach");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelCopyAttachLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelCopyAttachLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ModelCopyNotes {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelCopyNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelCopyNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelCopyNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelDateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelDateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelDateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelDateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelDesc {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ModelExclude {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelExcludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExcludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ModelExportInclude {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ModelExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelHandling {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelHandling");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelHandlingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelHandlingLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ModelIgnoreSerialNoRules {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelIgnoreSerialNoRules");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelIgnoreSerialNoRulesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelIgnoreSerialNoRulesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ModelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelLabor {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelLabor");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelLaborLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelLaborLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelMarkupRate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelMarkupRate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelMarkupRateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelMarkupRateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelNotes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelPackCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPackCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelPackCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPackCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelParts {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelParts");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelPartsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPartsLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ModelPreapproved {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPreapproved");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelPreapprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelPreapprovedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelReference1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelReference2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelReference3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelReference4 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelReplaceCostNew {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReplaceCostNew");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReplaceCostNewLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReplaceCostNewLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelReplaceCostRefurbished {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReplaceCostRefurbished");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelReplaceCostRefurbishedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelReplaceCostRefurbishedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelShipping {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelShipping");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelShippingLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelShippingLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelSubcontractNotes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelSubcontractNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelSubcontractNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelSubcontractNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelTravel {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelTravel");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelTravelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelTravelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelVendNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelVendNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelVendNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelVendNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ModelWarranty {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelWarranty");
            }
        }
            
        public System.Web.UI.WebControls.Literal ModelWarrantyLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ModelWarrantyLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SelectRow {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow");
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
        MakesModelsRecord rec = null;
             
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
    MakesModelsRecord rec = null;
    
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

        
        public virtual MakesModelsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return MakesModelsTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the MakesModelsTableControl control on the Edit_MakesModels_Table page.
// Do not modify this class. Instead override any method in MakesModelsTableControl.
public class BaseMakesModelsTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseMakesModelsTableControl()
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
                if  (this.InSession(this.CategoryFilter)) 				
                    initialVal = this.GetFromSession(this.CategoryFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"Category\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] CategoryFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in CategoryFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.CategoryFilter.Items.Add(item);
                            this.CategoryFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.CategoryFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.MakeFilter)) 				
                    initialVal = this.GetFromSession(this.MakeFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"Make\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] MakeFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in MakeFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.MakeFilter.Items.Add(item);
                            this.MakeFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.MakeFilter.Items)
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
            
              this.CategoryFilter.SelectedIndexChanged += CategoryFilter_SelectedIndexChanged;                  
                
              this.MakeFilter.SelectedIndexChanged += MakeFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.MakesModelsRecord);
                      this.DataSource = (MakesModelsRecord[])(alist.ToArray(myrec));
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
                    foreach (MakesModelsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.MakesModelsRecord);
                    this.DataSource = (MakesModelsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual MakesModelsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(MakesModelsTable.Column1, true);          
            // selCols.Add(MakesModelsTable.Column2, true);          
            // selCols.Add(MakesModelsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return MakesModelsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                MakesModelsTable databaseTable = new MakesModelsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(MakesModelsRecord)) as MakesModelsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(MakesModelsTable.Column1, true);          
            // selCols.Add(MakesModelsTable.Column2, true);          
            // selCols.Add(MakesModelsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return MakesModelsTable.GetRecordCount(join, where);
            else
            {
                MakesModelsTable databaseTable = new MakesModelsTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MakesModelsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            MakesModelsTableControlRow recControl = (MakesModelsTableControlRow)(repItem.FindControl("MakesModelsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                SetCategoryFilter();
                SetCategoryLabel1();
                
                
                
                SetMakeFilter();
                SetMakeLabel1();
                SetOrderSort();
                
                
                
                
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
          
            this.Page.PregetDfkaRecords(MakesModelsTable.Category, this.DataSource);
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


            
            this.CategoryFilter.ClearSelection();
            
            this.MakeFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
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
    
            // Bind the buttons for MakesModelsTableControl pagination.
        
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
              
            foreach (MakesModelsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (MakesModelsTableControlRow recCtl in this.GetRecordControls()){
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
            MakesModelsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.CategoryFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.CategoryFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.CategoryFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(MakesModelsTable.Category, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.MakeFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.MakeFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.MakeFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(MakesModelsTable.Make, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
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
      
      cols.Add(MakesModelsTable.Category, true);
      
      cols.Add(MakesModelsTable.Make, true);
      
      cols.Add(MakesModelsTable.Model, true);
      
      cols.Add(MakesModelsTable.ModelReference1, true);
      
      cols.Add(MakesModelsTable.ModelReference2, true);
      
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
            MakesModelsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String CategoryFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CategoryFilter_Ajax"];
            if (MiscUtils.IsValueSelected(CategoryFilterSelectedValue)) {

              
        if (CategoryFilterSelectedValue != null){
                        string[] CategoryFilteritemListFromSession = CategoryFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in CategoryFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(MakesModelsTable.Category, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String MakeFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "MakeFilter_Ajax"];
            if (MiscUtils.IsValueSelected(MakeFilterSelectedValue)) {

              
        if (MakeFilterSelectedValue != null){
                        string[] MakeFilteritemListFromSession = MakeFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in MakeFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(MakesModelsTable.Make, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
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
      
      cols.Add(MakesModelsTable.Category, true);
      
      cols.Add(MakesModelsTable.Make, true);
      
      cols.Add(MakesModelsTable.Model, true);
      
      cols.Add(MakesModelsTable.ModelReference1, true);
      
      cols.Add(MakesModelsTable.ModelReference2, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(MakesModelsTable.Category, true);
      
      cols.Add(MakesModelsTable.Make, true);
      
      cols.Add(MakesModelsTable.Model, true);
      
      cols.Add(MakesModelsTable.ModelReference1, true);
      
      cols.Add(MakesModelsTable.ModelReference2, true);
      
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
            OEMConversion.Business.MakesModelsRecord[] recordList  = MakesModelsTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (MakesModelsRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(MakesModelsTable.Category);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(MakesModelsTable.Category.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, MakesModelsTable.Category.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(MakesModelsTable.Make);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(MakesModelsTable.Make.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, MakesModelsTable.Make.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(MakesModelsTable.Model);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(MakesModelsTable.Model.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, MakesModelsTable.Model.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(MakesModelsTable.ModelReference1);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(MakesModelsTable.ModelReference1.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, MakesModelsTable.ModelReference1.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(MakesModelsTable.ModelReference2);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(MakesModelsTable.ModelReference2.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, MakesModelsTable.ModelReference2.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MakesModelsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                MakesModelsTableControlRow recControl = (MakesModelsTableControlRow)(repItem.FindControl("MakesModelsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      MakesModelsRecord rec = new MakesModelsRecord();
        
                        if (recControl.Category.Text != "") {
                            rec.Parse(recControl.Category.Text, MakesModelsTable.Category);
                  }
                
                        rec.LastExtraction = recControl.LastExtraction.Checked;
                
                        if (recControl.Make.Text != "") {
                            rec.Parse(recControl.Make.Text, MakesModelsTable.Make);
                  }
                
                        if (recControl.Model.Text != "") {
                            rec.Parse(recControl.Model.Text, MakesModelsTable.Model);
                  }
                
                        if (recControl.ModelBin.Text != "") {
                            rec.Parse(recControl.ModelBin.Text, MakesModelsTable.ModelBin);
                  }
                
                        rec.ModelCopyAttach = recControl.ModelCopyAttach.Checked;
                
                        rec.ModelCopyNotes = recControl.ModelCopyNotes.Checked;
                
                        if (recControl.ModelDateRecordUpdated.Text != "") {
                            rec.Parse(recControl.ModelDateRecordUpdated.Text, MakesModelsTable.ModelDateRecordUpdated);
                  }
                
                        if (recControl.ModelDesc.Text != "") {
                            rec.Parse(recControl.ModelDesc.Text, MakesModelsTable.ModelDesc);
                  }
                
                        rec.ModelExclude = recControl.ModelExclude.Checked;
                
                        rec.ModelExportInclude = recControl.ModelExportInclude.Checked;
                
                        rec.ModelExportRecordChanged = recControl.ModelExportRecordChanged.Checked;
                
                        if (recControl.ModelHandling.Text != "") {
                            rec.Parse(recControl.ModelHandling.Text, MakesModelsTable.ModelHandling);
                  }
                
                        rec.ModelIgnoreSerialNoRules = recControl.ModelIgnoreSerialNoRules.Checked;
                
                        if (recControl.ModelLabor.Text != "") {
                            rec.Parse(recControl.ModelLabor.Text, MakesModelsTable.ModelLabor);
                  }
                
                        if (recControl.ModelMarkupRate.Text != "") {
                            rec.Parse(recControl.ModelMarkupRate.Text, MakesModelsTable.ModelMarkupRate);
                  }
                
                        if (recControl.ModelNotes.Text != "") {
                            rec.Parse(recControl.ModelNotes.Text, MakesModelsTable.ModelNotes);
                  }
                
                        if (recControl.ModelPackCode.Text != "") {
                            rec.Parse(recControl.ModelPackCode.Text, MakesModelsTable.ModelPackCode);
                  }
                
                        if (recControl.ModelParts.Text != "") {
                            rec.Parse(recControl.ModelParts.Text, MakesModelsTable.ModelParts);
                  }
                
                        rec.ModelPreapproved = recControl.ModelPreapproved.Checked;
                
                        if (recControl.ModelReference1.Text != "") {
                            rec.Parse(recControl.ModelReference1.Text, MakesModelsTable.ModelReference1);
                  }
                
                        if (recControl.ModelReference2.Text != "") {
                            rec.Parse(recControl.ModelReference2.Text, MakesModelsTable.ModelReference2);
                  }
                
                        if (recControl.ModelReference3.Text != "") {
                            rec.Parse(recControl.ModelReference3.Text, MakesModelsTable.ModelReference3);
                  }
                
                        if (recControl.ModelReference4.Text != "") {
                            rec.Parse(recControl.ModelReference4.Text, MakesModelsTable.ModelReference4);
                  }
                
                        if (recControl.ModelReplaceCostNew.Text != "") {
                            rec.Parse(recControl.ModelReplaceCostNew.Text, MakesModelsTable.ModelReplaceCostNew);
                  }
                
                        if (recControl.ModelReplaceCostRefurbished.Text != "") {
                            rec.Parse(recControl.ModelReplaceCostRefurbished.Text, MakesModelsTable.ModelReplaceCostRefurbished);
                  }
                
                        if (recControl.ModelShipping.Text != "") {
                            rec.Parse(recControl.ModelShipping.Text, MakesModelsTable.ModelShipping);
                  }
                
                        if (recControl.ModelSubcontractNotes.Text != "") {
                            rec.Parse(recControl.ModelSubcontractNotes.Text, MakesModelsTable.ModelSubcontractNotes);
                  }
                
                        if (recControl.ModelTravel.Text != "") {
                            rec.Parse(recControl.ModelTravel.Text, MakesModelsTable.ModelTravel);
                  }
                
                        if (recControl.ModelVendNo.Text != "") {
                            rec.Parse(recControl.ModelVendNo.Text, MakesModelsTable.ModelVendNo);
                  }
                
                        if (recControl.ModelWarranty.Text != "") {
                            rec.Parse(recControl.ModelWarranty.Text, MakesModelsTable.ModelWarranty);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new MakesModelsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.MakesModelsRecord);
                this.DataSource = (MakesModelsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(MakesModelsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(MakesModelsTableControlRow rec)            
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
        
        public virtual void SetCategoryLabel1()
                  {
                  
                    
        }
                
        public virtual void SetMakeLabel1()
                  {
                  
                    
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
            
        public virtual void SetCategoryFilter()
        {
            
            ArrayList CategoryFilterselectedFilterItemList = new ArrayList();
            string CategoryFilteritemsString = null;
            if (this.InSession(this.CategoryFilter))
                CategoryFilteritemsString = this.GetFromSession(this.CategoryFilter);
            
            if (CategoryFilteritemsString != null)
            {
                string[] CategoryFilteritemListFromSession = CategoryFilteritemsString.Split(',');
                foreach (string item in CategoryFilteritemListFromSession)
                {
                    CategoryFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateCategoryFilter(MiscUtils.GetSelectedValueList(this.CategoryFilter, CategoryFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Category/Category-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.CategoryFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Category")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.CategoryFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(CategoryFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetMakeFilter()
        {
            
            ArrayList MakeFilterselectedFilterItemList = new ArrayList();
            string MakeFilteritemsString = null;
            if (this.InSession(this.MakeFilter))
                MakeFilteritemsString = this.GetFromSession(this.MakeFilter);
            
            if (MakeFilteritemsString != null)
            {
                string[] MakeFilteritemListFromSession = MakeFilteritemsString.Split(',');
                foreach (string item in MakeFilteritemListFromSession)
                {
                    MakeFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateMakeFilter(MiscUtils.GetSelectedValueList(this.MakeFilter, MakeFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../MakesModels/MakesModels-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.MakeFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Make")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.MakeFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(MakeFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
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
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Ascending}"), "Category Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Descending}"), "Category Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Extraction {Txt:Ascending}"), "LastExtraction Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Extraction {Txt:Descending}"), "LastExtraction Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Copy Attach {Txt:Ascending}"), "ModelCopyAttach Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Copy Attach {Txt:Descending}"), "ModelCopyAttach Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Copy Notes {Txt:Ascending}"), "ModelCopyNotes Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Copy Notes {Txt:Descending}"), "ModelCopyNotes Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Date Record Updated {Txt:Ascending}"), "ModelDateRecordUpdated Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Date Record Updated {Txt:Descending}"), "ModelDateRecordUpdated Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Exclude {Txt:Ascending}"), "ModelExclude Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Exclude {Txt:Descending}"), "ModelExclude Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Handling {Txt:Ascending}"), "ModelHandling Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Handling {Txt:Descending}"), "ModelHandling Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Markup Rate {Txt:Ascending}"), "ModelMarkupRate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Markup Rate {Txt:Descending}"), "ModelMarkupRate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Vend Number {Txt:Ascending}"), "ModelVendNo Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Vend Number {Txt:Descending}"), "ModelVendNo Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Warranty {Txt:Ascending}"), "ModelWarranty Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model Warranty {Txt:Descending}"), "ModelWarranty Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Makesmodels Active {Txt:Ascending}"), "makesmodels_active Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Makesmodels Active {Txt:Descending}"), "makesmodels_active Desc"));
              
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
            
        // Get the filters' data for CategoryFilter.
                
        protected virtual void PopulateCategoryFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_CategoryFilter();            
            this.CategoryFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CategoryFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            CategoryRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = CategoryView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (CategoryRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CategorySpecified) 
                        {
                            cvalue = itemValue.Category.ToString();
                            if (counter < maxItems && this.CategoryFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = MakesModelsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(MakesModelsTable.Category);
                                if(_isExpandableNonCompositeForeignKey && MakesModelsTable.Category.IsApplyDisplayAs)
                                     fvalue = MakesModelsTable.GetDFKA(itemValue, MakesModelsTable.Category);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(CategoryView.Category);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.CategoryFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.CategoryFilter.Items.Add(newItem);

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
            
            
            this.CategoryFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.CategoryFilter.Items.Count == 0)
                this.CategoryFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.CategoryFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        // Get the filters' data for MakeFilter.
                
        protected virtual void PopulateMakeFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_MakeFilter();            
            this.MakeFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_MakeFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(MakesModelsTable.Make, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = MakesModelsTable.GetValues(MakesModelsTable.Make, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( MakesModelsTable.Make.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = MakesModelsTable.Make.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.MakeFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.MakeFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.MakeFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.MakeFilter.Items.Count == 0)
                this.MakeFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.MakeFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_CategoryFilter()
        {
            // Create a where clause for the filter CategoryFilter.
            // This function is called by the Populate method to load the items 
            // in the CategoryFilterQuickSelector
        
            ArrayList CategoryFilterselectedFilterItemList = new ArrayList();
            string CategoryFilteritemsString = null;
            if (this.InSession(this.CategoryFilter))
                CategoryFilteritemsString = this.GetFromSession(this.CategoryFilter);
            
            if (CategoryFilteritemsString != null)
            {
                string[] CategoryFilteritemListFromSession = CategoryFilteritemsString.Split(',');
                foreach (string item in CategoryFilteritemListFromSession)
                {
                    CategoryFilterselectedFilterItemList.Add(item);
                }
            }
              
            CategoryFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CategoryFilter, CategoryFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (CategoryFilterselectedFilterItemList == null || CategoryFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in CategoryFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(CategoryView.Category, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      
        public virtual WhereClause CreateWhereClause_MakeFilter()
        {
            // Create a where clause for the filter MakeFilter.
            // This function is called by the Populate method to load the items 
            // in the MakeFilterQuickSelector
        
            ArrayList MakeFilterselectedFilterItemList = new ArrayList();
            string MakeFilteritemsString = null;
            if (this.InSession(this.MakeFilter))
                MakeFilteritemsString = this.GetFromSession(this.MakeFilter);
            
            if (MakeFilteritemsString != null)
            {
                string[] MakeFilteritemListFromSession = MakeFilteritemsString.Split(',');
                foreach (string item in MakeFilteritemListFromSession)
                {
                    MakeFilterselectedFilterItemList.Add(item);
                }
            }
              
            MakeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.MakeFilter, MakeFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (MakeFilterselectedFilterItemList == null || MakeFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in MakeFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(MakesModelsTable.Make, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("MakesModelsTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                MakesModelsTableControlRow recControl = (MakesModelsTableControlRow)repItem.FindControl("MakesModelsTableControlRow");
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
                  
            ArrayList CategoryFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CategoryFilter, null);
            string CategoryFilterSessionString = "";
            if (CategoryFilterselectedFilterItemList != null){
                foreach (string item in CategoryFilterselectedFilterItemList){
                    CategoryFilterSessionString = String.Concat(CategoryFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.CategoryFilter, CategoryFilterSessionString);
                  
            ArrayList MakeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.MakeFilter, null);
            string MakeFilterSessionString = "";
            if (MakeFilterselectedFilterItemList != null){
                foreach (string item in MakeFilterselectedFilterItemList){
                    MakeFilterSessionString = String.Concat(MakeFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.MakeFilter, MakeFilterSessionString);
                  
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
                  
            ArrayList CategoryFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.CategoryFilter, null);
            string CategoryFilterSessionString = "";
            if (CategoryFilterselectedFilterItemList != null){
                foreach (string item in CategoryFilterselectedFilterItemList){
                    CategoryFilterSessionString = String.Concat(CategoryFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("CategoryFilter_Ajax", CategoryFilterSessionString);
          
            ArrayList MakeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.MakeFilter, null);
            string MakeFilterSessionString = "";
            if (MakeFilterselectedFilterItemList != null){
                foreach (string item in MakeFilterselectedFilterItemList){
                    MakeFilterSessionString = String.Concat(MakeFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("MakeFilter_Ajax", MakeFilterSessionString);
          
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.CategoryFilter);
            this.RemoveFromSession(this.MakeFilter);
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

            string orderByStr = (string)ViewState["MakesModelsTableControl_OrderBy"];
          
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
                this.ViewState["MakesModelsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
    
      
            if (MiscUtils.IsValueSelected(CategoryFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(MakeFilter))
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
                
              this.CategoryFilter.ClearSelection();
            
              this.MakeFilter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
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
           
                foreach (MakesModelsTableControlRow recCtl in this.GetRecordControls()){
                     
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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in MakesModelsTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(MakesModelsTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (MakesModelsTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && MakesModelsTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(MakesModelsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(MakesModelsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void CategoryFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void MakeFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = MakesModelsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  MakesModelsRecord[] DataSource {
             
            get {
                return (MakesModelsRecord[])(base._DataSource);
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector CategoryFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CategoryFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal CategoryLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CategoryLabel1");
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector MakeFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MakeFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal MakeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MakeLabel1");
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
                MakesModelsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        MakesModelsRecord rec = null;
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
                MakesModelsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        MakesModelsRecord rec = null;
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
            foreach (MakesModelsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual MakesModelsTableControlRow GetSelectedRecordControl()
        {
        MakesModelsTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual MakesModelsTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (MakesModelsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow != null && recControl.SelectRow.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (MakesModelsTableControlRow[])(selectedList.ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_MakesModels_Table.MakesModelsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            MakesModelsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (MakesModelsTableControlRow recCtl in recordList)
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

        public virtual MakesModelsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "MakesModelsTableControlRow");
	          List<MakesModelsTableControlRow> list = new List<MakesModelsTableControlRow>();
	          foreach (MakesModelsTableControlRow recCtrl in recCtrls) {
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

  