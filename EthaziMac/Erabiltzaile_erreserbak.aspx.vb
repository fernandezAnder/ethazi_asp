Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class WebForm4
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim erabiltzailea As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        erabiltzailea = Session("erabiltzailea")
        Label2.Text = "Ongi Etorri " + erabiltzailea

        conexionbd = New MySqlConnection()
        'conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
        conexionbd.Open()
        taulaBete()
        conexionbd.Close()

    End Sub
    Private Sub taulaBete()

        Dim ds As New DataSet
        Dim SQL As String = "SELECT er.id_Erreserba,er.hasieraData,er.amaieraData,er.prezioGuztira, os.Izena, os.Deskribapena, os.Kokapena, os.Telefonoa, os.Email 
        From erreserba er, ostatu os, erabiltzaile era 
        WHERE era.id_erabiltzaile = er.id_Erabiltzaile 
                           And er.id_Erreserba = os.id_Ostatu 
                          And era.erabiltzaile = '" + erabiltzailea + "'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()

    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        GridView2.PageIndex = e.NewSelectedIndex
        taulaBete()

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Dim erreserba As String = TextBox1.Text
        conexionbd = New MySqlConnection()
        'conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
        conexionbd.Open()
        If erreserba IsNot "" Then
            taulaBeteBilatu()
        Else
            taulaBete()
        End If
    End Sub

    Private Sub taulaBeteBilatu()
        Dim ds As New DataSet
        Dim erreserba As String = TextBox1.Text
        Dim SQL As String = "SELECT er.id_Erreserba,er.hasieraData,er.amaieraData,er.prezioGuztira, os.Izena, os.Deskribapena, os.Kokapena, os.Telefonoa, os.Email  FROM erreserba er, ostatu os, erabiltzaile era WHERE era.id_erabiltzaile = er.id_Erabiltzaile AND er.id_Erreserba = os.id_Ostatu AND er.id_Erreserba like '%" + erreserba + "%'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()
    End Sub



    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Response.Redirect("Erreserbatu.aspx")
    End Sub

    Protected Sub GridView2_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView2.PageIndexChanging
        GridView2.PageIndex = e.NewPageIndex
        conexionbd.Open()
        taulaBete()
        conexionbd.Close()
    End Sub

    Protected Sub GridView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView2.SelectedIndexChanged
        Dim id_erreserba As Integer
        Dim ostatu_id As Integer
        Dim linea As GridViewRow = GridView2.SelectedRow
        id_erreserba = linea.Cells(1).Text

        ostatu_id = CInt(ostatuIdAtera(id_erreserba))


        Session.Add("id_erreserba", id_erreserba)
        Session.Add("ostatu_id", ostatu_id)
        Response.Redirect("ErreserbaAldaketa.aspx")
    End Sub

    Private Function ostatuIdAtera(id_erreserba As Integer) As Integer
        conexionbd.Open()
        conexionbd = New MySqlConnection()
        'conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
        Dim ostatu_id As Integer

        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT id_Ostatu FROM erreserba WHERE id_Erreserba = " + id_erreserba.ToString
        conexionbd.Open()
        Dim rs As MySqlDataReader = SQL.ExecuteReader()
        rs.Read()
        ostatu_id = rs(0)
        rs.Close()
        conexionbd.Close()
        Return ostatu_id
    End Function
End Class