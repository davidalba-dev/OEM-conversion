<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Add-Customer-note-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Add_Customer_note_Mobile" %>
<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Add_Customer_note_Mobile" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:Customer_noteRecordControl runat="server" id="Customer_noteRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot;  Customer Note&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions"></td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="SaveButton" causesvalidation="True" commandname="UpdateData" imageurl="../Images/MobileButtonSave.png" text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="Customer_noteRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="custnoLabel" Text="Custno">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="custno" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>&nbsp;
<asp:RequiredFieldValidator runat="server" id="custnoRequiredFieldValidator" ControlToValidate="custno" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Custno&quot;) %>" enabled="True" initialvalue="--PLEASE_SELECT--" text="*"></asp:RequiredFieldValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="customer_note_createdbyLabel" Text="Customer Note Createdby">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="customer_note_createdby" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>&nbsp;
<asp:RequiredFieldValidator runat="server" id="customer_note_createdbyRequiredFieldValidator" ControlToValidate="customer_note_createdby" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Note Createdby&quot;) %>" enabled="True" initialvalue="--PLEASE_SELECT--" text="*"></asp:RequiredFieldValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="customer_note_dateLabel" Text="Customer Note Date">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="customer_note_date" Columns="20" MaxLength="30" cssclass="mobileFieldInput"></asp:TextBox></td>
<td style="padding-right: 5px">
<asp:ImageButton runat="server" ID="customer_note_datePopupButton" ImageUrl="../Images/MobileCalendar.png" CausesValidation="false">
</asp:ImageButton><Selectors:CalendarExtendarClass runat="server" ID="customer_note_dateCalendarExtender" TargetControlID="customer_note_date" CssClass="MyCalendarMobile" OnClientShown="mobileCalendarShown" PopupPosition="BottomLeft" PopupButtonID="customer_note_datePopupButton" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="customer_note_dateTextBoxMaxLengthValidator" ControlToValidate="customer_note_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Note Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="customer_noteLabel" Text="Customer Note">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><asp:TextBox runat="server" id="customer_note" MaxLength="3000" columns="20" cssclass="mobileFieldInput" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="customer_noteTextBoxMaxLengthValidator" ControlToValidate="customer_note" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Note&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Customer_noteRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Customer_noteRecordControl>

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
                