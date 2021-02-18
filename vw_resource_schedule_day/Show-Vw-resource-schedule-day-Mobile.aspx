<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Vw-resource-schedule-day-Mobile.aspx.cs" Culture="en-US" MasterPageFile="../Master Pages/Mobile.master" Inherits="OEMConversion.UI.Show_Vw_resource_schedule_day_Mobile" %>
<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Tagprefix="OEMConversion" Namespace="OEMConversion.UI.Controls.Show_Vw_resource_schedule_day_Mobile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      
                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <OEMConversion:Vw_resource_schedule_dayRecordControl runat="server" id="Vw_resource_schedule_dayRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="mobileHeader"><tr><td class="mobileHeaderLeft">
                            <asp:ImageButton runat="server" id="CancelButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonBack.png" text="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Back&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderTitle">
                      <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;&lt;span class=&#39;mobileFontAdjust90&#39;>&quot;, &quot; Resource Schedule Day&quot;, &quot;&lt;/span>&quot;) %>">	</asp:Literal>
                    </td><td class="mobileHeaderOptions">
                            <asp:ImageButton runat="server" id="DeleteButton" causesvalidation="True" commandname="DeleteRecord" imageurl="../Images/MobileButtonDelete.png" text="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td><td class="mobileHeaderRight">
                            <asp:ImageButton runat="server" id="EditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/MobileButtonEdit.png" text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton>
                          </td></tr></table>

                      </td></tr><tr><td>
                      <asp:panel id="CollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileBody"><asp:panel id="Vw_resource_schedule_dayRecordControlPanel" runat="server"><table class="mobileRecordPanel mobileBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="CustNameLabel" Text="Customer Name">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="CustName"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="project_nameLabel" Text="Project Name">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="project_name"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="due_dateLabel" Text="Due Date">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="due_date"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="scheduled_dateLabel" Text="Scheduled Date">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="scheduled_date"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="estimated_duration_hoursLabel" Text="Estimated Duration Hours">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="estimated_duration_hours"></asp:Literal>:<asp:Literal runat="server" id="estimated_duration_minutes"></asp:Literal></td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_priorityLabel" Text="Resource SCH Priority">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="resource_sch_priority"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="resource_sch_statusLabel" Text="Resource SCH Status">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="resource_sch_status"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="subjectLabel" Text="Subject">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom"><asp:Literal runat="server" id="subject"></asp:Literal> </td></tr><tr><td class="mobileFieldLabelOnTop"><asp:Literal runat="server" id="ticket_detailsLabel" Text="Ticket Details">	</asp:Literal></td></tr><tr><td class="mobileFieldValueOnBottom" style="padding-bottom: 22px;"><asp:Literal runat="server" id="ticket_details"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                      </td></tr></table>
	<asp:hiddenfield id="Vw_resource_schedule_dayRecordControl_PostbackTracker" runat="server" />
</OEMConversion:Vw_resource_schedule_dayRecordControl>

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
                