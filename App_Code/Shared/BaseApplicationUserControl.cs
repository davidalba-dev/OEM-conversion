﻿using System;
using System.Web.UI;
using System.Collections;
using BaseClasses.Data;
using BaseClasses.Utils;

namespace OEMConversion.UI
{

#region "Section 1: Place your customizations here."

    
    public class BaseApplicationUserControl : BaseApplicationUserControlGEN
    {


    }

  

#endregion

  

#region "Section 2: Do not modify this section."

    public class BaseApplicationUserControlGEN : BaseClasses.Web.UI.BaseUserControl
    {
        private bool _modifyRedirectUrlInProgress = false;

        public BaseApplicationUserControlGEN()
        {
            this.PreRender += new EventHandler(Control_ClearControls_PreRender);
            this.Unload += new EventHandler(Control_SaveControls_Unload);
        }

        // Allow for migration from earlier versions which did not have url encryption.
        public virtual string ModifyRedirectUrl(string redirectUrl, string redirectArgument)
        {
            return EvaluateExpressions(redirectUrl, redirectArgument, false);
        }

        public virtual string ModifyRedirectUrl(string redirectUrl, string redirectArgument, bool bEncrypt)
        {
            return EvaluateExpressions(redirectUrl, redirectArgument, bEncrypt);
        }

        public virtual string EvaluateExpressions(string redirectUrl, string redirectArgument, bool bEncrypt)
        {
            const string PREFIX_NO_ENCODE = "NoUrlEncode:";
            if ((_modifyRedirectUrlInProgress))
            {
                return null;
            }
            else
            {
                _modifyRedirectUrlInProgress = true;
            }

            string finalRedirectUrl = redirectUrl;
            string finalRedirectArgument = redirectArgument;
            if ((finalRedirectUrl == null || finalRedirectUrl.Length == 0))
            {
                return "";
            }
            else if ((finalRedirectUrl.IndexOf('{') < 0))
            {
                _modifyRedirectUrlInProgress = false;
                return finalRedirectUrl;
            }
            else
            {
                if (redirectArgument != null && redirectArgument.Length > 0)
                {
                    string[] arguments = redirectArgument.Split(',');
                    for (int i = 0; i <= (arguments.Length - 1); i++)
                    {
                        finalRedirectUrl = finalRedirectUrl.Replace("{" + i.ToString() + "}", "{" + arguments[i] + "}");
                    }
                    finalRedirectArgument = "";
                }

                ArrayList controlList = GetAllRecordAndTableControls();
                if (controlList.Count == 0)
                {
                    return finalRedirectUrl;
                }

                Hashtable controlIdList = new Hashtable();
                bool found = false;
                foreach (System.Web.UI.Control control in controlList)
                {
                    string uID = control.UniqueID;
                    int pageContentIndex = uID.IndexOf("$PageContent$");
                    if (pageContentIndex > 0)
                    {
                        if (found == false)
                        {
                            //Remove all controls without $PageContent$ prefix, because this page is used with Master Page
                            //and these entries are irrelevant
                            controlIdList.Clear();
                        }
                        found = true;
                    }
                    if (found)
                    {
                        //If we found that Master Page is used for this page construction than disregard all controls
                        //without $PageContent$ prefix
                        if (pageContentIndex > 0)
                        {
                            uID = uID.Substring(pageContentIndex + "$PageContent$".Length);
                            controlIdList.Add(uID, control);
                        }
                    }
                    else
                    {
                        //No Master Page presense found so far
                        controlIdList.Add(uID, control);
                    }
                }
                ArrayList forwardTo = new ArrayList();
                string remainingUrl = finalRedirectUrl;
                while ((remainingUrl.IndexOf('{') >= 0) & (remainingUrl.IndexOf('}') > 0) & (remainingUrl.IndexOf('{') < remainingUrl.IndexOf('}')))
                {
                    int leftIndex = remainingUrl.IndexOf('{');
                    int rightIndex = remainingUrl.IndexOf('}');
                    string expression = remainingUrl.Substring(leftIndex + 1, rightIndex - leftIndex - 1);
                    remainingUrl = remainingUrl.Substring(rightIndex + 1);
                    string prefix = null;
                    if ((expression.IndexOf(":") > 0))
                    {
                        prefix = expression.Substring(0, expression.IndexOf(":"));
                    }
                    if ((prefix != null) && (prefix.Length > 0) && (!((StringUtils.InvariantLCase(prefix) == StringUtils.InvariantLCase(PREFIX_NO_ENCODE)))) && (!(BaseRecord.IsKnownExpressionPrefix(prefix))))
                    {
                        if ((controlIdList.Contains(prefix)) & (!(forwardTo.Contains(prefix))))
                        {
                            forwardTo.Add(prefix);
                        }
                    }
                }
                
                foreach (string containerId in forwardTo)
                {
                    Control ctl = ((Control)(controlIdList[containerId]));
                    if (ctl != null)
                    {
                        if (ctl is BaseApplicationRecordControl)
                        {
                            finalRedirectUrl = ((BaseApplicationRecordControl)(ctl)).EvaluateExpressions(finalRedirectUrl, finalRedirectArgument, bEncrypt);
                        }
                        else if (ctl is BaseApplicationTableControl)
                        {
                            finalRedirectUrl = ((BaseApplicationTableControl)(ctl)).EvaluateExpressions(finalRedirectUrl, finalRedirectArgument, bEncrypt);
                        }
                    }
                }

                foreach (Control control in controlList)
                {
                    if ((forwardTo.IndexOf(control.ID) < 0))
                    {
                        if (control is BaseApplicationRecordControl)
                        {
                            finalRedirectUrl = ((BaseApplicationRecordControl)(control)).EvaluateExpressions(finalRedirectUrl, finalRedirectArgument, bEncrypt);
                        }
                        else if (control is BaseApplicationTableControl)
                        {
                            finalRedirectUrl = ((BaseApplicationTableControl)(control)).EvaluateExpressions(finalRedirectUrl, finalRedirectArgument, bEncrypt);
                        }
                    }
                }
            }
            _modifyRedirectUrlInProgress = false;
            return finalRedirectUrl;
        }

