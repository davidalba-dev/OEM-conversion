﻿<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Menu.ascx.cs" Inherits="OEMConversion.UI.Menu" %><table cellpadding="0" cellspacing="0" border="0" class="MLMmenuAlign"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td></td><td><asp:Menu ID="MultiLevelMenu" DataSourceID="SiteMapDataSource1" runat="server" DynamicHorizontalOffset="0" staticdisplaylevels="1" MaximumDynamicDisplayLevels="100" StaticSubMenuIndent="10px" orientation="Horizontal" StaticEnableDefaultPopOutImage="False" CssClass="MLMmenu">
							<StaticMenuItemStyle CssClass="MLMmC" />
							<StaticHoverStyle CssClass="MLMmoC" />
							<DynamicMenuStyle CssClass="MLMmenusub" />
							<DynamicMenuItemStyle CssClass="MLMsubmC" />
							<DynamicHoverStyle CssClass="MLMsubmoC" />
						</asp:Menu>
						<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" SiteMapProvider="MenuElementsProvider" ShowStartingNode="false" />
					</td><td></td></tr></table>
</td><td style="width:100%"></td></tr></table>