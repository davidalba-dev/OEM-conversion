<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Add_Customers_Basic" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Add-Customers-Basic.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Add_Customers_Basic" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                        <OEMConversion:CustomersRecordControl runat="server" id="CustomersRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="Add New Facility">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="CustomersRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="corporate_idLabel" Text="Corp. Entity">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="corporate_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="CustPhoneBusinessLabel" Text="EvaluateFormula(&quot;= \&quot;Phone Business\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustPhoneBusiness" Columns="32" MaxLength="32" cssclass="field_input" tabindex="7"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustPhoneBusinessTextBoxMaxLengthValidator" ControlToValidate="CustPhoneBusiness" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Phone Business\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:CheckBox runat="server" id="customer_inventory" visible="False"></asp:CheckBox></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustNameLabel" Text="EvaluateFormula(&quot;= \&quot;Facility Name\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustName" Columns="40" MaxLength="70" cssclass="field_input" tabindex="1"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustNameTextBoxMaxLengthValidator" ControlToValidate="CustName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Facility Name\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="CustFaxLabel" Text="EvaluateFormula(&quot;= \&quot;Fax\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustFax" Columns="32" MaxLength="32" cssclass="field_input" tabindex="8"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustFaxTextBoxMaxLengthValidator" ControlToValidate="CustFax" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Fax\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:CheckBox runat="server" id="customer_active" visible="False"></asp:CheckBox></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustAddress1Label" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustAddress1" Columns="40" MaxLength="40" cssclass="field_input" tabindex="2"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustAddress1TextBoxMaxLengthValidator" ControlToValidate="CustAddress1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="CustEmailLabel" Text="EvaluateFormula(&quot;= \&quot;Billing Email\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustEmail" Columns="40" MaxLength="200" cssclass="field_input" tabindex="9"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustEmailTextBoxMaxLengthValidator" ControlToValidate="CustEmail" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Billing Email\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustAddress2Label" Text="EvaluateFormula(&quot;= \&quot;Address 2\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustAddress2" Columns="40" MaxLength="40" cssclass="field_input" tabindex="3"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustAddress2TextBoxMaxLengthValidator" ControlToValidate="CustAddress2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Address 2\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="CustWebSiteLabel" Text="Customer Website">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustWebSite" Columns="40" MaxLength="50" cssclass="field_input" tabindex="10"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustWebSiteTextBoxMaxLengthValidator" ControlToValidate="CustWebSite" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Website&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustCityLabel" Text="EvaluateFormula(&quot;= \&quot;City\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustCity" Columns="32" MaxLength="32" cssclass="field_input" tabindex="4"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustCityTextBoxMaxLengthValidator" ControlToValidate="CustCity" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;City\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="CustPayTermsLabel" Text="EvaluateFormula(&quot;=\&quot;Pay Terms\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="CustPayTerms" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="12"></asp:DropDownList></span>
</td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustProvinceLabel" Text="EvaluateFormula(&quot;= \&quot;State\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="CustProvince" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="5"></asp:DropDownList></span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="customer_type_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="13" visible="False"></asp:DropDownList>&nbsp;
<asp:RequiredFieldValidator runat="server" id="customer_type_idRequiredFieldValidator" ControlToValidate="customer_type_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Facility Type\&quot;&quot;, true)) %>" enabled="True" initialvalue="--PLEASE_SELECT--" text="* Must select Customer Type"></asp:RequiredFieldValidator></span>
</td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustPostalCodeLabel" Text="EvaluateFormula(&quot;= \&quot;Zip Code\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustPostalCode" Columns="10" MaxLength="10" cssclass="field_input" tabindex="6"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustPostalCodeTextBoxMaxLengthValidator" ControlToValidate="CustPostalCode" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Zip Code\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CustNoF" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="CustNoFRequiredFieldValidator" ControlToValidate="CustNoF" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Facility #\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustNoFTextBoxMaxLengthValidator" ControlToValidate="CustNoF" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Facility #\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="CustomersRecordControl_PostbackTracker" runat="server" />
</OEMConversion:CustomersRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" postback="True" sendemail1cc="kplante%40oemmed.com" sendemail1content="The+following+new+Customer+Account+was+created+with+the+following+details%3a%0d%0a%0d%0aAccount+Name%3a+%7bCustomersRecordControl%3aNoUrlEncode%3aFDV%3aCustName%7d%0d%0a" sendemail1forrecord="Current" sendemail1from="oeminfo%40oemmed.com" sendemail1subject="OEM+MED+Expertech-+New+Customer+Account" sendemail1to="oeminfo%40oemmed.com"></OEMConversion:ThemeButton></td><td></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                