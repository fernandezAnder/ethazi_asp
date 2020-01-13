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
            conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"

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
        Dim pasahitza As String = pasahitza_textua.text
        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT erabiltzaile, pasahitza from erabiltzaile"
        Dim rs As MySqlDataReader = SQL.ExecuteReader()
        Try
            conexionbd = New MySqlConnection()
            conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"


            conexionbd.Open()

            rs.Read()

            array_erabiltzaileak.Add(rs(0).ToString)
            array_pasahitzak.Add(rs(1).ToString)
            While rs.Read

                array_erabiltzaileak.Add(rs(0).ToString)
                array_pasahitzak.Add(rs(1).ToString)

            End While
        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()

        End Try


        For Each izena As String In array_erabiltzaileak

            If (izena.Equals(erabiltzailea)) Then
                For Each bd_pasahitza As String In array_pasahitzak
                    If bd_pasahitza.Equals(pasahitza) Then
                        balidazioa = True
                    End If
                Next
            End If
        Next

        If balidazioa = True Then
            Response.Redirect("Erreserbatu.aspx?erabiltzailea=", erabiltzailea)
        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Response.Redirect("Erregistratu.aspx")

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim erabiltzailea = "gonbidatua"
        Response.Redirect("Erreserbatu.aspx?erabiltzailea=", erabiltzailea)
    End Sub

    Protected Sub erabiltzaile_textua_TextChanged(sender As Object, e As EventArgs) Handles erabiltzaile_textua.TextChanged

    End Sub
End Class