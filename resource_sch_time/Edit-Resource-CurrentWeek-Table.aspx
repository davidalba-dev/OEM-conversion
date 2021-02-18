<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Edit-Resource-CurrentWeek-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Edit_Resource_CurrentWeek_Table" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Edit_Resource_CurrentWeek_Table" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style="position:absolute; padding:30px;" class="updatingContainer">
					<img src="../Images/updating.gif" alt="Updating" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td></td></tr><tr><td><OEMConversion:CalendarTableControl runat="server" id="CalendarTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(&quot;Current Timesheet&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle">&nbsp;</td><td class="dht" valign="middle"><OEMConversion:ThemeButton runat="server" id="Button3" button-causesvalidation="False" button-commandname="Redirect" button-text="Add Time" button-tooltip="Add Time" redirectstyle="Popup"></OEMConversion:ThemeButton></td><td><OEMConversion:CalendarTableControl1 runat="server" id="CalendarTableControl1">	<table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td></tr><tr><td><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <table id="CalendarTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><asp:Repeater runat="server" id="CalendarTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:CalendarTableControl1Row runat="server" id="CalendarTableControl1Row">
<tr><td><OEMConversion:ThemeButton runat="server" id="Button1" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;&lt; Previous Week" button-tooltip="Previous Week"></OEMConversion:ThemeButton> 
</td><td><OEMConversion:ThemeButton runat="server" id="Button2" button-causesvalidation="False" button-commandname="Redirect" button-text="Next Week >>" button-tooltip="Next Week"></OEMConversion:ThemeButton> 
</td></tr></OEMConversion:CalendarTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td></tr><tr><td><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="CalendarTableControl1_PostbackTracker" runat="server" />
</OEMConversion:CalendarTableControl1>
</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="CalendarTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="CalendarTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:CalendarTableControlRow runat="server" id="CalendarTableControlRow">
<tr><td class="tableCellValue"><span style="color:#DBB739"><b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="calendar_date"></asp:Literal></span>
</b></span></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="2"><OEMConversion:Resource_sch_timeTableControl2 runat="server" id="Resource_sch_timeTableControl2">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title3" Text="&lt;%#String.Concat(&quot;Time Detail&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          </div>
                        </td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                     
<table id="Resource_sch_timeTableControl2Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc" width="400"><asp:LinkButton runat="server" id="resource_sch_ticket_idLabel1" tooltip="Sort by resource_sch_ticket_id" CausesValidation="False">	</asp:LinkButton></th><th class="thc" width="100"><asp:LinkButton runat="server" id="resource_sch_time_hoursLabel1" tooltip="Sort by resource_sch_time_hours" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th></tr><asp:Repeater runat="server" id="Resource_sch_timeTableControl2Repeater">		<ITEMTEMPLATE>		<OEMConversion:Resource_sch_timeTableControl2Row runat="server" id="Resource_sch_timeTableControl2Row">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                </td><td class="tableCellValue" width="400"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="resource_sch_ticket_id"></asp:Literal></span>
&nbsp;</td><td class="tableCellValue" width="100"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="timehours"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="4"></td></tr></OEMConversion:Resource_sch_timeTableControl2Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td>
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Resource_sch_timeTableControl2_PostbackTracker" runat="server" />
</OEMConversion:Resource_sch_timeTableControl2>
</td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></OEMConversion:CalendarTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="CalendarTableControl_PostbackTracker" runat="server" />
</OEMConversion:CalendarTableControl>
</td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                