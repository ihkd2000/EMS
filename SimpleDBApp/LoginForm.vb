Imports System.Data.SqlClient

Public Class LoginForm


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Defining variables Update 2022/07
        'Dim username As String = textUsername.Text
        'Dim password As String = textPassword.Text

        'If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
        '    'Define Data access layer object that inherets from EmployeeDAL to use function to interact
        '    ' with the database
        '    Dim empD As New EmployeeDAL

        '    'Creating the select statement to validate the username and password
        '    Dim sql As String = "select count(*) from muser where username='" & username &
        '        "' and password='" & password & "'"
        '    Dim isValidated = empD.getReader(sql) ' We are using function to read single record from the database

        '    If isValidated = 0 Then ' If there is no record that matches the username and password validation or access denied
        '        MessageBox.Show("Username or password incorrect, please make sure you have a valid redential.")
        '    ElseIf isValidated = 1 Then ' Here the username & password validated with a correct and exist credentials
        '        EmployeeDataForm.Show()
        '        Me.Hide()

        '    End If
        'Else
        '    MessageBox.Show("Please input a valid username and password")
        'End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close() ' Here we cancel login to the system
    End Sub
End Class
