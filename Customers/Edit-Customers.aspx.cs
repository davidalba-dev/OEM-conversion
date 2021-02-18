
// This file implements the code-behind class for Edit_Customers.aspx.
// App_Code\Edit_Customers.Controls.vb contains the Table, Row and Record control classes
// for the page.  Best practices calls for overriding methods in the Row or Record control classes.

#region "Using statements"    

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
        
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Utils;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using BaseClasses.Web.UI.WebControls;
        
using OEMConversion.Business;
using OEMConversion.Data;
        

#endregion

  
namespace OEMConversion.UI
{
  
public partial class Edit_Customers
        : BaseApplicationPage
// Code-behind class for the Edit_Customers page.
// Place your customizations in Section 1. Do not modify Section 2.
{
        
      #region "Section 1: Place your customizations here."

      public Edit_Customers()
        {
            this.Initialize();
    

        }
        
    public void SetPageFocus()
    {
      //To set focus on page load to a specific control pass this control to the SetStartupFocus method. To get a hold of a control
      //use FindControlRecursively method. For example:
      //System.Web.UI.WebControls.TextBox controlToFocus = (System.Web.UI.WebControls.TextBox)(this.FindControlRecursively("ProductsSearch"));
      //this.SetFocusOnLoad(controlToFocus);
      //If no control is passed or control does not exist this method will set focus on the first focusable control on the page.
      this.SetFocusOnLoad();	
    }
         
        public void LoadData()
        {
            // LoadData reads database data and assigns it to UI controls.
            // Customize by adding code before or after the call to LoadData_Base()
            // or replace the call to LoadData_Base().
            LoadData_Base();            
        }
        
      private string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string,object> variables, bool includeDS)
      {
          return EvaluateFormula_Base(formula, dataSourceForEvaluate, format, variables, includeDS);
      }
      
      public void Page_InitializeEventHandlers(object sender, System.EventArgs e)
      {
          // Handles base.Init. 
          // Register the Event handler for any Events.
          this.Page_InitializeEventHandlers_Base(sender, e);
      }
      
      protected override void SaveControlsToSession()
      {
        SaveControlsToSession_Base();
      }


      protected override void ClearControlsFromSession()
      {
        ClearControlsFromSession_Base();
      }

      protected override void LoadViewState(object savedState)
      {
        LoadViewState_Base(savedState);
      }


      protected override object SaveViewState()
      {
        return SaveViewState_Base();
      }      


        public void Page_PreRender(object sender, System.EventArgs e)
        {
            this.Page_PreRender_Base(sender, e);
        }
        
      
      public override void SaveData()
      {
          this.SaveData_Base();
      }          
              
    
      public override void SetControl(string control)
      {
          this.SetControl_Base(control);
      }
    
    
      public void Page_PreInit(object sender, System.EventArgs e)
      {
          //override call to PreInit_Base() here to change top level master page used by this page.
          //For example for Microsoft SharePoint applications uncomment next line to use Microsoft SharePoint default master page
          //if(this.Master != null) this.Master.MasterPageFile = Microsoft.SharePoint.SPContext.Current.Web.MasterUrl;	
          //You may change here assignment of application theme
          try
          {
              this.PreInit_Base();
          }
          catch
          {
          
          } 
      }
      
#region "Ajax Functions"

        [System.Web.Services.WebMethod()]
        public static Object[] GetRecordFieldValue(string contextName,
                                                   string tableName , 
                                                   string recordID , 
                                                   string columnName, 
                                                   string fieldName, 
                                                   string title, 
                                                   string closeBtnText,
                                                   bool persist, 
                                                   int popupWindowHeight, 
                                                   int popupWindowWidth, 
                                                   bool popupWindowScrollBar)
        {
            // GetRecordFieldValue gets the pop up window content from the column specified by
            // columnName in the record specified by the recordID in data base table specified by tableName.
            // Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            // or replace the call to  GetRecordFieldValue_Base().
            return GetRecordFieldValue_Base(contextName, tableName, recordID, columnName, fieldName, title, closeBtnText, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar);
        }

