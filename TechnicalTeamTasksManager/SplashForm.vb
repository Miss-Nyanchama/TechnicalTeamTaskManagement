Imports MySql.Data.MySqlClient
Public Class SplashForm
    Private Sub CheckDatabaseConnection()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
            End Using

            lblConnectionsStatus.Text =
               "✓ Connected to database"
        Catch ex As Exception
            lblConnectionsStatus.Text =
                "Database connection failed"
            MessageBox.Show(ex.Message, "Database Connection Error")

        End Try
    End Sub

    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 10
        Else
            splashTimer.Stop()

        End If
    End Sub

    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        lblLoading.Text = "Loading application..."
        lblConnectionsStatus.Text =
            "Checking database connection..."

        CheckDatabaseConnection()
        splashTimer.Start()
    End Sub

End Class
