<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Search-Equipment-inventory.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Search_Equipment_inventory" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Search_Equipment_inventory" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td></td></tr><tr><td><OEMConversion:Vw_equipment_inventoryTableControl runat="server" id="Vw_equipment_inventoryTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(&quot;Equipment Inventory Search&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table><tr><td class="tre"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton"))%>
<span style="font-size:8pt"><i>Search OEM EIN </i></span><br>
<asp:TextBox runat="server" id="SearchText1" columns="50" cssclass="Search_Input" tabindex="1">	</asp:TextBox>
<asp:AutoCompleteExtender id="SearchText1AutoCompleteExtender" runat="server" TargetControlID="SearchText1" ServiceMethod="GetAutoCompletionList_SearchText1" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>
 
<asp:ImageButton runat="server" id="SearchButton1" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SearchButton"))%>
</td><td class="tre"><asp:ImageButton runat="server" id="ResetButton2" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td></tr><tr><td class="tre"><table id="Vw_equipment_inventoryTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="1" style="display:none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="Vw_equipment_inventoryTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_equipment_inventoryTableControlRow runat="server" id="Vw_equipment_inventoryTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;">
                                  <asp:ImageButton runat="server" id="EditRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                </td><td class="tableCellLabel"><asp:Literal runat="server" id="oem_einLabel1" Text="OEM EIN">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="oem_ein1" Columns="40" MaxLength="50" cssclass="field_input" tabindex="1"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="oem_ein1TextBoxMaxLengthValidator" ControlToValidate="oem_ein1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;OEM EIN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 
</td><td class="tableCellLabel"><asp:Literal runat="server" id="received_from_customer_idLabel1" Text="Received From Customer">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="received_from_customer_id1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="9"></asp:DropDownList></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="date_disposedLabel1" Text="Date Disposed">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_disposed1" Columns="20" MaxLength="30" cssclass="field_input" tabindex="16"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="date_disposed1CalendarExtender" TargetControlID="date_disposed1" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_disposed1TextBoxMaxLengthValidator" ControlToValidate="date_disposed1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Disposed&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Label runat="server" id="Label1" Text="Location">	</asp:Label></td><td class="tableCellValue"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:Equipment_inventory_historyRecordControl1 runat="server" id="Equipment_inventory_historyRecordControl1">	<table cellpadding="0" cellspacing="0" border="0"><tr><td><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Equipment_inventory_historyRecordControl1Panel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel" style="text-align:left;"><asp:Literal runat="server" id="warehouse_idLabel1" Text="Warehouse">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="warehouse_id1"></asp:Literal>  
</td><td class="tableCellValue"><asp:ImageButton runat="server" id="ImageButton" alternatetext="Update Location" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon_edit.gif" redirectstyle="Popup">		
	</asp:ImageButton></td></tr><tr><td class="tableCellLabel" style="text-align:left;"><asp:Literal runat="server" id="warehouse_location_idLabel1" Text="Warehouse Location">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="warehouse_location_id1"></asp:Literal></td><td class="tableCellValue"></td></tr></table></asp:panel>

                  </td></tr></table>
</td></tr></table>
	<asp:hiddenfield id="Equipment_inventory_historyRecordControl1_PostbackTracker" runat="server" />
</OEMConversion:Equipment_inventory_historyRecordControl1>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>
 
<OEMConversion:Vw_current_inventory_locationTableControl1 runat="server" id="Vw_current_inventory_locationTableControl1">	<table cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td></td><td><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <table id="Vw_current_inventory_locationTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><asp:Repeater runat="server" id="Vw_current_inventory_locationTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_current_inventory_locationTableControl1Row runat="server" id="Vw_current_inventory_locationTableControl1Row">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="warehouse_nameLabel1" Text="Warehouse Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="warehouse_name1"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="warehouse_locationLabel1" Text="Warehouse Location">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="warehouse_location1"></asp:Literal></td></tr></OEMConversion:Vw_current_inventory_locationTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</td></tr></table>
	<asp:hiddenfield id="Vw_current_inventory_locationTableControl1_PostbackTracker" runat="server" />
