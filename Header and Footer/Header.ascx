<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Header.ascx.cs" Inherits="OEMConversion.UI.Header" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Header" %>
<table cellpadding="0" cellspacing="0" border="0" width="100%" class="logoBG"><tr><td class="pHeaderT" colspan="4"><asp:HyperLink runat="server" id="_SkipNavigationLinks" cssclass="skipNavigationLinks" navigateurl="#StartOfPageContent" text="&lt;%# GetResourceValue(&quot;Txt:SkipNavigation&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Txt:SkipNavigation&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:HyperLink></td></tr><tr><td><asp:Image runat="server" id="_Logo" alt="&lt;%# GetResourceValue(&quot;Txt:PageHeader&quot;, &quot;OEMConversion&quot;) %>" visible="False" style="border-width:0px;">		
	</asp:Image></td><td style="color:White"><OEMConversion:Repair_order_requestTableControl runat="server" id="_Repair_order_requestTableControl">	<table cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><th></th><th></th><th></th><th></th></tr><asp:Repeater runat="server" id="_Repair_order_requestTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Repair_order_requestTableControlRow runat="server" id="_Repair_order_requestTableControlRow">
</OEMConversion:Repair_order_requestTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
<tr summary="Footer"><td style="color:White;vertical-align:top;"><asp:Label runat="server" id="_processedLabel" Text="Processed">	</asp:Label></td><td class="tableCellValue" style="color:White;vertical-align:top;"><asp:Literal runat="server" id="_Repair_order_requestCountControl">	</asp:Literal></td><td style="color:White;vertical-align:top;"><asp:Label runat="server" id="_processedLabel1" Text="Processed">	</asp:Label></td><td class="tableCellValue" style="color:White;vertical-align:top;"><asp:Literal runat="server" id="_Equipment_pickup_requestCountControl">	</asp:Literal></td></tr></table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Repair_order_requestTableControl_PostbackTracker" runat="server" />
</OEMConversion:Repair_order_requestTableControl>
 
</td><td class="pHeaderC" style="color:White"><asp:Label runat="server" id="_Label" Text="Version 3.11 07/15/2019">	</asp:Label></td><td class="pHeaderR"><table cellpadding="0" cellspacing="0" border="0"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td class="signInBar"><asp:Label runat="server" id="_UserStatusLbl">	</asp:Label></td><td class="signInBar"></td><td class="signInBar"><div onclick="return ISD_ModernButtonClick(this,event);" /><asp:ImageButton runat="server" id="_HeaderSettings" alt="&lt;%# GetResourceValue(&quot;Btn:Settings&quot;, &quot;OEMConversion&quot;) %>" causesvalidation="False" commandname="Custom" imageurl="../Images/ButtonOptions.png" onclientclick="return ISD_ShowPopupPanel(&#39;languagePanel&#39;,&#39;_HeaderSettings&#39;,this);" onmouseout="this.src=&#39;../Images/ButtonOptions.png&#39;" onmouseover="this.src=&#39;../Images/ButtonOptionsOver.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Settings&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="signInBar"><asp:LinkButton runat="server" id="_SignIn" causesvalidation="False" commandname="ShowSignIn" tooltip="SignIn">		
	</asp:LinkButton></td><td>&nbsp;</td></tr></table>
</td></tr></table>
</td></tr><tr><td colspan="4"><div id="languagePanel" class="popupWrapper" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellValue" style="text-align: right"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellValue"><asp:dropdownlist id="LanguageSelector" runat="server" cssclass="Filter_Input" AutoPostBack="true"></asp:dropdownlist></td></tr><tr><td class="popupTableCellValue"><asp:dropdownlist id="ThemeSelector" runat="server" cssclass="Filter_Input" AutoPostBack="true"></asp:dropdownlist></td></tr></table>
</div></td></tr></table>