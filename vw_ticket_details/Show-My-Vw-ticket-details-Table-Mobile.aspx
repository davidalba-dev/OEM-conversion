<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_My_Vw_ticket_details_Table_Mobile" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-My-Vw-ticket-details-Table-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Show_My_Vw_ticket_details_Table_Mobile" %>
<%@ Register Tagprefix="OEMConversion" TagName="InfinitePaginationMobile" Src="../Shared/InfinitePaginationMobile.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonMobile" Src="../Shared/ThemeButtonMobile.ascx" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td>
                        <OEMConversion:Vw_ticket_detailsTableControl runat="server" id="Vw_ticket_detailsTableControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <OEMConversion:ThemeButtonMobile runat="server" id="MenuButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButtonMobile>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot; Ticket Details&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions"></td><td class="mobileHeaderRight"></td></tr></table>

                      </td></tr><tr><td width="100%">
                        <OEMConversion:InfinitePaginationMobile runat="server" id="Pagination"></OEMConversion:InfinitePaginationMobile>
                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFilterArea">
                      <asp:panel id="CollapsibleRegionMobile" style="display: none; overflow: hidden; height: 0px; width: 96%; padding-left: 2%; padding-right: 2%; margin: 0px;" cssClass="mobileBody" runat="server">
<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_ticket_idLabel" Text="Resource SCH Ticket">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<asp:DropDownList runat="server" id="resource_sch_ticket_idFilter" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td></tr><tr><td class="mobileFieldValueOnBottom"><OEMConversion:ThemeButtonMobile runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButtonMobile></td></tr><tr><td class="mobileFieldLabelOnTop"></td></tr><tr><td class="mobileFieldValueOnBottom"></td></tr></table>
</asp:panel>
                  </td></tr><tr><td class="mobileBody"><table id="Vw_ticket_detailsTableControlGrid" cellpadding="0" cellspacing="0" border="0" onkeydown="captureUpDownKey(this, event)" width="100%"><tr><th class="mobileTableCell" colspan="1" style="display:none"><!-- Note: Cell Is Hidden --></th><th class="mobileTableCell" scope="col" style="display:none"><!-- Note: Cell Is Hidden --></th><th class="mobileTableCell" scope="col" style="display:none"><!-- Note: Cell Is Hidden --></th></tr><asp:Repeater runat="server" id="Vw_ticket_detailsTableControlRepeater">		<ITEMTEMPLATE>
		<asp:Repeater runat="server" id="Vw_ticket_detailsTableControlRepeater1">				<ITEMTEMPLATE>		<OEMConversion:Vw_ticket_detailsTableControlRow runat="server" id="Vw_ticket_detailsTableControlRow">
<tr onclick="RedirectByViewButton(event)"><td class="mobileTableCell" style="display:none;"><!-- Note: Cell Is Hidden --><asp:ImageButton runat="server" id="ViewRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="mobileTableImageCell">
                  &nbsp;
                </td><td class="mobileTableCell"><asp:Label runat="server" id="resource_sch_ticket_id" cssclass="mobileTableCellTitle"></asp:Label> 
                            <br />
                          <asp:Literal runat="server" id="subject"></asp:Literal>    <br />
<asp:Literal runat="server" id="custno"></asp:Literal> 
<asp:Literal runat="server" id="technician_id"></asp:Literal> 
                            <br />
                          <asp:Literal runat="server" id="scheduled_date"></asp:Literal>    <br />
<asp:Literal runat="server" id="ROCategory"></asp:Literal> 
                            <br />
                          <asp:Literal runat="server" id="ROMake"></asp:Literal> 
                            <br />
                          <asp:Literal runat="server" id="ROModel"></asp:Literal> 
                            <br /></td></tr></OEMConversion:Vw_ticket_detailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</ITEMTEMPLATE>
</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Vw_ticket_detailsTableControl_PostbackTracker" runat="server" />
</OEMConversion:Vw_ticket_detailsTableControl>

            </td></tr></table>
      
    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                