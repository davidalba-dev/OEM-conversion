<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Add_Resource_sch_time_Mobile" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Add-Resource-sch-time-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Add_Resource_sch_time_Mobile" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonMobile" Src="../Shared/ThemeButtonMobile.ascx" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:Resource_sch_timeRecordControl runat="server" id="Resource_sch_timeRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft"><OEMConversion:ThemeButtonMobile runat="server" id="MenuButton" button-causesvalidation="false" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Menu&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonMobile></td><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;&lt;span class=&#39;mobileFontAdjust90&#39;>&quot;, GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot;   Time&quot;, &quot;&lt;/span>&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="SaveButton" causesvalidation="True" commandname="UpdateData" imageurl="../Images/MobileButtonSave.png" text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="Resource_sch_timeRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_time_dateLabel" Text="EvaluateFormula(&quot;= \&quot;Date\&quot;&quot;, true)">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="resource_sch_time_date" Columns="20" MaxLength="30" cssclass="mobileFieldInput" dataformat="d"></asp:TextBox></td>
<td style="padding-right: 5px">
<asp:ImageButton runat="server" ID="resource_sch_time_datePopupButton" ImageUrl="../Images/MobileCalendar.png" CausesValidation="false">
</asp:ImageButton><Selectors:CalendarExtendarClass runat="server" ID="resource_sch_time_dateCalendarExtender" TargetControlID="resource_sch_time_date" CssClass="MyCalendarMobile" OnClientShown="mobileCalendarShown" PopupPosition="BottomLeft" PopupButtonID="resource_sch_time_datePopupButton" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="resource_sch_time_dateTextBoxMaxLengthValidator" ControlToValidate="resource_sch_time_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Date\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_ticket_idLabel" Text="EvaluateFormula(&quot;= \&quot;Ticket #\&quot;&quot;, true)">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="resource_sch_ticket_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_time_hoursLabel" Text="EvaluateFormula(&quot;= \&quot;Hours\&quot;&quot;, true)">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="resource_sch_time_hours" Columns="14" MaxLength="14" cssclass="mobileFieldInput"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="resource_sch_time_hoursTextBoxMaxLengthValidator" ControlToValidate="resource_sch_time_hours" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Hours\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_time_minLabel" Text="Minutes">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="time_interval_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="resource_sch_technician_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Resource_sch_timeRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Resource_sch_timeRecordControl>

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
                