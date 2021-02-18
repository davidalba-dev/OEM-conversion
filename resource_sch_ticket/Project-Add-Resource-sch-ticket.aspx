<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Project-Add-Resource-sch-ticket.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Project_Add_Resource_sch_ticket" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Project_Add_Resource_sch_ticket" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:Resource_sch_ticketRecordControl runat="server" id="Resource_sch_ticketRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="Add Ticket">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Resource_sch_ticketRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="technician_idLabel" Text="EvaluateFormula(&quot;= \&quot;Resource\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="technician_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="resource_sch_priority_idLabel" Text="EvaluateFormula(&quot;= \&quot;Priority\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="resource_sch_priority_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="contractor_idLabel" Text="Contractor">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="contractor_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="resource_sch_status_idLabel" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="resource_sch_status_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="contractor_contact_idLabel" Text="Contractor Contact">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="contractor_contact_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="scheduled_dateLabel" Text="Scheduled Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="scheduled_date" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="scheduled_dateCalendarExtender" TargetControlID="scheduled_date" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<asp:RequiredFieldValidator runat="server" id="scheduled_dateRequiredFieldValidator" ControlToValidate="scheduled_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Scheduled Date&quot;) %>" enabled="True" text="* Scheduled Date is Required"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="scheduled_dateTextBoxMaxLengthValidator" ControlToValidate="scheduled_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Scheduled Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="project_role_idLabel" Text="Project Role">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="project_role_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="due_dateLabel" Text="Due Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="due_date" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="due_dateCalendarExtender" TargetControlID="due_date" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<asp:RequiredFieldValidator runat="server" id="due_dateRequiredFieldValidator" ControlToValidate="due_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Due Date&quot;) %>" enabled="True" text="* * Due Date is Required"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="due_dateTextBoxMaxLengthValidator" ControlToValidate="due_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Due Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="estimated_duration_hoursLabel" Text="EvaluateFormula(&quot;= \&quot;Est. Hours\&quot;&quot;, true)">	</asp:Literal><asp:Literal runat="server" id="estimated_duration_minutesLabel" Text="EvaluateFormula(&quot;= \&quot;Est. Minutes\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><table><tr><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="estimated_duration_hours" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="estimated_duration_hoursTextBoxMaxLengthValidator" ControlToValidate="estimated_duration_hours" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Est. Hours\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="time_interval_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td></tr></table>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="subjectLabel" Text="Subject">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="subject" MaxLength="255" columns="60" cssclass="field_input" rows="1" textmode="SingleLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="subjectTextBoxMaxLengthValidator" ControlToValidate="subject" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Subject&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ticket_detailsLabel" Text="Ticket Details">	</asp:Literal></td><td class="tableCellValue" rowspan="2" colspan="3"><asp:TextBox runat="server" id="ticket_details" MaxLength="3000" columns="90" cssclass="field_input" height="75px" rows="2" textmode="MultiLine" width="240px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ticket_detailsTextBoxMaxLengthValidator" ControlToValidate="ticket_details" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Ticket Details&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="created_by" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="created_datetime" visible="False"></asp:Literal></span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Resource_sch_ticketRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Resource_sch_ticketRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" postback="True"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="SaveAndNewButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;OEMConversion&quot;) %>" postback="True"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
</td></tr></table>
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
                