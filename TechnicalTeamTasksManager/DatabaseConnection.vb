Imports MySql.Data.MySqlClient
Module DatabaseConnection

    Public connectionString As String =
            "Server=localhost;" &
"Port=3306;" &
            "Database=technical_team_manager;" &
"Uid=root;" &
"Pwd=" &
TTMDatabaseConfig.GetDatabasePassword() & ";" &
"SslMode=Required;"
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Module
