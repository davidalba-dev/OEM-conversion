<%@ Register Tagprefix="OEMConversion" TagName="InfinitePaginationMobile" Src="../Shared/InfinitePaginationMobile.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Vw_resource_schedule_week_Table_Mobile" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Vw-resource-schedule-week-Table-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Show_Vw_resource_schedule_week_Table_Mobile" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonMobile" Src="../Shared/ThemeButtonMobile.ascx" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td>
                        <OEMConversion:Vw_resource_schedule_weekTableControl runat="server" id="Vw_resource_schedule_weekTableControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <OEMConversion:ThemeButtonMobile runat="server" id="MenuButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButtonMobile>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;&lt;span class=&#39;mobileFontAdjust90&#39;>&quot;, &quot; Resource Schedule Week&quot;, &quot;&lt;/span>&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions">
                      <asp:CollapsiblePanelExtender id="PanelExtenderMobile" runat="server" TargetControlid="CollapsibleRegionMobile" ExpandControlID="IconMobile" CollapseControlID="IconMobile" ImageControlID="IconMobile" ExpandedImage="../images/MobileButtonFiltersCollapse.png" CollapsedImage="../images/MobileButtonFiltersExpand.png" Collapsed="true" SuppressPostBack="true" />
<asp:ImageButton id="IconMobile" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;) %&gt;" causesvalidation="False" imageurl="../images/MobileButtonFiltersCollapse.png" />
                    </td><td class="mobileHeaderRight"></td></tr></table>

                      </td></tr><tr><td width="100%">
                        <OEMConversion:InfinitePaginationMobile runat="server" id="Pagination"></OEMConversion:InfinitePaginationMobile>
                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFilterArea">
                      <asp:panel id="CollapsibleRegionMobile" style="display: none; overflow: hidden; height: 0px; width: 96%; padding-left: 2%; padding-right: 2%; margin: 0px;" cssClass="mobileBody" runat="server">
<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><%# GetResourceValue("Txt:SearchFor", "OEMConversion") %></td><td class="mobileFieldLabelOnTop"></td></tr><tr><td class="mobileFieldValueOnBottom"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton"))%>
<asp:TextBox runat="server" id="SearchText" columns="20" cssclass="mobileFieldInput">	</asp:TextBox><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SearchButton"))%>
</td><td class="mobileFieldValueOnBottom"></td></tr><tr><td class="mobileFieldValueOnBottom"><OEMConversion:ThemeButtonMobile runat="server" id="SearchButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButtonMobile></td><td class="mobileFieldValueOnBottom"></td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_ticket_idLabel" Text="EvaluateFormula(&quot;= \&quot;Ticket\&quot;&quot;, true)">	</asp:Literal></td><td class="mobileFieldLabelOnTop"></td></tr><tr><td class="mobileFieldValueOnBottom"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<asp:TextBox runat="server" id="resource_sch_ticket_idFromFilter" columns="20" cssclass="mobileFieldInput">	</asp:TextBox>
                        <span class="mobileFieldLabelOnTop"><%# GetResourceValue("Txt:To", "OEMConversion") %></span><br />
                        <asp:TextBox runat="server" id="resource_sch_ticket_idToFilter" columns="20" cssclass="mobileFieldInput">	</asp:TextBox>
                    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="mobileFieldValueOnBottom"></td></tr><tr><td class="mobileFieldValueOnBottom"><OEMConversion:ThemeButtonMobile runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButtonMobile></td><td class="mobileFieldValueOnBottom"></td></tr><tr><td class="mobileFieldLabelOnTop">
              <asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label>
            </td><td class="mobileFieldLabelOnTop"></td></tr><tr><td class="mobileFieldValueOnBottom">
            <asp:DropDownList runat="server" id="SortControl" autopostback="True" cssclass="mobileFilterInput" priorityno="1">	</asp:DropDownList>
          </td><td class="mobileFieldValueOnBottom"></td></tr><tr><td class="mobileFieldValueOnBottom"></td><td class="mobileFieldValueOnBottom"></td></tr></table>
</asp:panel>
                  </td></tr><tr><td class="mobileBody"><table id="Vw_resource_schedule_weekTableControlGrid" cellpadding="0" cellspacing="0" border="0" onkeydown="captureUpDownKey(this, event)" width="100%"><tr><th class="mobileTableCell" scope="col" style="display:none"><!-- Note: Cell Is Hidden --></th><th class="mobileTableCell" scope="col" style="display:none"><!-- Note: Cell Is Hidden --></th></tr><asp:Repeater runat="server" id="Vw_resource_schedule_weekTableControlRepeater">		<ITEMTEMPLATE>
		<asp:Repeater runat="server" id="Vw_resource_schedule_weekTableControlRepeater1">				<ITEMTEMPLATE>		<OEMConversion:Vw_resource_schedule_weekTableControlRow runat="server" id="Vw_resource_schedule_weekTableControlRow">
<tr><td class="mobileTableImageCell">
                  &nbsp;
                </td><td class="mobileTableCell"><asp:Label runat="server" id="resource_sch_ticket_id" cssclass="mobileTableCellTitle"></asp:Label> 
                            <br />
                          </td></tr></OEMConversion:Vw_resource_schedule_weekTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</ITEMTEMPLATE>
</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Vw_resource_schedule_weekTableControl_PostbackTracker" runat="server" />
</OEMConversion:Vw_resource_schedule_weekTableControl>

            </td></tr></table>
      
    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                