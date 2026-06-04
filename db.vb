
Imports System.Data.SqlClient
Module db

    Public Class Database

        Private Shared ReadOnly connStr As String =
            "Server=localhost\SQLEXPRESS;Database=Sale_Management;Trusted_Connection=True;"

        Public Shared Function GetConnection() As SqlConnection
            Return New SqlConnection(connStr)
        End Function

    End Class
End Module
