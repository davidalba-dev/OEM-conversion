<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Edit-Equipment-inventory-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Edit_Equipment_inventory_Mobile" %>
<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Edit_Equipment_inventory_Mobile" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:Equipment_inventoryRecordControl runat="server" id="Equipment_inventoryRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;&lt;span class=&#39;mobileFontAdjust90&#39;>&quot;, GetResourceValue(&quot;Title:Edit&quot;),&quot;&quot;,&quot;  Equipment Inventory&quot;, &quot;&lt;/span>&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions"></td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="SaveButton" causesvalidation="True" commandname="UpdateData" imageurl="../Images/MobileButtonSave.png" text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="Equipment_inventoryRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="received_from_customer_idLabel" Text="Received From Customer">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="received_from_customer_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>&nbsp;
<asp:RequiredFieldValidator runat="server" id="received_from_customer_idRequiredFieldValidator" ControlToValidate="received_from_customer_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Received From Customer&quot;) %>" enabled="True" initialvalue="--PLEASE_SELECT--" text="*"></asp:RequiredFieldValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="condition_idLabel" Text="Condition">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="condition_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="received_from_contact_idLabel" Text="Received From Contact">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="received_from_contact_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList> </td></tr><tr><td class="mobileFieldLabelOnTop"></td></tr><tr><td class="mobileFieldValueOnBottom"> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="disposition_idLabel" Text="Disposition">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="disposition_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="sale_method_idLabel" Text="Sale Method">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="sale_method_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="sold_from_idLabel" Text="Sold From">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="sold_from_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="warehouse_idLabel" Text="Warehouse">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="warehouse_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="warehouse_location_idLabel" Text="Warehouse Location">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:DropDownList runat="server" id="warehouse_location_id" cssclass="mobileFilterInput" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="date_disposedLabel" Text="Date Disposed">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_disposed" Columns="20" MaxLength="30" cssclass="mobileFieldInput"></asp:TextBox></td>
<td style="padding-right: 5px">
<asp:ImageButton runat="server" ID="date_disposedPopupButton" ImageUrl="../Images/MobileCalendar.png" CausesValidation="false">
</asp:ImageButton><Selectors:CalendarExtendarClass runat="server" ID="date_disposedCalendarExtender" TargetControlID="date_disposed" CssClass="MyCalendarMobile" OnClientShown="mobileCalendarShown" PopupPosition="BottomLeft" PopupButtonID="date_disposedPopupButton" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_disposedTextBoxMaxLengthValidator" ControlToValidate="date_disposed" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Disposed&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="date_receivedLabel" Text="Date Received">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_received" Columns="20" MaxLength="30" cssclass="mobileFieldInput"></asp:TextBox></td>
<td style="padding-right: 5px">
<asp:ImageButton runat="server" ID="date_receivedPopupButton" ImageUrl="../Images/MobileCalendar.png" CausesValidation="false">
</asp:ImageButton><Selectors:CalendarExtendarClass runat="server" ID="date_receivedCalendarExtender" TargetControlID="date_received" CssClass="MyCalendarMobile" OnClientShown="mobileCalendarShown" PopupPosition="BottomLeft" PopupButtonID="date_receivedPopupButton" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_receivedTextBoxMaxLengthValidator" ControlToValidate="date_received" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Received&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="date_soldLabel" Text="Date Sold">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="date_sold" Columns="20" MaxLength="30" cssclass="mobileFieldInput"></asp:TextBox></td>
<td style="padding-right: 5px">
<asp:ImageButton runat="server" ID="date_soldPopupButton" ImageUrl="../Images/MobileCalendar.png" CausesValidation="false">
</asp:ImageButton><Selectors:CalendarExtendarClass runat="server" ID="date_soldCalendarExtender" TargetControlID="date_sold" CssClass="MyCalendarMobile" OnClientShown="mobileCalendarShown" PopupPosition="BottomLeft" PopupButtonID="date_soldPopupButton" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="date_soldTextBoxMaxLengthValidator" ControlToValidate="date_sold" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date Sold&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="pd_dateLabel" Text="PD Date">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="pd_date" Columns="20" MaxLength="30" cssclass="mobileFieldInput"></asp:TextBox></td>
<td style="padding-right: 5px">
<asp:ImageButton runat="server" ID="pd_datePopupButton" ImageUrl="../Images/MobileCalendar.png" CausesValidation="false">
</asp:ImageButton><Selectors:CalendarExtendarClass runat="server" ID="pd_dateCalendarExtender" TargetControlID="pd_date" CssClass="MyCalendarMobile" OnClientShown="mobileCalendarShown" PopupPosition="BottomLeft" PopupButtonID="pd_datePopupButton" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pd_dateTextBoxMaxLengthValidator" ControlToValidate="pd_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;PD Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="equipment_phiLabel" Text="Equipment PHI">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:CheckBox runat="server" id="equipment_phi" cssclass="mobileCheckbox"></asp:CheckBox> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="require_accessoriesLabel" Text="Require Accessories">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:CheckBox runat="server" id="require_accessories" cssclass="mobileCheckbox"></asp:CheckBox> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="cogsLabel" Text="Cogs">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="cogs" Columns="20" MaxLength="31" cssclass="mobileFieldInput"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="cogsTextBoxMaxLengthValidator" ControlToValidate="cogs" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Cogs&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="final_sale_priceLabel" Text="Final Sale Price">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="final_sale_price" Columns="20" MaxLength="31" cssclass="mobileFieldInput"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="final_sale_priceTextBoxMaxLengthValidator" ControlToValidate="final_sale_price" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Final Sale Price&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="proposed_sale_priceLabel" Text="Proposed Sale Price">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="proposed_sale_price" Columns="20" MaxLength="31" cssclass="mobileFieldInput"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="proposed_sale_priceTextBoxMaxLengthValidator" ControlToValidate="proposed_sale_price" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Proposed Sale Price&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="purchase_priceLabel" Text="Purchase Price">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="purchase_price" Columns="20" MaxLength="31" cssclass="mobileFieldInput"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="purchase_priceTextBoxMaxLengthValidator" ControlToValidate="purchase_price" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Purchase Price&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="category_idLabel" Text="Category">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="category_id" Columns="20" MaxLength="50" cssclass="mobileFieldInput"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="category_idTextBoxMaxLengthValidator" ControlToValidate="category_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Category&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="inventory_status_idLabel" Text="Inventory Status">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="inventory_status_id" Columns="20" MaxLength="26" cssclass="mobileFieldInput"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="inventory_status_idTextBoxMaxLengthValidator" ControlToValidate="inventory_status_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Inventory Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="make_idLabel" Text="Make">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="make_id" Columns="20" MaxLength="30" cssclass="mobileFieldInput"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="make_idTextBoxMaxLengthValidator" ControlToValidate="make_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Make&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="model_idLabel" Text="Model">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="model_id" Columns="20" MaxLength="50" cssclass="mobileFieldInput"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="model_idTextBoxMaxLengthValidator" ControlToValidate="model_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Model&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="customer_einLabel" Text="Customer EIN">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="customer_ein" Columns="15" MaxLength="15" cssclass="mobileFieldInput"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="customer_einTextBoxMaxLengthValidator" ControlToValidate="customer_ein" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer EIN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="doc_numLabel" Text="Document Number">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="doc_num" Columns="20" MaxLength="25" cssclass="mobileFieldInput"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="doc_numTextBoxMaxLengthValidator" ControlToValidate="doc_num" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="other_id_numLabel" Text="EvaluateFormula(&quot;= \&quot;Cust. Asset#\&quot;&quot;, true)">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="other_id_num" Columns="20" MaxLength="25" cssclass="mobileFieldInput"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="other_id_numTextBoxMaxLengthValidator" ControlToValidate="other_id_num" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Cust. Asset#\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="serial_numberLabel" Text="Serial Number">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="serial_number" Columns="20" MaxLength="50" cssclass="mobileFieldInput"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="serial_numberTextBoxMaxLengthValidator" ControlToValidate="serial_number" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Serial Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="descriptionLabel" Text="Description">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:TextBox runat="server" id="description" MaxLength="750" columns="20" cssclass="mobileFieldInput" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="descriptionTextBoxMaxLengthValidator" ControlToValidate="description" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="repair_notesLabel" Text="Repair Notes">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><asp:TextBox runat="server" id="repair_notes" MaxLength="1000" columns="20" cssclass="mobileFieldInput" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="repair_notesTextBoxMaxLengthValidator" ControlToValidate="repair_notes" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Repair Notes&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Equipment_inventoryRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Equipment_inventoryRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>
      
    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                