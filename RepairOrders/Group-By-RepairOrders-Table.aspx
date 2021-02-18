<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Group_By_RepairOrders_Table" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Group-By-RepairOrders-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Group_By_RepairOrders_Table" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>
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
                        <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(&quot;Repair Orders&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton"))%>

                <asp:TextBox runat="server" id="SearchText" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="SearchTextAutoCompleteExtender" runat="server" TargetControlID="SearchText" ServiceMethod="GetAutoCompletionList_SearchText" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SearchButton"))%>
</td><td>
                <asp:ImageButton runat="server" id="SearchButton" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ROCustNoLabel1" Text="EvaluateFormula(&quot;= \&quot;Facility\&quot;&quot;, true)">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<BaseClasses:QuickSelector runat="server" id="ROCustNoFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ROReference4Label1" Text="EvaluateFormula(&quot;= \&quot;Approved By\&quot;&quot;, true)">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<BaseClasses:QuickSelector runat="server" id="ROReference4Filter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"><OEMConversion:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="RepairOrdersTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3" style="display:none"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="RepairOrdersTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:RepairOrdersTableControlRow runat="server" id="RepairOrdersTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="34" colspan="3">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                                  
                                    <br /><br />
                                  </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROContactNameLabel" Text="RO Contact Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROContactName"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROAddress1Label" Text="RO Address 1">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAddress1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateRecordUpdatedLabel" Text="RO Date Record Updated">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateRecordUpdated"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROCustNameLabel" Text="EvaluateFormula(&quot;= \&quot;Facility Name\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROCustName"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROAddress2Label" Text="RO Address 2">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAddress2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateStatusUpdatedLabel" Text="RO Date Status Updated">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateStatusUpdated"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROHowApprovedLabel" Text="EvaluateFormula(&quot;= \&quot;How Approved\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="ROHowApproved" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROCityLabel" Text="RO City">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROCity"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateLabel" Text="EvaluateFormula(&quot;= \&quot;Date\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROConditionLabel" Text="EvaluateFormula(&quot;= \&quot;Condition\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="ROCondition" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROProvinceLabel" Text="RO Province">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROProvince"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimateApprovedLabel" Text="EvaluateFormula(&quot;= \&quot;Date Est. Approved\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimateApproved"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory4Label" Text="EvaluateFormula(&quot;= \&quot;Light Cable\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory4"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROPostalCodeLabel" Text="RO Postal Code">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROPostalCode"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimateCompletedLabel" Text="RO Date Estimate Completed">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimateCompleted"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROReference4Label" Text="EvaluateFormula(&quot;= \&quot;Approved By\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference4"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROCountryLabel" Text="RO Country">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROCountry"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimatedCompletionLabel" Text="RO Date Estimated Completion">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimatedCompletion"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROCustNoLabel" Text="EvaluateFormula(&quot;= \&quot;Facility\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="ROCustNo" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROAdvertisingLabel" Text="RO Advertising">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAdvertising"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimateRefusedLabel" Text="EvaluateFormula(&quot;= \&quot;Date Est. Refused\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimateRefused"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROBillingNoLabel" Text="RO Billing Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="ROBillingNo" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROBatchIDLabel" Text="RO Batch">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROBatchID"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimateSentLabel" Text="RO Date Estimate Sent">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimateSent"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROFaultCodesLabel" Text="EvaluateFormula(&quot;= \&quot;Fault Code\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROFaultCodes"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROBinLabel" Text="RO Binary">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROBin"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODatePaidLabel" Text="RO Date Paid">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODatePaid"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROCategoryLabel" Text="EvaluateFormula(&quot;= \&quot;Category\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROCategory"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROCustom1Label" Text="RO Custom 1">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROCustom1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODatePurchasedLabel" Text="RO Date Purchased">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODatePurchased"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROMakeLabel" Text="EvaluateFormula(&quot;= \&quot;Make\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROMake"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROCustom2Label" Text="RO Custom 2">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROCustom2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateReceivedFromVendorLabel" Text="EvaluateFormula(&quot;= \&quot;Date Rec. from Vendor\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateReceivedFromVendor"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROModelLabel" Text="EvaluateFormula(&quot;= \&quot;Model\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROModel"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODescLabel" Text="EvaluateFormula(&quot;= \&quot;Description\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="RODesc"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateRecordAddedLabel" Text="RO Date Record Added">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateRecordAdded"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RONoLabel" Text="EvaluateFormula(&quot;= \&quot;RO#\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RONo"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROPurchasedFromLabel" Text="RO Purchased From">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROPurchasedFrom"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateRepairCompletedLabel" Text="EvaluateFormula(&quot;= \&quot;Repair Order Complete\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateRepairCompleted"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROShipViaLabel" Text="EvaluateFormula(&quot;= \&quot;Shipping\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="ROShipVia" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROQBInvNoLabel" Text="ROQB Invoice Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROQBInvNo"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateRequestedForLabel" Text="EvaluateFormula(&quot;= \&quot;Date Requested For\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateRequestedFor"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROStatusLabel" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROStatus"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROQBTxnIDLabel" Text="ROQB Transaction">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROQBTxnID"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateReturnedLabel" Text="EvaluateFormula(&quot;= \&quot;Date Returned\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateReturned"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROEstimatedByLabel" Text="RO Estimated By">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROEstimatedBy"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROQBTxnIDPayLabel" Text="ROQB Transaction Pay">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROQBTxnIDPay"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODateSubcontractedLabel" Text="EvaluateFormula(&quot;= \&quot;Date Subcontracted\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateSubcontracted"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROReceivedByLabel" Text="EvaluateFormula(&quot;= \&quot;Received By\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROReceivedBy"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROReference1Label" Text="EvaluateFormula(&quot;= \&quot;PO#\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROExportedLabel" Text="RO Exported">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROExported"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROTechnicianLabel" Text="EvaluateFormula(&quot;= \&quot;Tech.\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROTechnician"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROReference2Label" Text="EvaluateFormula(&quot;= \&quot;Dept\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROInvDateLabel" Text="RO Invoice Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROInvDate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROSubcontractVendNoLabel" Text="RO Subcontract Vend Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="ROSubcontractVendNo" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROReference3Label" Text="EvaluateFormula(&quot;= \&quot;Case/Box\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference3"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LinkLabel" Text="Link">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Link"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROWarrantyPlanLabel" Text="EvaluateFormula(&quot;= \&quot;Warranty Plan\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROWarrantyPlan"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROSerialNoLabel" Text="EvaluateFormula(&quot;= \&quot;Serial Number\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROSerialNo"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROCustomExportedLabel" Text="RO Custom Exported">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROCustomExported"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROPhoneBusinessLabel" Text="RO Phone Business">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROPhoneBusiness"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROSubcontractReference1Label" Text="RO Subcontract Reference 1">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROSubcontractReference1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODiscountRateLabel" Text="RO Discount Rate">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODiscountRate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROPhoneHomeLabel" Text="RO Phone Home">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROPhoneHome"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROSubcontractReference2Label" Text="RO Subcontract Reference 2">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROSubcontractReference2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROEditLockLabel" Text="RO Edit Lock">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROEditLock"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROPhoneMobileLabel" Text="RO Phone Mobile">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROPhoneMobile"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROTaxExemptLabel" Text="RO Tax Exempt">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROTaxExempt"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROEstimateRequiredLabel" Text="RO Estimate Required">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROEstimateRequired"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROFaxLabel" Text="RO Fax">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROFax"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROTrackingLabel" Text="RO Tracking">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROTracking"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROHoursLabel" Text="RO Hours">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROHours"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROEmailLabel" Text="RO Email">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROEmail"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROTypeLabel" Text="RO Type">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROType"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROInvNoLabel" Text="RO Invoice Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROInvNo"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory0Label" Text="EvaluateFormula(&quot;= \&quot;Case\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory0"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROAmountPaidLabel" Text="RO Amount Paid">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROAmountPaid"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROLinkedRONoLabel" Text="RO Linked RO Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROLinkedRONo"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory1Label" Text="EvaluateFormula(&quot;= \&quot;Box\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="RODiscountLabel" Text="RO Discount">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODiscount"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROLocationBusLabel" Text="RO Location Bus">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROLocationBus"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory10Label" Text="RO Accessory 10">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory10"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROGrandTotalLabel" Text="EvaluateFormula(&quot;= \&quot;Grand Total\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROGrandTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROMarkupRateLabel" Text="RO Markup Rate">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROMarkupRate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory11Label" Text="RO Accessory 11">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory11"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROHandlingLabel" Text="RO Handling">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROHandling"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROPayMethodLabel" Text="RO Pay Method">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROPayMethod"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory12Label" Text="RO Accessory 12">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory12"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROHandlingCostLabel" Text="RO Handling Cost">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROHandlingCost"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROPayTermsLabel" Text="RO Pay Terms">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROPayTerms"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory13Label" Text="RO Accessory 13">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory13"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROLaborLabel" Text="RO Labor">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROLabor"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROPriorityLabel" Text="RO Priority">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROPriority"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory14Label" Text="RO Accessory 14">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory14"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROLaborCostLabel" Text="RO Labor Cost">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROLaborCost"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROTax1RateLabel" Text="RO Tax 1 Rate">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROTax1Rate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory15Label" Text="RO Accessory 15">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory15"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROPartsLabel" Text="RO Parts">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROParts"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROTax1RulesLabel" Text="RO Tax 1 Rules">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROTax1Rules"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory2Label" Text="EvaluateFormula(&quot;= \&quot;Water Cap\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory2"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr id="RepairOrdersTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="6"><BaseClasses:TabContainer runat="server" id="RepairOrdersTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="AttachmentsTabPanel" HeaderText="Attachments">	<ContentTemplate>
  <OEMConversion:AttachmentsTableControl runat="server" id="AttachmentsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="AttachmentsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="AttachmentsTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:AttachmentsTableControlRow runat="server" id="AttachmentsTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="AttTableLabel" Text="Att">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AttTable"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="AttPrintLabel" Text="Att Print">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AttPrint"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="AttTypeLabel" Text="Att Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AttType"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="AttFilenameLabel" Text="Att Filename">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="AttFilename"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="AttDataLabel" Text="Att Data">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="AttData"></asp:Literal> </td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></OEMConversion:AttachmentsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination1"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="AttachmentsTableControl_PostbackTracker" runat="server" />
</OEMConversion:AttachmentsTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
 <BaseClasses:TabPanel runat="server" id="LedgerInvoicesTabPanel" HeaderText="Ledger Invoices">	<ContentTemplate>
  <OEMConversion:LedgerInvoicesTableControl runat="server" id="LedgerInvoicesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="LedgerInvoicesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="LedgerInvoicesTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:LedgerInvoicesTableControlRow runat="server" id="LedgerInvoicesTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgFormTypeLabel" Text="EvaluateFormula(&quot;= \&quot;Form Type\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgFormType"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgExportIncludeLabel" Text="EvaluateFormula(&quot;= \&quot;Export Include\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgExportInclude"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgExportedLabel" Text="EvaluateFormula(&quot;= \&quot;Exported\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgExported"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgExportRecordChangedLabel" Text="LDG Export Record Changed">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgExportRecordChanged"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgBillingNoLabel" Text="EvaluateFormula(&quot;= \&quot;Billing Number\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgBillingNo"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgRecDateLabel" Text="EvaluateFormula(&quot;= \&quot;Rec Date\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgRecDate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgGrandTotalLabel" Text="EvaluateFormula(&quot;= \&quot;Grand Total\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgGrandTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgHandlingLabel" Text="EvaluateFormula(&quot;= \&quot;Handling\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgHandling"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgTrnDateLabel" Text="EvaluateFormula(&quot;= \&quot;Trn Date\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgTrnDate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgLaborLabel" Text="EvaluateFormula(&quot;= \&quot;Labor\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgLabor"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgPartsLabel" Text="EvaluateFormula(&quot;= \&quot;Parts\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgParts"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgShippingLabel" Text="EvaluateFormula(&quot;= \&quot;Shipping\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgShipping"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgTax1Label" Text="EvaluateFormula(&quot;= \&quot;Tax 1\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgTax1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgTax2Label" Text="LDG Tax 2">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgTax2"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgTax3Label" Text="LDG Tax 3">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgTax3"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgTravelLabel" Text="EvaluateFormula(&quot;= \&quot;Travel\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgTravel"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></OEMConversion:LedgerInvoicesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination2"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="LedgerInvoicesTableControl_PostbackTracker" runat="server" />
</OEMConversion:LedgerInvoicesTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
 <BaseClasses:TabPanel runat="server" id="LedgerPaymentsTabPanel" HeaderText="Ledger Payments">	<ContentTemplate>
  <OEMConversion:LedgerPaymentsTableControl runat="server" id="LedgerPaymentsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="LedgerPaymentsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="LedgerPaymentsTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:LedgerPaymentsTableControlRow runat="server" id="LedgerPaymentsTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgFormTypeLabel2" Text="LDG Form Type">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgFormType1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgQBTxnIDPayLabel" Text="LDG QB Transaction Pay">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgQBTxnIDPay"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgExportedLabel1" Text="LDG Exported">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgExported1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgExportIncludeLabel1" Text="LDG Export Include">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgExportInclude1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgReferenceLabel" Text="LDG Reference">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgReference"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgRecDateLabel1" Text="LDG Received Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgRecDate1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgExportRecordChangedLabel1" Text="LDG Export Record Changed">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgExportRecordChanged1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgQBInvoiceLinkedLabel" Text="LDG QB Invoice Linked">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LdgQBInvoiceLinked"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgTrnDateLabel1" Text="LDG TRN Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgTrnDate1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="LdgPaymentLabel" Text="LDG Payment">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgPayment"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgBillingNoLabel2" Text="LDG Billing Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgBillingNo1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="LdgPayMethodLabel" Text="LDG Pay Method">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LdgPayMethod"></asp:Literal></span>
 </td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></OEMConversion:LedgerPaymentsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination3"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="LedgerPaymentsTableControl_PostbackTracker" runat="server" />
</OEMConversion:LedgerPaymentsTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer></td></tr><tr><td class="tableRowDivider" colspan="9"></td></tr></OEMConversion:RepairOrdersTableControlRow>
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
                