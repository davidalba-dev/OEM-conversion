<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Corp-Add-Repair-order-request.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Corp_Add_Repair_order_request" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Corp_Add_Repair_order_request" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

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

                        <OEMConversion:Repair_order_requestRecordControl runat="server" id="Repair_order_requestRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Repair Order Request&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Repair_order_requestRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel" colspan="4" style="text-align:left;"><span style="font-size:12pt;color:Navy"><i><asp:label id="Label1" runat="server" text="If your Make, Model or Serial Number are not visible in the dropdown selections please enter the details in the Repair Request Notes field"></asp:label></i></span></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="custnoLabel" Text="Customer">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="custno" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="serialnoLabel" Text="Serial No.">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="serialno" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="corporatecontact_idLabel" Text="Requestor">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="corporatecontact_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="makeLabel" Text="Make">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="make" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"><asp:Label runat="server" id="cust_dept_idLabel" Text="Customer Department">	</asp:Label></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="cust_dept_id" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="modelLabel" Text="Model">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="model" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="clean_statusLabel" Text="Scope Status">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="clean_status" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="request_methodLabel" Text="Request Method">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="request_method" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="repair_request_poLabel" Text="Repair Request PO">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="repair_request_po" Columns="25" MaxLength="25" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="repair_request_poTextBoxMaxLengthValidator" ControlToValidate="repair_request_po" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Repair Request PO&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"><asp:Literal runat="server" id="corp_name" visible="False"></asp:Literal></td></tr><tr><td class="tableCellLabel" style="vertical-align:top;"><asp:Literal runat="server" id="repair_request_notesLabel" Text="Repair Request Notes">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:TextBox runat="server" id="repair_request_notes" MaxLength="500" columns="120" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="repair_request_notesTextBoxMaxLengthValidator" ControlToValidate="repair_request_notes" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Repair Request Notes&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="tableCellLabel" colspan="4"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:LoginRecordControl runat="server" id="LoginRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="LoginRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td></td><td class="tableCellValue"><asp:Literal runat="server" id="user_email" visible="False"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="LoginRecordControl_PostbackTracker" runat="server" />
</OEMConversion:LoginRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Repair_order_requestRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Repair_order_requestRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-redirectargument="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" postback="True" sendemail1cc="kplante%40oemmed.com++%3ckplante%40oemmed.com%3e" sendemail1content="The+following+Repair+Request+form+has+been+submitted+by+a+Corporate+Contact%3a%0d%0a%0d%0aCustomer%3a++%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3acustno%7d%0d%0aDept%3a%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3acust_dept_id%7d%0d%0aRequest+Method%3a%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3arequest_method%7d%0d%0aSerial+Num%3a+%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3aserialno%7d%0d%0aCorp+Requestor%3a+%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3acorporatecontact_id%7d%0d%0aMake%3a%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3amake%7d%0d%0aModel%3a%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3amodel%7d%0d%0aNotes%3a+%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3arepair_request_notes%7d%0d%0aStatus%3a+%7bRepair_order_requestRecordControl%3aNoUrlEncode%3aFDV%3aclean_status%7d" sendemail1forrecord="Current" sendemail1from="OEMInfo%40oemmed.com" sendemail1subject="OEM+Medical+Solutions+-+Repair+Request+Form+(Corporate-Form)" sendemail1to="oeminfo%40oemmed.com++%3coeminfo%40oemmed.com%3e" sendemail2content="Thank+you+we+have+received+your+Repair+Order+Request+and+will+begin+processing+your+request.%0d%0a%0d%0aIf+you+have+any+questions+please+contact+us+oeminfo%40oemmed.com+or+(410)+321-4260%0d%0a%0d%0aYou+may+track+the+status+and+updates+to+your+Repair+Order+Request+online+at+http%3a%2f%2fexpertech.oemmed.com" sendemail2forrecord="Current" sendemail2from="OEMInfo%40oemmed.com" sendemail2subject="OEM+MED-+Repair+Order+Request" sendemail2to="%7bLoginRecordControl%3aNoUrlEncode%3aFV%3auser_email%7d+%3c%7bLoginRecordControl%3aNoUrlEncode%3aFV%3auser_email%7d%3e"></OEMConversion:ThemeButton></td><td></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                