Imports MySql.Data.MySqlClient

Public Class ErreserbaAldaketa
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim erabiltzailea As String
    Dim erreserba_data As String
    Dim ostatu_id As Integer
    Dim prezioa As String
    Dim id_erreserba As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        id_erreserba = Session("id_erreserba")
        ostatu_id = Session("ostatu_id")
        erabiltzailea = Session("erabiltzailea")
        datuakBistaratu()


    End Sub

    Private Sub datuakBistaratu()
        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"

        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT * from ostatu WHERE id_Ostatu = '" + ostatu_id.ToString + "'"
        conexionbd.Open()
        Dim rs As MySqlDataReader = SQL.ExecuteReader()
        Try
            rs.Read()

            Dim izena As String = (rs(1).ToString)
            Dim deskribapena As String = (rs(2).ToString)
            Dim Kokapena As String = (rs(5).ToString)
            Dim telefonoa As String = (rs(6).ToString)
            Dim email As String = (rs(7).ToString)
            prezioa = (rs(10).ToString)

            Label7.Text = izena
            Label8.Text = deskribapena
            Label9.Text = Kokapena
            Label10.Text = telefonoa
            Label11.Text = email
            Label12.Text = prezioa
        Catch

        Finally
            rs.Close()
            conexionbd.Close()

        End Try
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexionbd.Open()
        Dim SQL As MySqlCommand = New MySqlCommand("DELETE FROM `erreserba` WHERE `id_Erreserba` =" + id_erreserba, conexionbd)
        SQL.ExecuteNonQuery()
        conexionbd.Close()
        Response.Redirect("Erabiltzaile_erreserbak.aspx")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("Erabiltzaile_erreserbak.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexionbd.Open()
        Dim hasi_data_berria As String = calendario3.Text
        Dim amaiera_data_berria As String = calendario4.Text
        Dim SQL As MySqlCommand = New MySqlCommand("UPDATE `erreserba` `hasieraData`= '" + hasi_data_berria + "' ,`amaieraData`= '" + amaiera_data_berria + "'  WHERE id_Erreserba = " + id_erreserba, conexionbd)
        SQL.ExecuteNonQuery()
        conexionbd.Close()
        Response.Redirect("Erabiltzaile_erreserbak.aspx")
    End Sub
End Class