</OEMConversion:Vw_current_inventory_locationTableControl1>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="received_from_contact_idLabel1" Text="Received From Contact">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="received_from_contact_id1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="10"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="date_receivedLabel1" Text="Date Received">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_received1" Columns="20" MaxLength="30" cssclass="field_input" tabindex="17"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="date_received1CalendarExtender" TargetControlID="date_received1" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_received1TextBoxMaxLengthValidator" ControlToValidate="date_received1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Received&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Literal runat="server" id="make_idLabel1" Text="Make">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="make_id1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="customer_einLabel1" Text="Customer EIN">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="customer_ein1" Columns="15" MaxLength="15" cssclass="field_input" tabindex="11"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="customer_ein1TextBoxMaxLengthValidator" ControlToValidate="customer_ein1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer EIN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="date_soldLabel1" Text="Date Sold">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_sold1" Columns="20" MaxLength="30" cssclass="field_input" tabindex="18"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="date_sold1CalendarExtender" TargetControlID="date_sold1" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_sold1TextBoxMaxLengthValidator" ControlToValidate="date_sold1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Sold&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Literal runat="server" id="model_idLabel1" Text="Model">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="model_id1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_phiLabel1" Text="Equipment PHI">	</asp:Literal></td><td class="tableCellValue"><asp:CheckBox runat="server" id="equipment_phi1" tabindex="12"></asp:CheckBox> </td><td class="tableCellLabel"><asp:Literal runat="server" id="pd_dateLabel1" Text="PD Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="pd_date1" Columns="20" MaxLength="30" cssclass="field_input" tabindex="19"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="pd_date1CalendarExtender" TargetControlID="pd_date1" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pd_date1TextBoxMaxLengthValidator" ControlToValidate="pd_date1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;PD Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Literal runat="server" id="serial_numberLabel1" Text="Serial Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="serial_number1" Columns="40" MaxLength="50" cssclass="field_input" tabindex="4"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="serial_number1TextBoxMaxLengthValidator" ControlToValidate="serial_number1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Serial Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="require_accessoriesLabel1" Text="Require Accessories">	</asp:Literal></td><td class="tableCellValue"><asp:CheckBox runat="server" id="require_accessories1" tabindex="13"></asp:CheckBox> </td><td colspan="2" rowspan="2"></td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Literal runat="server" id="category_idLabel1" Text="Category">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="category_id1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="5"></asp:DropDownList></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="doc_numLabel1" Text="Document Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="doc_num1" Columns="25" MaxLength="25" cssclass="field_input" tabindex="14"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="doc_num1TextBoxMaxLengthValidator" ControlToValidate="doc_num1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_type_idLabel1" Text="Equipment Type">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="equipment_type_id1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="6"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="other_id_numLabel1" Text="Other Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="other_id_num1" Columns="25" MaxLength="25" cssclass="field_input" tabindex="15"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="other_id_num1TextBoxMaxLengthValidator" ControlToValidate="other_id_num1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Other Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Literal runat="server" id="condition_idLabel1" Text="Condition">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="condition_id"></asp:Literal></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Literal runat="server" id="disposition_idLabel1" Text="Disposition">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="disposition_id"></asp:Literal></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider"></td><td class="tableCellLabel"><asp:Literal runat="server" id="descriptionLabel1" Text="Description">	</asp:Literal></td><td class="tableCellValue" colspan="5"></td></tr><tr><td class="tableRowDivider" colspan="7"></td></tr></OEMConversion:Vw_equipment_inventoryTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
<tr summary="Footer"><td class="tableCellValue"></td><td class="tableCellValue"><OEMConversion:ThemeButton runat="server" id="Button1" button-causesvalidation="False" button-commandname="UpdateData" button-text="Update " button-tooltip="Update"></OEMConversion:ThemeButton></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr></table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Vw_equipment_inventoryTableControl_PostbackTracker" runat="server" />
</OEMConversion:Vw_equipment_inventoryTableControl>
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
                