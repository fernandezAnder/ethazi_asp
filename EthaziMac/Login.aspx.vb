Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim array_erabiltzaileak As ArrayList = New ArrayList()
    Dim array_pasahitzak As ArrayList = New ArrayList()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            conexionbd = New MySqlConnection()
            conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"

            conexionbd.Open()

        Catch ex As MySqlException
            MessageBox.Show("Barne Errorea")
        End Try
        conexionbd.Close()
    End Sub


    'LOGIN BOTOIA
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim balidazioa As Boolean = False


        Dim erabiltzailea As String = erabiltzaile_textua.Text
        Dim pasahitza As String = pasahitza_textua.Text
        Dim bd_pasahitza As String
        conexionbd.Open()
        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT erabiltzaile from erabiltzaile"
        Dim rs As MySqlDataReader = SQL.ExecuteReader()
        Try
            conexionbd = New MySqlConnection()
            conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"
            rs.Read()
            array_erabiltzaileak.Add((rs(0).ToString))
            While rs.Read
                array_erabiltzaileak.Add((rs(0).ToString))
            End While
        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()

        End Try
        conexionbd.Open()
        Dim SQL2 As MySqlCommand = conexionbd.CreateCommand()
        SQL2.CommandText = "SELECT pasahitza from erabiltzaile where erabiltzaile = '" + erabiltzailea + "'"
        Dim rs2 As MySqlDataReader = SQL2.ExecuteReader()

        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"
        rs2.Read()
        bd_pasahitza = rs2(0)



        rs2.Close()
        conexionbd.Close()




        For Each izena As String In array_erabiltzaileak

            If (izena.Equals(erabiltzailea)) Then

                If Metodoak.verificarMD5(pasahitza, bd_pasahitza) Then
                        balidazioa = True
                    End If

            End If
        Next

        If balidazioa = True Then
            Session.Add("erabiltzailea", erabiltzailea)
            Response.Redirect("Erabiltzaile_erreserbak.aspx")
        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Erregistratu.aspx")

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim erabiltzailea = "gonbidatua"
        Session.Add("erabiltzailea", erabiltzailea)
        Response.Redirect("Erreserbatu.aspx")
    End Sub

    Protected Sub erabiltzaile_textua_TextChanged(sender As Object, e As EventArgs) Handles erabiltzaile_textua.TextChanged

    End Sub
End Class