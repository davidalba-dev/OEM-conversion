<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-VendorContacts-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Show_VendorContacts_Mobile" %>
<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_VendorContacts_Mobile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:VendorContactsRecordControl runat="server" id="VendorContactsRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(&quot; Vendor Contacts&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions">
                            <asp:ImageButton runat="server" id="DeleteButton" causesvalidation="True" commandname="DeleteRecord" imageurl="../Images/MobileButtonDelete.png" text="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="EditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonEdit.png" text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="VendorContactsRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="VendContactNameLabel" Text="Vend Contact Name">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="VendContactName"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="VendContactTitleLabel" Text="Vend Contact Title">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="VendContactTitle"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="VendContactPhoneBusinessLabel" Text="Vend Contact Phone Business">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="VendContactPhoneBusiness"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="VendContactPhoneMobileLabel" Text="Vend Contact Phone Mobile">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="VendContactPhoneMobile"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="VendContactFaxLabel" Text="Vend Contact Fax">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="VendContactFax"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="VendContactEmailLabel" Text="Vend Contact Email">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="VendContactEmail"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="SessionIDLabel" Text="Session">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="SessionID"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="VendContactTypeLabel" Text="Vend Contact Type">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="VendContactType"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="VendNoLabel" Text="Vend Number">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><asp:Literal runat="server" id="VendNo"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="VendorContactsRecordControl_PostbackTracker" runat="server" />
</OEMConversion:VendorContactsRecordControl>

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
                