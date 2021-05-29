Imports System.Data.SqlClient


Public Class DBCon

    Public Function getConnection() As SqlConnection
        Dim conString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ApplicationDev\Source\Repos\SimpleDBApp\SimpleDBApp\EmployeeMSDB.mdf;Integrated Security=True"

        Try
            Dim con As New SqlConnection
            con.ConnectionString = conString

            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If

            Return con

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
