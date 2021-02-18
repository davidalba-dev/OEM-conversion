<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Remove_Site_inventory" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Remove-Site-inventory.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Remove_Site_inventory" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Namespace="OEMConversion.UI" TagPrefix="custom" %>
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

                        <OEMConversion:Site_inventoryRecordControl runat="server" id="Site_inventoryRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="Remove Site Inventory Item">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Site_inventoryRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="makeLabel" Text="Make">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="make"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="condition_idLabel" Text="Condition">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="condition_id"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="modelLabel" Text="Model">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="model"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="date_addedLabel" Text="Date Added">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_added"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"> </td><td class="tableCellLabel"><asp:Literal runat="server" id="site_inventory_commentsLabel" Text="EvaluateFormula(&quot;= \&quot;Comments\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue" rowspan="2"><custom:HTMLEditor ID="site_inventory_comments" runat="server" site_inventory_commentsRequiredFieldValidator:Enabled="False" site_inventory_commentsRequiredFieldValidator:Text="*" Height="350" Width="640" AutoFocus="False" /></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="categoryLabel" Text="Category">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="category"></asp:Literal> </td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="dept_idLabel" Text="Department">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="dept_id"></asp:Literal></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="notesLabel" Text="Notes">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="notes"></asp:Literal> </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="site_inventory_date" Columns="20" MaxLength="30" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="site_inventory_dateCalendarExtender" TargetControlID="site_inventory_date" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="site_inventory_dateTextBoxMaxLengthValidator" ControlToValidate="site_inventory_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Site Inventory Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="removed_by" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_removed" Columns="20" MaxLength="30" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="date_removedCalendarExtender" TargetControlID="date_removed" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_removedTextBoxMaxLengthValidator" ControlToValidate="date_removed" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Removed&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"></td></tr></table></asp:panel>
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
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-backcolor="Red" button-causesvalidation="True" button-commandname="UpdateData" button-text="Remove Item" button-tooltip="Remove Item" postback="True"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                