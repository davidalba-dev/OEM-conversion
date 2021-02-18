<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Resource_sch_ticket_Table" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Resource-sch-ticket-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_Resource_sch_ticket_Table" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <OEMConversion:Resource_sch_ticketTableControl runat="server" id="Resource_sch_ticketTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="Ticket Dashboard">	</asp:Literal>
                      </td><td class="dht" valign="middle"><OEMConversion:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="Projects" button-tooltip="Projects"></OEMConversion:ThemeButton></td><td class="dht" valign="middle"><OEMConversion:ThemeButton runat="server" id="Button1" button-causesvalidation="False" button-commandname="Redirect" button-text="Closed Tickets" button-tooltip="Closed Tickets"></OEMConversion:ThemeButton></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="custnoLabel1" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="custnoFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"><OEMConversion:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="resource_sch_project_idLabel1" Text="EvaluateFormula(&quot;= \&quot;Project\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="resource_sch_project_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="technician_idLabel1" Text="EvaluateFormula(&quot;= \&quot;Resource\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="technician_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="scheduled_dateLabel1" Text="Scheduled Date">	</asp:Literal></td><td class="popupTableCellValue"><asp:TextBox runat="server" id="scheduled_dateFromFilter" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;m/d/yyyy&#39;)" timestring="&quot;00:00:00&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="scheduled_dateFromFilterCalenderExtender" TargetControlID="scheduled_dateFromFilter" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> <span class="rft"><%# GetResourceValue("Txt:To", "OEMConversion") %></span> <asp:TextBox runat="server" id="scheduled_dateToFilter" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;m/d/yyyy&#39;)" timestring="&quot;23:59:59&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="scheduled_dateToFilterCalenderExtender" TargetControlID="scheduled_dateToFilter" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="resource_sch_status_idLabel1" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<asp:DropDownList runat="server" id="resource_sch_status_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="contractor_idLabel" Text="Contractor">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="contractor_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="contractor_contact_idLabel" Text="Contractor Contact">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="contractor_contact_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Resource_sch_ticketTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)" class="TFtable"><tr class="tch"><th class="thc" colspan="2"></th><th class="thc"></th><th class="thc"><asp:LinkButton runat="server" id="resource_sch_ticket_idLabel" tooltip="Sort by resource_sch_ticket_id" Text="Ticket #" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_idLabel" tooltip="Sort by project_id" Text="Project" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="custnoLabel" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Literal runat="server" id="subjectLabel" Text="Subject">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="technician_idLabel" Text="EvaluateFormula(&quot;= \&quot;Resource\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="resource_sch_status_idLabel" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="resource_sch_priority_idLabel" Text="EvaluateFormula(&quot;= \&quot;Priority\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="scheduled_dateLabel" tooltip="Sort by scheduled_date" Text="Scheduled Date" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="due_dateLabel" tooltip="Sort by due_date" Text="Due Date" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Literal runat="server" id="estimated_duration_hoursLabel" Text="EvaluateFormula(&quot;= \&quot;Est. Hours\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="ticket_actual_timeLabel" tooltip="Sort by ticket_actual_time" Text="EvaluateFormula(&quot;= \&quot;Actual Time\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ticket_costLabel" tooltip="Sort by ticket_cost" Text="Ticket Cost" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="Resource_sch_ticketTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Resource_sch_ticketTableControlRow runat="server" id="Resource_sch_ticketTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" colspan="2">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                                                   
                                </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="resource_sch_ticket_id"></asp:Literal></span>
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="project_id" CommandName="Redirect"></asp:LinkButton></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="custno"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="subject"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="technician_id" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>

<asp:LinkButton runat="server" id="contractor_id" CommandName="Redirect"></asp:LinkButton><br> 
<span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="contractor_contact_id" CommandName="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="resource_sch_status_id1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="resource_sch_priority_id"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="scheduled_date"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="due_date"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="esthours"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="ticket_actual_time"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ticket_cost"></asp:Literal></span>
</td></tr></OEMConversion:Resource_sch_ticketTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Resource_sch_ticketTableControl_PostbackTracker" runat="server" />
</OEMConversion:Resource_sch_ticketTableControl>

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
                