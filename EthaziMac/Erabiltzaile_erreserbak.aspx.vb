Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class WebForm4
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim erabiltzailea As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        erabiltzailea = Session("erabiltzailea")
        Label2.Text = "Ongi Etorri " + erabiltzailea

        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
        conexionbd.Open()
        taulaBete()


        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT erabiltzaile from erabiltzaile"
        conexionbd.Open()
        Dim rs As MySqlDataReader = SQL.ExecuteReader()
        Try


            rs.Read()

            While rs.Read

            End While
        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()

        End Try



        conexionbd.Close()
    End Sub
    Private Sub taulaBete()
        Dim ds As New DataSet
        Dim SQL As String = "SELECT  er.id_Erreserba, os.Izena, os.Deskribapena, os.Kokapena, os.Telefonoa, os.Email
	                            FROM erreserba er, ostatu os, erabiltzaile era
		                            WHERE era.id_erabiltzaile = er.id_Erabiltzaile 
		                            AND er.id_Erreserba = os.id_Ostatu 
		                            AND era.id_erabiltzaile  = '" + erabiltzailea + "'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()

    End Sub


End Class