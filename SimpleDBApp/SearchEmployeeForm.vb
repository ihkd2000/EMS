Public Class SearchEmployeeForm
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'Me.Close()

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim empName As String = EmployeeName.Text

        Dim getEmployee As New EmployeeDAL
        Dim dtEmployee As New DataTable
        Dim sqlEmployee As String
        Dim depNo As Integer = departmentCombo.SelectedValue

        ' Get all data that matches employee name
        sqlEmployee = "select * from employee where empname like '" & empName & "%'"
        If depNo > 0 Then
            sqlEmployee = sqlEmployee + " and depNo=" & departmentCombo.SelectedValue
        End If
        dtEmployee = getEmployee.getDetails(sqlEmployee)
            If dtEmployee.Rows.Count > 0 Then
                EmployeeListGrid.DataSource = dtEmployee

            Else
                MessageBox.Show("No data found")
            End If


    End Sub

    Private Sub EmployeeListGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeListGrid.CellContentClick
        empNoProperty = EmployeeListGrid.CurrentRow.Cells("colEmpNo").Value

    End Sub

    Sub getDepartments()
        Dim depData As New EmployeeDAL

        Dim sqlDepartment As String = "Select * from department"

        departmentCombo.DataSource = depData.getDetails(sqlDepartment)
        departmentCombo.DisplayMember = "DepName"
        departmentCombo.ValueMember = "DepID"
    End Sub

    Private empNoProperty As Integer
    Public Property empNoProp() As Integer
        Get
            Return empNoProperty
        End Get
        Set(ByVal value As Integer)
            empNoProperty = value
        End Set
    End Property

    Private Sub SearchEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDepartments()
    End Sub
End Class