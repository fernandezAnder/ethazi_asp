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
        .auto-style26 {
            font-size: large;
        }
        .auto-style27 {
            text-align: left;
            margin-left: 666px;
        }
        .auto-style28 {
            text-align: left;
            margin-left: 664px;
        }
        .auto-style29 {
            text-align: left;
            margin-left: 667px;
        }
        .auto-style30 {
            text-align: left;
            margin-left: 667px;
            width: 477px;
            height: 201px;
        }
        .auto-style31 {
            margin-left: 664px;
            margin-right: 559px;
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
        <p class="auto-style27">
            <strong><span class="auto-style26">Izena:</span></strong>
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
            <span class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; </span> <strong><span class="auto-style26">Kokapena:</span></strong><span class="auto-style26">&nbsp;
            </span>
            <asp:Label ID="Label3" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
        </p>
        <p class="auto-style28">
            <strong><span class="auto-style26">Telefonoa:</span></strong><span class="auto-style26">&nbsp;
            </span>
            <asp:Label ID="Label4" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
            <span class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; </span> <strong><span class="auto-style26">Email:</span></strong><span class="auto-style26">&nbsp;
            </span>
            <asp:Label ID="Label5" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
        </p>
        <p class="auto-style30">
            <strong><span class="auto-style26">Deskribapena:</span></strong><span class="auto-style26">&nbsp;
            </span>
            <asp:Label ID="Label2" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
        </p>
        <p class="auto-style29">
            &nbsp;</p>
        <p class="auto-style29">
            <strong><span class="auto-style26">Prezio Totala:</span></strong>
            <asp:Label ID="Label6" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
        </p>
          <asp:ScriptManager 
            ID="ScriptManager1"
            runat="server"
            >
        </asp:ScriptManager>
        <p class="auto-style31"><strong><span class="auto-style26">Sartze data:</span></strong><span class="auto-style26"> &nbsp;&nbsp;</span><asp:TextBox ID="calendario" runat="server" AutoCompleteType="Disabled" CssClass="auto-style26"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="calendario_CalendarExtender" runat="server" TargetControlID="calendario" />
            <span class="auto-style26">&nbsp;&nbsp;</span><strong><span class="auto-style26"> Irtetze data:</span></strong>
            <asp:TextBox ID="calendario2" runat="server" AutoCompleteType="Disabled" CssClass="auto-style26" Height="27px"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="calendario2_CalendarExtender" runat="server" TargetControlID="calendario2" />
        </p>
        <p class="auto-style31">&nbsp;</p>
        <div class="auto-style3">
            <asp:Button ID="Button1" runat="server" Text="Ezeztatu" CssClass="auto-style26" Height="40px" />
            <span class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;</span><asp:Button ID="Button2" runat="server" Text="Errserbatu" CssClass="auto-style26" Height="40px" />
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>