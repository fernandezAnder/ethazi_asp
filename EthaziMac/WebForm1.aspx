<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="EthaziMac.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            height: 47px;
            margin-left: 640px;
        }
        .auto-style2 {
            margin-left: 1303px;
        }
        .auto-style3 {
            font-size: large;
        }
        </style>
</head>
<body>
    <script src="path/to/gmap3.min.js"></script>
    <form id="form1" runat="server">
        <h1 class="auto-style1">&nbsp;</h1>
        <h1 class="auto-style1">EUSKAL ALOKAIRUA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
        <p class="auto-style3">
            &nbsp; <span class="auto-style3">Erabiltzailea : </span>&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style3">
            &nbsp;
            Pasahitza:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <input id="Password1" type="password" /></p>
        <p class="auto-style3">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login" Width="71px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Erregistratu" />
        </p>
        <p class="auto-style2">
&nbsp;Buscar :
            <input id="Text1" type="text" />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="24px" ImageUrl="~/EthaziMac/imagenes/lupa.jpg" Width="30px" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_Ostatu" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="id_Ostatu" HeaderText="id_Ostatu" InsertVisible="False" ReadOnly="True" SortExpression="id_Ostatu" />
                    <asp:BoundField DataField="Izena" HeaderText="Izena" SortExpression="Izena" />
                    <asp:BoundField DataField="Deskribapena" HeaderText="Deskribapena" SortExpression="Deskribapena" />
                    <asp:BoundField DataField="Ostatu_mota" HeaderText="Ostatu_mota" SortExpression="Ostatu_mota" />
                    <asp:BoundField DataField="Logela_kop" HeaderText="Logela_kop" SortExpression="Logela_kop" />
                    <asp:BoundField DataField="Kokapena" HeaderText="Kokapena" SortExpression="Kokapena" />
                    <asp:BoundField DataField="Telefonoa" HeaderText="Telefonoa" SortExpression="Telefonoa" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Latitudea" HeaderText="Latitudea" SortExpression="Latitudea" />
                    <asp:BoundField DataField="Longitudea" HeaderText="Longitudea" SortExpression="Longitudea" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mydbConnectionString %>" ProviderName="<%$ ConnectionStrings:mydbConnectionString.ProviderName %>" SelectCommand="select * from ostatu"></asp:SqlDataSource>
        </p>
        <p>
             <div id="gmap" style="height: 600px; width: 500px;"></div>
        </p>
    </form>
     <script src="//ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"></script>
    <script src="http://maps.google.com/maps/api/js?sensor=false" type="text/javascript"></script>
    <script src="gmap3.min.js" type="text/javascript"></script>
    
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
