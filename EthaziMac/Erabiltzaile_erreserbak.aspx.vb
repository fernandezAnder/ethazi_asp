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
        conexionbd.Close()
    End Sub
    Private Sub taulaBete()
        Dim ds As New DataSet
        Dim SQL As String = "SELECT  er.id_Erreserba, os.Izena, os.Deskribapena, os.Kokapena, os.Telefonoa, os.Email
	                            FROM erreserba er, ostatu os, erabiltzaile era
		                            WHERE erabiltzaile.id_erabiltzaile = erreserba.id_Erabiltzaile 
		                            AND erreserba.id_Erreserba = ostatu.id_Ostatu 
		                            AND erabiltzaile.id_erabiltzaile  = '" + erabiltzailea + "'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()
    End Sub

End Class