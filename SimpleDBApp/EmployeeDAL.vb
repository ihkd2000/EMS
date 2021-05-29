Imports System.Data.SqlClient

Public Class EmployeeDAL

    Function getScalar(sqlString As String) As Integer


        Dim con As New DBCon

        Try
            If con.getConnection.State = ConnectionState.Closed Then
                con.getConnection.Open()
            End If

            'Here we will pass a function that returns the number of records found if >0 then there is a match
            ' if the return value 0 there is no match found
            Dim sqlCommand As New SqlCommand(sqlString, con.getConnection)

            Dim isRecordFound = sqlCommand.ExecuteScalar()

            Return isRecordFound

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0 ' No record found
        End Try

    End Function

    Function getDetails(sqlString As String) As DataTable ' We also can pass insert statement here

        Dim con As New DBCon

        Try
            If con.getConnection.State = ConnectionState.Closed Then
                con.getConnection.Open()
            End If

            'Here we will pass a function that returns the number of records found if >0 then there is a match
            ' if the return value 0 there is no match found
            ' Dim sqlCommand As New SqlDataAdapter(sqlString, con.getConnection)

            Dim dtData As New DataTable
            Dim da As New SqlDataAdapter(sqlString, con.getConnection)


            da.Fill(dtData)
            Return dtData 'Return any data found from the database

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing  ' as we are dealing with an object we will return nothing
        End Try


    End Function

    Function updateData(sqlUpdate As String) As Integer


        Dim con As New DBCon

        Try
            If con.getConnection.State = ConnectionState.Closed Then
                con.getConnection.Open()
            End If

            'Here we will pass a function that returns the number of records found if >0 then there is a match
            ' if the return value 0 there is no match found
            Dim sqlCommand As New SqlCommand(sqlUpdate, con.getConnection)

            Dim affectedRecords As Integer = sqlCommand.ExecuteNonQuery()

            Return affectedRecords

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0 ' No record found
        End Try

    End Function
End Class
