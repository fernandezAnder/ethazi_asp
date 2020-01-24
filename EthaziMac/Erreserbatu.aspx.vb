Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

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

    Protected Sub GridView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView2.SelectedIndexChanged
        Dim ostatu_id As Integer
        Dim linea As GridViewRow = GridView2.SelectedRow

        ostatu_id = linea.Cells(1).Text
        MessageBox.Show(linea.Cells(1).Text)

        Session.Add("ostatu_id", ostatu_id)
        Response.Redirect("Konfirmazioa.aspx")
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        GridView2.PageIndex = e.NewSelectedIndex
        taulaBeteGonbidatua()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla As String = "ostatu"
        Dim kokapena As String = DropDownList1.Text
        Dim ruraletxea_checkbox As Boolean = False
        Dim kanping_checkbox As Boolean = False
        Dim alberge_checkbox As Boolean = False
        Dim agroturismo_checkbox As Boolean = False
        Dim logela_libreak As Boolean = False
        Dim sql As String = "SELECT * FROM ostatu WHERE "

        If Checkbox1.Checked Then
            ruraletxea_checkbox = True
            sql = sql + "Ostatu_mota = 'Casas Rurales'"
        End If
        If Checkbox2.Checked Then
            If Checkbox1.Checked Or Checkbox3.Checked Or Checkbox4.Checked Then
                alberge_checkbox = True
                sql = sql + " AND Ostatu_mota = 'Albergues'"
            Else
                sql = sql + " Ostatu_mota = 'Albergues'"

            End If

        End If
        If Checkbox3.Checked Then
            If Checkbox1.Checked Or Checkbox2.Checked Or Checkbox4.Checked Then
                kanping_checkbox = True
                sql = sql + " AND Ostatu_mota = 'Campings'"
            Else
                sql = sql + " Ostatu_mota = 'Campings'"
            End If
        End If

        If Checkbox4.Checked Then
            agroturismo_checkbox = True
            If Checkbox1.Checked Or Checkbox2.Checked Or Checkbox3.Checked Then
                sql = sql + " AND Ostatu_mota = 'Agroturismos'"
            Else
                sql = sql + " Ostatu_mota = 'Agroturismos'"
            End If
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

        Dim adaptador As New MySqlDataAdapter(sql, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()
    End Sub
End Class