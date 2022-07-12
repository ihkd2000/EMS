<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDataForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmployeeName = New System.Windows.Forms.TextBox()
        Me.AddressText = New System.Windows.Forms.TextBox()
        Me.CityText = New System.Windows.Forms.TextBox()
        Me.MobileNoText = New System.Windows.Forms.TextBox()
        Me.CountryText = New System.Windows.Forms.TextBox()
        Me.CommentText = New System.Windows.Forms.TextBox()
        Me.HireDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.EmployeePicture = New System.Windows.Forms.PictureBox()
        Me.InsertImageButton = New System.Windows.Forms.Button()
        Me.departmentCombo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FindEmployeeLink = New System.Windows.Forms.LinkLabel()
        Me.Salary = New System.Windows.Forms.Label()
        Me.SalaryText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.employeeNoText = New System.Windows.Forms.TextBox()
        CType(Me.EmployeePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Country"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mobile No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Hire Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Comments"
        '
        'EmployeeName
        '
        Me.EmployeeName.Location = New System.Drawing.Point(157, 69)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(211, 23)
        Me.EmployeeName.TabIndex = 0
        '
        'AddressText
        '
        Me.AddressText.Location = New System.Drawing.Point(157, 158)
        Me.AddressText.Name = "AddressText"
        Me.AddressText.Size = New System.Drawing.Size(308, 23)
        Me.AddressText.TabIndex = 4
        '
        'CityText
        '
        Me.CityText.Location = New System.Drawing.Point(157, 189)
        Me.CityText.Name = "CityText"
        Me.CityText.Size = New System.Drawing.Size(105, 23)
        Me.CityText.TabIndex = 5
        '
        'MobileNoText
        '
        Me.MobileNoText.Location = New System.Drawing.Point(157, 100)
        Me.MobileNoText.Name = "MobileNoText"
        Me.MobileNoText.Size = New System.Drawing.Size(105, 23)
        Me.MobileNoText.TabIndex = 1
        '
        'CountryText
        '
        Me.CountryText.Location = New System.Drawing.Point(326, 189)
        Me.CountryText.Name = "CountryText"
        Me.CountryText.Size = New System.Drawing.Size(139, 23)
        Me.CountryText.TabIndex = 6
        '
        'CommentText
        '
        Me.CommentText.Location = New System.Drawing.Point(157, 249)
        Me.CommentText.Multiline = True
        Me.CommentText.Name = "CommentText"
        Me.CommentText.Size = New System.Drawing.Size(308, 65)
        Me.CommentText.TabIndex = 8
        '
        'HireDatePicker
        '
        Me.HireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HireDatePicker.Location = New System.Drawing.Point(335, 100)
        Me.HireDatePicker.Name = "HireDatePicker"
        Me.HireDatePicker.Size = New System.Drawing.Size(130, 23)
        Me.HireDatePicker.TabIndex = 2
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(376, 335)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(89, 29)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(271, 335)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(89, 29)
        Me.UpdateButton.TabIndex = 12
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AddNewButton
        '
        Me.AddNewButton.Location = New System.Drawing.Point(157, 335)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(89, 29)
        Me.AddNewButton.TabIndex = 10
        Me.AddNewButton.Text = "Add New"
        Me.AddNewButton.UseVisualStyleBackColor = True
        '
        'EmployeePicture
        '
        Me.EmployeePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmployeePicture.Location = New System.Drawing.Point(485, 35)
        Me.EmployeePicture.Name = "EmployeePicture"
        Me.EmployeePicture.Size = New System.Drawing.Size(154, 154)
        Me.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmployeePicture.TabIndex = 12
        Me.EmployeePicture.TabStop = False
        '
        'InsertImageButton
        '
        Me.InsertImageButton.Location = New System.Drawing.Point(485, 195)
        Me.InsertImageButton.Name = "InsertImageButton"
        Me.InsertImageButton.Size = New System.Drawing.Size(154, 29)
        Me.InsertImageButton.TabIndex = 9
        Me.InsertImageButton.Text = "Insert Image"
        Me.InsertImageButton.UseVisualStyleBackColor = True
        '
        'departmentCombo
        '
        Me.departmentCombo.FormattingEnabled = True
        Me.departmentCombo.Location = New System.Drawing.Point(157, 219)
        Me.departmentCombo.Name = "departmentCombo"
        Me.departmentCombo.Size = New System.Drawing.Size(308, 24)
        Me.departmentCombo.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Departments"
        '
        'FindEmployeeLink
        '
        Me.FindEmployeeLink.AutoSize = True
        Me.FindEmployeeLink.Location = New System.Drawing.Point(374, 72)
        Me.FindEmployeeLink.Name = "FindEmployeeLink"
        Me.FindEmployeeLink.Size = New System.Drawing.Size(90, 16)
        Me.FindEmployeeLink.TabIndex = 14
        Me.FindEmployeeLink.TabStop = True
        Me.FindEmployeeLink.Text = "Find Employee"
        '
        'Salary
        '
        Me.Salary.AutoSize = True
        Me.Salary.Location = New System.Drawing.Point(52, 132)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(43, 16)
        Me.Salary.TabIndex = 4
        Me.Salary.Text = "Salary"
        '
        'SalaryText
        '
        Me.SalaryText.Location = New System.Drawing.Point(157, 129)
        Me.SalaryText.Name = "SalaryText"
        Me.SalaryText.Size = New System.Drawing.Size(105, 23)
        Me.SalaryText.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Employee No"
        '
        'employeeNoText
        '
        Me.employeeNoText.Location = New System.Drawing.Point(157, 40)
        Me.employeeNoText.Name = "employeeNoText"
        Me.employeeNoText.Size = New System.Drawing.Size(211, 23)
        Me.employeeNoText.TabIndex = 0
        '
        'EmployeeDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 381)
        Me.Controls.Add(Me.FindEmployeeLink)
        Me.Controls.Add(Me.departmentCombo)
        Me.Controls.Add(Me.EmployeePicture)
        Me.Controls.Add(Me.InsertImageButton)
        Me.Controls.Add(Me.AddNewButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.HireDatePicker)
        Me.Controls.Add(Me.SalaryText)
        Me.Controls.Add(Me.MobileNoText)
        Me.Controls.Add(Me.CommentText)
        Me.Controls.Add(Me.CountryText)
        Me.Controls.Add(Me.CityText)
        Me.Controls.Add(Me.AddressText)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.employeeNoText)
        Me.Controls.Add(Me.EmployeeName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EmployeeDataForm"
        Me.Text = "Employee Information Data"
        CType(Me.EmployeePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EmployeeName As TextBox
    Friend WithEvents AddressText As TextBox
    Friend WithEvents CityText As TextBox
    Friend WithEvents MobileNoText As TextBox
    Friend WithEvents CountryText As TextBox
    Friend WithEvents CommentText As TextBox
    Friend WithEvents HireDatePicker As DateTimePicker
    Friend WithEvents CloseButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents AddNewButton As Button
    Friend WithEvents EmployeePicture As PictureBox
    Friend WithEvents InsertImageButton As Button
    Friend WithEvents departmentCombo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FindEmployeeLink As LinkLabel
    Friend WithEvents Salary As Label
    Friend WithEvents SalaryText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents employeeNoText As TextBox
End Class
