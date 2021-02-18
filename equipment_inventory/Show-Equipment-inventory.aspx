<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Equipment-inventory.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_Equipment_inventory" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Equipment_inventory" %>
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
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Equipment Inventory&quot;) %>">	</asp:Literal>
                      </td><td class="dhir">
                  <asp:ImageButton runat="server" id="DialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" onmouseout="this.src=&#39;../Images/iconEdit.gif&#39;" onmouseover="this.src=&#39;../Images/iconEditOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Equipment_inventoryRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="received_from_customer_idLabel" Text="Received From Customer">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="received_from_customer_id"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="warehouse_idLabel" Text="Warehouse">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="warehouse_id"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="other_id_numLabel" Text="EvaluateFormula(&quot;= \&quot;Cust. Asset#\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="other_id_num"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="received_from_contact_idLabel" Text="Received From Contact">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="received_from_contact_id"></asp:Literal></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="warehouse_location_idLabel" Text="Warehouse Location">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="warehouse_location_id"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="sale_method_idLabel" Text="Sale Method">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="sale_method_id"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="serial_numberLabel" Text="Serial Number">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="serial_number"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_phiLabel" Text="Equipment PHI">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="equipment_phi"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="sold_from_idLabel" Text="Sold From">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="sold_from_id"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="condition_idLabel" Text="Condition">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="condition_id"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="require_accessoriesLabel" Text="Require Accessories">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="require_accessories"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="customer_einLabel" Text="Customer EIN">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="customer_ein"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="disposition_idLabel" Text="Disposition">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="disposition_id"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="doc_numLabel" Text="Document Number">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="doc_num"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="purchase_priceLabel" Text="Purchase Price">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="purchase_price"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="make_idLabel" Text="Make">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="make_id"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="date_disposedLabel" Text="Date Disposed">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_disposed"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="proposed_sale_priceLabel" Text="Proposed Sale Price">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="proposed_sale_price"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="model_idLabel" Text="Model">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="model_id"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="date_receivedLabel" Text="Date Received">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_received"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="final_sale_priceLabel" Text="Final Sale Price">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="final_sale_price"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="category_idLabel" Text="Category">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="new_category_id"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="date_soldLabel" Text="Date Sold">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="date_sold"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="cogsLabel" Text="Cogs">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="cogs"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="pd_dateLabel" Text="PD Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="pd_date"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="descriptionLabel" Text="Description">	</asp:Literal></td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="description"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="repair_notesLabel" Text="Repair Notes">	</asp:Literal></td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="repair_notes"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic1Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-1\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Image runat="server" id="equipment_inventory_pic" height="150px" size="60" width="150px" style="max-width:250px;margin:5px;"></asp:Image></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic2Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-2\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Image runat="server" id="equipment_inventory_pic4" imageheight="150" imagewidth="150" size="60" style="max-width:250px;margin:5px;"></asp:Image></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="equipment_inventory_pic3Label" Text="EvaluateFormula(&quot;= \&quot;Equip. Pic-3\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Image runat="server" id="equipment_inventory_pic5" height="150px" size="60" width="150px" style="max-width:250px;margin:5px;"></asp:Image></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="datetime_addedLabel" Text="Date/Time Added">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="datetime_added"></asp:Literal></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="technician_idLabel1" Text="Add By">	</asp:Literal></td><td class="tableCellValue"><asp:Label runat="server" id="technician_id"></asp:Label></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr></table></asp:panel>

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
</td></tr><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<BaseClasses:TabContainer runat="server" id="Equipment_inventoryTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="CustomersTabPanel" HeaderText="Received From Customer">	<ContentTemplate>
  <OEMConversion:CustomersRecordControl runat="server" id="CustomersRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="CustomersRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustNameLabel" Text="EvaluateFormula(&quot;= \&quot;Facility Name\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustName"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustAddress1Label" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustAddress1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustNoLabel" Text="EvaluateFormula(&quot;= \&quot;Facility #\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CustNo"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="corporate_idLabel" Text="Corporate">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="corporate_id"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustAddress2Label" Text="EvaluateFormula(&quot;= \&quot;Address 2\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustAddress2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="customer_activeLabel" Text="EvaluateFormula(&quot;= \&quot;Active\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="customer_active"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustPhoneBusinessLabel" Text="EvaluateFormula(&quot;= \&quot;Phone Business\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustPhoneBusiness"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustCityLabel" Text="EvaluateFormula(&quot;= \&quot;City\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustCity"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustCodeLabel" Text="Customer Code">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustCode"></asp:Literal> </td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="CustomersRecordControl_PostbackTracker" runat="server" />
</OEMConversion:CustomersRecordControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="EditButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                