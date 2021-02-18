﻿
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Vw_contactlist_export_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Vw_contactlist_export_Table
{
  

#region "Section 1: Place your customizations here."

    
public class Vw_contactlist_exportTableControlRow : BaseVw_contactlist_exportTableControlRow
{
      
        // The BaseVw_contactlist_exportTableControlRow implements code for a ROW within the
        // the Vw_contactlist_exportTableControl table.  The BaseVw_contactlist_exportTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Vw_contactlist_exportTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Vw_contactlist_exportTableControl : BaseVw_contactlist_exportTableControl
{
    // The BaseVw_contactlist_exportTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Vw_contactlist_exportTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Vw_contactlist_exportTableControlRow control on the Show_Vw_contactlist_export_Table page.
// Do not modify this class. Instead override any method in Vw_contactlist_exportTableControlRow.
public class BaseVw_contactlist_exportTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseVw_contactlist_exportTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Vw_contactlist_exportTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Vw_contactlist_exportTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.vw_contactlist_export record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseVw_contactlist_exportTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Vw_contactlist_exportRecord();
            
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
          

            // Call the Set methods for each controls on the panel
        
                SetCustAddress1();
                SetCustAddress2();
                SetCustCity();
                SetCustContact_active();
                SetCustContactEmail();
                SetCustContactName();
                SetCustContactPhoneBusiness();
                SetCustContactPhoneMobile();
                SetCustContactTitle();
                SetCustName();
                Setcustomer_active();
                SetCustPostalCode();
                SetCustProvince();
                SetCustWebSite();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetCustAddress1()
        {
            
                    
            // Set the CustAddress1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustAddress1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress1Specified) {
                								
                // If the CustAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustAddress1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress1.Text = Vw_contactlist_exportView.CustAddress1.Format(Vw_contactlist_exportView.CustAddress1.DefaultValue);
            		
            }
            
            // If the CustAddress1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustAddress1.Text == null ||
                this.CustAddress1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustAddress1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustAddress2()
        {
            
                    
            // Set the CustAddress2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustAddress2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress2Specified) {
                								
                // If the CustAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustAddress2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress2.Text = Vw_contactlist_exportView.CustAddress2.Format(Vw_contactlist_exportView.CustAddress2.DefaultValue);
            		
            }
            
            // If the CustAddress2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustAddress2.Text == null ||
                this.CustAddress2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustAddress2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustCity()
        {
            
                    
            // Set the CustCity Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustCity is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCitySpecified) {
                								
                // If the CustCity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustCity);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCity.Text = Vw_contactlist_exportView.CustCity.Format(Vw_contactlist_exportView.CustCity.DefaultValue);
            		
            }
            
            // If the CustCity is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustCity.Text == null ||
                this.CustCity.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustCity.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContact_active()
        {
            
                    
            // Set the CustContact_active Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustContact_active is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContact_activeSpecified) {
                								
                // If the CustContact_active is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustContact_active);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustContact_active.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContact_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContact_active.Text = Vw_contactlist_exportView.CustContact_active.Format(Vw_contactlist_exportView.CustContact_active.DefaultValue);
            		
            }
            
            // If the CustContact_active is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContact_active.Text == null ||
                this.CustContact_active.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContact_active.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactEmail()
        {
            
                    
            // Set the CustContactEmail Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustContactEmail is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactEmailSpecified) {
                								
                // If the CustContactEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustContactEmail);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustContactEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactEmail.Text = Vw_contactlist_exportView.CustContactEmail.Format(Vw_contactlist_exportView.CustContactEmail.DefaultValue);
            		
            }
            
            // If the CustContactEmail is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactEmail.Text == null ||
                this.CustContactEmail.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactEmail.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactName()
        {
            
                    
            // Set the CustContactName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustContactName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactNameSpecified) {
                								
                // If the CustContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustContactName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactName.Text = Vw_contactlist_exportView.CustContactName.Format(Vw_contactlist_exportView.CustContactName.DefaultValue);
            		
            }
            
            // If the CustContactName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactName.Text == null ||
                this.CustContactName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactPhoneBusiness()
        {
            
                    
            // Set the CustContactPhoneBusiness Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustContactPhoneBusiness is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactPhoneBusinessSpecified) {
                								
                // If the CustContactPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustContactPhoneBusiness);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustContactPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactPhoneBusiness.Text = Vw_contactlist_exportView.CustContactPhoneBusiness.Format(Vw_contactlist_exportView.CustContactPhoneBusiness.DefaultValue);
            		
            }
            
            // If the CustContactPhoneBusiness is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactPhoneBusiness.Text == null ||
                this.CustContactPhoneBusiness.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactPhoneBusiness.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactPhoneMobile()
        {
            
                    
            // Set the CustContactPhoneMobile Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustContactPhoneMobile is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactPhoneMobileSpecified) {
                								
                // If the CustContactPhoneMobile is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustContactPhoneMobile);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustContactPhoneMobile.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactPhoneMobile is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactPhoneMobile.Text = Vw_contactlist_exportView.CustContactPhoneMobile.Format(Vw_contactlist_exportView.CustContactPhoneMobile.DefaultValue);
            		
            }
            
            // If the CustContactPhoneMobile is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactPhoneMobile.Text == null ||
                this.CustContactPhoneMobile.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactPhoneMobile.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactTitle()
        {
            
                    
            // Set the CustContactTitle Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustContactTitle is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactTitleSpecified) {
                								
                // If the CustContactTitle is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustContactTitle);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustContactTitle.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactTitle is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactTitle.Text = Vw_contactlist_exportView.CustContactTitle.Format(Vw_contactlist_exportView.CustContactTitle.DefaultValue);
            		
            }
            
            // If the CustContactTitle is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactTitle.Text == null ||
                this.CustContactTitle.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactTitle.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustName()
        {
            
                    
            // Set the CustName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNameSpecified) {
                								
                // If the CustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustName.Text = Vw_contactlist_exportView.CustName.Format(Vw_contactlist_exportView.CustName.DefaultValue);
            		
            }
            
            // If the CustName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustName.Text == null ||
                this.CustName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcustomer_active()
        {
            
                    
            // Set the customer_active Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.customer_active is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_activeSpecified) {
                								
                // If the customer_active is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.customer_active);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.customer_active.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.customer_active.Text = Vw_contactlist_exportView.customer_active.Format(Vw_contactlist_exportView.customer_active.DefaultValue);
            		
            }
            
            // If the customer_active is NULL or blank, then use the value specified  
            // on Properties.
            if (this.customer_active.Text == null ||
                this.customer_active.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.customer_active.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustPostalCode()
        {
            
                    
            // Set the CustPostalCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustPostalCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPostalCodeSpecified) {
                								
                // If the CustPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustPostalCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPostalCode.Text = Vw_contactlist_exportView.CustPostalCode.Format(Vw_contactlist_exportView.CustPostalCode.DefaultValue);
            		
            }
            
            // If the CustPostalCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustPostalCode.Text == null ||
                this.CustPostalCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustPostalCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustProvince()
        {
            
                    
            // Set the CustProvince Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustProvince is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustProvinceSpecified) {
                								
                // If the CustProvince is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustProvince);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustProvince.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustProvince.Text = Vw_contactlist_exportView.CustProvince.Format(Vw_contactlist_exportView.CustProvince.DefaultValue);
            		
            }
            
            // If the CustProvince is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustProvince.Text == null ||
                this.CustProvince.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustProvince.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustWebSite()
        {
            
                    
            // Set the CustWebSite Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_contactlist_export database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_contactlist_export record retrieved from the database.
            // this.CustWebSite is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustWebSiteSpecified) {
                								
                // If the CustWebSite is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_contactlist_exportView.CustWebSite);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustWebSite.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustWebSite is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustWebSite.Text = Vw_contactlist_exportView.CustWebSite.Format(Vw_contactlist_exportView.CustWebSite.DefaultValue);
            		
            }
            
            // If the CustWebSite is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustWebSite.Text == null ||
                this.CustWebSite.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustWebSite.Text = "&nbsp;";
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
                ((Vw_contactlist_exportTableControl)MiscUtils.GetParentControlObject(this, "Vw_contactlist_exportTableControl")).DataChanged = true;
                ((Vw_contactlist_exportTableControl)MiscUtils.GetParentControlObject(this, "Vw_contactlist_exportTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
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
        
            GetCustAddress1();
            GetCustAddress2();
            GetCustCity();
            GetCustContact_active();
            GetCustContactEmail();
            GetCustContactName();
            GetCustContactPhoneBusiness();
            GetCustContactPhoneMobile();
            GetCustContactTitle();
            GetCustName();
            Getcustomer_active();
            GetCustPostalCode();
            GetCustProvince();
            GetCustWebSite();
        }
        
        
        public virtual void GetCustAddress1()
        {
            
        }
                
        public virtual void GetCustAddress2()
        {
            
        }
                
        public virtual void GetCustCity()
        {
            
        }
                
        public virtual void GetCustContact_active()
        {
            
        }
                
        public virtual void GetCustContactEmail()
        {
            
        }
                
        public virtual void GetCustContactName()
        {
            
        }
                
        public virtual void GetCustContactPhoneBusiness()
        {
            
        }
                
        public virtual void GetCustContactPhoneMobile()
        {
            
        }
                
        public virtual void GetCustContactTitle()
        {
            
        }
                
        public virtual void GetCustName()
        {
            
        }
                
        public virtual void Getcustomer_active()
        {
            
        }
                
        public virtual void GetCustPostalCode()
        {
            
        }
                
        public virtual void GetCustProvince()
        {
            
        }
                
        public virtual void GetCustWebSite()
        {
            
        }
                

      // To customize, override this method in Vw_contactlist_exportTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersVw_contactlist_exportTableControl = false;
            hasFiltersVw_contactlist_exportTableControl = hasFiltersVw_contactlist_exportTableControl && false; // suppress warning
      
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
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public Vw_contactlist_exportRecord DataSource {
            get {
                return (Vw_contactlist_exportRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal CustAddress1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAddress2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCity {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContact_active {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactEmail {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactPhoneMobile {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneMobile");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactTitle");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_active {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPostalCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustProvince {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustProvince");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustWebSite {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustWebSite");
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
        Vw_contactlist_exportRecord rec = null;
             
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
    Vw_contactlist_exportRecord rec = null;
    
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

        
        public virtual Vw_contactlist_exportRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
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

  
// Base class for the Vw_contactlist_exportTableControl control on the Show_Vw_contactlist_export_Table page.
// Do not modify this class. Instead override any method in Vw_contactlist_exportTableControl.
public class BaseVw_contactlist_exportTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseVw_contactlist_exportTableControl()
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
                if  (this.InSession(this.CustContact_activeFilter)) 				
                    initialVal = this.GetFromSession(this.CustContact_activeFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"CustContact_active\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.CustContact_activeFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.CustContact_activeFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.CustNameFilter)) 				
                    initialVal = this.GetFromSession(this.CustNameFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"CustName\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.CustNameFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.CustNameFilter.SelectedValue = initialVal;
                            
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
        
              this.CustAddress1Label.Click += CustAddress1Label_Click;
            
              this.CustContact_activeLabel.Click += CustContact_activeLabel_Click;
            
              this.CustContactEmailLabel.Click += CustContactEmailLabel_Click;
            
              this.CustContactNameLabel.Click += CustContactNameLabel_Click;
            
              this.CustContactPhoneBusinessLabel.Click += CustContactPhoneBusinessLabel_Click;
            
              this.CustNameLabel.Click += CustNameLabel_Click;
            
              this.customer_activeLabel1.Click += customer_activeLabel1_Click;
            
              this.CustWebSiteLabel.Click += CustWebSiteLabel_Click;
            
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
            this.CustContact_activeFilter.SelectedIndexChanged += new EventHandler(CustContact_activeFilter_SelectedIndexChanged);
            
            this.CustNameFilter.SelectedIndexChanged += new EventHandler(CustNameFilter_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.Vw_contactlist_exportRecord);
                      this.DataSource = (Vw_contactlist_exportRecord[])(alist.ToArray(myrec));
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
                    foreach (Vw_contactlist_exportTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Vw_contactlist_exportRecord);
                    this.DataSource = (Vw_contactlist_exportRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Vw_contactlist_exportRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Vw_contactlist_exportView.Column1, true);          
            // selCols.Add(Vw_contactlist_exportView.Column2, true);          
            // selCols.Add(Vw_contactlist_exportView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Vw_contactlist_exportView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Vw_contactlist_exportView databaseTable = new Vw_contactlist_exportView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Vw_contactlist_exportRecord)) as Vw_contactlist_exportRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Vw_contactlist_exportView.Column1, true);          
            // selCols.Add(Vw_contactlist_exportView.Column2, true);          
            // selCols.Add(Vw_contactlist_exportView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Vw_contactlist_exportView.GetRecordCount(join, where);
            else
            {
                Vw_contactlist_exportView databaseTable = new Vw_contactlist_exportView();
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
               

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vw_contactlist_exportTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Vw_contactlist_exportTableControlRow recControl = (Vw_contactlist_exportTableControlRow)(repItem.FindControl("Vw_contactlist_exportTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                SetCustAddress1Label();
                SetCustContact_activeFilter();
                SetCustContact_activeLabel();
                SetCustContact_activeLabel1();
                SetCustContactEmailLabel();
                SetCustContactNameLabel();
                SetCustContactPhoneBusinessLabel();
                SetCustNameFilter();
                SetCustNameLabel();
                SetCustNameLabel1();
                Setcustomer_activeLabel1();
                SetCustWebSiteLabel();
                
                
                
                
                
                
                
                SetSearchText();
                SetSortByLabel();
                SetSortControl();
                
                
                SetExcelButton();
              
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


            
            this.CustContact_activeFilter.ClearSelection();
            
            this.CustNameFilter.ClearSelection();
            
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
    
            // Bind the buttons for Vw_contactlist_exportTableControl pagination.
        
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
              
            foreach (Vw_contactlist_exportTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (recCtl.Visible) {
                    recCtl.SaveData();
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (Vw_contactlist_exportTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
                
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
            Vw_contactlist_exportView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.CustContact_activeFilter)) {
                        
                wc.iAND(Vw_contactlist_exportView.CustContact_active, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.CustContact_activeFilter, this.GetFromSession(this.CustContact_activeFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.CustNameFilter)) {
                        
                wc.iAND(Vw_contactlist_exportView.CustName, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.CustNameFilter, this.GetFromSession(this.CustNameFilter)), false, false);
                    
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
      
      cols.Add(Vw_contactlist_exportView.CustContactName, true);
      
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
            Vw_contactlist_exportView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String CustContact_activeFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CustContact_activeFilter_Ajax"];
            if (MiscUtils.IsValueSelected(CustContact_activeFilterSelectedValue)) {

              
                wc.iAND(Vw_contactlist_exportView.CustContact_active, BaseFilter.ComparisonOperator.EqualsTo, CustContact_activeFilterSelectedValue, false, false);
                      
      }
                      
      String CustNameFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CustNameFilter_Ajax"];
            if (MiscUtils.IsValueSelected(CustNameFilterSelectedValue)) {

              
                wc.iAND(Vw_contactlist_exportView.CustName, BaseFilter.ComparisonOperator.EqualsTo, CustNameFilterSelectedValue, false, false);
                      
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
      
      cols.Add(Vw_contactlist_exportView.CustContactName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(Vw_contactlist_exportView.CustContactName, true);
      
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
            OEMConversion.Business.Vw_contactlist_exportRecord[] recordList  = Vw_contactlist_exportView.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (Vw_contactlist_exportRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(Vw_contactlist_exportView.CustContactName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Vw_contactlist_exportView.CustContactName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Vw_contactlist_exportView.CustContactName.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vw_contactlist_exportTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Vw_contactlist_exportTableControlRow recControl = (Vw_contactlist_exportTableControlRow)(repItem.FindControl("Vw_contactlist_exportTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Vw_contactlist_exportRecord rec = new Vw_contactlist_exportRecord();
        
                        if (recControl.CustAddress1.Text != "") {
                            rec.Parse(recControl.CustAddress1.Text, Vw_contactlist_exportView.CustAddress1);
                  }
                
                        if (recControl.CustAddress2.Text != "") {
                            rec.Parse(recControl.CustAddress2.Text, Vw_contactlist_exportView.CustAddress2);
                  }
                
                        if (recControl.CustCity.Text != "") {
                            rec.Parse(recControl.CustCity.Text, Vw_contactlist_exportView.CustCity);
                  }
                
                        if (recControl.CustContact_active.Text != "") {
                            rec.Parse(recControl.CustContact_active.Text, Vw_contactlist_exportView.CustContact_active);
                  }
                
                        if (recControl.CustContactEmail.Text != "") {
                            rec.Parse(recControl.CustContactEmail.Text, Vw_contactlist_exportView.CustContactEmail);
                  }
                
                        if (recControl.CustContactName.Text != "") {
                            rec.Parse(recControl.CustContactName.Text, Vw_contactlist_exportView.CustContactName);
                  }
                
                        if (recControl.CustContactPhoneBusiness.Text != "") {
                            rec.Parse(recControl.CustContactPhoneBusiness.Text, Vw_contactlist_exportView.CustContactPhoneBusiness);
                  }
                
                        if (recControl.CustContactPhoneMobile.Text != "") {
                            rec.Parse(recControl.CustContactPhoneMobile.Text, Vw_contactlist_exportView.CustContactPhoneMobile);
                  }
                
                        if (recControl.CustContactTitle.Text != "") {
                            rec.Parse(recControl.CustContactTitle.Text, Vw_contactlist_exportView.CustContactTitle);
                  }
                
                        if (recControl.CustName.Text != "") {
                            rec.Parse(recControl.CustName.Text, Vw_contactlist_exportView.CustName);
                  }
                
                        if (recControl.customer_active.Text != "") {
                            rec.Parse(recControl.customer_active.Text, Vw_contactlist_exportView.customer_active);
                  }
                
                        if (recControl.CustPostalCode.Text != "") {
                            rec.Parse(recControl.CustPostalCode.Text, Vw_contactlist_exportView.CustPostalCode);
                  }
                
                        if (recControl.CustProvince.Text != "") {
                            rec.Parse(recControl.CustProvince.Text, Vw_contactlist_exportView.CustProvince);
                  }
                
                        if (recControl.CustWebSite.Text != "") {
                            rec.Parse(recControl.CustWebSite.Text, Vw_contactlist_exportView.CustWebSite);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Vw_contactlist_exportRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Vw_contactlist_exportRecord);
                this.DataSource = (Vw_contactlist_exportRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetCustAddress1Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CustAddress1Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustContact_activeLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CustContact_activeLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustContact_activeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetCustContactEmailLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CustContactEmailLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustContactNameLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CustContactNameLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustContactPhoneBusinessLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CustContactPhoneBusinessLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustNameLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CustNameLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustNameLabel1()
                  {
                  
                    
        }
                
        public virtual void Setcustomer_activeLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.customer_activeLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustWebSiteLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CustWebSiteLabel.Text = "Some value";
                    
                    
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
            
        public virtual void SetCustContact_activeFilter()
        {
            
            this.PopulateCustContact_activeFilter(MiscUtils.GetSelectedValue(this.CustContact_activeFilter,  GetFromSession(this.CustContact_activeFilter)), 500);					
                                     
        }
            
        public virtual void SetCustNameFilter()
        {
            
            this.PopulateCustNameFilter(MiscUtils.GetSelectedValue(this.CustNameFilter,  GetFromSession(this.CustNameFilter)), 5000);					
                                     
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
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Address 2 {Txt:Ascending}"), "CustAddress2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Address 2 {Txt:Descending}"), "CustAddress2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer City {Txt:Ascending}"), "CustCity Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer City {Txt:Descending}"), "CustCity Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Code {Txt:Ascending}"), "CustCode Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Code {Txt:Descending}"), "CustCode Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Key {Txt:Ascending}"), "CustContactKey Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Key {Txt:Descending}"), "CustContactKey Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Name {Txt:Ascending}"), "CustContactName Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Name {Txt:Descending}"), "CustContactName Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Title {Txt:Ascending}"), "CustContactTitle Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Title {Txt:Descending}"), "CustContactTitle Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Type {Txt:Ascending}"), "CustContactType Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Contact Type {Txt:Descending}"), "CustContactType Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Ascending}"), "CustName Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Name {Txt:Descending}"), "CustName Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Type {Txt:Ascending}"), "customer_type Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Type {Txt:Descending}"), "customer_type Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Province {Txt:Ascending}"), "CustProvince Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Province {Txt:Descending}"), "CustProvince Desc"));
              
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
            
        // Get the filters' data for CustContact_activeFilter.
                
        protected virtual void PopulateCustContact_activeFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.CustContact_activeFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_CustContact_activeFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CustContact_activeFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.CustContact_activeFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Vw_contactlist_exportView.CustContact_active, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Vw_contactlist_exportView.GetValues(Vw_contactlist_exportView.CustContact_active, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Vw_contactlist_exportView.CustContact_active.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Vw_contactlist_exportView.CustContact_active.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.CustContact_activeFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.CustContact_activeFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.CustContact_activeFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.CustContact_activeFilter.SelectedValue != null && this.CustContact_activeFilter.Items.FindByValue(this.CustContact_activeFilter.SelectedValue) == null)
                this.CustContact_activeFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for CustNameFilter.
                
        protected virtual void PopulateCustNameFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.CustNameFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_CustNameFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CustNameFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.CustNameFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Vw_contactlist_exportView.CustName, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Vw_contactlist_exportRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Vw_contactlist_exportView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Vw_contactlist_exportRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CustNameSpecified) 
                        {
                            cvalue = itemValue.CustName.ToString();
                            if (counter < maxItems && this.CustNameFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("CustName", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.CustNameFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.CustNameFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.CustNameFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.CustNameFilter.SelectedValue != null && this.CustNameFilter.Items.FindByValue(this.CustNameFilter.SelectedValue) == null)
                this.CustNameFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_CustContact_activeFilter()
        {
            // Create a where clause for the filter CustContact_activeFilter.
            // This function is called by the Populate method to load the items 
            // in the CustContact_activeFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_CustNameFilter()
        {
            // Create a where clause for the filter CustNameFilter.
            // This function is called by the Populate method to load the items 
            // in the CustNameFilterDropDownList
        
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
        
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            this.SaveToSession(this.CustContact_activeFilter, this.CustContact_activeFilter.SelectedValue);
                  
            this.SaveToSession(this.CustNameFilter, this.CustNameFilter.SelectedValue);
                  
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
          
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
      this.SaveToSession("CustContact_activeFilter_Ajax", this.CustContact_activeFilter.SelectedValue);
              
      this.SaveToSession("CustNameFilter_Ajax", this.CustNameFilter.SelectedValue);
              
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.CustContact_activeFilter);
            this.RemoveFromSession(this.CustNameFilter);
            this.RemoveFromSession(this.SearchText);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["Vw_contactlist_exportTableControl_OrderBy"];
          
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
    
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["Vw_contactlist_exportTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
    
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
    
      
            if (MiscUtils.IsValueSelected(CustContact_activeFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(CustNameFilter))
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
        
        public virtual void CustAddress1Label_Click(object sender, EventArgs args)
        {
            //Sorts by CustAddress1 when clicked.
              
            // Get previous sorting state for CustAddress1.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.CustAddress1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CustAddress1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_contactlist_exportView.CustAddress1, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CustAddress1, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CustContact_activeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CustContact_active when clicked.
              
            // Get previous sorting state for CustContact_active.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.CustContact_active);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CustContact_active.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_contactlist_exportView.CustContact_active, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CustContact_active, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CustContactEmailLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CustContactEmail when clicked.
              
            // Get previous sorting state for CustContactEmail.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.CustContactEmail);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CustContactEmail.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_contactlist_exportView.CustContactEmail, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CustContactEmail, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CustContactNameLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CustContactName when clicked.
              
            // Get previous sorting state for CustContactName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.CustContactName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CustContactName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_contactlist_exportView.CustContactName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CustContactName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CustContactPhoneBusinessLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CustContactPhoneBusiness when clicked.
              
            // Get previous sorting state for CustContactPhoneBusiness.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.CustContactPhoneBusiness);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CustContactPhoneBusiness.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_contactlist_exportView.CustContactPhoneBusiness, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CustContactPhoneBusiness, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CustNameLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CustName when clicked.
              
            // Get previous sorting state for CustName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.CustName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CustName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_contactlist_exportView.CustName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CustName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void customer_activeLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by customer_active when clicked.
              
            // Get previous sorting state for customer_active.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.customer_active);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for customer_active.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_contactlist_exportView.customer_active, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by customer_active, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CustWebSiteLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CustWebSite when clicked.
              
            // Get previous sorting state for CustWebSite.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.CustWebSite);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CustWebSite.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_contactlist_exportView.CustWebSite, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CustWebSite, so just reverse.
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


              this.TotalRecords = Vw_contactlist_exportView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Vw_contactlist_exportView.CustContactName,
             Vw_contactlist_exportView.CustContactTitle,
             Vw_contactlist_exportView.CustContactPhoneBusiness,
             Vw_contactlist_exportView.CustContactPhoneMobile,
             Vw_contactlist_exportView.CustContactEmail,
             Vw_contactlist_exportView.CustName,
             Vw_contactlist_exportView.CustAddress1,
             Vw_contactlist_exportView.CustAddress2,
             Vw_contactlist_exportView.CustCity,
             Vw_contactlist_exportView.CustProvince,
             Vw_contactlist_exportView.CustPostalCode,
             Vw_contactlist_exportView.CustWebSite,
             Vw_contactlist_exportView.customer_active,
             Vw_contactlist_exportView.CustContact_active,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Vw_contactlist_exportView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Vw_contactlist_exportView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Vw_contactlist_exportView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Vw_contactlist_exportView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustContactName, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustContactTitle, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustContactPhoneBusiness, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustContactPhoneMobile, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustContactEmail, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustName, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustAddress1, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustAddress2, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustCity, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustProvince, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustPostalCode, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustWebSite, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.customer_active, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_contactlist_exportView.CustContact_active, "Default"));


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
                val = Vw_contactlist_exportView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Vw-contactlist-export-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_contactlist_export";
                // If Show-Vw-contactlist-export-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_contactlist_exportView.CustContactName.Name, ReportEnum.Align.Left, "${CustContactName}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustContactTitle.Name, ReportEnum.Align.Left, "${CustContactTitle}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustContactPhoneBusiness.Name, ReportEnum.Align.Left, "${CustContactPhoneBusiness}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustContactPhoneMobile.Name, ReportEnum.Align.Left, "${CustContactPhoneMobile}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustContactEmail.Name, ReportEnum.Align.Left, "${CustContactEmail}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustName.Name, ReportEnum.Align.Left, "${CustName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustAddress1.Name, ReportEnum.Align.Left, "${CustAddress1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustAddress2.Name, ReportEnum.Align.Left, "${CustAddress2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustCity.Name, ReportEnum.Align.Left, "${CustCity}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustProvince.Name, ReportEnum.Align.Left, "${CustProvince}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustPostalCode.Name, ReportEnum.Align.Left, "${CustPostalCode}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_contactlist_exportView.CustWebSite.Name, ReportEnum.Align.Left, "${CustWebSite}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.customer_active.Name, ReportEnum.Align.Left, "${customer_active}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_contactlist_exportView.CustContact_active.Name, ReportEnum.Align.Left, "${CustContact_active}", ReportEnum.Align.Left, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Vw_contactlist_exportView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Vw_contactlist_exportView.GetRecordCount(joinFilter,whereClause);
                Vw_contactlist_exportRecord[] records = null;
                
                do
                {
                    
                    records = Vw_contactlist_exportView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Vw_contactlist_exportRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${CustContactName}", record.Format(Vw_contactlist_exportView.CustContactName), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContactTitle}", record.Format(Vw_contactlist_exportView.CustContactTitle), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContactPhoneBusiness}", record.Format(Vw_contactlist_exportView.CustContactPhoneBusiness), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContactPhoneMobile}", record.Format(Vw_contactlist_exportView.CustContactPhoneMobile), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContactEmail}", record.Format(Vw_contactlist_exportView.CustContactEmail), ReportEnum.Align.Left, 300);
                             report.AddData("${CustName}", record.Format(Vw_contactlist_exportView.CustName), ReportEnum.Align.Left, 300);
                             report.AddData("${CustAddress1}", record.Format(Vw_contactlist_exportView.CustAddress1), ReportEnum.Align.Left, 300);
                             report.AddData("${CustAddress2}", record.Format(Vw_contactlist_exportView.CustAddress2), ReportEnum.Align.Left, 300);
                             report.AddData("${CustCity}", record.Format(Vw_contactlist_exportView.CustCity), ReportEnum.Align.Left, 300);
                             report.AddData("${CustProvince}", record.Format(Vw_contactlist_exportView.CustProvince), ReportEnum.Align.Left, 300);
                             report.AddData("${CustPostalCode}", record.Format(Vw_contactlist_exportView.CustPostalCode), ReportEnum.Align.Left, 300);
                             report.AddData("${CustWebSite}", record.Format(Vw_contactlist_exportView.CustWebSite), ReportEnum.Align.Left, 300);
                             report.AddData("${customer_active}", record.Format(Vw_contactlist_exportView.customer_active), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContact_active}", record.Format(Vw_contactlist_exportView.CustContact_active), ReportEnum.Align.Left, 300);

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
                
              this.CustContact_activeFilter.ClearSelection();
            
              this.CustNameFilter.ClearSelection();
            
           
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Vw-contactlist-export-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_contactlist_export";
                // If Show-Vw-contactlist-export-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_contactlist_exportView.CustContactName.Name, ReportEnum.Align.Left, "${CustContactName}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustContactTitle.Name, ReportEnum.Align.Left, "${CustContactTitle}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustContactPhoneBusiness.Name, ReportEnum.Align.Left, "${CustContactPhoneBusiness}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustContactPhoneMobile.Name, ReportEnum.Align.Left, "${CustContactPhoneMobile}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustContactEmail.Name, ReportEnum.Align.Left, "${CustContactEmail}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustName.Name, ReportEnum.Align.Left, "${CustName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustAddress1.Name, ReportEnum.Align.Left, "${CustAddress1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustAddress2.Name, ReportEnum.Align.Left, "${CustAddress2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.CustCity.Name, ReportEnum.Align.Left, "${CustCity}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustProvince.Name, ReportEnum.Align.Left, "${CustProvince}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Vw_contactlist_exportView.CustPostalCode.Name, ReportEnum.Align.Left, "${CustPostalCode}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_contactlist_exportView.CustWebSite.Name, ReportEnum.Align.Left, "${CustWebSite}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_contactlist_exportView.customer_active.Name, ReportEnum.Align.Left, "${customer_active}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_contactlist_exportView.CustContact_active.Name, ReportEnum.Align.Left, "${CustContact_active}", ReportEnum.Align.Left, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Vw_contactlist_exportView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Vw_contactlist_exportView.GetColumnList();
                Vw_contactlist_exportRecord[] records = null;
                do
                {
                    records = Vw_contactlist_exportView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Vw_contactlist_exportRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${CustContactName}", record.Format(Vw_contactlist_exportView.CustContactName), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContactTitle}", record.Format(Vw_contactlist_exportView.CustContactTitle), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContactPhoneBusiness}", record.Format(Vw_contactlist_exportView.CustContactPhoneBusiness), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContactPhoneMobile}", record.Format(Vw_contactlist_exportView.CustContactPhoneMobile), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContactEmail}", record.Format(Vw_contactlist_exportView.CustContactEmail), ReportEnum.Align.Left, 300);
                             report.AddData("${CustName}", record.Format(Vw_contactlist_exportView.CustName), ReportEnum.Align.Left, 300);
                             report.AddData("${CustAddress1}", record.Format(Vw_contactlist_exportView.CustAddress1), ReportEnum.Align.Left, 300);
                             report.AddData("${CustAddress2}", record.Format(Vw_contactlist_exportView.CustAddress2), ReportEnum.Align.Left, 300);
                             report.AddData("${CustCity}", record.Format(Vw_contactlist_exportView.CustCity), ReportEnum.Align.Left, 300);
                             report.AddData("${CustProvince}", record.Format(Vw_contactlist_exportView.CustProvince), ReportEnum.Align.Left, 300);
                             report.AddData("${CustPostalCode}", record.Format(Vw_contactlist_exportView.CustPostalCode), ReportEnum.Align.Left, 300);
                             report.AddData("${CustWebSite}", record.Format(Vw_contactlist_exportView.CustWebSite), ReportEnum.Align.Left, 300);
                             report.AddData("${customer_active}", record.Format(Vw_contactlist_exportView.customer_active), ReportEnum.Align.Left, 300);
                             report.AddData("${CustContact_active}", record.Format(Vw_contactlist_exportView.CustContact_active), ReportEnum.Align.Left, 300);

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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Vw_contactlist_exportView.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Vw_contactlist_exportView.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Vw_contactlist_exportView.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Vw_contactlist_exportView.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Vw_contactlist_exportView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Vw_contactlist_exportView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void CustContact_activeFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void CustNameFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Vw_contactlist_exportView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Vw_contactlist_exportRecord[] DataSource {
             
            get {
                return (Vw_contactlist_exportRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton CustAddress1Label {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList CustContact_activeFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_activeFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CustContact_activeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustContact_activeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_activeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CustContactEmailLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CustContactNameLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CustContactPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList CustNameFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNameFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CustNameLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustNameLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton customer_activeLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_activeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CustWebSiteLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustWebSiteLabel");
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
            return EvaluateExpressions(url, arg, null, bEncrypt);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return EvaluateExpressions(url, arg, null, bEncrypt,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            return EvaluateExpressions(url, arg, null, bEncrypt);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return EvaluateExpressions(url, arg, null, bEncrypt);
        }
          
        public virtual Vw_contactlist_exportTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Vw_contactlist_exportTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Vw_contactlist_exportTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Vw_contactlist_export_Table.Vw_contactlist_exportTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Vw_contactlist_exportTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Vw_contactlist_exportTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        // Localization.
                        throw new Exception(Page.GetResourceValue("Err:CannotDelRecs", "OEMConversion"));
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:CannotDelRecs", "OEMConversion"));
                  
                }
            }
        }

        public virtual Vw_contactlist_exportTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Vw_contactlist_exportTableControlRow");
	          List<Vw_contactlist_exportTableControlRow> list = new List<Vw_contactlist_exportTableControlRow>();
	          foreach (Vw_contactlist_exportTableControlRow recCtrl in recCtrls) {
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

  