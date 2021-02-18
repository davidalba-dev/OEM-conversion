﻿<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Control Language="C#" AutoEventWireup="false" CodeFile="PaginationModern.ascx.cs" Inherits="OEMConversion.UI.PaginationModern" %><table class="panelPaginationCContainer"><tr><td class="panelPaginationCContainerL"><img src="../Images/space.gif" width="10" height="1" alt="" /></td><td class="panelPaginationCContainerC"><table><tr><td><asp:ImageButton runat="server" id="_FirstPage" causesvalidation="False" commandname="FirstPage" imageurl="../Images/ButtonBarFirst.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarFirst.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarFirstOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:FirstPage&quot;, &quot;OEMConversion&quot;) %>" visible="False">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="_PreviousPage" causesvalidation="False" commandname="PreviousPage" imageurl="../Images/ButtonBarPrevious.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarPrevious.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPreviousOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PreviousPage&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="prbg"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("_PageSizeButton")) %><asp:TextBox runat="server" id="_CurrentPage" cssclass="Pagination_Input" maxlength="10" size="5">	</asp:TextBox><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("_PageSizeButton")) %></td><td><asp:ImageButton runat="server" id="_NextPage" causesvalidation="False" commandname="NextPage" imageurl="../Images/ButtonBarNext.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarNext.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNextOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:NextPage&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="_LastPage" causesvalidation="False" commandname="LastPage" imageurl="../Images/ButtonBarLast.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarLast.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarLastOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:LastPage&quot;, &quot;OEMConversion&quot;) %>" visible="False">		
	</asp:ImageButton></td></tr></table>
</td><td style="width: 50%" text-align="right"><table><tr><td class="prbggo"><asp:LinkButton runat="server" id="_PageSizeButton" causesvalidation="False" commandname="PageSize" cssclass="button_link" text="&lt;%# GetResourceValue(&quot;Txt:PageSize&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:LinkButton></td><td class="prbg"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("_PageSizeButton")) %><asp:TextBox runat="server" id="_PageSize" cssclass="Pagination_Input" maxlength="5" size="5" visible="False">	</asp:TextBox>
        <asp:dropdownlist id="_PageSizeSelector" runat="server" cssclass="Pagination_Input" AutoPostBack="false" onchange="ISD_CopyPageSize(this)">
	<asp:listitem id="PageSizeSelector5ListItem" value="5" text="5" />
	<asp:listitem id="PageSizeSelector10ListItem" value="10" text="10" selected="true" />
	<asp:listitem id="PageSizeSelector25ListItem" value="25" text="25" />
	<asp:listitem id="PageSizeSelector50ListItem" value="50" text="50" />
	<asp:listitem id="PageSizeSelector100ListItem" value="100" text="100" />
	</asp:dropdownlist>
        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("_PageSizeButton")) %></td></tr></table>
</td></tr></table>