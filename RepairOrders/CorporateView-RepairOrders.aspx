<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.CorporateView_RepairOrders" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="CorporateView-RepairOrders.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.CorporateView_RepairOrders" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Title" Text="Repair Order Details">	</asp:Literal>-<span style="white-space:nowrap;">
<asp:Literal runat="server" id="RONo1"></asp:Literal></span>
</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="RepairOrdersRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROWorkDoneNotesLabel" Text="EvaluateFormula(&quot;= \&quot;Work Done Notes\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROWorkDoneNotes"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="ROReference1Label" Text="EvaluateFormula(&quot;= \&quot;PO#\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference1"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROStatusLabel" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROStatus"></asp:Literal></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="ROReference2Label" Text="EvaluateFormula(&quot;= \&quot;Dept\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference2"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROReference3Label" Text="EvaluateFormula(&quot;= \&quot;Case/Box\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROReference3"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="ROReference4Label" Text="EvaluateFormula(&quot;= \&quot;Approved By\&quot;&quot;, true)">	</asp:Literal></td><td style="white-space: nowrap"><asp:Literal runat="server" id="ROReference4"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROMakeLabel" Text="EvaluateFormula(&quot;= \&quot;Make\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROMake"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="ROConditionLabel" Text="EvaluateFormula(&quot;= \&quot;Condition\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROCondition"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROModelLabel" Text="EvaluateFormula(&quot;= \&quot;Model\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROModel"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="ROFaultCodesLabel" Text="EvaluateFormula(&quot;= \&quot;Fault Code\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROFaultCodes"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROCategoryLabel" Text="EvaluateFormula(&quot;= \&quot;Category\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="category_id"></asp:Literal></td><td class="tableCellLabel" rowspan="2" colspan="2"><asp:Image runat="server" id="SignatureImage" size="60" style="max-width:250px;margin:5px;"></asp:Image></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROSerialNoLabel" Text="EvaluateFormula(&quot;= \&quot;Serial Number\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROSerialNo"></asp:Literal></td></tr><tr><td class="tableCellLabel" colspan="4"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<BaseClasses:TabContainer runat="server" id="RepairOrdersRecordControlTabContainer" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Customer Details">	<ContentTemplate> 
  <OEMConversion:CustomersRecordControl runat="server" id="CustomersRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="Customer Details">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="CustomersRecordControlPanel" runat="server"><table><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustNoLabel" Text="EvaluateFormula(&quot;= \&quot;Facility #\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CustNo"></asp:Literal></span>
</td><td class="dfv" style="white-space:nowrap;" colspan="2"><asp:Literal runat="server" id="CustName"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustAddress1Label" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustAddress1"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="CustPhoneBusinessLabel" Text="EvaluateFormula(&quot;= \&quot;Phone Business\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustPhoneBusiness"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustAddress2Label" Text="EvaluateFormula(&quot;= \&quot;Address 2\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustAddress2"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="CustFaxLabel" Text="EvaluateFormula(&quot;= \&quot;Fax\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustFax"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustCityLabel" Text="EvaluateFormula(&quot;= \&quot;City\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustCity"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="CustShipViaLabel" Text="EvaluateFormula(&quot;= \&quot;Ship Via\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustShipVia"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustProvinceLabel" Text="EvaluateFormula(&quot;= \&quot;State\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustProvince"></asp:Literal></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustPostalCodeLabel" Text="EvaluateFormula(&quot;= \&quot;Zip Code\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustPostalCode"></asp:Literal></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="CustomersRecordControl_PostbackTracker" runat="server" />
</OEMConversion:CustomersRecordControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Contact Details">	<ContentTemplate> 
  <OEMConversion:CustomerContactsRecordControl runat="server" id="CustomerContactsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title9" Text="Customer Contact">	</asp:Literal>
                      </td><td class="dhir"></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion9" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="CustomerContactsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustContactNameLabel" Text="EvaluateFormula(&quot;= \&quot;Contact Name\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustContactName"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustContactPhoneBusinessLabel" Text="EvaluateFormula(&quot;= \&quot;Phone\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustContactPhoneBusiness"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustContactTitleLabel" Text="EvaluateFormula(&quot;= \&quot;Title\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustContactTitle"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustContactPhoneMobileLabel" Text="EvaluateFormula(&quot;= \&quot;Mobile\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustContactPhoneMobile"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustContactEmailLabel" Text="EvaluateFormula(&quot;= \&quot;Email\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustContactEmail"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustContactFaxLabel" Text="EvaluateFormula(&quot;= \&quot;Contact Fax\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustContactFax"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="CustomerContactsRecordControl_PostbackTracker" runat="server" />
</OEMConversion:CustomerContactsRecordControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
  
 <BaseClasses:TabPanel runat="server" id="Accessories" HeaderText="Common Accessories">	<ContentTemplate> 
  <OEMConversion:AccessoriesRecordControl runat="server" id="AccessoriesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title4" Text="Common Accessories">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="AccessoriesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory5Label1" Text="EvaluateFormula(&quot;= \&quot;Battery Light Source\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory51"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory6Label1" Text="EvaluateFormula(&quot;= \&quot;Forcep\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory61"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory1Label1" Text="EvaluateFormula(&quot;= \&quot;Box\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory11"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory4Label1" Text="EvaluateFormula(&quot;= \&quot;Light Cable\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory41"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory8Label1" Text="EvaluateFormula(&quot;= \&quot;Brush\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory81"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory3Label1" Text="EvaluateFormula(&quot;= \&quot;Valves\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory31"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory0Label1" Text="EvaluateFormula(&quot;= \&quot;Case\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory01"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory2Label1" Text="EvaluateFormula(&quot;= \&quot;Water Cap\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory21"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROAccessory7Label1" Text="EvaluateFormula(&quot;= \&quot;Cleaning Adapter\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROAccessory71"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="AccessoriesRecordControl_PostbackTracker" runat="server" />
</OEMConversion:AccessoriesRecordControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 

<BaseClasses:TabPanel runat="server" id="TabPanel4" HeaderText="Warranty">	<ContentTemplate> 
  <OEMConversion:RepairOrdersRecordControl2 runat="server" id="RepairOrdersRecordControl2">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title11" Text="Warranty Details">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion11" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="RepairOrdersRecordControl2Panel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROUnderWarrantyLabel1" Text="EvaluateFormula(&quot;= \&quot;Under Warranty\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROUnderWarranty1"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROWarrantyLabel1" Text="EvaluateFormula(&quot;= \&quot;Warranty Term\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROWarranty1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROWarrantyPlanLabel1" Text="EvaluateFormula(&quot;= \&quot;Warranty Plan\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROWarrantyPlan1"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RepairOrdersRecordControl2_PostbackTracker" runat="server" />
</OEMConversion:RepairOrdersRecordControl2>
 
</ContentTemplate></BaseClasses:TabPanel> 
  
<BaseClasses:TabPanel runat="server" id="TabPanel6" HeaderText="Est/Repair">	<ContentTemplate> 
  <OEMConversion:RepairOrdersRecordControl1 runat="server" id="RepairOrdersRecordControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title13" Text="Repair Details">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion6" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="RepairOrdersRecordControl1Panel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROEstimatedByLabel" Text="Estimated By">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROEstimatedBy1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROWorkDoneNotesLabel2" Text="EvaluateFormula(&quot;= \&quot;Work Done Notes\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue" rowspan="7"><asp:Literal runat="server" id="ROWorkDoneNotes2"></asp:Literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimateCompletedLabel1" Text="Date Est. Prepared">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimateCompleted1"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimateSentLabel1" Text="Date Est. Sent">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimateSent1"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimateApprovedLabel1" Text="Date Est. Approved">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimateApproved1"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ROHowApprovedLabel1" Text="How Approved">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROHowApproved1"></asp:Literal></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RODateEstimatedCompletionLabel1" Text="Est. Completion Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateEstimatedCompletion1"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RODateRepairCompletedLabel1" Text="Repair Completed">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateRepairCompleted1"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="RODateReturnedLabel1" Text="Date Returned">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RODateReturned1"></asp:Literal></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RepairOrdersRecordControl1_PostbackTracker" runat="server" />
</OEMConversion:RepairOrdersRecordControl1>
 
</ContentTemplate></BaseClasses:TabPanel> 
<BaseClasses:TabPanel runat="server" id="TabPanel7" HeaderText="Details">	<ContentTemplate> 
 <OEMConversion:RODetailsTableControl runat="server" id="RODetailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dht"><asp:Literal runat="server" id="Title5" Text="Inventory Items">	</asp:Literal></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="RODetailsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb">&nbsp;</th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROPartNoLabel1" Text="EvaluateFormula(&quot;= \&quot;Part Number\&quot;&quot;, true)">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROItemDescLabel1" Text="EvaluateFormula(&quot;= \&quot;Item Description\&quot;&quot;, true)">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROQuantityLabel1" Text="EvaluateFormula(&quot;= \&quot;Quantity\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="ROSellPriceLabel1" Text="EvaluateFormula(&quot;= \&quot;Sell Price\&quot;&quot;, true)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="RODetailsTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:RODetailsTableControlRow runat="server" id="RODetailsTableControlRow">
<tr><td class="tableRowButtonsCellVertical"></td><td class="tableCellValue"><asp:Literal runat="server" id="ROPartNo1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROItemDesc1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROQuantity1"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROSellPrice1"></asp:Literal></span>
</td></tr></OEMConversion:RODetailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RODetailsTableControl_PostbackTracker" runat="server" />
</OEMConversion:RODetailsTableControl>

<OEMConversion:RODetailsTableControl1 runat="server" id="RODetailsTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dht"><img src="../Images/space.gif" alt="" /> 
<asp:Literal runat="server" id="Title3" Text="Service Codes">	</asp:Literal></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion5" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="RODetailsTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb">&nbsp;</th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROPartNoLabel" Text="EvaluateFormula(&quot;= \&quot;Part Number\&quot;&quot;, true)">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROItemDescLabel" Text="EvaluateFormula(&quot;= \&quot;Item Description\&quot;&quot;, true)">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROQuantityLabel" Text="EvaluateFormula(&quot;= \&quot;Quantity\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="ROSellPriceLabel" Text="EvaluateFormula(&quot;= \&quot;Sell Price\&quot;&quot;, true)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="RODetailsTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:RODetailsTableControl1Row runat="server" id="RODetailsTableControl1Row">
<tr><td class="tableRowButtonsCellVertical"></td><td class="tableCellValue"><asp:Literal runat="server" id="ROPartNo"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROItemDesc"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROQuantity"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROSellPrice"></asp:Literal></span>
</td></tr></OEMConversion:RODetailsTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination1"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RODetailsTableControl1_PostbackTracker" runat="server" />
</OEMConversion:RODetailsTableControl1>
 
<OEMConversion:RODetailsTableControl2 runat="server" id="RODetailsTableControl2" visible="false">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dht"><img src="../Images/space.gif" alt="" /> 
<asp:Literal runat="server" id="Title2" Text="Service Codes">	</asp:Literal></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="RODetailsTableControl2Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb">&nbsp;</th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROPartNoLabel2" Text="EvaluateFormula(&quot;= \&quot;Part Number\&quot;&quot;, true)">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROItemDescLabel2" Text="EvaluateFormula(&quot;= \&quot;Item Description\&quot;&quot;, true)">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="ROQuantityLabel2" Text="EvaluateFormula(&quot;= \&quot;Quantity\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="ROSellPriceLabel2" Text="EvaluateFormula(&quot;= \&quot;Sell Price\&quot;&quot;, true)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="RODetailsTableControl2Repeater">		<ITEMTEMPLATE>		<OEMConversion:RODetailsTableControl2Row runat="server" id="RODetailsTableControl2Row">
<tr><td class="tableRowButtonsCellVertical"></td><td class="tableCellValue"><asp:Literal runat="server" id="ROPartNo2"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROItemDesc2"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROQuantity2"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ROSellPrice2"></asp:Literal></span>
</td></tr></OEMConversion:RODetailsTableControl2Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination2"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="RODetailsTableControl2_PostbackTracker" runat="server" />
</OEMConversion:RODetailsTableControl2>
 
 </ContentTemplate></BaseClasses:TabPanel> 

 
  
</BaseClasses:TabContainer><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table></asp:panel>
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
</td></tr><tr><td></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><OEMConversion:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;OEMConversion&quot;) %>" postback="True"></OEMConversion:ThemeButton></td><td><OEMConversion:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;OEMConversion&quot;) %>" postback="False"></OEMConversion:ThemeButton></td></tr></table>
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
                