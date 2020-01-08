Public Class WebForm1
    Inherits System.Web.UI.Page



    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim myConnectionString As String

        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=;" _
                    & "database=mydb"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class