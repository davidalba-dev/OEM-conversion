<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-RepairOrders-History-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_RepairOrders_History_Table" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_RepairOrders_History_Table" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <OEMConversion:RepairOrdersTableControl runat="server" id="RepairOrdersTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="Device Repair History">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="RepairOrdersTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="2"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc"><asp:LinkButton runat="server" id="RONoLabel" tooltip="Sort by RONo" Text="Repair Order #" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROCustNameLabel" tooltip="Sort by ROCustName" Text="EvaluateFormula(&quot;= \&quot;Facility Name\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton> 
</th><th class="thc"><asp:LinkButton runat="server" id="ROReference2Label" tooltip="Sort by ROReference2" Text="EvaluateFormula(&quot;= \&quot;Dept.\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROMakeLabel" tooltip="Sort by ROMake" Text="EvaluateFormula(&quot;= \&quot;Make\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROModelLabel" tooltip="Sort by ROModel" Text="EvaluateFormula(&quot;= \&quot;Model\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROSerialNoLabel" tooltip="Sort by ROSerialNo" Text="Serial #" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROStatusLabel" tooltip="Sort by ROStatus" Text="Status" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="RODateLabel1" tooltip="Sort by RODate" Text="EvaluateFormula(&quot;= \&quot;Date\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="RODateEstimateApprovedLabel" tooltip="Sort by RODateEstimateApproved" Text="EvaluateFormula(&quot;= \&quot;Date Est. Approved\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Literal runat="server" id="RODateReturnedLabel" Text="EvaluateFormula(&quot;= \&quot;Date Returned\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="ROReference4Label" tooltip="Sort by ROReference4" Text="EvaluateFormula(&quot;= \&quot;Approved By\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROReference1Label" tooltip="Sort by ROReference1" Text="EvaluateFormula(&quot;= \&quot;PO#\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROCategoryLabel" tooltip="Sort by ROCategory" Text="EvaluateFormula(&quot;= \&quot;Category\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROGrandTotalLabel" tooltip="Sort by ROGrandTotal" Text="EvaluateFormula(&quot;= \&quot;Total\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROTechnicianLabel" tooltip="Sort by ROTechnician" Text="Tech" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROFaultCodesLabel1" tooltip="Sort by ROFaultCodes" Text="EvaluateFormula(&quot;= \&quot;Fault Code\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="RepairOrdersTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:RepairOrdersTableControlRow runat="server" id="RepairOrdersTableControlRow">
<tr class="tableCellValueGrid"><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" colspan="2"><asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" requiredroles="&lt;PRoles>1;3&lt;/PRoles>" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
<asp:ImageButton runat="server" id="ViewRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" requiredroles="&lt;PRoles>2&lt;/PRoles>" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellValueGrid"><asp:Literal runat="server" id="RONo"></asp:Literal></td><td class="tableCellValueNW"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROCustNo"></asp:Literal></span>
 
<asp:Literal runat="server" id="customer_name"></asp:Literal></td><td class="tableCellValueGrid"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODeptIDNew"></asp:Literal></span>
</td><td class="tableCellValueNW"><asp:Literal runat="server" id="ROMake"></asp:Literal> 
</td><td class="tableCellValueNW"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RONo1"></asp:Literal></span>
 
</td><td class="tableCellValueGrid"><asp:Literal runat="server" id="ROSerialNo"></asp:Literal></td><td class="tableCellValueGrid"><asp:Literal runat="server" id="ROStatus"></asp:Literal></td><td class="tableCellValueGrid"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODate"></asp:Literal></span>
</td><td class="tableCellValueGrid"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimateApproved"></asp:Literal></span>
</td><td class="tableCellValueGrid"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateReturned"></asp:Literal></span>
</td><td class="tableCellValueGrid"><asp:Literal runat="server" id="ROReference4"></asp:Literal></td><td class="tableCellValueGrid"><asp:Literal runat="server" id="ROReference1"></asp:Literal> 
</td><td class="tableCellValueGrid"><asp:Literal runat="server" id="category_id"></asp:Literal></td><td class="tableCellValueGrid"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ro_subtotal"></asp:Literal></span>
</td><td class="tableCellValueGrid"><asp:Literal runat="server" id="ROTechnician"></asp:Literal></td><td class="tableCellValueGrid"><asp:Literal runat="server" id="ROFaultCodes"></asp:Literal></td></tr></OEMConversion:RepairOrdersTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RepairOrdersTableControl_PostbackTracker" runat="server" />
</OEMConversion:RepairOrdersTableControl>

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
                