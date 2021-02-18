<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Project-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_Project_Table" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Project_Table" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

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
                        <OEMConversion:ProjectTableControl runat="server" id="ProjectTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Project Dashboard&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle"><OEMConversion:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="Closed Projects" button-tooltip="Closed Projects"></OEMConversion:ThemeButton></td><td class="dht" valign="middle"><asp:ImageButton runat="server" id="ImageButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/helpicon.png" redirectstyle="NewWindow">		
	</asp:ImageButton></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" requiredroles="&lt;PRoles>3&lt;/PRoles>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OEMConversion&quot;) %>">		
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
                  </td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton"))%>
<i><span style="font-size:8pt">Search Project Name </span></i>
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
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="project_companyidLabel2" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="project_companyidFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"><OEMConversion:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="project_type_idLabel1" Text="Project Type">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="project_type_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="project_status_idLabel1" Text="Project Status">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<asp:DropDownList runat="server" id="project_status_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="ProjectTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="2"></th><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="project_companyidLabel" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="project_nameLabel" tooltip="Sort by project_name" Text="EvaluateFormula(&quot;= \&quot;Name\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_startdateLabel" tooltip="Sort by project_startdate" Text="Start/End" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_est_hoursLabel" tooltip="Sort by project_est_hours" Text="EvaluateFormula(&quot;= \&quot;Est. Hours\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_actual_timeLabel" tooltip="Sort by project_actual_time" Text="EvaluateFormula(&quot;= \&quot;Actual Hours\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_time_leftLabel" tooltip="Sort by project_time_left" Text="Project Time Left" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_percent_copmleteLabel" tooltip="Sort by project_percent_copmlete" Text="Percent Complete" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_budgetLabel" tooltip="Sort by project_budget" Text="EvaluateFormula(&quot;= \&quot;Budget\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_costLabel" tooltip="Sort by project_cost" Text="Project Cost" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_flat_feeLabel" tooltip="Sort by project_flat_fee" Text="EvaluateFormula(&quot;= \&quot;Flat Fee\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_status_idLabel" tooltip="Sort by project_status_id" Text="Project Status" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="project_type_idLabel" tooltip="Sort by project_type_id" Text="Project Type" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="ProjectTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:ProjectTableControlRow runat="server" id="ProjectTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="2" colspan="2">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                                                   
                                </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="project_companyid" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
<br> 
POC: <span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="project_poc" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="project_name"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="project_startdate"></asp:Literal></span>
<br> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="project_enddate"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="project_est_hours"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="project_actual_time"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="project_time_left"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="project_percent_copmlete"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="project_budget"></asp:Literal></span>
 
</td><td class="tableCellValue"><asp:Literal runat="server" id="project_cost"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="project_flat_fee"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="project_status_id"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="project_type_id"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="project_descriptionLabel" Text="EvaluateFormula(&quot;= \&quot;Description\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue" colspan="8"><asp:Literal runat="server" id="project_description"></asp:Literal> </td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="11"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OEMConversion:ProjectTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ProjectTableControl_PostbackTracker" runat="server" />
</OEMConversion:ProjectTableControl>

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
                