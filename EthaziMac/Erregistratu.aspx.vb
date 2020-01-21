Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim conexionbd As MySqlConnection
    Dim array_erabiltzaileak As ArrayList = New ArrayList()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    'Erregistratu
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Konprobaketa_globala As Boolean = False


        Dim izen_abizenak As String = TextBox1.Text
        Dim erabiltzailea As String = TextBox2.Text
        Dim pasahitza As String = TextBox3.Text
        Dim balid_pasahitza As String = TextBox4.Text
        Dim telefonoa As String = TextBox5.Text
        Dim email As String = TextBox6.Text


        If izen_abizenak.Equals(Nothing) Or izen_abizenak.Equals("") Then

            MessageBox.Show("Izen Abizenak txarto")


        End If
        If erabiltzailea.Equals(Nothing) Or erabiltzailea.Equals("") Then

            MessageBox.Show("Erabiltzaile hau ezin da hautatu. Sartu beste bat.")
        End If
        If pasahitza.Equals(Nothing) Or pasahitza.Equals("") Then

            MessageBox.Show("Pasahitza txarto")
        End If
        If balid_pasahitza.Equals(Nothing) Or balid_pasahitza.Equals("") Then

            MessageBox.Show("Pasahitza txarto")
        End If
        If telefonoa.Equals(Nothing) Or telefonoa.Equals("") Then

            MessageBox.Show("Telefonoa txarto ")
        End If
        If email.Equals(Nothing) Or email.Equals("") Then

            MessageBox.Show("Email txarto")
        End If
        Try
            Dim Konprobaketa_erabiltzailea As Boolean = konprobatuErabiltzailea(erabiltzailea)

            Dim Konprobaketa_pasahitza As Boolean = konprobatuPasahitzak(pasahitza, balid_pasahitza)

            If Konprobaketa_erabiltzailea = True And Konprobaketa_pasahitza = True Then
                Konprobaketa_globala = True
            End If

            If Konprobaketa_globala = True Then

                insertBD(izen_abizenak, erabiltzailea, pasahitza, telefonoa, email)

                Response.Redirect("Login.aspx")
            End If

        Catch ex As Exception


        End Try



    End Sub

    Private Function konprobatuPasahitzak(pasahitza As String, balid_pasahitza As String)
        If Not pasahitza.Equals(balid_pasahitza) Then
            MessageBox.Show("Pasahitzak berdinak izan behar dira")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub insertBD(izen_abizenak As String, erabiltzailea As String, pasahitza As String, telefonoa As String, email As String)
        conexionbd.Open()
        Dim SQL As MySqlCommand = New MySqlCommand("INSERT INTO `erabiltzaile`(`erabiltzaile`, `pasahitza`, `mail`, `telefonoa`, `Erabiltzaile_mota`, `Izen Abizenak`) VALUES ('" + erabiltzailea + "' , '" + pasahitza + "' , '" + email + "' , '" + telefonoa + "' , '1' , '" + izen_abizenak + "')", conexionbd)
        SQL.ExecuteNonQuery()
        conexionbd.Close()
    End Sub

    Private Function konprobatuErabiltzailea(erabiltzailea As String)
        Dim balidazioa As Boolean = False
        conexionbd = New MySqlConnection()
        conexionbd.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=mydb"
        Dim SQL As MySqlCommand = conexionbd.CreateCommand()
        SQL.CommandText = "SELECT erabiltzaile from erabiltzaile"
        conexionbd.Open()
        Dim rs As MySqlDataReader = SQL.ExecuteReader()
        Try


            rs.Read()

            array_erabiltzaileak.Add(rs(0).ToString)

            While rs.Read
                array_erabiltzaileak.Add(rs(0).ToString)
            End While
        Catch
            MessageBox.Show("Barne errorea")
        Finally
            rs.Close()
            conexionbd.Close()

        End Try


        For Each izena As String In array_erabiltzaileak

            If (izena.Equals(erabiltzailea)) Then

                balidazioa = False
            Else
                balidazioa = True

            End If
        Next

        If balidazioa = False Then
            MessageBox.Show("Erabiltzaile hau hautatuta dago")
        End If

        Return balidazioa
    End Function

    'Ezeztatu
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class