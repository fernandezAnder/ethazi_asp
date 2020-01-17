Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim erabiltzailea As String



    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        erabiltzailea = Session("erabiltzailea")
        Label1.Text = "Ongi Etorri " + erabiltzailea

        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
        conexionbd.Open()


        If erabiltzailea.Equals("gonbidatua") Then
            taulaBeteGonbidatua()
        Else
            MessageBox.Show("Barne Errorea")
        End If
        conexionbd.Close()

    End Sub

    Private Sub taulaBeteGonbidatua()
        Dim ds As New DataSet
        Dim SQL As String = "SELECT * FROM ostatu"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)

        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Dim bilatzailea As String = TextBox1.Text



    End Sub

End Class