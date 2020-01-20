Imports MySql.Data.MySqlClient

Public Class Konfirmazioa
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim erabiltzailea As String
    Dim erreserba_data As String
    Dim ostatu_id As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ostatu_id = Session("ostatu_id")

        Dim SQL As String = "SELECT id_erabiltzaile from ostatu WHERE erabiltzaile = '" + erabiltzailea + "'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        erabiltzailea = Session("erabiltzailea")
        Dim SQL As String = "INSERT INTO `erreserba`(`id_Ostatu`, `id_Erabiltzaile`, `Erreserba_data`) VALUES ('" + ostatu_id.ToString + "' ,'" + erabiltzailea + "' ," + erreserba_data + "')"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
    End Sub
End Class