﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Konfirmazioa.aspx.vb" Inherits="EthaziMac.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style3 {
            margin-left: 800px;
        }
        .auto-style23 {
            text-align: left;
            margin-left: 840px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">ERRERSERBA KONFIRMAZIOA</h1>
            <p class="auto-style1">
                &nbsp;</p>
        </div>
        <p class="auto-style23">
            Izena:
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style23">
            Deskribapena:&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style23">
            Kokapena:&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style23">
            Telefonoa:&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style23">
            Email:&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
        <div class="auto-style3">
            <asp:Button ID="Button1" runat="server" Text="Ezeztatu" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Errserbatu" />
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
