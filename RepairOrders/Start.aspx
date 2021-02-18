<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Start" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Start.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Start" %>
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

	<meta http-equiv="refresh" content="120"><table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td colspan="2"><span style="color:Navy;font-size:14pt"><b><asp:label id="Label" runat="server" text="Welcome to Expertech"></asp:label></b></span></td></tr><tr><td></td><td></td></tr><tr><td style="vertical-align:top;"><OEMConversion:Repairorder_dashboardTableControl runat="server" id="Repairorder_dashboardTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title" Text="Repair Order Dashboard">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"></td></tr><tr><td class="tre"><table id="Repairorder_dashboardTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="StaCustomCaptionLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="Expr1Label" Text="Count">	</asp:Literal></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="Repairorder_dashboardTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Repairorder_dashboardTableControlRow runat="server" id="Repairorder_dashboardTableControlRow">
<tr><td class="tableCelllable"><asp:Literal runat="server" id="StaCustomCaption"></asp:Literal> </td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Expr1"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="4"></td></tr></OEMConversion:Repairorder_dashboardTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Repairorder_dashboardTableControl_PostbackTracker" runat="server" />
</OEMConversion:Repairorder_dashboardTableControl>
</td><td style="vertical-align:top;"><OEMConversion:Pickup_requestTableControl runat="server" id="Pickup_requestTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Image runat="server" id="Image" imageurl="../images/pickup_icon.png">		
	</asp:Image></td><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title2" Text="&lt;%#String.Concat(&quot;Pickup Requests&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Pickup_requestTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)" class="TFtable"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="pickup_request_idLabel" tooltip="Sort by pickup_request_id" Text="Pickup #" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Literal runat="server" id="pickup_custnoLabel" Text="EvaluateFormula(&quot;= \&quot;Customer\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="pickup_addressLabel" tooltip="Sort by pickup_address" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="pickup_datetimeLabel" tooltip="Sort by pickup_datetime" Text="EvaluateFormula(&quot;= \&quot;Pickup Date-Time\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="pickup_request_type_idLabel" tooltip="Sort by pickup_request_type_id" Text="EvaluateFormula(&quot;= \&quot;Transaction Type\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="pickup_status_idLabel" tooltip="Sort by pickup_status_id" Text="EvaluateFormula(&quot;= \&quot;Status\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Literal runat="server" id="pickup_technicianLabel" Text="EvaluateFormula(&quot;= \&quot;Pickup Resource\&quot;&quot;, true)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Pickup_requestTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Pickup_requestTableControlRow runat="server" id="Pickup_requestTableControlRow">
<tr><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="pickup_request_id" CommandName="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="pickup_custno" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
<br> 
<asp:Literal runat="server" id="pickup_customercontactLabel" Text="EvaluateFormula(&quot;= \&quot;Contact\&quot;&quot;, true)">	</asp:Literal><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="pickup_customercontact" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 <br>
<asp:Literal runat="server" id="pickup_phoneLabel" Text="EvaluateFormula(&quot;= \&quot;Phone\&quot;&quot;, true)">	</asp:Literal><asp:Literal runat="server" id="pickup_phone"></asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="pickup_address"></asp:Literal> <br>
<asp:Literal runat="server" id="pickup_address2"></asp:Literal> <br>
<asp:Literal runat="server" id="pickup_city"></asp:Literal>&nbsp;<asp:Literal runat="server" id="provname"></asp:Literal> &nbsp;<asp:Literal runat="server" id="pickup_zipcode"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="pickup_datetime"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="pickup_request_type_id"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="pickup_status_id"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="pickup_technician" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
</td></tr></OEMConversion:Pickup_requestTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Pickup_requestTableControl_PostbackTracker" runat="server" />
</OEMConversion:Pickup_requestTableControl>
 
