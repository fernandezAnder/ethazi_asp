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
        SQL.CommandText = "SELECT * from ostatu WHERE id_Ostatu = '" + ostatu_id + "'"
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
        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()

        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id_erabiltzailea As String = ateraIdErabiltzaileDBBDD()
        Dim prezioInt As Integer = CInt(prezioa)
        Dim Hasiera_data As String = 

        insertBD(ostatu_id.ToString, id_erabiltzailea, prezioInt, Hasiera_data, Amaiera_data)
    End Sub

    Private Function ateraIdErabiltzaileDBBDD()
        Dim id_erabiltzaile As String
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

            id_erabiltzaile = (rs(0).ToString)

        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()

        End Try

        Return id_erabiltzaile
    End Function

    Private Sub insertBD(ostatu_id As String, id_erabiltzailea As String, PrezioaGuztira As Integer, Hasiera_data As String, Amaiera_data As String)
        conexionbd.Open()
        Dim SQL As MySqlCommand = New MySqlCommand("INSERT INTO `erreserba`(`id_Ostatu`, `id_Erabiltzaile`, `PrezioaGuztira`, `Hasiera_data`, `Amaiera_data`) VALUES ( '" + ostatu_id + "' , '" + id_erabiltzailea + ", '" + PrezioaGuztira + ", '" + Hasiera_data + ", '" + Amaiera_data + "')", conexionbd)
        SQL.ExecuteNonQuery()
        conexionbd.Close()
    End Sub
End Class