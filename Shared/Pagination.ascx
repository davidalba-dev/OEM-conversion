﻿<%@ Register Tagprefix="Selectors" Namespace="OEMConversion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Pagination.ascx.cs" Inherits="OEMConversion.UI.Pagination" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table class="panelPaginationCContainer"><tr><td class="panelPaginationCContainerL"><img src="../Images/space.gif" width="10" height="1" alt="" /></td><td><asp:ImageButton runat="server" id="_FirstPage" causesvalidation="False" commandname="FirstPage" imageurl="../Images/ButtonBarFirst.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarFirst.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarFirstOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:FirstPage&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="_PreviousPage" causesvalidation="False" commandname="PreviousPage" imageurl="../Images/ButtonBarPrevious.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarPrevious.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPreviousOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PreviousPage&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="prbg"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("_PageSizeButton")) %><asp:TextBox runat="server" id="_CurrentPage" cssclass="Pagination_Input" maxlength="10" size="5">	</asp:TextBox><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("_PageSizeButton")) %></td><td class="prbg"><%# GetResourceValue("Txt:Of", "OEMConversion") %> <b><asp:Label runat="server" id="_TotalPages">	</asp:Label></b></td><td><asp:ImageButton runat="server" id="_NextPage" causesvalidation="False" commandname="NextPage" imageurl="../Images/ButtonBarNext.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarNext.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNextOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:NextPage&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="_LastPage" causesvalidation="False" commandname="LastPage" imageurl="../Images/ButtonBarLast.gif" onclientclick="return SubmitHRefOnce(this, &quot;&quot;);" onmouseout="this.src=&#39;../Images/ButtonBarLast.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarLastOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:LastPage&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:ImageButton></td><td class="prbg"><b><asp:Label runat="server" id="_TotalItems">	</asp:Label></b>&nbsp;<%# GetResourceValue("Txt:Items", "OEMConversion") %></td><td class="prbg"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("_PageSizeButton")) %><asp:TextBox runat="server" id="_PageSize" cssclass="Pagination_Input" maxlength="5" size="5">	</asp:TextBox><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("_PageSizeButton")) %></td><td class="prbggo"><asp:LinkButton runat="server" id="_PageSizeButton" causesvalidation="False" commandname="PageSize" cssclass="button_link" text="&lt;%# GetResourceValue(&quot;Txt:Page&quot;, &quot;OEMConversion&quot;) %>">		
	</asp:LinkButton></td><td style="width: 50%"><img src="../Images/space.gif" width="10" height="1" alt="" /></td><td style="width: 50%"><img src="../Images/space.gif" width="10" height="1" alt="" /></td></tr></table>