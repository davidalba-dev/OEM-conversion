<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_LastPrevious_Resource_sch_time_Table_Mobile" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-LastPrevious-Resource-sch-time-Table-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Show_LastPrevious_Resource_sch_time_Table_Mobile" %>
<%@ Register Tagprefix="OEMConversion" TagName="InfinitePaginationMobile" Src="../Shared/InfinitePaginationMobile.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonMobile" Src="../Shared/ThemeButtonMobile.ascx" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><OEMConversion:CalendarTableControl runat="server" id="CalendarTableControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:CalendarRecordControl runat="server" id="CalendarRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td></td></tr><tr><td><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="CalendarRecordControlPanel" runat="server"><table><tr><td class="fls"><OEMConversion:ThemeButtonMobile runat="server" id="MenuButton" button-causesvalidation="false" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonMobile></td><td class="fls"><asp:ImageButton runat="server" id="SaveButton1" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" causesvalidation="True" commandname="Redirect" imageurl="../Images/MobileButtonNext.rtl.png" text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="dfv" style="white-space:nowrap;"><asp:ImageButton runat="server" id="SaveButton2" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" causesvalidation="True" commandname="Redirect" imageurl="../Images/MobileButtonNext.png" text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td></tr></table></asp:panel>
</td></tr></table>
</td></tr></table>
	<asp:hiddenfield id="CalendarRecordControl_PostbackTracker" runat="server" />
</OEMConversion:CalendarRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td width="100%">
                        <OEMConversion:InfinitePaginationMobile runat="server" id="Pagination1"></OEMConversion:InfinitePaginationMobile>
                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion1" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFilterArea">
                      <asp:panel id="CollapsibleRegionMobile1" style="display: none; overflow: hidden; height: 0px; width: 96%; padding-left: 2%; padding-right: 2%; margin: 0px;" cssClass="mobileBody" runat="server">
</asp:panel>
                  </td></tr><tr><td class="mobileBody"><table id="CalendarTableControlGrid" cellpadding="0" cellspacing="0" border="0" onkeydown="captureUpDownKey(this, event)" width="100%"><tr><th class="mobileTableCell" colspan="1"></th><th class="mobileTableCell" scope="col"></th><th class="mobileTableCell" scope="col"></th></tr><asp:Repeater runat="server" id="CalendarTableControlRepeater">		<ITEMTEMPLATE>
		<asp:Repeater runat="server" id="CalendarTableControlRepeater1">				<ITEMTEMPLATE>		<OEMConversion:CalendarTableControlRow runat="server" id="CalendarTableControlRow">
<tr onclick="RedirectByViewButton(event)"><td class="mobileTableCell" style="display:none;"><!-- Note: Cell Is Hidden --><asp:ImageButton runat="server" id="ViewRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="mobileTableImageCell">
                  &nbsp;
                </td><td class="mobileTableCell"><asp:Label runat="server" id="calendar_date" cssclass="mobileTableCellTitle"></asp:Label> 
                            <br />
                          </td></tr><tr onclick="RedirectByViewButton(event)"><td class="mobileTableCell" style="display:none;"></td><td class="mobileTableImageCell"></td><td class="mobileTableCell"><OEMConversion:Resource_sch_timeTableControl1 runat="server" id="Resource_sch_timeTableControl1">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft"></td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title2" Text="&lt;%#String.Concat(&quot; Time Summary&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions"></td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="NewButton1" causesvalidation="false" commandname="Redirect" imageurl="../Images/MobileButtonNew.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion2" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFilterArea">
                      <asp:panel id="CollapsibleRegionMobile2" style="display: none; overflow: hidden; height: 0px; width: 96%; padding-left: 2%; padding-right: 2%; margin: 0px;" cssClass="mobileBody" runat="server">
</asp:panel>
                  </td></tr><tr><td class="mobileBody"><table id="Resource_sch_timeTableControl1Grid" cellpadding="0" cellspacing="0" border="0" onkeydown="captureUpDownKey(this, event)" width="100%"><tr><th class="mobileTableCell" colspan="1" style="display:none"><!-- Note: Cell Is Hidden --></th><th class="mobileTableCell" scope="col" style="display:none"><!-- Note: Cell Is Hidden --></th><th class="mobileTableCell" scope="col" style="display:none"><!-- Note: Cell Is Hidden --></th></tr><asp:Repeater runat="server" id="Resource_sch_timeTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:Resource_sch_timeTableControl1Row runat="server" id="Resource_sch_timeTableControl1Row">
<tr onclick="RedirectByViewButton(event)"><td class="mobileTableCell" style="display:none;"><!-- Note: Cell Is Hidden --><asp:ImageButton runat="server" id="ViewRowButton2" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="mobileTableImageCell">
                  &nbsp;
                </td><td class="mobileTableCell"><asp:Label runat="server" id="resource_sch_ticket_id" cssclass="mobileTableCellTitle"></asp:Label> 
                            <br />
                          <asp:Literal runat="server" id="timehours"></asp:Literal> 
                            <br />
                          </td></tr></OEMConversion:Resource_sch_timeTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Resource_sch_timeTableControl1_PostbackTracker" runat="server" />
</OEMConversion:Resource_sch_timeTableControl1>
</td></tr></OEMConversion:CalendarTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</ITEMTEMPLATE>
</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="CalendarTableControl_PostbackTracker" runat="server" />
</OEMConversion:CalendarTableControl>
</td></tr></table>
      
    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                