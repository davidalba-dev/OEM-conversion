﻿<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="ForgotUserMobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.ForgotUserMobile" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonMobile" Src="../Shared/ThemeButtonMobile.ascx" %>
<%@ Register TagPrefix="asp" Namespace="Recaptcha" Assembly="Recaptcha" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><table class="mobileHeader" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileHeaderLeft"><OEMConversion:ThemeButtonMobile runat="server" id="MenuButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButtonMobile></td><td class="mobileHeaderTitle"><asp:Literal runat="server" id="DialogTitle" Text="&lt;%#String.Concat(&quot;&lt;span class=&#39;mobileFontAdjust70&#39;>&quot;, GetResourceValue(&quot;Title:ForgotUser&quot;), &quot;&lt;/span>&quot;) %>">	</asp:Literal></td><td class="mobileHeaderRight"><OEMConversion:ThemeButtonMobile runat="server" id="SendButton" button-causesvalidation="True" button-commandname="ResetData" button-text="&lt;%# GetResourceValue(&quot;Btn:Send&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Send&quot;, &quot;OEMConversion&quot;) %>" commandname="EmailLinkButton_Command"></OEMConversion:ThemeButtonMobile></td></tr></table>
</td></tr><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SendButton")) %><asp:panel id="ForgotUserCollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><table cellpadding="1" cellspacing="1" border="0" width="100%" class="mobileBody"><tr><td style="height: 5px;" class="mobileBodyText"></td></tr><tr><td class="mobileBodyText"><b><asp:Label runat="server" id="ForgotUserInfoLabel" Text="&lt;%# GetResourceValue(&quot;Txt:UserEmailed&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label></b> 
<asp:Label runat="server" id="ForgotUserErrorLabel" visible="False">	</asp:Label></td></tr><tr><td style="height: 5px;" class="mobileBodyText"></td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Label runat="server" id="EnterEmailLabel" Text="&lt;%# GetResourceValue(&quot;Txt:EnterEmail&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="Emailaddress" columns="20" cssclass="mobileFieldInput">	</asp:TextBox>
	<asp:RequiredFieldValidator runat="server" id="EmailaddressRequiredFieldValidator" ControlToValidate="Emailaddress" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Emailaddress&quot;) %>" display="None" enabled="True">	</asp:RequiredFieldValidator></td></tr><tr><td style="height: 5px;" class="mobileBodyText"></td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Label runat="server" id="FillRecaptchaLabel" Text="&lt;%# GetResourceValue(&quot;Txt:EnterCaptcha&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label></td></tr><tr><td class="mobileFieldValueOnBottom"><div id="recaptcha_widget" class="mobileRecaptchaContainer"> 
    <div id="recaptcha_image" class="mobileRecaptchaImage"></div> 
</div>

<asp:panel id="recaptcha_response_holder" runat="server">
<input id="recaptcha_response_field" name="recaptcha_response_field" type="text" columns="20" text="" class="mobileFieldInput" /><br />
<input type="image" align="absbottom" src="../Images/MobileButtonRefresh.png" onclick="Recaptcha.reload();return false;" />
</asp:panel>

</td></tr><tr><td class="mobileFieldValueOnBottom" style="display: none;"><asp:RecaptchaControl ID="recaptcha" runat="server" theme="clean" PublicKey="Enter your key here" PrivateKey="Enter your key here" /></td></tr></table>
</td></tr></table></asp:panel>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SendButton")) %></td></tr></table><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>          
        <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
    </asp:Content>
          