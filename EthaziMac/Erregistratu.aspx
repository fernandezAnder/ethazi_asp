<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Erregistratu.aspx.vb" Inherits="EthaziMac.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center; margin-left: 40px">&nbsp;</h1>
            <h1 style="text-align: center; margin-left: 40px">Erregistro Formularioa</h1>
        </div>
        <p style="text-align: center; margin-left: 40px">
            <span class="auto-style2">Izen</span> <span class="auto-style2">Abizenak: </span>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
        </p>
        <p style="text-align: center; margin-left: 40px">
            <span class="auto-style2">Erabiltzailea:
            </span>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2"></asp:TextBox>
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        </p>
        <p style="text-align: center; margin-left: 40px">
            <span class="auto-style2">Pasahitza:
            </span>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2"></asp:TextBox>
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        </p>
        <p style="text-align: center; margin-left: 40px">
            <span class="auto-style2">Balidatu Pasahitza:
            </span>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style2"></asp:TextBox>
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        </p>
        <p style="text-align: center; margin-left: 40px">
            <span class="auto-style2">Telefonoa:
            </span>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style2"></asp:TextBox>
            <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        </p>
        <p style="text-align: center; margin-left: 40px">
            <span class="auto-style2">&nbsp;Email:
            </span>
            <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style2"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="text-align: center; margin-left: 40px">
            &nbsp;</p>
        <p style="text-align: center; margin-left: 40px">
            <asp:Button ID="Button1" runat="server" Height="39px" Text="Erregistratu" Width="115px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="38px" Text="Ezeztatu" Width="116px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    </form>
</body>
</html>
