<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_ServiceCodes" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-ServiceCodes.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_ServiceCodes" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                        <OEMConversion:ServiceCodesRecordControl runat="server" id="ServiceCodesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(&quot;Service Codes&quot;) %>">	</asp:Literal>
                      </td><td class="dhir">
                  <asp:ImageButton runat="server" id="DialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" onmouseout="this.src=&#39;../Images/iconEdit.gif&#39;" onmouseover="this.src=&#39;../Images/iconEditOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="ServiceCodesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServCategoryLabel" Text="EvaluateFormula(&quot;= \&quot;Service Category\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServCategory"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ServDateRecordAddedLabel" Text="EvaluateFormula(&quot;= \&quot;Date Record Added\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ServDateRecordAdded"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServDefaultLabel" Text="EvaluateFormula(&quot;= \&quot;Service Default\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServDefault"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ServTypeLabel" Text="EvaluateFormula(&quot;= \&quot;Service Type\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ServType"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServCodeLabel" Text="EvaluateFormula(&quot;= \&quot;Service Code\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServCode"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ServChargeLabel" Text="EvaluateFormula(&quot;= \&quot;Service Charge\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ServCharge"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServCodeGroupLabel" Text="EvaluateFormula(&quot;= \&quot;Service Code Group\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServCodeGroup"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ServDescLabel" Text="EvaluateFormula(&quot;= \&quot;Service Description\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServDesc"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServQBItemCodeLabel" Text="Serv QB Item Code">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServQBItemCode"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ServReference1Label" Text="Serv Reference 1">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServReference1"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServReference2Label" Text="Serv Reference 2">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServReference2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ServReference3Label" Text="Serv Reference 3">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServReference3"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServReference4Label" Text="Serv Reference 4">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServReference4"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ServRepairStepLabel" Text="Serv Repair Step">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ServRepairStep"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServDropdownLabel" Text="Serv Dropdown">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="ServDropdown"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ServNotesLabel" Text="EvaluateFormula(&quot;= \&quot;Service Notes\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="ServNotes"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ServiceCodesRecordControl_PostbackTracker" runat="server" />
</OEMConversion:ServiceCodesRecordControl>

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
                