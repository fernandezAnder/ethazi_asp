Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page



    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strconexion As String

        Dim conexionbd As MySqlConnection
        Try
            conexionbd = New MySqlConnection()
            conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"

            conexionbd.Open()
            MessageBox.Show("conectado al servidor")
        Catch ex As MySqlException
            MessageBox.Show("no se ha podido conectar al servidor")

        End Try

    End Sub
End Class