

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Add-Equipment-inventory.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Add_Equipment_inventory" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Add_Equipment_inventory" %>
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

                        <OEMConversion:Equipment_inventoryRecordControl runat="server" id="Equipment_inventoryRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Equipment Inventory&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle"><asp:ImageButton runat="server" id="ImageButton1" causesvalidation="False" commandname="Redirect" imageurl="../Images/helpicon.png" redirectstyle="NewWindow">		
	</asp:ImageButton></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Equipment_inventoryRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="oem_einLabel" Text="EvaluateFormula(&quot;= \&quot;OEM Barcode\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("Button4"))%>
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="oem_ein1" Columns="40" MaxLength="50" cssclass="field_input" enterkeycapturetobutton="Button4" tabindex="1"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="oem_ein1TextBoxMaxLengthValidator" ControlToValidate="oem_ein1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;OEM Barcode\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="oem_ein" Columns="40" MaxLength="50" cssclass="field_input" tabindex="1" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="oem_einTextBoxMaxLengthValidator" ControlToValidate="oem_ein" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;OEM Barcode\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<br> 


<asp:regularexpressionvalidator id="RegexValidator" controltovalidate="oem_ein1" validationexpression="^[0-9]*$" text="Barcode can only be numeric" runat="server" forecolor="red" errormessage="Numbers Only"></asp:regularexpressionvalidator><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("Button4"))%>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="received_from_customer_idLabel" Text="Received From Customer">	</asp:Literal></td><td class="tableCellValue"><table><tr><td><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="received_from_customer_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="9"></asp:DropDownList></span>
</td><td><OEMConversion:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="+" button-tooltip="Add Customer" redirectstyle="Popup"></OEMConversion:ThemeButton> 
</td></tr></table>
<asp:requiredfieldvalidator id="RequiredFieldValidator" text="Customer Required!" runat="server" forecolor="red" controltovalidate="received_from_customer_id" initialvalue="--PLEASE_SELECT--"></asp:requiredfieldvalidator></td><td class="tableCellLabel"><asp:Literal runat="server" id="date_receivedLabel" Text="Date Received">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_received" Columns="20" MaxLength="30" cssclass="field_input" tabindex="17"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="date_receivedCalendarExtender" TargetControlID="date_received" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_receivedTextBoxMaxLengthValidator" ControlToValidate="date_received" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Received&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="make_idLabel" Text="Make">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="make_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="2"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="received_from_contact_idLabel" Text="Received From Contact">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="received_from_contact_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="10"></asp:DropDownList></span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="model_idLabel" Text="Model">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="model_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="3"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="customer_einLabel" Text="Customer EIN">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="customer_ein" Columns="15" MaxLength="15" cssclass="field_input" tabindex="11"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="customer_einTextBoxMaxLengthValidator" ControlToValidate="customer_ein" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer EIN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="serial_numberLabel" Text="Serial Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="serial_number" Columns="40" MaxLength="50" cssclass="field_input" tabindex="4"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="serial_numberTextBoxMaxLengthValidator" ControlToValidate="serial_number" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Serial Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="doc_numLabel" Text="Document Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="doc_num" Columns="25" MaxLength="25" cssclass="field_input" tabindex="14"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="doc_numTextBoxMaxLengthValidator" ControlToValidate="doc_num" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="category_idLabel" Text="Category">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="new_category_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="other_id_numLabel" Text="EvaluateFormula(&quot;= \&quot;Cust. Asset#\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="other_id_num" Columns="25" MaxLength="25" cssclass="field_input" tabindex="15"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="other_id_numTextBoxMaxLengthValidator" ControlToValidate="other_id_num" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Cust. Asset#\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_type_idLabel" Text="Equipment Type">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="equipment_type_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="6"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_phiLabel" Text="Equipment PHI">	</asp:Literal></td><td class="tableCellValue"><asp:CheckBox runat="server" id="equipment_phi" tabindex="12"></asp:CheckBox> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="condition_idLabel" Text="Condition">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="condition_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="7"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="require_accessoriesLabel" Text="Require Accessories">	</asp:Literal></td><td class="tableCellValue"><asp:CheckBox runat="server" id="require_accessories" tabindex="13"></asp:CheckBox> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="disposition_idLabel" Text="Disposition">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="disposition_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" tabindex="8"></asp:DropDownList></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="equipment_inventory_old" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="equipment_inventory_oldTextBoxMaxLengthValidator" ControlToValidate="equipment_inventory_old" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Equipment Inventory Old&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="descriptionLabel" Text="Description">	</asp:Literal></td><td class="tableCellValue" colspan="5"><asp:TextBox runat="server" id="description" MaxLength="750" columns="120" cssclass="field_input" rows="3" tabindex="20" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="descriptionTextBoxMaxLengthValidator" ControlToValidate="description" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="repair_notesLabel" Text="Repair Notes">	</asp:Literal></td><td class="tableCellValue" colspan="5"><asp:TextBox runat="server" id="repair_notes" MaxLength="1000" columns="120" cssclass="field_input" rows="3" tabindex="21" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="repair_notesTextBoxMaxLengthValidator" ControlToValidate="repair_notes" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Repair Notes&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic1Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-1\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic1" cssclass="field_input" size="60" tabindex="22"></asp:FileUpload></td><td class="tableCellValue"><asp:Image runat="server" id="equipment_inventory_pic" height="150px" size="60" width="150px" style="max-width:250px;margin:5px;"></asp:Image></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic2Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-2\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic2" cssclass="field_input" size="60" tabindex="23"></asp:FileUpload></td><td class="tableCellValue"><asp:Image runat="server" id="equipment_inventory_pic4" imageheight="150" imagewidth="150" size="60" style="max-width:250px;margin:5px;"></asp:Image></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic3Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-3\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic3" cssclass="field_input" size="60" tabindex="24"></asp:FileUpload></td><td class="tableCellValue"><asp:Image runat="server" id="equipment_inventory_pic5" height="150px" size="60" width="150px" style="max-width:250px;margin:5px;"></asp:Image></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic4Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-4\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic41" cssclass="field_input" size="60"></asp:FileUpload></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic5Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-5\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic51" cssclass="field_input" size="60"></asp:FileUpload></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic6Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-6\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic6" cssclass="field_input" size="60"></asp:FileUpload></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic7Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-7\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic7" cssclass="field_input" size="60"></asp:FileUpload></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic8Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-8\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic8" cssclass="field_input" size="60"></asp:FileUpload> 
</td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic9Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-9\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic9" cssclass="field_input" size="60"></asp:FileUpload></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic10Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-10\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:FileUpload runat="server" id="equipment_inventory_pic10" cssclass="field_input" size="60"></asp:FileUpload></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="datetime_added" Columns="20" MaxLength="30" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="datetime_addedCalendarExtender" TargetControlID="datetime_added" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="datetime_addedTextBoxMaxLengthValidator" ControlToValidate="datetime_added" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date And Time Added&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="technician_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:Max_customerRecordControl runat="server" id="Max_customerRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion8" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Max_customerRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
</td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Equipment_inventoryRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Equipment_inventoryRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" postback="True"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="Button4" button-causesvalidation="False" button-commandname="Redirect" button-text="MyButton" button-tooltip="MyButton" button-visible="False"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                