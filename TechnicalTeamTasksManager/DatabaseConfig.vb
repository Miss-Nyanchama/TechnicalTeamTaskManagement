Public Module TTMDatabaseConfig
    Public Function GetDatabasePassword() As String
        Return Environment.GetEnvironmentVariable("TTM_DB_PASSWORD")
    End Function
End Module