<br> 
<OEMConversion:Vw_ticket_detailsTableControl runat="server" id="Vw_ticket_detailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Image runat="server" id="Image3" imageurl="../images/ticketing-icon.png">		
	</asp:Image></td><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title3" Text="&lt;%#String.Concat(&quot;Top 20 Tickets&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle"><OEMConversion:ThemeButton runat="server" id="Button2" button-causesvalidation="False" button-commandname="Redirect" button-text="All Tickets" button-tooltip="All Tickets"></OEMConversion:ThemeButton></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right"></td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_ticket_detailsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="resource_sch_ticket_idLabel2" tooltip="Sort by resource_sch_ticket_id" Text="Ticket #" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="subjectLabel1" tooltip="Sort by subject" Text="Subject" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="custnoLabel2" tooltip="Sort by custno" Text="Custno" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Literal runat="server" id="project_idLabel2" Text="Project">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="technician_idLabel1" Text="Technician" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="resource_sch_status_idLabel" tooltip="Sort by resource_sch_status_id" Text="Status" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Label runat="server" id="ROCategoryLabel" Text="Cat/Make/Model">	</asp:Label></th><th class="thc"><asp:LinkButton runat="server" id="scheduled_dateLabel2" tooltip="Sort by scheduled_date" Text="Scheduled Date" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th></tr><asp:Repeater runat="server" id="Vw_ticket_detailsTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_ticket_detailsTableControlRow runat="server" id="Vw_ticket_detailsTableControlRow">
<tr><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="resource_sch_ticket_id2" CommandName="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="subject1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="custno2" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="project_id2" CommandName="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Label runat="server" id="technician_id1"></asp:Label></span>
 </td><td class="tableCellValue"><asp:Literal runat="server" id="resource_sch_status_id"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROCategory"></asp:Literal> 
<asp:Literal runat="server" id="ROMake"></asp:Literal> 
<asp:Literal runat="server" id="ROModel"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="scheduled_date2"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="9"></td></tr></OEMConversion:Vw_ticket_detailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Vw_ticket_detailsTableControl_PostbackTracker" runat="server" />
</OEMConversion:Vw_ticket_detailsTableControl>
 
<OEMConversion:Vw_ticket_detailsTableControl1 runat="server" id="Vw_ticket_detailsTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Image runat="server" id="Image1" imageurl="../images/ticketing-icon.png">		
	</asp:Image></td><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title4" Text="&lt;%#String.Concat(&quot;My Top 10 Tickets&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle"><OEMConversion:ThemeButton runat="server" id="Button1" button-causesvalidation="False" button-commandname="Redirect" button-text="My Tickets" button-tooltip="My Tickets"></OEMConversion:ThemeButton></td><td class="dht" valign="middle"><asp:ImageButton runat="server" id="ImageButton1" alternatetext="Time Entry" causesvalidation="False" commandname="Redirect" imageurl="../Images/clock-icon.png">		
	</asp:ImageButton></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right"></td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_ticket_detailsTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="resource_sch_ticket_idLabel1" tooltip="Sort by resource_sch_ticket_id" Text="Ticket #" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="subjectLabel" tooltip="Sort by subject" Text="Subject" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="custnoLabel" tooltip="Sort by custno" Text="Custno" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Literal runat="server" id="project_idLabel" Text="Project">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="technician_idLabel" Text="Technician" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="resource_sch_status_idLabel1" tooltip="Sort by resource_sch_status_id" Text="Status" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Label runat="server" id="ROCategoryLabel1" Text="Cat/Make/Model">	</asp:Label></th><th class="thc"><asp:LinkButton runat="server" id="scheduled_dateLabel" tooltip="Sort by scheduled_date" Text="Scheduled Date" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th></tr><asp:Repeater runat="server" id="Vw_ticket_detailsTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_ticket_detailsTableControl1Row runat="server" id="Vw_ticket_detailsTableControl1Row">
<tr><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="resource_sch_ticket_id1" CommandName="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="subject"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="custno" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="project_id" CommandName="Redirect"></asp:LinkButton></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Label runat="server" id="technician_id"></asp:Label></span>
 </td><td class="tableCellValue"><asp:Literal runat="server" id="resource_sch_status_id1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ROCategory1"></asp:Literal> 
<asp:Literal runat="server" id="ROMake1"></asp:Literal> 
<asp:Literal runat="server" id="ROModel1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="scheduled_date"></asp:Literal></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="9"></td></tr></OEMConversion:Vw_ticket_detailsTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Vw_ticket_detailsTableControl1_PostbackTracker" runat="server" />
</OEMConversion:Vw_ticket_detailsTableControl1>
</td></tr></table>
</td></tr></table>
</td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr></table></ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>