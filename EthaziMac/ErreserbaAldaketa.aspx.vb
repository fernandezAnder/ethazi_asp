Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ErreserbaAldaketa
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim erabiltzailea As String
    Dim erreserba_data As String
    Dim ostatu_id As Integer
    Dim id_erreserba As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        erabiltzailea = Session("erabiltzailea")
        id_erreserba = Session("id_erreserba")
        ostatu_id = Session("ostatu_id")

        datuakBistaratu()


    End Sub

    Private Sub datuakBistaratu()
        Dim izena As String
        Dim deskribapena As String
        Dim kokapena As String
        Dim telefonoa As String
        Dim email As String
        Dim prezioa As String

        conexionbd = New MySqlConnection()
        'conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT * from ostatu WHERE id_Ostatu = " + ostatu_id.ToString
        conexionbd.Open()
        Dim rs As MySqlDataReader = SQL.ExecuteReader()

        While rs.Read
            izena = (rs(1).ToString)
            deskribapena = (rs(2).ToString)
            kokapena = (rs(5).ToString)
            telefonoa = (rs(6).ToString)
            email = (rs(7).ToString)
            prezioa = (rs(10).ToString)
        End While

        Label7.Text = izena
        Label8.Text = deskribapena
        Label9.Text = kokapena
        Label10.Text = telefonoa
        Label11.Text = email
        Label12.Text = prezioa

        rs.Close()
        conexionbd.Close()
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexionbd.Open()
            Dim SQL As MySqlCommand = New MySqlCommand("DELETE FROM `erreserba` WHERE `id_Erreserba` =" + id_erreserba, conexionbd)
            SQL.ExecuteNonQuery()
            conexionbd.Close()
            Response.Redirect("Erabiltzaile_erreserbak.aspx")
        Catch
        End Try
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("Erabiltzaile_erreserbak.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim hasi_data_berria As String = calendario3.Text
            Dim amaiera_data_berria As String = calendario4.Text
            If hasi_data_berria IsNot "" And amaiera_data_berria IsNot "" Then
                Dim SQL As MySqlCommand = New MySqlCommand("UPDATE `erreserba` SET `hasieraData`= '" + hasi_data_berria + "' ,`amaieraData`= '" + amaiera_data_berria + "'  WHERE id_Erreserba = " + id_erreserba.ToString, conexionbd)
                SQL.ExecuteNonQuery()
                conexionbd.Close()
                Response.Redirect("Erabiltzaile_erreserbak.aspx")
                conexionbd.Open()
            Else
                MessageBox.Show("Datak ezin dira hutsik egon")
            End If

        Catch
        End Try
    End Sub
End Class