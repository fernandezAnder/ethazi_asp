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


        Dim ds As New DataSet
        Dim SQL As String = "SELECT * FROM pertsona"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)

        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView1.DataSource = ds.Tables("tabla")
        conexionbd.Close()

    End Sub
End Class