        protected virtual ArrayList GetAllRecordAndTableControls()
        {
            ArrayList controlList = new ArrayList();
            GetAllRecordAndTableControls(this, controlList);
            return controlList;
        }

        protected virtual void GetAllRecordAndTableControls(Control ctl, ArrayList controlList)
        {
            if (ctl == null)
            {
                return;
            }
            if (ctl is BaseApplicationRecordControl || ctl is BaseApplicationTableControl)
            {
                controlList.Add(ctl);
            }

            foreach (Control nextCtl in ctl.Controls)
            {
                GetAllRecordAndTableControls(nextCtl, controlList);
            }
        }

		public virtual string GetResourceValue(string keyVal, string appName) 
		{ 
			object resObj = GetGlobalResourceObject(appName, keyVal); 
			try 
			{
				if (!(resObj == null)) 
				{ 
					return resObj.ToString();  
				} 
				return ""; 
			}
			catch(Exception ) 
			{
				return ""; 
			}
			
		}

        public virtual string GetResourceValue(string keyVal)
        {
            string appname = BaseClasses.Configuration.ApplicationSettings.Current.GetAppSetting(BaseClasses.Configuration.ApplicationSettings.ConfigurationKey.ApplicationName);
            object resObj = GetGlobalResourceObject(appname, keyVal);
            try
            {
                if (!(resObj == null))
                {
                    return resObj.ToString();
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }

        }


        protected virtual void Control_SaveControls_Unload(object sender, EventArgs e)
        {
            if (((BaseApplicationPage)(this.Page)).ShouldSaveControlsToSession)
            {
                this.SaveControlsToSession();
            }
        }

        protected virtual void SaveControlsToSession()
        {
        }

        protected virtual void Control_ClearControls_PreRender(object sender, EventArgs e)
        {
            this.ClearControlsFromSession();
        }

        protected virtual void ClearControlsFromSession()
        {
        }

        public virtual void SaveToSession(Control control, string value)
        {
            SaveToSession(control.UniqueID, value);
        }

        public virtual string GetFromSession(Control control, string defaultValue)
        {
            return GetFromSession(control.UniqueID, defaultValue);
        }

        public virtual string GetFromSession(Control control)
        {
            return GetFromSession(control.UniqueID, null);
        }

        public virtual void RemoveFromSession(Control control)
        {
            RemoveFromSession(control.UniqueID);
        }

        public virtual bool InSession(Control control)
        {
            return InSession(control.UniqueID);
        }

        public virtual void SaveToSession(Control control, string variable, string value)
        {
            SaveToSession(control.UniqueID + variable, value);
        }

        public virtual string GetFromSession(Control control, string variable, string defaultValue)
        {
            return GetFromSession(control.UniqueID + variable, defaultValue);
        }

        public virtual void RemoveFromSession(Control control, string variable)
        {
            RemoveFromSession(control.UniqueID + variable);
        }

        public virtual bool InSession(Control control, string variable)
        {
            return InSession(control.UniqueID + variable);
        }

        public virtual void SaveToSession(string name, string value)
        {
            this.Page.Session[GetValueKey(name)] = value;
        }

        public virtual void SetControl(string control)
        {
        }

        public virtual string GetFromSession(string name, string defaultValue)
        {
            string value = ((string)(this.Page.Session[GetValueKey(name)]));
            if (value == null || value.Length == 0)
            {
                value = defaultValue;
            }
            return value;
        }

        public virtual string GetFromSession(string name)
        {
            return GetFromSession(name, null);
        }

        public virtual void RemoveFromSession(string name)
        {
            this.Page.Session.Remove(GetValueKey(name));
        }

        public virtual bool InSession(string name)
        {
            return (!(this.Page.Session[GetValueKey(name)] == null));
        }

        public virtual string GetValueKey(string name)
        {
            return this.Page.Session.SessionID + this.Page.AppRelativeVirtualPath + name;
        }

        // -----------------------------------------------------------------------------
        // <summary>
        // Register Control buttonCtrl with ScriptManager to perform traditional postback instead of default async postback
        // </summary>
        // <remarks>
        // </remarks>
        // <history>
        // 	[sramarao]	3/2007	Created
        // </history>
        // -----------------------------------------------------------------------------
        public virtual void RegisterPostBackTrigger(System.Web.UI.Control buttonCtrl, System.Web.UI.Control updatePanelCtrl)
        {
            try
            {
                // Get current ScriptManager
                ScriptManager scriptMgr = ScriptManager.GetCurrent(this.Page);
                System.Web.UI.UpdatePanel CurrentUpdatePanel = (UpdatePanel)updatePanelCtrl;
                // If Scriptmanager not preset return.
                // If buttonCtrl is not surrounded by an UpdatePanel then return.
                if (scriptMgr != null && CurrentUpdatePanel != null && buttonCtrl != null)
                {
                    scriptMgr.RegisterPostBackControl(buttonCtrl);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void RegisterPostBackTrigger(System.Web.UI.Control buttonCtrl)
        {
            try
            {
                // Get current ScriptManager
                ScriptManager scriptMgr = ScriptManager.GetCurrent(this.Page);
                // If Scriptmanager not preset return.
                if (scriptMgr != null && buttonCtrl != null)
                {
                    scriptMgr.RegisterPostBackControl(buttonCtrl);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void SaveData()
        {
        }
    }

#endregion
}