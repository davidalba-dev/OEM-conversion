<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Add_Loaner_inventory" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Add-Loaner-inventory.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Add_Loaner_inventory" %>
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

                        <OEMConversion:Loaner_inventoryRecordControl runat="server" id="Loaner_inventoryRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Loaner Inventory&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Loaner_inventoryRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="makeLabel" Text="Make">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="make" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="loaner_type_idLabel" Text="Loaner Type">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="loaner_type_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="modelLabel" Text="Model">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="model" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="loaner_activeLabel" Text="EvaluateFormula(&quot;= \&quot;Active\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:CheckBox runat="server" id="loaner_active"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="category_idLabel" Text="Category">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="category_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="serial_numberLabel" Text="Serial Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="serial_number" Columns="15" MaxLength="15" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="serial_numberTextBoxMaxLengthValidator" ControlToValidate="serial_number" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Serial Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="loaner_inventory_commentLabel" Text="EvaluateFormula(&quot;= \&quot;Comment\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:TextBox runat="server" id="loaner_inventory_comment" MaxLength="500" columns="80" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="loaner_inventory_commentTextBoxMaxLengthValidator" ControlToValidate="loaner_inventory_comment" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Comment\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Loaner_inventoryRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Loaner_inventoryRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" postback="True"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="SaveAndNewButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;OEMConversion&quot;) %>" postback="True"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                