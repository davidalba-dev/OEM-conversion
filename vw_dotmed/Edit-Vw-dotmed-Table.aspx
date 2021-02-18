<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Edit-Vw-dotmed-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Edit_Vw_dotmed_Table" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Edit_Vw_dotmed_Table" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="OEMConversion" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><OEMConversion:Dotmed_processTableControl1 runat="server" id="Dotmed_processTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="vertical-align:middle;"><asp:ImageButton runat="server" id="ImportButton1" causesvalidation="false" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>&nbsp;<asp:Label runat="server" id="Label" Text="Import CSV File">	</asp:Label></td><td class="dht" valign="middle"><asp:Image runat="server" id="Image1" imageurl="../images/step1.png" tooltip="Step 1 Export DotMed">		
	</asp:Image></td><td class="dht" valign="middle"></td><td class="dht" valign="middle"></td><td class="dht" valign="middle"></td></tr><tr><td class="dht" valign="middle" style="vertical-align:middle;" colspan="5">From the Pop-up window scroll to column 29 (Item ID) check the box to import and select "Item" from the drop down.<br>
From the Pop-up window scroll to column 33 (Listing ID) check the box to import and select "Listing" from the drop down.</td></tr><tr><td class="dht" valign="middle" style="vertical-align:middle;"><OEMConversion:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="Move to Next Step" button-tooltip="Move to Next Step" visible="False"></OEMConversion:ThemeButton></td><td class="dht" valign="middle" style="vertical-align:middle;"></td><td class="dht" valign="middle" style="vertical-align:middle;"></td><td class="dht" valign="middle" style="vertical-align:middle;"></td><td class="dht" valign="middle" style="vertical-align:middle;"></td></tr></table>
</td><td class="dhb"></td><td class="dher"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Dotmed_processTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="2" style="display:none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="Dotmed_processTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:Dotmed_processTableControl1Row runat="server" id="Dotmed_processTableControl1Row">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" colspan="2">
                                  <asp:ImageButton runat="server" id="EditRowButton2" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                                                   
                                </td><td class="tableCellLabel"><asp:Literal runat="server" id="item_idLabel" Text="Item">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="item_id"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="listing_idLabel2" Text="Listing">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="listing_id2"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8"></td></tr></OEMConversion:Dotmed_processTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Dotmed_processTableControl1_PostbackTracker" runat="server" />
</OEMConversion:Dotmed_processTableControl1>
</td></tr><tr><td><OEMConversion:Equipment_inventory_dotmedTableControl runat="server" id="Equipment_inventory_dotmedTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Equipment_inventory_dotmedTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="1" style="display:none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="Equipment_inventory_dotmedTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Equipment_inventory_dotmedTableControlRow runat="server" id="Equipment_inventory_dotmedTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;">
                                                                   
                                <OEMConversion:ThemeButton runat="server" id="Button1" button-causesvalidation="False" button-commandname="Redirect" button-text="MOVE TO THE NEXT STEP" button-tooltip="MOVE TO THE NEXT STEP"></OEMConversion:ThemeButton></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="5"></td></tr></OEMConversion:Equipment_inventory_dotmedTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Equipment_inventory_dotmedTableControl_PostbackTracker" runat="server" />
</OEMConversion:Equipment_inventory_dotmedTableControl>
</td></tr><tr><td>
                        <OEMConversion:Vw_dotmedTableControl runat="server" id="Vw_dotmedTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="DotMed Active Listing Items">	</asp:Literal>
                      </td></tr></table>
</td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_dotmedTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="1"></th><th class="thc"><asp:Literal runat="server" id="oem_einLabel" Text="OEM EIN">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="new_category_idLabel" tooltip="Sort by new_category_id" Text="Category" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="make_idLabel" tooltip="Sort by make_id" Text="EvaluateFormula(&quot;= \&quot;System Mfg\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="condition_idLabel" tooltip="Sort by condition_id" Text="Condition" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="descriptionLabel" tooltip="Sort by description" Text="EvaluateFormula(&quot;= \&quot;Comments\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th></tr><asp:Repeater runat="server" id="Vw_dotmedTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_dotmedTableControlRow runat="server" id="Vw_dotmedTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;">
                                                                   
                                <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellValue"><asp:Literal runat="server" id="oem_ein"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="new_category_id"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="make_id"></asp:Literal> 
<asp:Literal runat="server" id="model_id"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="condition_id"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="description"></asp:Literal></td><td class="tableCellValue"></td></tr></OEMConversion:Vw_dotmedTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Vw_dotmedTableControl_PostbackTracker" runat="server" />
</OEMConversion:Vw_dotmedTableControl>

            </td></tr><tr><td>
                        <OEMConversion:Vw_dotmedTableControl1 runat="server" id="Vw_dotmedTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="DotMed Remove Listing Items">	</asp:Literal>
                      </td></tr></table>
</td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_dotmedTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="1"></th><th class="thc"><asp:Literal runat="server" id="oem_einLabel1" Text="OEM EIN">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="new_category_idLabel1" tooltip="Sort by new_category_id" Text="Category" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="make_idLabel1" tooltip="Sort by make_id" Text="EvaluateFormula(&quot;= \&quot;System Mfg\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="condition_idLabel1" tooltip="Sort by condition_id" Text="Condition" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="descriptionLabel1" tooltip="Sort by description" Text="EvaluateFormula(&quot;= \&quot;Comments\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="Vw_dotmedTableControl1Repeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_dotmedTableControl1Row runat="server" id="Vw_dotmedTableControl1Row">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;">
                                                                   
                                <asp:ImageButton runat="server" id="EditRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellValue"><asp:Literal runat="server" id="oem_ein1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="new_category_id1"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="make_id1"></asp:Literal> 
<asp:Literal runat="server" id="model_id1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="condition_id1"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="description1"></asp:Literal></td><td class="tableCellValue"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="dotmed_processed" Columns="5" MaxLength="5" checkedvalue="Yes" cssclass="field_input" uncheckedvalue="No" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="dotmed_processedTextBoxMaxLengthValidator" ControlToValidate="dotmed_processed" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Dotmed Processed&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr></OEMConversion:Vw_dotmedTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <OEMConversion:PaginationModern runat="server" id="Pagination1"></OEMConversion:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Vw_dotmedTableControl1_PostbackTracker" runat="server" />
</OEMConversion:Vw_dotmedTableControl1>

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
                