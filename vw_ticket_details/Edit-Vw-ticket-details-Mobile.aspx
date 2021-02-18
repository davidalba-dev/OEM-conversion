<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Edit-Vw-ticket-details-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Edit_Vw_ticket_details_Mobile" %>
<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Edit_Vw_ticket_details_Mobile" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:Vw_ticket_detailsRecordControl runat="server" id="Vw_ticket_detailsRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot;&quot;,&quot;  Ticket Details&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions"></td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="SaveButton" causesvalidation="True" commandname="UpdateData" imageurl="../Images/MobileButtonSave.png" text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="Vw_ticket_detailsRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_ticket_idLabel" Text="Resource SCH Ticket">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="resource_sch_ticket_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>&nbsp;
<asp:RequiredFieldValidator runat="server" id="resource_sch_ticket_idRequiredFieldValidator" ControlToValidate="resource_sch_ticket_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Resource SCH Ticket&quot;) %>" enabled="True" initialvalue="--PLEASE_SELECT--" text="*"></asp:RequiredFieldValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="subjectLabel" Text="Subject">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><asp:TextBox runat="server" id="subject" MaxLength="255" columns="20" cssclass="mobileFieldInput" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="subjectTextBoxMaxLengthValidator" ControlToValidate="subject" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Subject&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Vw_ticket_detailsRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Vw_ticket_detailsRecordControl>

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
                