<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestSignature.aspx.cs" Inherits="TestSignature" %>
<%@ Register Assembly="WebSignature" Namespace="RealSignature" TagPrefix="ASP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <asp:WebSignature ID="WebSignature1"  Width="600" Height="100" runat="server">
            </asp:WebSignature>
    </div>
    </form>
</body>
</html>
