<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_InventorySerial_Mobile" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-InventorySerial-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Show_InventorySerial_Mobile" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:InventorySerialRecordControl runat="server" id="InventorySerialRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(&quot; Inventory Serial&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions">
                            <asp:ImageButton runat="server" id="DeleteButton" causesvalidation="True" commandname="DeleteRecord" imageurl="../Images/MobileButtonDelete.png" text="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="EditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonEdit.png" text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="InventorySerialRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="SerFormTypeLabel" Text="Serial Form Type">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="SerFormType"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="SerDetailNoLabel" Text="Serial Detail Number">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="SerDetailNo"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="SerFormNoLabel" Text="Serial Form Number">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="SerFormNo"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="SerLocationLabel" Text="Serial Location">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="SerLocation"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="SerPartNoLabel" Text="Serial Part Number">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="SerPartNo"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="SerSerialNoLabel" Text="Serial Serial Number">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><asp:Literal runat="server" id="SerSerialNo"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="InventorySerialRecordControl_PostbackTracker" runat="server" />
</OEMConversion:InventorySerialRecordControl>

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
                