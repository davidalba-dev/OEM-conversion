﻿<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Control Language="C#" AutoEventWireup="false" CodeFile="ThemeButton.ascx.cs" Inherits="OEMConversion.UI.ThemeButton" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table class="buttonPadding" cellspacing="0" cellpadding="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);"><tr><td><div class="themeButton"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" cssclass="button_link">		
	</asp:LinkButton></div></td></tr></table>