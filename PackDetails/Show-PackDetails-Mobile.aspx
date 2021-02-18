<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_PackDetails_Mobile" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-PackDetails-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Show_PackDetails_Mobile" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:PackDetailsRecordControl runat="server" id="PackDetailsRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(&quot; Pack Details&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions">
                            <asp:ImageButton runat="server" id="DeleteButton" causesvalidation="True" commandname="DeleteRecord" imageurl="../Images/MobileButtonDelete.png" text="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="EditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonEdit.png" text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="PackDetailsRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="PackItemDescLabel" Text="Pack Item Description">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="PackItemDesc"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="PackSellPriceLabel" Text="Pack Sell Price">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="PackSellPrice"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="PackKeyLabel" Text="Pack Key">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="PackKey"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="PackLineTypeLabel" Text="Pack Line Type">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="PackLineType"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="PackQuantityLabel" Text="Pack Quantity">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="PackQuantity"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="SessionIDLabel" Text="Session">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="SessionID"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="PackPartNoLabel" Text="Pack Part Number">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><asp:Literal runat="server" id="PackPartNo"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="PackDetailsRecordControl_PostbackTracker" runat="server" />
</OEMConversion:PackDetailsRecordControl>

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
                