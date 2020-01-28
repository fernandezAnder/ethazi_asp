<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ErreserbaAldaketa.aspx.vb" Inherits="EthaziMac.ErreserbaAldaketa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style26 {
            font-size: large;
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
            <h1 class="auto-style1">ERRERSERBA MODIFIKAZIOA</h1>
            <p class="auto-style1">&nbsp;</p>
            <p class="auto-style1"><span class="auto-style26">Izena:
            </span>
            <asp:Label ID="Label7" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
                <span class="auto-style26">&nbsp;&nbsp;
            Deskribapena:&nbsp;
            </span>
            <asp:Label ID="Label8" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
            </p>
            <p class="auto-style1"><span class="auto-style26">Kokapena:&nbsp;
            </span>
            <asp:Label ID="Label9" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
                <span class="auto-style26">&nbsp;
            Telefonoa:&nbsp;
            </span>
            <asp:Label ID="Label10" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
            </p>
          <asp:ScriptManager 
            ID="ScriptManager1"
            runat="server"
            >
        </asp:ScriptManager>
            <p class="auto-style1"><span class="auto-style26">Sartze data: &nbsp;&nbsp;</span><asp:TextBox ID="calendario3" runat="server" CssClass="auto-style26" ReadOnly="True"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="calendario3_CalendarExtender" runat="server" TargetControlID="calendario3" />
                <span class="auto-style26">&nbsp;&nbsp; irtetze data:
            </span>
            <asp:TextBox ID="calendario4" runat="server" CssClass="auto-style26" ReadOnly="True"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="calendario4_CalendarExtender" runat="server" TargetControlID="calendario4" />
            </p>
            <p class="auto-style1"><span class="auto-style26">Email:&nbsp;
            </span>
            <asp:Label ID="Label11" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
            <p class="auto-style1"><span class="auto-style26">Prezio Totala:
            </span>
            <asp:Label ID="Label12" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
            </p>
            <p class="auto-style1"><asp:Button ID="Button3" runat="server" Text="Atzera" CssClass="auto-style26" Width="109px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Ezabatu Erreserba" CssClass="auto-style26" />
                <span class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;</span><asp:Button ID="Button2" runat="server" Text="Aldatu" CssClass="auto-style26" Width="109px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        </div>
        <span class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </span>
    </form>
</body>
</html>