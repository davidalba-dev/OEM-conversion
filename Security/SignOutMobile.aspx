﻿<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="SignOutMobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.SignOutMobile" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonMobile" Src="../Shared/ThemeButtonMobile.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="Content" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
          <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft"><OEMConversion:ThemeButtonMobile runat="server" id="MenuButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButtonMobile></td><td class="mobileHeaderTitle"><asp:Literal runat="server" id="DialogTitle" Text="&lt;%# GetResourceValue(&quot;Txt:SignOut&quot;, &quot;OEMConversion&quot;) %>">	</asp:Literal></td><td class="mobileHeaderRight"></td></tr></table>
</td></tr><tr><td class="mobileBody"><asp:panel id="SignOutCollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileBody"><tr><td class="mobileBodyText"><asp:Label runat="server" id="SignOutMessage" Text="&lt;%# GetResourceValue(&quot;Txt:SuccessfullySignOut&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label><br /><br /></td></tr><tr><td><OEMConversion:ThemeButtonMobile runat="server" id="ForgetSignInButton" button-causesvalidation="False" button-commandname="ForgetSignInInformation" button-text="&lt;%# GetResourceValue(&quot;Btn:ForgetSignInButton&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:ForgetSignInButton&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonMobile></td></tr><tr><td class="mobileBodyText"><br /><asp:Label id="CloseWindowMessage" runat="server" Text="<%# GetResourceValue(&quot;Txt:CloseWindowMessage&quot;, &quot;OEMConversion&quot;) %>" />&nbsp;</td></tr></table></asp:panel>
</td></tr></table><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>          
        <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
    </asp:Content>
          