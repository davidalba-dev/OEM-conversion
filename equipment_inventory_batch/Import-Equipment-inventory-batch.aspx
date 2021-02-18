<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Import-Equipment-inventory-batch.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Import_Equipment_inventory_batch" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Import_Equipment_inventory_batch" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:Equipment_inventory_batchRecordControl runat="server" id="Equipment_inventory_batchRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot;&quot;,&quot; Equipment Inventory Batch&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle"><span style="color:Red"><b>ID:<span style="white-space:nowrap;">
<asp:Literal runat="server" id="equipment_inventory_batch_id1"></asp:Literal></span>
</b></span></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Equipment_inventory_batchRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="technician_idLabel" Text="Technician">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="technician_id"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="custnoLabel" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><table><tr><td><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="custno" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td><OEMConversion:ThemeButton runat="server" id="Button3" button-causesvalidation="False" button-commandname="UpdateData" button-text="+" button-tooltip="Add Customer" redirectstyle="Popup"></OEMConversion:ThemeButton></td></tr></table>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="batch_status_idLabel" Text="Batch Status">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="batch_status_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="warehouse_idLabel" Text="Warehouse">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="warehouse_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="batch_dateLabel" Text="Batch Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="batch_date"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="warehouse_location_idLabel" Text="Warehouse Location">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="warehouse_location_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" colspan="4"><OEMConversion:Equipment_inventory_batch_detailTableControl1 runat="server" id="Equipment_inventory_batch_detailTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <table><tr><td class="dht">&nbsp; 
<asp:Literal runat="server" id="Title2" Text="&lt;%#String.Concat(&quot;Equipment Inventory Batch Detail&quot;) %>">	</asp:Literal></td><td class="dht" valign="middle"><OEMConversion:ThemeButton runat="server" id="Button6" button-causesvalidation="False" button-commandname="AddRecord" button-text="Add New Item" button-tooltip="Add New Item"></OEMConversion:ThemeButton></td></tr></table>
</td><td class="dht"></td><td class="dht" valign="middle"><asp:ImageButton runat="server" id="ImportButton" causesvalidation="false" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td><asp:ImageButton runat="server" id="ImportButton1" causesvalidation="false" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="Filters1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters1Div&#39;,&#39;Filters1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td></td><td class="prspaceEnd">&nbsp;</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="Filters1Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="makeLabel2" Text="Make">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><asp:DropDownList runat="server" id="makeFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"><OEMConversion:ThemeButton runat="server" id="FilterButton1" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="condition_idLabel2" Text="Condition">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="condition_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="acceptedLabel2" Text="Accepted">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="acceptedFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="phiLabel2" Text="PHI">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="phiFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="equipment_inventory_disposition_idLabel" Text="Equipment Inventory Disposition" visible="False">	</asp:Literal></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="equipment_inventory_disposition_idFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" visible="False">	</asp:DropDownList> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Equipment_inventory_batch_detailTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="2"></th><th class="thc"><asp:LinkButton runat="server" id="EINLabel1" tooltip="Sort by EIN" Text="EIN" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="serial_numberLabel1" tooltip="Sort by serial_number" Text="Serial Number" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="makeLabel1" tooltip="Sort by make" Text="Make" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="modelLabel1" tooltip="Sort by model" Text="Model" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="condition_idLabel1" tooltip="Sort by condition_id" Text="Condition" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="purchase_priceLabel1" tooltip="Sort by purchase_price" Text="EvaluateFormula(&quot;= \&quot;Bid Price\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="accessoriesLabel1" tooltip="Sort by accessories" Text="Accessories" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="phiLabel1" tooltip="Sort by phi" Text="PHI" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="purchase_priceLabel3" tooltip="Sort by purchase_price" Text="Bid" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="acceptedLabel1" tooltip="Sort by accepted" Text="Accepted" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="oem_barcode_approveLabel1" tooltip="Sort by oem_barcode_approve" Text="OEM Barcode Approve" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="Equipment_inventory_batch_detailTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:Equipment_inventory_batch_detailTableControl1Row runat="server" id="Equipment_inventory_batch_detailTableControl1Row">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="2" colspan="2">
                                  <asp:ImageButton runat="server" id="EditRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                </td><td class="tableCellLabel"><asp:Literal runat="server" id="EIN1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="serial_number1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="make1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="model1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="condition_id1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="purchase_price2"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="accessories1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="phi1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="purchase_price4"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="accepted1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="oem_barcode_approve1"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="commentLabel" Text="Comment">	</asp:Literal></td><td class="tableCellValue" colspan="10"><asp:Literal runat="server" id="comment1"></asp:Literal></td></tr><tr><td class="tableRowDivider" colspan="8"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OEMConversion:Equipment_inventory_batch_detailTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination1"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Equipment_inventory_batch_detailTableControl1_PostbackTracker" runat="server" />
</OEMConversion:Equipment_inventory_batch_detailTableControl1>
</td></tr><tr><td></td><td class="tableCellLabel"></td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:Max_customerRecordControl runat="server" id="Max_customerRecordControl">	<table cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion8" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Max_customerRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="Expr" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="ExprRequiredFieldValidator" ControlToValidate="Expr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Expiration&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ExprTextBoxMaxLengthValidator" ControlToValidate="Expr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Expiration&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Max_customerRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Max_customerRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td><td class="tableCellLabel"></td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Equipment_inventory_batchRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Equipment_inventory_batchRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" postback="True"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                