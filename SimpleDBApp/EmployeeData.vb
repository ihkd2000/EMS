Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class EmployeeDataForm
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click
        'Define a the functionality of adding the employee
        Dim empImage As String


        Dim empAddNew As New EmployeeDAL

        Try
            Dim sqlInsert As String
            Dim imageName = Year(Now) & Month(Now) & Hour(Now) & Minute(Now) & Second(Now)
            Dim imageDirectory = AppDomain.CurrentDomain.BaseDirectory & "\images\"
            empImage = imageDirectory & imageName & ".jpg"

            sqlInsert = "INSERT INTO Employee (EmpName, Address, City, Country, MobileNo, Salary, HireDate, EmpImage,DepNo) "
            sqlInsert = sqlInsert + " Values('" & EmployeeName.Text & "','" & AddressText.Text & "','"
            sqlInsert = sqlInsert + CityText.Text & "','" & CountryText.Text & "','" & MobileNoText.Text
            sqlInsert = sqlInsert + "'," & SalaryText.Text & ",'" & HireDatePicker.Value.ToShortDateString & "','" & imageName & ".jpg" & "'," & departmentCombo.SelectedValue & ")"

            empAddNew.getScalar(sqlInsert)

            EmployeePicture.Image.Save(empImage, ImageFormat.Jpeg)

            MessageBox.Show("New employee has been recorded successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

    End Sub

    Private Sub InsertImageButton_Click(sender As Object, e As EventArgs) Handles InsertImageButton.Click
        Dim imageDiag As New OpenFileDialog
        imageDiag.InitialDirectory = "C:\Users\ApplicationDev\Downloads\images"
        If imageDiag.ShowDialog = DialogResult.OK Then
            Dim empImage As Image = New Bitmap(imageDiag.FileName)
            EmployeePicture.Image = empImage
        End If

    End Sub

    Sub getDeparments()
        Dim dep As New EmployeeDAL
        Dim dtDept As New DataTable
        dtDept = dep.getDetails("Select * from department")

        departmentCombo.DataSource = dtDept
        departmentCombo.ValueMember = "DepID"
        departmentCombo.DisplayMember = "DepName"
    End Sub

    Private Sub EmployeeDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDeparments()
    End Sub

    Private Sub FindEmployeeLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FindEmployeeLink.LinkClicked
        Dim searchFormDiag As New SearchEmployeeForm


        If searchFormDiag.ShowDialog = DialogResult.OK Then
            employeeNoText.Text = searchFormDiag.empNoProp
            getEmployeeInformation(employeeNoText.Text)
            UpdateButton.Enabled = True
            AddNewButton.Enabled = False
        End If

    End Sub

    Sub getEmployeeInformation(empNo As Integer)
        Dim empDetails As New EmployeeDAL
        Dim dtEmployeeDetails As New DataTable
        Dim sqlEmployee As String

        sqlEmployee = "select * from employee where empno=" & empNo

        dtEmployeeDetails = empDetails.getDetails(sqlEmployee)

        If dtEmployeeDetails.Rows.Count > 0 Then

            With dtEmployeeDetails.Rows(0)
                EmployeeName.Text = .Item("EmpName").ToString
                SalaryText.Text = .Item("Salary").ToString
                AddressText.Text = .Item("Address").ToString
                CityText.Text = .Item("City").ToString
                CountryText.Text = .Item("Country").ToString
                MobileNoText.Text = .Item("MobileNo").ToString

                HireDatePicker.Value = .Item("HireDate").ToString
                ' CommentText.Text = .Item("Comment").ToString // No comment column added we will add it later on

                'Now we will grap the image and display it in the picture box
                Dim empImage As String = .Item("EmpImage").ToString
                Dim imageDirectory As String = AppDomain.CurrentDomain.BaseDirectory() & "\images\"

                If Not String.IsNullOrEmpty(empImage) Then
                    EmployeePicture.Image = New Bitmap(imageDirectory & empImage)
                Else
                    EmployeePicture.Image = Nothing

                End If
            End With
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim sqlUpdateEmp As String

        sqlUpdateEmp = "Update Employee set "
        sqlUpdateEmp = sqlUpdateEmp & "  EmpName='" & EmployeeName.Text & "', "
        sqlUpdateEmp = sqlUpdateEmp & "  Address='" & AddressText.Text & "', "
        sqlUpdateEmp = sqlUpdateEmp & "  City='" & CityText.Text & "', "
        sqlUpdateEmp = sqlUpdateEmp & "  Country='" & CountryText.Text & "', "
        sqlUpdateEmp = sqlUpdateEmp & "  MobileNo='" & MobileNoText.Text & "',"
        sqlUpdateEmp = sqlUpdateEmp & "  Salary='" & SalaryText.Text & "', "
        sqlUpdateEmp = sqlUpdateEmp & "  HireDate ='" & HireDatePicker.Value & "', "
        sqlUpdateEmp = sqlUpdateEmp & "  DepNo = " & departmentCombo.SelectedValue & "   "
        sqlUpdateEmp = sqlUpdateEmp & "  where EmpNo=" & employeeNoText.Text

        Dim updateEmployee As New EmployeeDAL


        If updateEmployee.updateData(sqlUpdateEmp) > 0 Then ' Check the affected row on update 0> updated
            MessageBox.Show(EmployeeName.Text & ", record has been updated successfully.")
        Else
            MessageBox.Show("No recod has been udpdated")

        End If
        clearElements()
        UpdateButton.Enabled = False
        AddNewButton.Enabled = True
    End Sub
    Sub clearElements() 'after update
        EmployeeName.Text = ""
        AddressText.Text = ""
        CityText.Text = ""
        CountryText.Text = ""
        MobileNoText.Text = ""
        SalaryText.Text = ""
        employeeNoText.Text = ""
        CommentText.Text = ""
    End Sub
End Class