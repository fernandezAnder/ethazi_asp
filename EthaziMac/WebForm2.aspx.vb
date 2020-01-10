Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexionbd = New MySqlConnection()
            conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"

            conexionbd.Open()
            'MessageBox.Show("conectado al servidor")
        Catch ex As MySqlException
            MessageBox.Show("Barne Errorea")
        End Try
    End Sub
End Class