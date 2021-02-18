<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Add-RepairOrders.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Add_RepairOrders" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Add_RepairOrders" %>

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

                        <OEMConversion:RepairOrdersRecordControl runat="server" id="RepairOrdersRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="Add Repair Order">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="RepairOrdersRecordControlPanel" runat="server"><table><tr><td class="fls"><asp:Literal runat="server" id="ROCustNameLabel" Text="Customer">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROCustNo" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,true)" visible="True"></asp:DropDownList></span>
 
<span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROCustName" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,true)" tabindex="1" visible="False"></asp:DropDownList></span>
</td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="ROUnder_ContractLabel" Text="Under Contract">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:CheckBox runat="server" id="ROUnder_Contract" tabindex="8"></asp:CheckBox></td></tr><tr><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="ROContactNameLabel" Text="Contact Name">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"> 
<table><tr><td><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROContactName" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="7"></asp:DropDownList></span>
</td></tr></table>
 
</td><td class="tableCellLabel" style="text-align:left;"><asp:Literal runat="server" id="repair_replaceLabel" Text="EvaluateFormula(&quot;= \&quot;Repair-Replace\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:CheckBox runat="server" id="repair_replace"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="RODeptIDNewLabel" Text="EvaluateFormula(&quot;= \&quot;Dept.\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="RODeptIDNew" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="loaner_requiredLabel" Text="Loaner Required">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:CheckBox runat="server" id="loaner_required"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ROStatusLabel" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROStatus" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="2"></asp:DropDownList></span>
</td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="label_requiredLabel" Text="Label Required">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:CheckBox runat="server" id="label_required"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ROReference3Label" Text="EvaluateFormula(&quot;= \&quot;Case/Box\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROReference3" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="3"></asp:DropDownList></span>
</td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="ROReference4Label" Text="EvaluateFormula(&quot;= \&quot;Approved By\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROReference4" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="9"></asp:DropDownList></span>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="ROCategoryLabel" Text="EvaluateFormula(&quot;= \&quot;Category\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="category_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="ROConditionLabel" Text="EvaluateFormula(&quot;= \&quot;Condition\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROCondition" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="10"></asp:DropDownList></span>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="ROMakeLabel" Text="EvaluateFormula(&quot;= \&quot;Make\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"> 
<table><tr><td><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROMake" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td><OEMConversion:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="+" button-tooltip="Add New Make/Model" button-width="10px" redirectstyle="Popup"></OEMConversion:ThemeButton> 
</td></tr></table>
</td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="ROFaultCodesLabel" Text="EvaluateFormula(&quot;= \&quot;Fault Code\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROFaultCodes" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="11"></asp:DropDownList></span>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="ROModelLabel" Text="EvaluateFormula(&quot;= \&quot;Model\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ROModel" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ROSerialNoLabel" Text="EvaluateFormula(&quot;= \&quot;Serial Number\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ROSerialNo" Columns="40" MaxLength="40" cssclass="field_input" tabindex="6"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ROSerialNoTextBoxMaxLengthValidator" ControlToValidate="ROSerialNo" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Serial Number\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ROSerialNo1" Columns="40" MaxLength="100" cssclass="field_input" tabindex="6" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ROSerialNo1TextBoxMaxLengthValidator" ControlToValidate="ROSerialNo1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Serial Encrypt&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ROCustNo1" Columns="40" MaxLength="100" cssclass="field_input" datareadersortby="CustName Asc" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ROCustNo1TextBoxMaxLengthValidator" ControlToValidate="ROCustNo1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Encrypt&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="RONo" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="RONoTextBoxMaxLengthValidator" ControlToValidate="RONo" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;RO#\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="RODate" Columns="20" MaxLength="30" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="RODateCalendarExtender" TargetControlID="RODate" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="RODateTextBoxMaxLengthValidator" ControlToValidate="RODate" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Date\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RepairOrdersRecordControl_PostbackTracker" runat="server" />
</OEMConversion:RepairOrdersRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:Max_makemodelRecordControl runat="server" id="Max_makemodelRecordControl">	<table cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server" visible="False"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Max_makemodelRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="Expr1Label" Text="Expiration 1">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Expr1"></asp:Literal></span>
 </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Max_makemodelRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Max_makemodelRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-redirectargument="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" postback="True"></OEMConversion:ThemeButton></td><td></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                