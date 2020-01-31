<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Erreserbatu.aspx.vb" Inherits="EthaziMac.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            height: 47px;
            margin-left: 760px;
        }
        .auto-style2 {
            margin-left: 44px;
            text-align: left;
        }
        .auto-style5 {
            margin-left: 0px;
            margin-right: 0px;
            margin-top: 0px;
        }
        .auto-style6 {
            font-size: medium;
        }
        .auto-style7 {
            margin-left: 603px;
            text-align: left;
        }
        .auto-style8 {
            font-size: large;
        }
        .auto-style9 {
            margin-left: 80px;
        }
        </style>
</head>
<body>
  
    <form id="form1" runat="server">
        <h1 class="auto-style1">EUSKAL ALOKAIRUA</h1>
        <p class="auto-style1">&nbsp;</p>
        <p class="auto-style2" aria-multiline="True">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" style="text-align: left" Font-Size="X-Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Height="42px" Text="Nire erreserbak" Width="122px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span class="auto-style8"><strong>Bilatu</strong></span> :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="24px" ImageUrl="../imagenes/lupa.jpg" Width="30px" />
            &nbsp;&nbsp;&nbsp; *Ostatu izena</p>
        <p class="auto-style2" aria-multiline="True">
            &nbsp;</p>
         <p class="auto-style7">
             <strong><span class="auto-style6">&nbsp;Kokapena:</span></strong><span class="auto-style6">&nbsp;
            </span>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style6">
            </asp:DropDownList>
             <span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <strong><span class="auto-style6">&nbsp;Ostatu Mota:</span></strong>
            <asp:CheckBox ID="Checkbox1" runat="server" Text="Rural Etxeak" CssClass="auto-style6" />
             <span class="auto-style6">&nbsp;
            </span>
            <asp:CheckBox ID="Checkbox2" runat="server" Text="Alberge" CssClass="auto-style6" />
             <span class="auto-style6">&nbsp;
            </span>
            <asp:CheckBox ID="Checkbox3" runat="server" Text="Kanping" CssClass="auto-style6" />
             <span class="auto-style6">&nbsp;&nbsp;&nbsp;
            </span>
            <asp:CheckBox ID="Checkbox4" runat="server" Text="AgroTurismoa" CssClass="auto-style6" />
             <span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;
             </span>
             <asp:Button ID="Button1" runat="server" Text="Bilatu" CssClass="auto-style6" Height="32px" Width="72px" />
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div class="auto-style9">
            <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="16px" Width="1707px"  AllowPaging="True" PageSize="20" CssClass="auto-style5">
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Erreserbatu" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </div>

    </form>
    </body>
</html>
