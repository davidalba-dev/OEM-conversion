<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Edit_Site_inventory_Table" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Edit-Site-inventory-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Edit_Site_inventory_Table" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <OEMConversion:Site_inventoryTableControl runat="server" id="Site_inventoryTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(&quot;Site Inventory&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="AddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right"></td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="Site_inventoryTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb">&nbsp;</th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="makeLabel" Text="Make">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="modelLabel" Text="Model">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="categoryLabel" Text="Category">	</asp:Literal></th><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="condition_idLabel" Text="Condition">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="notesLabel" Text="Notes">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="dept_idLabel" tooltip="Sort by dept_id" Text="Department" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="date_addedLabel" tooltip="Sort by date_added" Text="Date Added" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="added_byLabel" tooltip="Sort by added_by" Text="Added By" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="Site_inventoryTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Site_inventoryTableControlRow runat="server" id="Site_inventoryTableControlRow">
<tr><td class="tableRowButtonsCellVertical">
                          
                        <OEMConversion:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="Remove" button-tooltip="Remove Item"></OEMConversion:ThemeButton> 
<BaseClasses:QuickSelector runat="server" id="custno" redirecturl="" visible="False"></BaseClasses:QuickSelector></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="make" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="model" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="category" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td><td class="tableCellValue"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="condition_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="notes" MaxLength="250" columns="30" cssclass="field_input" rows="1" textmode="SingleLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="notesTextBoxMaxLengthValidator" ControlToValidate="notes" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Notes&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="dept_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_added"></asp:Literal></span>
 <span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_added1" Columns="20" MaxLength="30" cssclass="field_input" htmlencodevalue="Default" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_added1TextBoxMaxLengthValidator" ControlToValidate="date_added1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Added&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="added_by"></asp:Literal></span>
 <span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="added_by1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td></tr><tr><td class="tableRowDivider"></td><td class="tableRowDivider" colspan="9"><OEMConversion:Serial_numberTableControl runat="server" id="Serial_numberTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(&quot;Serial Number&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="Actions1Div" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="AddButton2" causesvalidation="false" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="SaveButton" causesvalidation="true" commandname="UpdateData" imageurl="../Images/ButtonBarSave.gif" onmouseout="this.src=&#39;../Images/ButtonBarSave.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarSaveOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="Actions1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Actions1Div&#39;,&#39;Actions1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <OEMConversion:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;OEMConversion&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="Serial_numberTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="1" style="display:none"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="Serial_numberTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Serial_numberTableControlRow runat="server" id="Serial_numberTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="3">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                </td><td class="tableCellLabel"><asp:Literal runat="server" id="site_inventory_idLabel" Text="Site Inventory">	</asp:Literal> 
</td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="site_inventory_id" redirecturl=""></BaseClasses:QuickSelector> </td><td class="tableCellLabel"><asp:Literal runat="server" id="serial_no_date_addedLabel" Text="Serial No Date Added">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="serial_no_date_added" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="serial_no_date_addedCalendarExtender" TargetControlID="serial_no_date_added" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="serial_no_date_addedTextBoxMaxLengthValidator" ControlToValidate="serial_no_date_added" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Serial No Date Added&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="serial_no_added_byLabel" Text="Serial No Added By">	</asp:Literal> 
</td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="serial_no_added_by" redirecturl=""></BaseClasses:QuickSelector> </td><td class="tableCellLabel"><asp:Literal runat="server" id="serial_no_date_removedLabel" Text="Serial No Date Removed">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="serial_no_date_removed" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="serial_no_date_removedCalendarExtender" TargetControlID="serial_no_date_removed" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="serial_no_date_removedTextBoxMaxLengthValidator" ControlToValidate="serial_no_date_removed" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Serial No Date Removed&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="serial_no_removed_byLabel" Text="Serial No Removed By">	</asp:Literal> 
</td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="serial_no_removed_by" redirecturl=""></BaseClasses:QuickSelector> </td><td class="tableCellLabel"><asp:Literal runat="server" id="serial_noLabel1" Text="Serial Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="serial_no1" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="serial_no1TextBoxMaxLengthValidator" ControlToValidate="serial_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Serial Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableRowDivider" colspan="5"></td></tr></OEMConversion:Serial_numberTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="Serial_numberTableControl_PostbackTracker" runat="server" />
</OEMConversion:Serial_numberTableControl>
</td></tr><tr><td class="tableRowDivider" colspan="4"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></OEMConversion:Site_inventoryTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
<tr summary="Footer"><td class="tableCellValue" colspan="2"><table><tr><td><OEMConversion:ThemeButton runat="server" id="Button1" button-causesvalidation="False" button-commandname="UpdateData" button-text="Save" button-tooltip="Save"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="Button2" button-causesvalidation="False" button-commandname="Redirect" button-text="Cancel" button-tooltip="Cancel"></OEMConversion:ThemeButton></td></tr></table>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr></table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Site_inventoryTableControl_PostbackTracker" runat="server" />
</OEMConversion:Site_inventoryTableControl>

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
                