        [System.Web.Services.WebMethod()]
        public static object[] GetImage(string contextName,
                                        string tableName,
                                        string recordID, 
                                        string columnName, 
                                        string title, 
                                        string closeBtnText,
                                        bool persist, 
                                        int popupWindowHeight, 
                                        int popupWindowWidth, 
                                        bool popupWindowScrollBar)
        {
            // GetImage gets the Image url for the image in the column "columnName" and
            // in the record specified by recordID in data base table specified by tableName.
            // Customize by adding code before or after the call to  GetImage_Base()
            // or replace the call to  GetImage_Base().
            return GetImage_Base(contextName, tableName, recordID, columnName, title, closeBtnText, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar);
        }
        
    
      protected override void BasePage_PreRender(object sender, EventArgs e)
      {
          base.BasePage_PreRender(sender, e);
          RegisterPostback();
      }
      
      protected void RegisterPostback()
      {
          Base_RegisterPostback();	  
      }
    
      
      #endregion

      // Page Event Handlers - buttons, sort, links
      
        public void CancelButton_Click(object sender, EventArgs args)
        {

          // Click handler for CancelButton.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          CancelButton_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
        }
            
        public void SaveButton_Click(object sender, EventArgs args)
        {

          // Click handler for SaveButton.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          SaveButton_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
        }
            
    
        // Write out the Set methods
        
//        public void SetCustomersTabContainer()
//        {
//            SetCustomersTabContainer_Base(); 
//        }
        
        public void SetCustomersRecordControl()
        {
            SetCustomersRecordControl_Base(); 
        }
        
//        public void SetRepairOrdersTableControl()
//        {
//            SetRepairOrdersTableControl_Base(); 
//        }
        
        public void SetCancelButton()
        {
            SetCancelButton_Base(); 
        }              
            
