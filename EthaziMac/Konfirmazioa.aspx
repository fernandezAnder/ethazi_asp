<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Konfirmazioa.aspx.vb" Inherits="EthaziMac.Konfirmazioa" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

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
            margin-left: 720px;
        }
        .auto-style25 {
            text-align: left;
            margin-left: 760px;
        }
    </style>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
  $( function() {
    $( "#datepicker" ).datepicker();
  } );
  </script>
   <script>
        $(function () {
            $("#datepicker2").datepicker();
        });
  </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">ERRERSERBA KONFIRMAZIOA</h1>
            <p class="auto-style1">
                &nbsp;</p>
        </div>
        <p class="auto-style25">
            Izena:
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style25">
            Deskribapena:&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style25">
            Kokapena:&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style25">
            Telefonoa:&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
          <asp:ScriptManager 
            ID="ScriptManager1"
            runat="server"
            >
        </asp:ScriptManager>
        <p class="auto-style3">Sartze data: &nbsp;&nbsp;<asp:TextBox ID="calendario" runat="server"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="calendario_CalendarExtender" runat="server" TargetControlID="TextBox1" />
            &nbsp;&nbsp; irtetze data:
            <asp:TextBox ID="calendario2" runat="server"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="calendario2_CalendarExtender" runat="server" TargetControlID="TextBox2" />
        </p>
        <p class="auto-style25">
            Email:&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
        <div class="auto-style3">
            <asp:Button ID="Button1" runat="server" Text="Ezeztatu" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Button ID="Button2" runat="server" Text="Errserbatu" />
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>