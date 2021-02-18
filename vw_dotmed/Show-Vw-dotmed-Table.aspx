<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Vw-dotmed-Table.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="OEMConversion.UI.Show_Vw_dotmed_Table" %>
<%@ Register Tagprefix="OEMConversion" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="OEMConversion" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Vw_dotmed_Table" %>

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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><OEMConversion:Vw_dotmedTableControl runat="server" id="Vw_dotmedTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel" colspan="3"></td><td class="dher"></td></tr><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" colspan="6"><asp:Image runat="server" id="Image" imageurl="../images/step2.png">		
	</asp:Image></td></tr><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(&quot;VW Dotmed&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle"><asp:ImageButton runat="server" id="CSVButton" causesvalidation="false" commandname="ExportData" imageurl="../Images/ButtonBarCSVExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarCSVExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarCSVExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Export&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="dht" valign="middle" colspan="4"><asp:Literal runat="server" id="HTMLText" Text="&lt;b>Export DotMed Data Listing to CSV file for upload to DotMed. Once you have uploaded your data click the data Uploaded button complete below.&lt;/b>">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="false" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="false" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="false" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="CSVButton1" causesvalidation="false" commandname="ExportData" imageurl="../Images/ButtonBarCSVExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarCSVExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarCSVExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Export&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><OEMConversion:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;OEMConversion&quot;) %>"></OEMConversion:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right"></td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_dotmedTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="1"></th><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="inventory_idLabel" Text="EvaluateFormula(&quot;= \&quot;Item ID\&quot;&quot;, true)">	</asp:Literal></th><th class="thc"><asp:LinkButton runat="server" id="dotmed_listing_idLabel" tooltip="Sort by dotmed_listing_id" Text="EvaluateFormula(&quot;= \&quot;Listing ID\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="make_idLabel" tooltip="Sort by make_id" Text="EvaluateFormula(&quot;= \&quot;System Mfg\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="model_idLabel" tooltip="Sort by model_id" Text="EvaluateFormula(&quot;= \&quot;System Model\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="proposed_sale_priceLabel" tooltip="Sort by proposed_sale_price" Text="EvaluateFormula(&quot;= \&quot;Price\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="dotmed_deleteLabel" tooltip="Sort by dotmed_delete" Text="EvaluateFormula(&quot;= \&quot;Delete\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="Vw_dotmedTableControlRepeater">		<ITEMTEMPLATE>		<OEMConversion:Vw_dotmedTableControlRow runat="server" id="Vw_dotmedTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>                                 
                                </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="inventory_id"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_listing_id"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="make_id"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="model_id"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="proposed_sale_price"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="dotmed_delete"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="new_category_id" visible="False"></asp:Literal></span>
 
<asp:Literal runat="server" id="dotmed_part_mfg" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="description" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_part_num" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_part_name" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="condition_id" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_listing_type" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_request_type" visible="False"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="proposed_sale_price1" visible="False"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_d2d_price" visible="False"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_vts_price" visible="False"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_currency" visible="False"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_qty" visible="False"></asp:Literal></span>
 
<asp:Literal runat="server" id="dotmed_paypal" visible="False"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_paypal_shipping" visible="False"></asp:Literal></span>
 
<asp:Literal runat="server" id="dotmed_make_offer" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_auto_accept" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_auto_reject" visible="False"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_weight" visible="False"></asp:Literal></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="dotmed_weight_units" visible="False"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_height" visible="False"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_depth" visible="False"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_width" visible="False"></asp:Literal></span>
 
<asp:Literal runat="server" id="dotmed_will_rent" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_avail_parts" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_item_id_type" visible="False"></asp:Literal> 
<div style="word-break: break-all;">
<asp:Literal runat="server" id="dotmed_youtube_url" visible="False"></asp:Literal></div>
 
<div style="word-break: break-all;">
<asp:Literal runat="server" id="dotmed_video_url" visible="False"></asp:Literal></div>
 
<asp:Literal runat="server" id="dotmed_spec_name1" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_spec_name2" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_spec_name3" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_spec_name4" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_spec_value1" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_spec_value2" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_spec_value3" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_spec_value4" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_in_stock" visible="False"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="dotmed_your_item_id" visible="False"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="dotmed_image1" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image2" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image3" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image4" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image5" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image6" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image7" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image8" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image9" visible="False"></asp:Literal> 
<asp:Literal runat="server" id="dotmed_image10" visible="False"></asp:Literal></td></tr><tr><td class="tableRowDivider" colspan="11"></td></tr></OEMConversion:Vw_dotmedTableControlRow>
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
</td></tr><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<OEMConversion:Equipment_inventory_dotmedRecordControl runat="server" id="Equipment_inventory_dotmedRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Equipment_inventory_dotmedRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"></td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:CheckBox runat="server" id="dotmed_processed" visible="False"></asp:CheckBox></td><td class="tableCellLabel"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="dotmed_item_id" Columns="40" MaxLength="50" cssclass="field_input" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="dotmed_item_idTextBoxMaxLengthValidator" ControlToValidate="dotmed_item_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Dotmed Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="listing_id" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="listing_idTextBoxMaxLengthValidator" ControlToValidate="listing_id" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;OEMConversion&quot;).Replace(&quot;{FieldName}&quot;, &quot;Listing&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"><OEMConversion:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="UpdateData" button-text="Data Uploaded Complete Process" button-tooltip="Data Uploaded Complete Process"></OEMConversion:ThemeButton></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Equipment_inventory_dotmedRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Equipment_inventory_dotmedRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
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
                