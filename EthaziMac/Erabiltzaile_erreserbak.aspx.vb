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
        conexionbd.Close()


    End Sub
    Private Sub taulaBete()

        Dim ds As New DataSet
        Dim SQL As String = "SELECT er.id_Erreserba,er.Hasiera_data,er.Amaiera_data,er.PrezioaGuztira, os.Izena, os.Deskribapena, os.Kokapena, os.Telefonoa, os.Email 
                            FROM erreserba er, ostatu os, erabiltzaile era 
                            WHERE era.id_erabiltzaile = er.id_Erabiltzaile 
                            AND er.id_Erreserba = os.id_Ostatu 
                            AND era.erabiltzaile = '" + erabiltzailea + "'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")

        GridView2.DataBind()

    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        GridView2.PageIndex = e.NewSelectedIndex
        taulaBete()

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Dim ostatu As String = TextBox1.Text
        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
        conexionbd.Open()
        taulaBeteBilatu()

    End Sub

    Private Sub taulaBeteBilatu()
        Dim ds As New DataSet
        Dim ostatu As String = TextBox1.Text
        Dim SQL As String = "SELECT er.id_Erreserba,er.Hasiera_data,er.Amaiera_data,er.PrezioaGuztira, os.Izena, os.Deskribapena, os.Kokapena, os.Telefonoa, os.Email FROM erreserba er, ostatu os, erabiltzaile era WHERE era.id_erabiltzaile = er.id_Erabiltzaile AND er.id_Erreserba = os.id_Ostatu AND os.Izena like '%" + ostatu + "%'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tabla As String = 'ostatu'
        Dim kokapena As String = DropDownList1.Text
        Dim apartamentua_checkbox As Boolean = False
        Dim kanping_checkbox As Boolean = False
        Dim alberge_checkbox As Boolean = False
        Dim logela_libreak As Boolean = False


        If Checkbox1.Checked Then
            apartamentua_checkbox = True
        End If
        If Checkbox2.Checked Then
            kanping_checkbox = True
        End If
        If Checkbox3.Checked Then
            alberge_checkbox = True
        End If

        If RadioButton1.Checked Then
            logela_libreak = True
        End If
        If RadioButton2.Checked Then
            logela_libreak = False
            RadioButton1.Checked = False
        End If

        Dim ds As New DataSet
        Dim ostatu As String = TextBox1.Text

        Dim SQL As String = "SELECT er.id_Erreserba,er.Hasiera_data,er.Amaiera_data,er.PrezioaGuztira, os.Izena, os.Deskribapena, os.Kokapena, os.Telefonoa, os.Email FROM erreserba er, ostatu os, erabiltzaile era WHERE era.id_erabiltzaile = er.id_Erabiltzaile AND er.id_Erreserba = os.id_Ostatu AND os.Izena like '%" + ostatu + "%'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()


    End Sub
End Class