        public void SetSaveButton()
        {
            SetSaveButton_Base(); 
        }              
                         
        
        // Write out the methods for DataSource
        


//public void SetCustomerContactsRecordControl()
//        {
//            SetCustomerContactsRecordControl_Base(); 
//        }
public void SetTabContainer()
        {
            SetTabContainer_Base(); 
        }
//public void SetCustomerContactsTableControl()
//        {
//            SetCustomerContactsTableControl_Base(); 
//        }
//public void SetCustomer_noteRecordControl()
//        {
//            SetCustomer_noteRecordControl_Base(); 
//        }
//public void SetCustomer_noteTableControl()
//        {
//            SetCustomer_noteTableControl_Base(); 
//        }
public void SetCustomer_noteTableControl()
        {
            SetCustomer_noteTableControl_Base(); 
        }
public void SetCustomer_payTableControl()
        {
            SetCustomer_payTableControl_Base(); 
        }
public void SetTechniciansRecordControl()
        {
            SetTechniciansRecordControl_Base(); 
        }
public void SendEmailOnSaveButton_Click()
    {
      //Customize by adding code before the call or replace the call to the Base function with your own code.
      SendEmailOnSaveButton_Click_Base();
    }
//public void SetDepartmentTableControl()
//        {
//            SetDepartmentTableControl_Base(); 
//        }
//[System.Web.Services.WebMethod]
//        public static string[] GetAutoCompletionList_DepartmentSearchText(string prefixText, int count)
//        {
//            // GetDepartmentSearchTextCompletionList gets the list of suggestions from the database.
//            // prefixText is the search text typed by the user .
//            // count specifies the number of suggestions to be returned.
//            // Customize by adding code before or after the call to  GetAutoCompletionList_DepartmentSearchText_Base()
//            // or replace the call to GetAutoCompletionList_DepartmentSearchText_Base().
//            return GetAutoCompletionList_DepartmentSearchText_Base(prefixText, count);
//        }
//public void SetSite_inventoryTableControl()
//        {
//            SetSite_inventoryTableControl_Base(); 
//        }
public void SetPrivateNotes()
        {
            SetPrivateNotes_Base(); 
        }
//public void SetSiteinv_serial_viewTableControl()
//        {
//            SetSiteinv_serial_viewTableControl_Base(); 
//        }
//public void SetSiteinv_serialno_viewTableControl()
//        {
//            SetSiteinv_serialno_viewTableControl_Base(); 
//        }
public void SetCustomerContactsTableControl1()
        {
            SetCustomerContactsTableControl1_Base(); 
        }
[System.Web.Services.WebMethod]
        public static string[] GetAutoCompletionList_CustomerContactsSearchText1(string prefixText, int count)
        {
            // GetCustomerContactsSearchText1CompletionList gets the list of suggestions from the database.
            // prefixText is the search text typed by the user .
            // count specifies the number of suggestions to be returned.
            // Customize by adding code before or after the call to  GetAutoCompletionList_CustomerContactsSearchText1_Base()
            // or replace the call to GetAutoCompletionList_CustomerContactsSearchText1_Base().
            return GetAutoCompletionList_CustomerContactsSearchText1_Base(prefixText, count);
        }
public void SetDepartmentTableControl1()
        {
            SetDepartmentTableControl1_Base(); 
        }
public void SetSiteinv_serialno_viewTableControl1()
        {
            SetSiteinv_serialno_viewTableControl1_Base(); 
        }
//public void SetSiteinv_serialno_viewTableControl2()
//        {
//            SetSiteinv_serialno_viewTableControl2_Base(); 
//        }
//public void SetSiteinv_serialno_viewTableControl2()
//        {
//            SetSiteinv_serialno_viewTableControl2_Base(); 
//        }
//public void SetSiteinv_serialno_viewTableControl6()
//        {
//            SetSiteinv_serialno_viewTableControl6_Base(); 
//        }
public void SetSiteinv_serialno_viewTableControl()
        {
            SetSiteinv_serialno_viewTableControl_Base(); 
        }
public void SetCustomercontact_loginTableControl()
        {
            SetCustomercontact_loginTableControl_Base(); 
        }
[System.Web.Services.WebMethod]
        public static string[] GetAutoCompletionList_Customercontact_loginSearchText(string prefixText, int count)
        {
            // GetCustomercontact_loginSearchTextCompletionList gets the list of suggestions from the database.
            // prefixText is the search text typed by the user .
            // count specifies the number of suggestions to be returned.
            // Customize by adding code before or after the call to  GetAutoCompletionList_Customercontact_loginSearchText_Base()
            // or replace the call to GetAutoCompletionList_Customercontact_loginSearchText_Base().
            return GetAutoCompletionList_Customercontact_loginSearchText_Base(prefixText, count);
        }
public void SetVw_max_equip_import_batch_idRecordControl()
        {
            SetVw_max_equip_import_batch_idRecordControl_Base(); 
        }
//public void SetVw_max_equip_import_batch_idRecordControl1()
//        {
//            SetVw_max_equip_import_batch_idRecordControl1_Base(); 
//        }
public void SetContractTableControl()
        {
            SetContractTableControl_Base(); 
        }
[System.Web.Services.WebMethod]
        public static string[] GetAutoCompletionList_ContractSearchText(string prefixText, int count)
        {
            // GetContractSearchTextCompletionList gets the list of suggestions from the database.
            // prefixText is the search text typed by the user .
            // count specifies the number of suggestions to be returned.
            // Customize by adding code before or after the call to  GetAutoCompletionList_ContractSearchText_Base()
            // or replace the call to GetAutoCompletionList_ContractSearchText_Base().
            return GetAutoCompletionList_ContractSearchText_Base(prefixText, count);
        }
public void SetLoaner_requestTableControl()
        {
            SetLoaner_requestTableControl_Base(); 
        }
public void SetRepairorder_historyTableControl()
        {
            SetRepairorder_historyTableControl_Base(); 
        }
#endregion

#region "Section 2: Do not modify this section."

      
        private void Initialize()
        {
            // Called by the class constructor to initialize event handlers for Init and Load
            // You can customize by modifying the constructor in Section 1.
            this.Init += new EventHandler(Page_InitializeEventHandlers);
            this.PreInit += new EventHandler(Page_PreInit);
            this.Load += new EventHandler(Page_Load);

            EvaluateFormulaDelegate = new BaseClasses.Data.DataSource.EvaluateFormulaDelegate(EvaluateFormula);        
        }
        
    
      // Handles base.Init. Registers event handler for any button, sort or links.
      // You can add additional Init handlers in Section 1.
      public void Page_InitializeEventHandlers_Base(object sender, System.EventArgs e)
      {
    
        // This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
        // include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
        if(!string.IsNullOrEmpty(this.Enctype)) this.Page.Form.Enctype = this.Enctype;
        	  
          this.PreRender += new EventHandler(Page_PreRender);    
          
          // Register the Event handler for any Events.
      
            


          // Setup the pagination events.
        
                    this.CancelButton.Button.Click += CancelButton_Click;
                        
                    this.SaveButton.Button.Click += SaveButton_Click;
                        
          this.ClearControlsFromSession();    
    
          System.Web.HttpContext.Current.Session["isd_geo_location"] = "<location><error>LOCATION_ERROR_DISABLED</error></location>";
    
          System.Web.UI.HtmlControls.HtmlGenericControl Include = new System.Web.UI.HtmlControls.HtmlGenericControl("script");
          Include.Attributes.Add("type", "text/javascript");
          Include.InnerHtml = "var IsInfinitePage = true; var sessvar = \"is_loaded\";if (window.frameElement != null) {sessvar = \"is_loaded\" +window.frameElement.id;}var iframeName = \"\";var bolea = \"False\";if(window.frameElement != null){iframeName =window.frameElement.id;}if(iframeName.indexOf(\"Infiniteframe\") == -1){bolea = \"True\";}if (bolea == \"True\") {if(!sessionStorage.getItem(sessvar) || sessionStorage.getItem(sessvar) == \"False\") {sessionStorage.setItem(sessvar, \"True\");}else {var htmlurl = window.location.href; if(htmlurl.indexOf(\"?InfiIframe\") != -1){htmlurl = htmlurl.replace(\"?InfiIframe\",\"\");}else{if(htmlurl.indexOf(\"&InfiIframe\") != -1){htmlurl = htmlurl.replace(\"&InfiIframe\", \"\");}} window.location.href =htmlurl;if (navigator.appName == 'Microsoft Internet Explorer'){window.location.href = htmlurl;}sessionStorage.setItem(sessvar, \"False\");}}else{if (bolea == \"False\") {window.alert = function() {};}}";
          Include.ID = "InfiScript";
          this.Page.Header.Controls.Add(Include);
    
        }

