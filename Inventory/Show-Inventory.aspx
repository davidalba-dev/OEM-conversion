<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Inventory.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_Inventory" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Inventory" %>

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

                        <OEMConversion:InventoryRecordControl runat="server" id="InventoryRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(&quot;Inventory&quot;) %>">	</asp:Literal>
                      </td><td class="dhir">
                  <asp:ImageButton runat="server" id="DialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" onmouseout="this.src=&#39;../Images/iconEdit.gif&#39;" onmouseover="this.src=&#39;../Images/iconEditOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="InventoryRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvBinLabel" Text="Invoice Binary">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvBin"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvDateRecordUpdatedLabel" Text="Invoice Date Record Updated">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvDateRecordUpdated"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvExportIncludeLabel" Text="Invoice Export Include">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvExportInclude"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvDateRecordAddedLabel" Text="Invoice Date Record Added">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvDateRecordAdded"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvExportRecordChangedLabel" Text="Invoice Export Record Changed">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvExportRecordChanged"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvLocationLabel" Text="EvaluateFormula(&quot;= \&quot;Location\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvLocation"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvNonStockItemLabel" Text="Invoice NON Stock Item">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvNonStockItem"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupRate0Label" Text="Invoice Markup Rate 0">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupRate0"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvShareLabel" Text="Invoice Share">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvShare"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupRate1Label" Text="Invoice Markup Rate 1">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupRate1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LastExtractionLabel" Text="Last Extraction">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="LastExtraction"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupRate2Label" Text="Invoice Markup Rate 2">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupRate2"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvCategoryLabel" Text="EvaluateFormula(&quot;= \&quot;Category\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvCategory"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupRate3Label" Text="Invoice Markup Rate 3">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupRate3"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvCustom1Label" Text="Invoice Custom 1">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvCustom1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupRate4Label" Text="Invoice Markup Rate 4">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupRate4"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvCustom2Label" Text="Invoice Custom 2">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvCustom2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupType0Label" Text="Invoice Markup Type 0">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupType0"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvItemDescLabel" Text="EvaluateFormula(&quot;= \&quot;Item Description\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvItemDesc"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupType1Label" Text="Invoice Markup Type 1">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupType1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvMakeLabel" Text="EvaluateFormula(&quot;= \&quot;Make\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvMake"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupType2Label" Text="Invoice Markup Type 2">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupType2"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvPartNoLabel" Text="EvaluateFormula(&quot;= \&quot;Part Number\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvPartNo"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupType3Label" Text="Invoice Markup Type 3">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupType3"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvReference1Label" Text="Invoice Reference 1">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvReference1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMarkupType4Label" Text="Invoice Markup Type 4">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMarkupType4"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvReference2Label" Text="Invoice Reference 2">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvReference2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMinOrderLabel" Text="Invoice Minimum Order">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMinOrder"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvReference3Label" Text="Invoice Reference 3">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvReference3"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvMinRequiredLabel" Text="Invoice Minimum Required">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvMinRequired"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvReference4Label" Text="Invoice Reference 4">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvReference4"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvPickQuantityLabel" Text="Invoice Pick Quantity">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvPickQuantity"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvReplacementLabel" Text="Invoice Replacement">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvReplacement"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvQuantityLabel" Text="Invoice Quantity">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvQuantity"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvVendorPartNo1Label" Text="Invoice Vendor Part No 1">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvVendorPartNo1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvStatusLabel" Text="Invoice Status">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvStatus"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvVendorPartNo2Label" Text="Invoice Vendor Part No 2">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvVendorPartNo2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvVendNo1Label" Text="Invoice Vend No 1">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvVendNo1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvVendorPartNo3Label" Text="Invoice Vendor Part No 3">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvVendorPartNo3"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvVendNo2Label" Text="Invoice Vend No 2">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvVendNo2"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvAvgBuyPriceLabel" Text="EvaluateFormula(&quot;= \&quot;Avg Buy Price\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvAvgBuyPrice"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvVendNo3Label" Text="Invoice Vend No 3">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvVendNo3"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvLastBuyPriceLabel" Text="Invoice Last Buy Price">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvLastBuyPrice"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvPrevBuyPriceLabel" Text="Invoice Previous Buy Price">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvPrevBuyPrice"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvSellPrice0Label" Text="EvaluateFormula(&quot;= \&quot;Sell Price\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvSellPrice0"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvSellPrice1Label" Text="Invoice Sell Price 1">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvSellPrice1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvSellPrice2Label" Text="Invoice Sell Price 2">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvSellPrice2"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvSellPrice3Label" Text="Invoice Sell Price 3">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvSellPrice3"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvSellPrice4Label" Text="Invoice Sell Price 4">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvSellPrice4"></asp:Literal></span>
 </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvPicturePathLabel" Text="Invoice Picture Path">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="InvPicturePath"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvModelsLabel" Text="Invoice Models">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="InvModels"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvNotesLabel" Text="EvaluateFormula(&quot;= \&quot;Notes\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="InvNotes"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="InventoryRecordControl_PostbackTracker" runat="server" />
</OEMConversion:InventoryRecordControl>

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
                