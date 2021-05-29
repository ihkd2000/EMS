Imports System.Data.SqlClient

Public Class DepartmentForm
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()

    End Sub

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click
        ' We are going to use previous form coding to accelerate the implementation

        'Now lets start to ad new user we will use the simplest form of adding a user

        ' First we will check for if the same user exsits

        ' Dim DepNo As Int32 = DepNoText.Text
        Dim DepName As String = DepartmentText.Text
        Dim DepDesc As String = DescriptionText.Text

        If Not String.IsNullOrEmpty(DepName) Then
            Dim getData As New EmployeeDAL
            'Here we will check if we already added the dep already before
            Dim sqlGetDep As String = "Select count(*) from department where DepName='" & DepName & "'"


            If getData.getScalar(sqlGetDep) <= 0 Then
                'Allow to create the new department
                Dim sqlInsertDep As String
                sqlInsertDep = "insert into department(depname,description) values("
                sqlInsertDep = sqlInsertDep + "'" & DepName & "','" & DepDesc & "')"

                getData.getScalar(sqlInsertDep)

                MessageBox.Show("New department has been created successfully")

                'Referesh the grid with the new user
                getDepList()
            Else
                'Notify that the username is exists
                MessageBox.Show("Department name aleady exists please try new department")

            End If
        Else
            MessageBox.Show("Empty department name not allowed")
        End If

    End Sub

    Sub getDepList()
        Dim getData As New EmployeeDAL
        Dim sqlGetDept As String = "Select * from department"

        Dim dtUser As New DataTable
        dtUser = getData.getDetails(sqlGetDept)

        DepartmentsListGrid.DataSource = dtUser
    End Sub

    Private Sub DepartmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDepList()
    End Sub

    Private Sub DepartmentsListGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DepartmentsListGrid.CellContentClick

        DepNoText.Text = DepartmentsListGrid.CurrentRow.Cells(0).Value
        DepartmentText.Text = DepartmentsListGrid.CurrentRow.Cells(1).Value
        DescriptionText.Text = DepartmentsListGrid.CurrentRow.Cells(2).Value

        UpdateButton.Enabled = True
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim depNo As Integer = DepNoText.Text
        Dim deName As String = DepartmentText.Text
        Dim depDesc As String = DescriptionText.Text

        If Not String.IsNullOrEmpty(deName) Then
            Dim getData As New EmployeeDAL
            '   Dim sqlGetUser As String = "Update  muser set Password='" & password & "' where  "
            '  sqlGetUser = sqlGetUser + " UserID=" & UserIDText.Text

            '   If getData.getScalar(sqlGetUser) <= 0 Then
            'Allow to create the username and password
            Dim sqlInsertDep As String
            sqlInsertDep = "Update  department set DepName = '" & deName & "' , description='" & depDesc
            sqlInsertDep = sqlInsertDep + "' "
            sqlInsertDep = sqlInsertDep + "where DepID=" & depNo

            'clearing text elements
            UpdateButton.Enabled = False
            DepNoText.Text = ""
            DepartmentText.Text = ""
            DescriptionText.Text = ""

            getData.getScalar(sqlInsertDep)
            MessageBox.Show("Department has been updated successfully")
            getDepList()

        Else


        End If
    End Sub
End Class