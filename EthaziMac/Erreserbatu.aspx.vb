Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim erabiltzailea As String
    Dim array_kokapena As ArrayList = New ArrayList()



    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        erabiltzailea = Session("erabiltzailea")
        Label1.Text = "Ongi Etorri " + erabiltzailea
        If erabiltzailea.Equals("gonbidatua") Then
            Button2.Enabled = False
            Button2.Visible = False
        End If
        taulaBeteGonbidatua()
        KokapenaBeteBD()

    End Sub

    Private Sub KokapenaBeteBD()
        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"
        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT DISTINCT(Kokapena) FROM ostatu"
        conexionbd.Open()
        Dim rs As MySqlDataReader = SQL.ExecuteReader()
        Try
            array_kokapena.Add("")
            rs.Read()
            array_kokapena.Add(rs(0).ToString)
            While rs.Read
                array_kokapena.Add(rs(0).ToString)
            End While
        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()
        End Try


        For Each kokapena As String In array_kokapena

            If kokapena IsNot "" Or kokapena IsNot " " Then
                DropDownList1.Items.Add(kokapena)
            End If
        Next
    End Sub

    Private Sub taulaBeteGonbidatua()

        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=192.168.13.16 ; userid=root ; password = ; database=mydb"
        conexionbd.Open()
        Dim ds As New DataSet
        Dim SQL As String = "SELECT * FROM ostatu"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)

        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()
        conexionbd.Close()
    End Sub

    Private Sub taulaBeteGonbidatuaBilatu()
        Dim bilatzailea As String = TextBox1.Text
        conexionbd.Open()
        Dim ds As New DataSet
        Dim SQL As String = "SELECT * FROM ostatu where Izena like '%" + bilatzailea + "%'"
        Dim adaptador As New MySqlDataAdapter(SQL, conexionbd)

        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()
        conexionbd.Close()
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Dim bilatzailea As String = TextBox1.Text
        If bilatzailea IsNot "" Then
            taulaBeteGonbidatuaBilatu()
        Else
            taulaBeteGonbidatua()
        End If


    End Sub

    Protected Sub GridView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView2.SelectedIndexChanged
        Dim ostatu_id As Integer
        Dim linea As GridViewRow = GridView2.SelectedRow

        ostatu_id = linea.Cells(1).Text


        Session.Add("ostatu_id", ostatu_id)
        Response.Redirect("Konfirmazioa.aspx")
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


        If kokapena IsNot "" Then
            sql = sql + "Kokapena = '" + kokapena + "'"

        End If

        If Checkbox1.Checked Then
            If kokapena IsNot "" Then
                sql = sql + " AND Ostatu_mota = 'Casas Rurales'"
            Else
                sql = sql + "Ostatu_mota = 'Casas Rurales'"
            End If


        End If
        If Checkbox2.Checked Then
            If Checkbox1.Checked Or Checkbox3.Checked Or Checkbox4.Checked Then
                If Checkbox1.Checked Then
                    sql = sql + " OR Ostatu_mota = 'Albergues'"
                Else
                    sql = sql + " AND Ostatu_mota = 'Albergues'"
                End If

            Else
                If kokapena IsNot "" Then
                    sql = sql + " AND Ostatu_mota = 'Albergues'"
                Else
                    sql = sql + " Ostatu_mota = 'Albergues'"
                End If


            End If

        End If
        If Checkbox3.Checked Then
            If Checkbox2.Checked Or Checkbox1.Checked Or Checkbox4.Checked Then
                If Checkbox2.Checked Then
                    sql = sql + " OR Ostatu_mota = 'Campings'"
                Else
                    sql = sql + " AND Ostatu_mota = 'Campings'"
                End If

            Else
                If kokapena IsNot "" Then
                    sql = sql + " AND Ostatu_mota = 'Campings'"
                Else
                    sql = sql + " Ostatu_mota = 'Campings'"
                End If

            End If
        End If

        If Checkbox4.Checked Then
            If Checkbox3.Checked Or Checkbox2.Checked Or Checkbox1.Checked Then
                If Checkbox3.Checked Then
                    sql = sql + " OR Ostatu_mota = 'Agroturismos'"
                Else
                    sql = sql + " AND Ostatu_mota = 'Agroturismos'"
                End If
            Else
                If kokapena IsNot "" Then
                    sql = sql + " AND Ostatu_mota = 'Agroturismos'"
                Else
                    sql = sql + " Ostatu_mota = 'Agroturismos'"
                End If

            End If
        End If

        Dim ds As New DataSet
        Dim ostatu As String = TextBox1.Text

        Dim adaptador As New MySqlDataAdapter(sql, conexionbd)
        ds.Tables.Add("tabla")
        adaptador.Fill(ds.Tables("tabla"))
        GridView2.DataSource = ds.Tables("tabla")
        GridView2.DataBind()
    End Sub

    Protected Sub GridView2_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView2.PageIndexChanging
        GridView2.PageIndex = e.NewPageIndex
        conexionbd.Open()
        taulaBeteGonbidatua()
        conexionbd.Close()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Erabiltzaile_erreserbak.aspx")
    End Sub
End Class