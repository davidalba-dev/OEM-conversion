<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Site_inventory" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Site-inventory.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_Site_inventory" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                        <OEMConversion:Site_inventoryRecordControl runat="server" id="Site_inventoryRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="Inventory Item Details">	</asp:Literal>
                      </td><td class="dhir"></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Site_inventoryRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="custnoLabel" Text="Customer">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="custno" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="date_addedLabel" Text="Date Added">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_added"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="dept_idLabel" Text="Department">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="dept_id"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="added_byLabel" Text="Added By">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="added_by"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="inventory_loc_idLabel" Text="Location">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="inventory_loc_id"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="date_removedLabel" Text="Date Removed">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_removed"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="makeLabel" Text="Make">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="make"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="removed_byLabel" Text="Removed By">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="removed_by" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="modelLabel" Text="Model">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="model"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="site_inventory_commentsLabel" Text="EvaluateFormula(&quot;= \&quot;Comments\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue" rowspan="2"><asp:Literal runat="server" id="site_inventory_comments"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="category_idLabel" Text="Category">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="category_id"></asp:Literal></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="condition_idLabel" Text="Condition">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="condition_id"></asp:Literal></span>
 </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="notesLabel" Text="Notes">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="notes"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="image1Label" Text="Image 1">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Image runat="server" id="image1" class="imageDropshadow" style="max-width:250px;margin:5px;"></asp:Image> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="image2Label" Text="Image 2">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Image runat="server" id="image2" class="imageDropshadow" style="max-width:250px;margin:5px;"></asp:Image> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="image3Label" Text="Image 3">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Image runat="server" id="image3" class="imageDropshadow" style="max-width:250px;margin:5px;"></asp:Image> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Site_inventoryRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Site_inventoryRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td><OEMConversion:Serial_numberTableControl runat="server" id="Serial_numberTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="Actions2Div" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td></td><td>
                    <asp:ImageButton runat="server" id="ExcelButton1" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="Actions2Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Actions2Div&#39;,&#39;Actions2Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="Filters2Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters2Div&#39;,&#39;Filters2Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td>
                          <div id="Filters2Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel2" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort2" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="Serial_numberTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="serial_noLabel" Text="Serial Number">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="serial_no_date_addedLabel" Text="Date Added">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="serial_no_added_byLabel" Text="Added By">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="serial_no_date_removedLabel" Text="Date Removed">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="serial_no_removed_byLabel" Text="Removed By">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Serial_numberTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Serial_numberTableControlRow runat="server" id="Serial_numberTableControlRow">
<tr><td class="tableCellLabel"></td><td class="tableCellValue"><asp:Literal runat="server" id="serial_no"></asp:Literal> </td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="serial_no_date_added"></asp:Literal></span>
 </td><td class="tableCellValue"><asp:LinkButton runat="server" id="serial_no_added_by" causesvalidation="False" commandname="Redirect"></asp:LinkButton></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="serial_no_date_removed"></asp:Literal></span>
 </td><td class="tableCellValue"><asp:LinkButton runat="server" id="serial_no_removed_by" causesvalidation="False" commandname="Redirect"></asp:LinkButton></td></tr><tr><td class="tableRowDivider" colspan="5"></td><td class="tableRowDivider"></td></tr></OEMConversion:Serial_numberTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination1"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Serial_numberTableControl_PostbackTracker" runat="server" />
</OEMConversion:Serial_numberTableControl>
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
                