<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Equipment-pickup-request.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_Equipment_pickup_request" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Equipment_pickup_request" %>

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

                        <OEMConversion:Equipment_pickup_requestRecordControl runat="server" id="Equipment_pickup_requestRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Equipment Pickup Request&quot;) %>">	</asp:Literal>
                      </td><td class="dhir">
                  <asp:ImageButton runat="server" id="DialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" onmouseout="this.src=&#39;../Images/iconEdit.gif&#39;" onmouseover="this.src=&#39;../Images/iconEditOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Equipment_pickup_requestRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="custnoLabel" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="custno" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_address1Label" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_address1"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="custcontactkeyLabel" Text="EvaluateFormula(&quot;= \&quot;Customer Contact\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="custcontactkey" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_address2Label" Text="EvaluateFormula(&quot;= \&quot;Address 2\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_address2"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="inventory_idLabel" Text="Inventory">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="inventory_id" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_cityLabel" Text="EvaluateFormula(&quot;= \&quot;City\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_city"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="technician_idLabel" Text="Technician">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="technician_id" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_stateLabel" Text="EvaluateFormula(&quot;= \&quot;State\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:LinkButton runat="server" id="pickup_state" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="poc_phoneLabel" Text="POC Phone">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="poc_phone"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_zipLabel" Text="EvaluateFormula(&quot;= \&quot;ZIP\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_zip"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="poc_phone_extLabel" Text="POC Phone Extension">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="poc_phone_ext"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="pickkup_dateLabel" Text="Pickkup Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="pickkup_date"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="processedLabel" Text="Processed">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="processed"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_timeLabel" Text="Pickup Time">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="pickup_time"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="pickup_instructionsLabel" Text="Pickup Instructions">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="pickup_instructions"></asp:Literal> </td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Equipment_pickup_requestRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Equipment_pickup_requestRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="EditButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                