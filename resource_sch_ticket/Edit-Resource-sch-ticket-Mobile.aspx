<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Edit-Resource-sch-ticket-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Edit_Resource_sch_ticket_Mobile" %>
<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Edit_Resource_sch_ticket_Mobile" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:Resource_sch_ticketRecordControl runat="server" id="Resource_sch_ticketRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;&lt;span class=&#39;mobileFontAdjust90&#39;>&quot;, GetResourceValue(&quot;Title:Edit&quot;),&quot;&quot;,&quot;  Ticket&quot;, &quot;&lt;/span>&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions"></td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="SaveButton" causesvalidation="True" commandname="UpdateData" imageurl="../Images/MobileButtonSave.png" text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="Resource_sch_ticketRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="subjectLabel" Text="Subject">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="subject"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="ticket_detailsLabel" Text="Ticket Details">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><asp:TextBox runat="server" id="ticket_details" MaxLength="3000" columns="20" cssclass="mobileFieldInput" rows="4" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ticket_detailsTextBoxMaxLengthValidator" ControlToValidate="ticket_details" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Ticket Details&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="custnoLabel" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:LinkButton runat="server" id="custno" CommandName="Redirect" cssclass="mobileLink"></asp:LinkButton></td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="technician_idLabel" Text="EvaluateFormula(&quot;= \&quot;Resource\&quot;&quot;, true)">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="technician_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_status_idLabel" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="resource_sch_status_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="scheduled_dateLabel" Text="Scheduled Date">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="scheduled_date"></asp:Literal><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="scheduled_date1" Columns="20" MaxLength="30" cssclass="mobileFieldInput" requiredroles="&lt;PRoles>3&lt;/PRoles>"></asp:TextBox></td>
<td style="padding-right: 5px">
<asp:ImageButton runat="server" ID="scheduled_date1PopupButton" ImageUrl="../Images/MobileCalendar.png" CausesValidation="false">
</asp:ImageButton><Selectors:CalendarExtendarClass runat="server" ID="scheduled_date1CalendarExtender" TargetControlID="scheduled_date1" CssClass="MyCalendarMobile" OnClientShown="mobileCalendarShown" PopupPosition="BottomLeft" PopupButtonID="scheduled_date1PopupButton" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="scheduled_date1TextBoxMaxLengthValidator" ControlToValidate="scheduled_date1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Scheduled Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="due_dateLabel" Text="Due Date">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="due_date"></asp:Literal><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="due_date1" Columns="20" MaxLength="30" cssclass="mobileFieldInput" requiredroles="&lt;PRoles>3&lt;/PRoles>"></asp:TextBox></td>
<td style="padding-right: 5px">
<asp:ImageButton runat="server" ID="due_date1PopupButton" ImageUrl="../Images/MobileCalendar.png" CausesValidation="false">
</asp:ImageButton><Selectors:CalendarExtendarClass runat="server" ID="due_date1CalendarExtender" TargetControlID="due_date1" CssClass="MyCalendarMobile" OnClientShown="mobileCalendarShown" PopupPosition="BottomLeft" PopupButtonID="due_date1PopupButton" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="due_date1TextBoxMaxLengthValidator" ControlToValidate="due_date1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Due Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="ticket_actual_timeLabel" Text="EvaluateFormula(&quot;= \&quot;Actual Time\&quot;&quot;, true)">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="ticket_actual_time"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Resource_sch_ticketRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Resource_sch_ticketRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>
      
    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                