Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Konfirmazioa
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim erabiltzailea As String
    Dim erreserba_data As String
    Dim ostatu_id As Integer
    Dim prezioa As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
            conexionbd = New MySqlConnection()
            conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
            conexionbd.Open()
            rs.Read()

            Dim izena As String = (rs(1).ToString)
            Dim deskribapena As String = (rs(2).ToString)
            Dim Kokapena As String = (rs(5).ToString)
            Dim telefonoa As String = (rs(6).ToString)
            Dim email As String = (rs(7).ToString)
            prezioa = (rs(10).ToString)

            Label1.Text = izena
            Label2.Text = deskribapena
            Label3.Text = Kokapena
            Label4.Text = telefonoa
            Label5.Text = email
            Label6.Text = prezioa
        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()

        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id_erabiltzailea_string As String = ateraIdErabiltzaileDBBDD()

        Dim preziostring As String = prezioa
        Dim Hasiera_data As String = calendario.Text
        Dim Amaiera_data As String = calendario2.Text

        insertBD(ostatu_id.ToString, id_erabiltzailea_string, preziostring, Hasiera_data, Amaiera_data)

        Response.Redirect("Erreserbatu.aspx")
    End Sub

    Private Function ateraIdErabiltzaileDBBDD()
        Dim id_erabiltzaile_string2 As String
        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"

        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT id_erabiltzaile from erabiltzaile WHERE erabiltzaile = '" + erabiltzailea + "'"
        conexionbd.Open()
        Dim rs As MySqlDataReader = SQL.ExecuteReader()
        Try
            conexionbd = New MySqlConnection()
            conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
            conexionbd.Open()
            rs.Read()

            id_erabiltzaile_string2 = (rs(0).ToString)

        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()

        End Try

        Return id_erabiltzaile_string2
    End Function

    Private Sub insertBD(ostatu_id As String, id_erabiltzailea As String, PrezioaGuztira As String, Hasiera_data As String, Amaiera_data As String)
        conexionbd.Open()

        Dim SQL As MySqlCommand = New MySqlCommand("INSERT INTO `erreserba`(`id_Ostatu`, `id_Erabiltzaile`, `hasieraData`, `amaieraData`, `prezioGuztira`) VALUES (" + ostatu_id + " ," + id_erabiltzailea + ",'" + Hasiera_data + "','" + Amaiera_data + "'," + PrezioaGuztira + ")", conexionbd)
        SQL.ExecuteNonQuery()
        conexionbd.Close()
    End Sub


End Class