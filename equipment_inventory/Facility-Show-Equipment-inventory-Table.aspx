﻿<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Facility_Show_Equipment_inventory_Table" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Facility-Show-Equipment-inventory-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Facility_Show_Equipment_inventory_Table" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                        
            <OEMConversion:Vw_customer_equip_inventoryTableControl runat="server" id="Vw_customer_equip_inventoryTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="Facility Inventory">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="false" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="false" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="false" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="category_idLabel3" Text="Category">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="category_idFilter1" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"><OEMConversion:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="make_idLabel5" Text="Make">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="make_idFilter1" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="model_idLabel3" Text="Model">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="model_idFilter1" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_customer_equip_inventoryTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb"></th><th class="thcnb"></th><th class="thc"><asp:Literal runat="server" id="date_receivedLabel1" Text="Dates">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="condition_idLabel" Text="Condition">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="make_idLabel" Text="Make/Model/Cat">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="serial_numberLabel" Text="Serial Number">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="disposition_idLabel" Text="Disposition">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="sale_method_idLabel" Text="Sale Method">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="final_sale_priceLabel1" Text="Pricing">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="warehouse_location_idLabel2" Text="Location">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Vw_customer_equip_inventoryTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_customer_equip_inventoryTableControlRow runat="server" id="Vw_customer_equip_inventoryTableControlRow">
<tr><td class="tableCellValue"><asp:ImageButton runat="server" id="ViewRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellValue"><asp:Image runat="server" id="equipment_inventory_pic1" class="imageDropshadow" style="max-width:120px;margin:5px;"></asp:Image></td><td class="tableCellValue"><b><asp:Literal runat="server" id="date_receivedLabel" Text="Date Received">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_received"></asp:Literal></span>
<br> 
<b><asp:Literal runat="server" id="date_soldLabel" Text="Date Sold">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_sold"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="condition_id"></asp:Literal></td><td class="tableCellValue"><b><asp:Literal runat="server" id="make_idLabel1" Text="Make">	</asp:Literal>:</b> <asp:Literal runat="server" id="make_id"></asp:Literal> <br>
<b><asp:Literal runat="server" id="model_idLabel" Text="Model">	</asp:Literal>:</b> <asp:Literal runat="server" id="model_id"></asp:Literal> <br>
<b><asp:Literal runat="server" id="category_idLabel" Text="Category">	</asp:Literal>:</b>  
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="new_category_id"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="serial_number"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="disposition_id"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="sale_method_id"></asp:Literal></span>
</td><td class="tableCellValue"><b><asp:Literal runat="server" id="purchase_priceLabel" Text="Purchase Price">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="purchase_price"></asp:Literal></span>
 <br>
<b><asp:Literal runat="server" id="proposed_sale_priceLabel" Text="Proposed Sale Price">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="proposed_sale_price"></asp:Literal></span>
<br>
<b><asp:Literal runat="server" id="final_sale_priceLabel" Text="Final Sale Price">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="final_sale_price"></asp:Literal></span>
</td><td class="tableCellValue"><b><asp:Literal runat="server" id="warehouse_idLabel" Text="Warehouse">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="warehouse_id"></asp:Literal></span>
<br> 
<b><asp:Literal runat="server" id="warehouse_location_idLabel" Text="Warehouse Location">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="warehouse_location_id"></asp:Literal></span>
 <br>
</td></tr><tr><td class="tableRowDivider" colspan="2"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OEMConversion:Vw_customer_equip_inventoryTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Vw_customer_equip_inventoryTableControl_PostbackTracker" runat="server" />
</OEMConversion:Vw_customer_equip_inventoryTableControl>
</td></tr><tr><td>
                        
            <OEMConversion:Vw_customer_equip_inventoryTableControl1 runat="server" id="Vw_customer_equip_inventoryTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="Organizational Inventory">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv1" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="PDFButton1" causesvalidation="false" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton1" causesvalidation="false" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton1" causesvalidation="false" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="ActionsButton1" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv1&#39;,&#39;ActionsButton1&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="FiltersButton1" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv1&#39;,&#39;FiltersButton1&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv1" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="category_idLabel2" Text="Category">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="category_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="make_idLabel4" Text="Make">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="make_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"><OEMConversion:ThemeButton runat="server" id="FilterButton1" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton1" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="model_idLabel2" Text="Model">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="model_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_customer_equip_inventoryTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb"></th><th class="thcnb"></th><th class="thc"><asp:Literal runat="server" id="received_from_customer_idLabel1" Text="Received From Customer">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="date_receivedLabel2" Text="Dates">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="condition_idLabel1" Text="Condition">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="make_idLabel2" Text="Make/Model/Cat">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="serial_numberLabel1" Text="Serial Number">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="disposition_idLabel1" Text="Disposition">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="sale_method_idLabel1" Text="Sale Method">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="final_sale_priceLabel2" Text="Pricing">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="warehouse_location_idLabel4" Text="Location">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Vw_customer_equip_inventoryTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_customer_equip_inventoryTableControl1Row runat="server" id="Vw_customer_equip_inventoryTableControl1Row">
<tr><td class="tableCellValue"><asp:ImageButton runat="server" id="ViewRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellValue"></td><td class="tableCellValue"><asp:Literal runat="server" id="CustName"></asp:Literal></td><td class="tableCellValue"><b><asp:Literal runat="server" id="date_receivedLabel3" Text="Date Received">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_received1"></asp:Literal></span>
<br> 
<b><asp:Literal runat="server" id="date_soldLabel1" Text="Date Sold">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_sold1"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="condition_id1"></asp:Literal></td><td class="tableCellValue"><b><asp:Literal runat="server" id="make_idLabel3" Text="Make">	</asp:Literal>:</b> <asp:Literal runat="server" id="make_id1"></asp:Literal> <br>
<b><asp:Literal runat="server" id="model_idLabel1" Text="Model">	</asp:Literal>:</b> <asp:Literal runat="server" id="model_id1"></asp:Literal> <br>
<b><asp:Literal runat="server" id="category_idLabel1" Text="Category">	</asp:Literal>:</b> <asp:Literal runat="server" id="category_id1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="serial_number1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="disposition_id1"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="sale_method_id1"></asp:Literal></span>
</td><td class="tableCellValue"><b><asp:Literal runat="server" id="purchase_priceLabel1" Text="Purchase Price">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="purchase_price1"></asp:Literal></span>
 <br>
<b><asp:Literal runat="server" id="proposed_sale_priceLabel1" Text="Proposed Sale Price">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="proposed_sale_price1"></asp:Literal></span>
<br>
<b><asp:Literal runat="server" id="final_sale_priceLabel3" Text="Final Sale Price">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="final_sale_price1"></asp:Literal></span>
</td><td class="tableCellValue"><b><asp:Literal runat="server" id="warehouse_idLabel3" Text="Warehouse">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="warehouse_id1"></asp:Literal></span>
<br> 
<b><asp:Literal runat="server" id="warehouse_location_idLabel5" Text="Warehouse Location">	</asp:Literal>:</b><span style="white-space:nowrap;">
<asp:Literal runat="server" id="warehouse_location_id1"></asp:Literal></span>
 <br>
</td></tr><tr><td class="tableRowDivider" colspan="2"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OEMConversion:Vw_customer_equip_inventoryTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination1"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Vw_customer_equip_inventoryTableControl1_PostbackTracker" runat="server" />
</OEMConversion:Vw_customer_equip_inventoryTableControl1>
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
                