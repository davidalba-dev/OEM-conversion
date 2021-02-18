<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="History-Show-RepairOrders-Table-Backup.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.History_Show_RepairOrders_Table_Backup" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.History_Show_RepairOrders_Table_Backup" %>
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
                        <asp:Literal runat="server" id="Title" Text="Repair Order History">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OEMConversion&quot;) %>">		
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
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" visible="False"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" visible="False"></OEMConversion:ThemeButtonWithArrow>
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
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td class="dh"></td><td class="panelR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre" style="font-weight:bold"><asp:Literal runat="server" id="ROCustNameLabel2" Text="EvaluateFormula(&quot;= \&quot;Facility Name\&quot;&quot;, true)">	</asp:Literal></td><td class="tre"><asp:DropDownList runat="server" id="ROCustNameFilter1" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:DropDownList> </td><td class="tre"><OEMConversion:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Search" button-text="Filter History" button-tooltip="Filter History"></OEMConversion:ThemeButton></td><td class="tre"></td></tr><tr><td class="tre" style="font-weight:bold"><asp:Literal runat="server" id="ROCategoryLabel1" Text="EvaluateFormula(&quot;= \&quot;Category\&quot;&quot;, true)">	</asp:Literal></td><td class="tre"><asp:DropDownList runat="server" id="ROCategoryFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:DropDownList> </td><td class="tre" style="font-weight:bold"><asp:Literal runat="server" id="ROSubcontractedLabel" Text="RO Subcontracted">	</asp:Literal></td><td class="tre"><asp:DropDownList runat="server" id="ROSubcontractedFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList> </td></tr><tr><td class="tre" style="font-weight:bold"><asp:Literal runat="server" id="RODateLabel2" Text="EvaluateFormula(&quot;= \&quot;Date\&quot;&quot;, true)">	</asp:Literal></td><td class="tre"><asp:TextBox runat="server" id="RODateFromFilter1" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;m/d/yyyy&#39;)" timestring="&quot;00:00:00&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="RODateFromFilter1CalenderExtender" TargetControlID="RODateFromFilter1" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> <span class="rft"><%# GetResourceValue("Txt:To", "OEMConversion") %></span> <asp:TextBox runat="server" id="RODateToFilter1" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;m/d/yyyy&#39;)" timestring="&quot;23:59:59&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="RODateToFilter1CalenderExtender" TargetControlID="RODateToFilter1" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> </td><td class="tre" style="font-weight:bold"><asp:Literal runat="server" id="ROSerialNoLabel1" Text="EvaluateFormula(&quot;= \&quot;Serial Number\&quot;&quot;, true)">	</asp:Literal></td><td class="tre"><asp:TextBox runat="server" id="ROSerialNoFilter" columns="20" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:TextBox> </td></tr><tr><td class="tre" style="font-weight:bold"><asp:Literal runat="server" id="RONoLabel1" Text="EvaluateFormula(&quot;= \&quot;RO#\&quot;&quot;, true)">	</asp:Literal></td><td class="tre"><asp:TextBox runat="server" id="RONoFilter" columns="20" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:TextBox> </td><td class="tre" style="font-weight:bold"><asp:Literal runat="server" id="ROFaultCodesLabel" Text="EvaluateFormula(&quot;= \&quot;Fault Code\&quot;&quot;, true)">	</asp:Literal></td><td class="tre"><asp:DropDownList runat="server" id="ROFaultCodesFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</asp:DropDownList> </td></tr><tr><td class="tre"></td><td class="tre"></td><td class="tre"></td><td class="tre"></td></tr><tr><td class="tre" colspan="4"><table id="RepairOrdersTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="2"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc"></th><th class="thc"><asp:LinkButton runat="server" id="RONoLabel" tooltip="Sort by RONo" Text="Repair Order #" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROStatusLabel" tooltip="Sort by ROStatus" Text="Status" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="RODateLabel1" tooltip="Sort by RODate" Text="EvaluateFormula(&quot;= \&quot;Date\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROReference1Label" tooltip="Sort by ROReference1" Text="EvaluateFormula(&quot;= \&quot;PO#\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROReference2Label" tooltip="Sort by ROReference2" Text="EvaluateFormula(&quot;= \&quot;Dept\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROReference4Label" tooltip="Sort by ROReference4" Text="EvaluateFormula(&quot;= \&quot;Approved By\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROCustNameLabel" tooltip="Sort by ROCustName" Text="Customer" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROMakeLabel" tooltip="Sort by ROMake" Text="EvaluateFormula(&quot;= \&quot;Make\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROModelLabel" tooltip="Sort by ROModel" Text="EvaluateFormula(&quot;= \&quot;Model\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROCategoryLabel" tooltip="Sort by ROCategory" Text="EvaluateFormula(&quot;= \&quot;Category\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROGrandTotalLabel" tooltip="Sort by ROGrandTotal" Text="EvaluateFormula(&quot;= \&quot;Grand Total\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROTechnicianLabel" tooltip="Sort by ROTechnician" Text="Technician" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ROSerialNoLabel" tooltip="Sort by ROSerialNo" Text="Serial #" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="RepairOrdersTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:RepairOrdersTableControlRow runat="server" id="RepairOrdersTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" colspan="2">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                                                   
                                </td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RONo1"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RONo"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROStatus"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODate"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference2"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference4"></asp:Literal></td><td class="tableCellValue"><asp:LinkButton runat="server" id="ROCustName" causesvalidation="False" commandname="Redirect"></asp:LinkButton></td><td class="tableCellValue"><asp:Literal runat="server" id="ROMake"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROModel"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROCategory"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROGrandTotal"></asp:Literal></span>
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="ROTechnician" causesvalidation="False" commandname="Redirect"></asp:LinkButton></td><td class="tableCellValue"><asp:Literal runat="server" id="ROSerialNo"></asp:Literal></td></tr></OEMConversion:RepairOrdersTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
<tr summary="Footer"><td class="tableCellValue" colspan="16"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:Max_repairorderRecordControl runat="server" id="Max_repairorderRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Max_repairorderRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Max_repairorderRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Max_repairorderRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>
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
                