        private void Base_RegisterPostback()
        {
        
              this.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SaveButton"));
                                
        }

        protected void BasePage_PreRender_Base(object sender, System.EventArgs e)
        {
            // Load data for each record and table UI control.
                  
            // Data bind for each chart UI control.
          
        }

        // Handles base.Load.  Read database data and put into the UI controls.
        // You can add additional Load handlers in Section 1.
        protected virtual void Page_Load(object sender, EventArgs e)
        {
    
               if (this.FindControlRecursively("Infiniteframe") == null){
                  Control RmvControl = this.FindControlRecursively("InfiScript");
                  this.Page.Header.Controls.Remove(RmvControl);
                }
            
                this.SetPageFocus();
            
            // Check if user has access to this page.  Redirects to either sign-in page
            // or 'no access' page if not. Does not do anything if role-based security
            // is not turned on, but you can override to add your own security.
            this.Authorize("NOT_ANONYMOUS");
             if (!this.IsPostBack)
             {
            
                    // Setup the header text for the validation summary control.
                    this.ValidationSummary1.HeaderText = GetResourceValue("ValidationSummaryHeaderText", "OEMConversion");
                 
             }
            
    // Load data only when displaying the page for the first time or if postback from child window
    if ((!this.IsPostBack) || ( this.Request["__EVENTTARGET"] == "ChildWindowPostBack") || ( this.Request["__EVENTTARGET"] == "isd_geo_location")) {

    // Read the data for all controls on the page.
    // To change the behavior, override the DataBind method for the individual
    // record or table UI controls.
    this.LoadData();
    }

    
            Page.Title = ExpandResourceValue("{Title:Edit} Customers");
        
        if (!IsPostBack)
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "PopupScript", "openPopupPage('QPageSize');", true);
        
            }

            public static object[] GetRecordFieldValue_Base(string contextName,
                        string tableName ,
                        string recordID ,
                        string columnName,
                        string fieldName,
                        string title, 
                        string closeBtnText,
                        bool persist,
                        int popupWindowHeight,
                        int popupWindowWidth,
                        bool popupWindowScrollBar)
            {
            if (recordID != ""){
                recordID = System.Web.HttpUtility.UrlDecode(recordID);
            }
            string content = BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName);
            
            content =  NetUtils.EncodeStringForHtmlDisplay(content);
            // returnValue is an array of string values.
            // returnValue(0) represents title of the pop up window.
            // returnValue(1) represents the tooltip of the close button.
            // returnValue(2) represents content of the text.
            // returnValue(3) represents whether pop up window should be made persistant
            // or it should close as soon as mouse moves out.
            // returnValue(4), (5) represents pop up window height and width respectivly
            // returnValue(6) represents whether pop up window should contain scroll bar.
            // They can be modified by going to Attribute tab of the properties window of the control in aspx page.
            object[] returnValue = new object[7];
            returnValue[0] = title;
            returnValue[1] = closeBtnText;
            returnValue[2] = content;
            returnValue[3] = persist;
            returnValue[4] = popupWindowWidth;
            returnValue[5] = popupWindowHeight;
            returnValue[6] = popupWindowScrollBar;
            return returnValue;
        }
        

        public static object[] GetImage_Base(string contextName,
        string tableName,
        string recordID,
        string columnName,
        string title, 
        string closeBtnText,
        bool persist,
        int popupWindowHeight,
        int popupWindowWidth,
        bool popupWindowScrollBar)
        {
            string  content;
            if (contextName != null && contextName != "NULL")
            {
                content = "<IMG alt =\"" + title + "\" src =" + "\"../Shared/ExportFieldValue.aspx?Context=" + contextName + "&Table=" + tableName + "&Field=" + columnName + "&Record=" + recordID + "\"/>";
            }
            else
            {
                content = "<IMG alt =\"" + title + "\" src =" + "\"../Shared/ExportFieldValue.aspx?Table=" + tableName + "&Field=" + columnName + "&Record=" + recordID + "\"/>";
            }
        // returnValue is an array of string values.
        // returnValue(0) represents title of the pop up window.
        // returnValue(1) represents the tooltip of the close button.
        // returnValue(2) represents content ie, image url.
        // returnValue(3) represents whether pop up window should be made persistant
        // or it should close as soon as mouse moves out.
        // returnValue(4), (5) represents pop up window height and width respectivly
        // returnValue(6) represents whether pop up window should contain scroll bar.
        // They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        object[] returnValue = new object[7];
        returnValue[0] = title;
        returnValue[1] = closeBtnText;
        returnValue[2] = content;
        returnValue[3] = persist;
        returnValue[4] = popupWindowWidth;
        returnValue[5] = popupWindowHeight;
        returnValue[6] = popupWindowScrollBar;
        return returnValue;
    }

      public void SetControl_Base(string control)
      {
          // Load data for each record and table UI control.
        
          switch (control)
          {
          
              case "ContractTableControl":
                 SetContractTableControl();
                 break;
          
              case "Customer_noteTableControl":
                 SetCustomer_noteTableControl();
                 break;
          
              case "Customer_payTableControl":
                 SetCustomer_payTableControl();
                 break;
          
              case "Customercontact_loginTableControl":
                 SetCustomercontact_loginTableControl();
                 break;
          
              case "CustomerContactsTableControl1":
                 SetCustomerContactsTableControl1();
                 break;
          
              case "CustomersRecordControl":
                 SetCustomersRecordControl();
                 break;
          
              case "DepartmentTableControl1":
                 SetDepartmentTableControl1();
                 break;
          
              case "Loaner_requestTableControl":
                 SetLoaner_requestTableControl();
                 break;
          
              case "PrivateNotes":
                 SetPrivateNotes();
                 break;
          
              case "Repairorder_historyTableControl":
                 SetRepairorder_historyTableControl();
                 break;
          
              case "Siteinv_serialno_viewTableControl":
                 SetSiteinv_serialno_viewTableControl();
                 break;
          
              case "Siteinv_serialno_viewTableControl1":
                 SetSiteinv_serialno_viewTableControl1();
                 break;
          
              case "TechniciansRecordControl":
                 SetTechniciansRecordControl();
                 break;
          
              case "Vw_max_equip_import_batch_idRecordControl":
                 SetVw_max_equip_import_batch_idRecordControl();
                 break;
               
          }
        
      }
      
    
      
      public void SaveData_Base()
      {
      
        this.ContractTableControl.SaveData();
        
        this.Customer_payTableControl.SaveData();
        
        this.Customercontact_loginTableControl.SaveData();
        
        this.CustomerContactsTableControl1.SaveData();
        
        this.CustomersRecordControl.SaveData();
        
        this.PrivateNotes.SaveData();
        
        this.TechniciansRecordControl.SaveData();
        
        this.Vw_max_equip_import_batch_idRecordControl.SaveData();
        
      }
      
     
    
        protected void SaveControlsToSession_Base()
        {
            base.SaveControlsToSession();
        
        }


        protected void ClearControlsFromSession_Base()
        {
            base.ClearControlsFromSession();
        
        }

        protected void LoadViewState_Base(object savedState)
        {
            base.LoadViewState(savedState);
        
        }


        protected object SaveViewState_Base()
        {
            
            return base.SaveViewState();
        }
        
    
     
      public void PreInit_Base()
      {
      //If it is SharePoint application this function performs dynamic Master Page assignment.
      
            if ((this.Page as BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle") == "Popup")
            {
                string masterPage = "../Master Pages/Popup.master";      
                this.Page.MasterPageFile = masterPage;
            }      
            
            if ((this.Page as BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle") == "NewWindow")
            {
                string masterPage = "../Master Pages/Blank.master";      
                this.Page.MasterPageFile = masterPage;
            }         
            
            // if url parameter specified a master apge, load it here
            if (!string.IsNullOrEmpty(this.Page.Request["MasterPage"]))
            {
                string masterPage = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("MasterPage");
                this.Page.MasterPageFile = masterPage;
            }
                   
       
      }
      
      public void Page_PreRender_Base(object sender, System.EventArgs e)
      {
     
          if ((this.Page as BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle")  == "Popup")
              AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "QPopupCreateHeader", "QPopupCreateHeader();", true);          
                 
            // Load data for each record and table UI control.
                  
            // Data bind for each chart UI control.
              
      }  
      
        
    public static string[] GetAutoCompletionList_ContractSearchText_Base(string prefixText, int count)
    {
        // Since this method is a shared/static method it does not maintain information about page or controls within the page.
        // Hence we can not invoke any method associated with any controls.
        // So, if we need to use any control in the page we need to instantiate it.
        OEMConversion.UI.Controls.Edit_Customers.ContractTableControl control = new OEMConversion.UI.Controls.Edit_Customers.ContractTableControl();
        
        return control.GetAutoCompletionList_ContractSearchText(prefixText, count);
            
    }
      
    public static string[] GetAutoCompletionList_Customercontact_loginSearchText_Base(string prefixText, int count)
    {
        // Since this method is a shared/static method it does not maintain information about page or controls within the page.
        // Hence we can not invoke any method associated with any controls.
        // So, if we need to use any control in the page we need to instantiate it.
        OEMConversion.UI.Controls.Edit_Customers.Customercontact_loginTableControl control = new OEMConversion.UI.Controls.Edit_Customers.Customercontact_loginTableControl();
        
        return control.GetAutoCompletionList_Customercontact_loginSearchText(prefixText, count);
            
    }
      
    public static string[] GetAutoCompletionList_CustomerContactsSearchText1_Base(string prefixText, int count)
    {
        // Since this method is a shared/static method it does not maintain information about page or controls within the page.
        // Hence we can not invoke any method associated with any controls.
        // So, if we need to use any control in the page we need to instantiate it.
        OEMConversion.UI.Controls.Edit_Customers.CustomerContactsTableControl1 control = new OEMConversion.UI.Controls.Edit_Customers.CustomerContactsTableControl1();
        
        return control.GetAutoCompletionList_CustomerContactsSearchText1(prefixText, count);
            
    }
      

    // Load data from database into UI controls.
    // Modify LoadData in Section 1 above to customize.  Or override DataBind() in
    // the individual table and record controls to customize.
    public void LoadData_Base()
    {
    
            try {
                
    if ((!this.IsPostBack) || ( this.Request["__EVENTTARGET"] == "ChildWindowPostBack") || ( this.Request["__EVENTTARGET"] == "isd_geo_location")) {
    // Must start a transaction before performing database operations
    DbUtils.StartTransaction();
    }



                this.DataBind();
                
                
                
            SetTabContainer(); 
          
    
                // Load and bind data for each record and table UI control.
                
        SetContractTableControl();
        
        SetCustomer_payTableControl();
        
        SetCustomercontact_loginTableControl();
        
        SetCustomerContactsTableControl1();
        
        SetCustomersRecordControl();
        
        SetPrivateNotes();
        
        SetTechniciansRecordControl();
        
        SetVw_max_equip_import_batch_idRecordControl();
        
    
                // Load data for chart.
                
            
                // initialize aspx controls
                
                SetCancelButton();
              
                SetSaveButton();
              
                //Set the corresponding menu item to be highlighted for this page
                System.Web.UI.MasterPage pageMaster = this.Master;
                if (!(pageMaster == null)) {
                IMenuComponent menuComponent = ((IMenuComponent)(this.Master.FindControl("_Menu")));
                    if (!(menuComponent == null)) {
                        menuComponent.HiliteSettings = "CustomersMenuItem";
                    }
                }
            
    } catch (Exception ex) {
    // An error has occured so display an error message.
    BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "Page_Load_Error_Message", ex.Message);
    } finally {
    if ((!this.IsPostBack) || ( this.Request["__EVENTTARGET"] == "ChildWindowPostBack") || ( this.Request["__EVENTTARGET"] == "isd_geo_location")) {
    // End database transaction
    DbUtils.EndTransaction();
    }
    }

    }

    public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;
    public string EvaluateFormula_Base(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
            FormulaEvaluator e = new FormulaEvaluator();

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

            
            e.CallingControl = this;

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;
            
            // Define the calling control.  
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
            {
                return FormulaUtils.Format(resultObj, format);
            }
            else
            {
                return resultObj.ToString();
            }
        }		
        
        public string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
            return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true);
        }
        
        
        private string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
            return EvaluateFormula(formula, dataSourceForEvaluate, null, null, true);
        }
        
        public string EvaluateFormula(string formula, bool includeDS)
        {
            return EvaluateFormula(formula, null, null, null, includeDS);
        }
        
        public string EvaluateFormula(string formula)
        {
            return EvaluateFormula(formula, null, null, null, true);
        }
        
                
        // Write out the Set methods
        
        public void SetTabContainer_Base()           
        
        {
                            
                   
            if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "true") 
                MiscUtils.FindControlRecursively(this, "TabContainer").Visible = true;
            else if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "false") 
                MiscUtils.FindControlRecursively(this, "TabContainer").Visible = false;
         
  
        }      
      
        public void SetContractTableControl_Base()           
        
        {        
            if (ContractTableControl.Visible)
            {
                ContractTableControl.LoadData();
                ContractTableControl.DataBind();
            }
        }
      
        public void SetCustomer_noteTableControl_Base()           
        
        {        
            if (Customer_noteTableControl.Visible)
            {
                Customer_noteTableControl.LoadData();
                Customer_noteTableControl.DataBind();
            }
        }
      
        public void SetCustomer_payTableControl_Base()           
        
        {        
            if (Customer_payTableControl.Visible)
            {
                Customer_payTableControl.LoadData();
                Customer_payTableControl.DataBind();
            }
        }
      
        public void SetCustomercontact_loginTableControl_Base()           
        
        {        
            if (Customercontact_loginTableControl.Visible)
            {
                Customercontact_loginTableControl.LoadData();
                Customercontact_loginTableControl.DataBind();
            }
        }
      
        public void SetCustomerContactsTableControl1_Base()           
        
        {        
            if (CustomerContactsTableControl1.Visible)
            {
                CustomerContactsTableControl1.LoadData();
                CustomerContactsTableControl1.DataBind();
            }
        }
      
        public void SetCustomersRecordControl_Base()           
        
        {        
            if (CustomersRecordControl.Visible)
            {
                CustomersRecordControl.LoadData();
                CustomersRecordControl.DataBind();
            }
        }
      
        public void SetDepartmentTableControl1_Base()           
        
        {        
            if (DepartmentTableControl1.Visible)
            {
                DepartmentTableControl1.LoadData();
                DepartmentTableControl1.DataBind();
            }
        }
      
        public void SetLoaner_requestTableControl_Base()           
        
        {        
            if (Loaner_requestTableControl.Visible)
            {
                Loaner_requestTableControl.LoadData();
                Loaner_requestTableControl.DataBind();
            }
        }
      
        public void SetPrivateNotes_Base()           
        
        {        
            if (PrivateNotes.Visible)
            {
                PrivateNotes.LoadData();
                PrivateNotes.DataBind();
            }
        }
      
        public void SetRepairorder_historyTableControl_Base()           
        
        {        
            if (Repairorder_historyTableControl.Visible)
            {
                Repairorder_historyTableControl.LoadData();
                Repairorder_historyTableControl.DataBind();
            }
        }
      
        public void SetSiteinv_serialno_viewTableControl_Base()           
        
        {        
            if (Siteinv_serialno_viewTableControl.Visible)
            {
                Siteinv_serialno_viewTableControl.LoadData();
                Siteinv_serialno_viewTableControl.DataBind();
            }
        }
      
        public void SetSiteinv_serialno_viewTableControl1_Base()           
        
        {        
            if (Siteinv_serialno_viewTableControl1.Visible)
            {
                Siteinv_serialno_viewTableControl1.LoadData();
                Siteinv_serialno_viewTableControl1.DataBind();
            }
        }
      
        public void SetTechniciansRecordControl_Base()           
        
        {        
            if (TechniciansRecordControl.Visible)
            {
                TechniciansRecordControl.LoadData();
                TechniciansRecordControl.DataBind();
            }
        }
      
        public void SetVw_max_equip_import_batch_idRecordControl_Base()           
        
        {        
            if (Vw_max_equip_import_batch_idRecordControl.Visible)
            {
                Vw_max_equip_import_batch_idRecordControl.LoadData();
                Vw_max_equip_import_batch_idRecordControl.DataBind();
            }
        }
      
        public void SetCancelButton_Base()                
              
        {
        
   
        }
            
        public void SetSaveButton_Base()                
              
        {
        
                    this.SaveButton.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, \"" + this.GetResourceValue("Txt:SaveRecord", "OEMConversion") + "\");");
                  
   
        }
                

        // Write out the DataSource properties and methods
                

        // Write out event methods for the page events
        
        // event handler for Button
        public void CancelButton_Click_Base(object sender, EventArgs args)
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
                  this.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
            if (shouldRedirect) {
                this.ShouldSaveControlsToSession = true;
      this.RedirectBack();
        
            }
        
        }
            
            
        
        // event handler for Button
        public void SaveButton_Click_Base(object sender, EventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
        
              if (!this.IsPageRefresh)
              {
                  this.SaveData();
              }

          this.CommitTransaction(sender);
                 SendEmailOnSaveButton_Click();
    
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.RollBackTransaction(sender);
                  this.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
    public  void SendEmailOnSaveButton_Click_Base()
        {
            BaseClasses.Utils.MailSenderInThread email;

      
        // For page control
        string SendEmail1From;
        //If From Address has from of expression {SomeRecordControl:FK:Email}
        //substitute expression with actuall value
        //Email address can have format "Display Name <emailAddress@companyName.com>"
        SendEmail1From = this.EvaluateExpressions(System.Web.HttpUtility.UrlDecode("oeminfo%40oemmed.com"), "", false);

        string SendEmail1To;
        //Email Addresses should be separated by comma
        //Display Name <emailAddress@companyName.com>,Display Name <emailAddress@companyName.com> or
        //emalAddress1@companyname.com,emalAddress2@companyname.com
        SendEmail1To = this.EvaluateExpressions(System.Web.HttpUtility.UrlDecode("kplante%40oemmed.com+%3ckplante%40oemmed.com%3e%2c+oeminfo%40oemmed.com"), "" ,false);

          
        string SendEmail1Subject;
        //In case Subject includes expressions substitute them with values
        SendEmail1Subject = this.EvaluateExpressions(System.Web.HttpUtility.UrlDecode("OEM+Medical+Customer+Record+Update"), "", false);
          
        string SendEmail1Content;
        //In case content has expressions substitude then with values
        SendEmail1Content = this.EvaluateExpressions(System.Web.HttpUtility.UrlDecode("The+following+Customer+Account+has+been+updated%0d%0a%0d%0aCustomer+Account%3a+%7bCustomersRecordControl%3aNoUrlEncode%3aFDV%3aCustName%7d%0d%0aUpdated+by%3a%7bTechniciansRecordControl%3aNoUrlEncode%3aFDV%3aTechName%7d%0d%0a%0d%0a%0d%0a"), "", false);
            
        email = new BaseClasses.Utils.MailSenderInThread();
        email.AddFrom(SendEmail1From);
        email.AddTo(SendEmail1To);
          
        email.SetSubject(SendEmail1Subject);
          
        email.SetContent(SendEmail1Content);
            
        email.EmailServer.EnableSsl = true;
          
      
        email.SendMessage();					
        
    }
      
      


#endregion

  
}
  
}
  