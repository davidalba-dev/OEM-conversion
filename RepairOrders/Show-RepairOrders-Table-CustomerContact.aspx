<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-RepairOrders-Table-CustomerContact.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_RepairOrders_Table_CustomerContact" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_RepairOrders_Table_CustomerContact" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><OEMConversion:RepairOrder_CustomerContactTableControl runat="server" id="RepairOrder_CustomerContactTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="Active Repair Orders">	</asp:Literal>
                      </td><td class="dht" valign="middle"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right"></td><td class="prbbc" style="text-align:right"></td><td class="prbbc" style="text-align:right"><div id="Actions1Div" runat="server" class="popupWrapper">
<table><tr><td><asp:ImageButton runat="server" id="ExcelButton" causesvalidation="false" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="WordButton" causesvalidation="false" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="PDFButton" causesvalidation="false" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td></tr></table>
                
                </div> 
</td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="Actions1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Actions1Div&#39;,&#39;Actions1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="Filters1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters1Div&#39;,&#39;Filters1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton3"))%>

                <asp:TextBox runat="server" id="RepairOrder_CustomerContactSearchText1" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="RepairOrder_CustomerContactSearchText1AutoCompleteExtender" runat="server" TargetControlID="RepairOrder_CustomerContactSearchText1" ServiceMethod="GetAutoCompletionList_RepairOrder_CustomerContactSearchText1" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SearchButton3"))%>
</td><td>
                <asp:ImageButton runat="server" id="SearchButton3" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td class="prspaceEnd">&nbsp;</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="Filters1Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"><OEMConversion:ThemeButton runat="server" id="FilterButton1" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td class="popupTableCellValue"><asp:ImageButton runat="server" id="ResetButton" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="RODateLabel" Text="EvaluateFormula(&quot;= \&quot;Date\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:TextBox runat="server" id="RODateFromFilter" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;m/d/yyyy&#39;)" timestring="&quot;00:00:00&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="RODateFromFilterCalenderExtender" TargetControlID="RODateFromFilter" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> <span class="rft"><%# GetResourceValue("Txt:To", "OEMConversion") %></span> <asp:TextBox runat="server" id="RODateToFilter" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;m/d/yyyy&#39;)" timestring="&quot;23:59:59&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="RODateToFilterCalenderExtender" TargetControlID="RODateToFilter" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> </td><td class="popupTableCellLabel"><asp:Literal runat="server" id="RODeptIDNewLabel" Text="Dept.">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="RODeptIDNewFromFilter" cssclass="Filter_Input">	</asp:DropDownList> <span class="rft"></span> </td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ROStatusLabel" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="ROStatusFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellLabel"><asp:Literal runat="server" id="category_idLabel" Text="Category">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="category_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="RONoLabel" Text="RO Number">	</asp:Literal></td><td class="popupTableCellValue"><asp:TextBox runat="server" id="RONoFromFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox> <span class="rft"></span> </td><td class="popupTableCellLabel"><asp:Literal runat="server" id="ROMakeLabel" Text="EvaluateFormula(&quot;= \&quot;Make\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="ROMakeFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ROFaultCodesLabel" Text="RO Fault Codes">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="ROFaultCodesFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellLabel"><asp:Literal runat="server" id="ROModelLabel" Text="EvaluateFormula(&quot;= \&quot;Model\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="ROModelFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ROSerialNoLabel" Text="EvaluateFormula(&quot;= \&quot;Serial Number\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="ROSerialNoFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="RepairOrder_CustomerContactTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="2"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc"><asp:LinkButton runat="server" id="RONoLabel1" tooltip="Sort by RONo" Text="RO Number" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Label runat="server" id="ROStatusLabel2" Text="RO Status">	</asp:Label></th><th class="thc"><asp:LinkButton runat="server" id="RODateLabel2" tooltip="Sort by RODate" Text="RO Date" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROReference1Label1" tooltip="Sort by ROReference1" Text="EvaluateFormula(&quot;= \&quot;PO#\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROReference2Label2" tooltip="Sort by ROReference2" Text="RO Department New" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROReference4Label1" tooltip="Sort by ROReference4" Text="EvaluateFormula(&quot;= \&quot;Approved By\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROMakeLabel2" tooltip="Sort by ROMake" Text="EvaluateFormula(&quot;= \&quot;Make\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROModelLabel2" tooltip="Sort by ROModel" Text="EvaluateFormula(&quot;= \&quot;Model\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROSerialNoLabel2" tooltip="Sort by ROSerialNo" Text="EvaluateFormula(&quot;= \&quot;Serial Number\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROCategoryLabel1" tooltip="Sort by ROCategory" Text="EvaluateFormula(&quot;= \&quot;Category\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROFaultCodesLabel1" tooltip="Sort by ROFaultCodes" Text="RO Fault Codes" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Label runat="server" id="ROGrandTotalLabel" Text="RO Subtotal">	</asp:Label></th></tr><asp:Repeater runat="server" id="RepairOrder_CustomerContactTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:RepairOrder_CustomerContactTableControlRow runat="server" id="RepairOrder_CustomerContactTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" colspan="2">                                 
<asp:ImageButton runat="server" id="ViewRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" requiredroles="&lt;PRoles>4;5&lt;/PRoles>" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellValue"><asp:Literal runat="server" id="RONo1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROStatus1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODate1"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODeptIDNew"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference5"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROMake1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROModel1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROSerialNo1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="category_id"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROFaultCodes"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ro_subtotal"></asp:Literal></span>
</td></tr><tr><td class="tableRowDivider" colspan="6"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OEMConversion:RepairOrder_CustomerContactTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination1"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RepairOrder_CustomerContactTableControl_PostbackTracker" runat="server" />
</OEMConversion:RepairOrder_CustomerContactTableControl>
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
                