<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Add-Pickup-request.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Add_Pickup_request" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Add_Pickup_request" %>

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

                        <OEMConversion:Pickup_requestRecordControl runat="server" id="Pickup_requestRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Pickup Request&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Pickup_requestRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_custnoLabel" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="pickup_custno" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="1"></asp:DropDownList></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_addressLabel" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="pickup_address" Columns="40" MaxLength="50" cssclass="field_input" tabindex="9"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_addressTextBoxMaxLengthValidator" ControlToValidate="pickup_address" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_customercontactLabel" Text="EvaluateFormula(&quot;= \&quot;Contact\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="pickup_customercontact" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="2"></asp:DropDownList></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_address2Label" Text="EvaluateFormula(&quot;= \&quot;Address 2\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="pickup_address2" Columns="40" MaxLength="50" cssclass="field_input" tabindex="10"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_address2TextBoxMaxLengthValidator" ControlToValidate="pickup_address2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Address 2\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_datetimeLabel" Text="EvaluateFormula(&quot;= \&quot;Pickup Date-Time\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="pickup_datetime" Columns="20" MaxLength="30" cssclass="field_input" tabindex="3"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="pickup_datetimeCalendarExtender" TargetControlID="pickup_datetime" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_datetimeTextBoxMaxLengthValidator" ControlToValidate="pickup_datetime" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Pickup Date-Time\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_cityLabel" Text="EvaluateFormula(&quot;= \&quot;City\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="pickup_city" Columns="40" MaxLength="50" cssclass="field_input" tabindex="11"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_cityTextBoxMaxLengthValidator" ControlToValidate="pickup_city" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;City\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_est_hoursLabel" Text="EvaluateFormula(&quot;= \&quot;Est. Hours\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><table><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="pickup_est_hours" Columns="14" MaxLength="14" cssclass="field_input" tabindex="4"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_est_hoursTextBoxMaxLengthValidator" ControlToValidate="pickup_est_hours" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Est. Hours\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_est_minutesLabel" Text="EvaluateFormula(&quot;= \&quot;Est. Minutes\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="pickup_est_minutes" Columns="14" MaxLength="14" cssclass="field_input" tabindex="5"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_est_minutesTextBoxMaxLengthValidator" ControlToValidate="pickup_est_minutes" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Est. Minutes\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr></table>
</td><td class="tableCellValue"><asp:Literal runat="server" id="provnameLabel" Text="EvaluateFormula(&quot;= \&quot;State\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="provname" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="12"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_technicianLabel" Text="EvaluateFormula(&quot;= \&quot;Pickup Resource\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="pickup_technician" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="6"></asp:DropDownList></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_zipcodeLabel" Text="EvaluateFormula(&quot;= \&quot;Zipcode\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="pickup_zipcode" Columns="11" MaxLength="11" cssclass="field_input" tabindex="13"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_zipcodeTextBoxMaxLengthValidator" ControlToValidate="pickup_zipcode" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Zipcode\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_request_type_idLabel" Text="EvaluateFormula(&quot;= \&quot;Transaction Type\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="pickup_request_type_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="7"></asp:DropDownList></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_phoneLabel" Text="EvaluateFormula(&quot;= \&quot;Phone\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="pickup_phone" Columns="14" MaxLength="14" cssclass="field_input" tabindex="14"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_phoneTextBoxMaxLengthValidator" ControlToValidate="pickup_phone" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Phone\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_status_idLabel" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="pickup_status_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="8"></asp:DropDownList></span>
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="pickup_status_id1"></asp:Literal></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="created_by" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="created_datetime" Columns="20" MaxLength="30" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="created_datetimeCalendarExtender" TargetControlID="created_datetime" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="created_datetimeTextBoxMaxLengthValidator" ControlToValidate="created_datetime" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Created Date And Time&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Pickup_requestRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Pickup_requestRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:Pickup_request_commentRecordControl runat="server" id="Pickup_request_commentRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Pickup Request Comment&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Pickup_request_commentRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_request_commentLabel" Text="Pickup Request Comment">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="pickup_request_comment" MaxLength="2000" columns="100" cssclass="field_input" height="150px" rows="2" textmode="SingleLine" width="340px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_request_commentTextBoxMaxLengthValidator" ControlToValidate="pickup_request_comment" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Pickup Request Comment&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_request_privateLabel" Text="EvaluateFormula(&quot;= \&quot;Private Comment\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:CheckBox runat="server" id="pickup_request_private"></asp:CheckBox></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="pickup_request_comment_createdby" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="pickup_request_comment_datetime" Columns="20" MaxLength="30" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="pickup_request_comment_datetimeCalendarExtender" TargetControlID="pickup_request_comment_datetime" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pickup_request_comment_datetimeTextBoxMaxLengthValidator" ControlToValidate="pickup_request_comment_datetime" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Pickup Request Comment Date A~Time&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Pickup_request_commentRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Pickup_request_commentRecordControl>
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
                