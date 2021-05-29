<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchEmployeeForm
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
        Me.MobileNoText = New System.Windows.Forms.TextBox()
        Me.EmployeeName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HireDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EmployeeListGrid = New System.Windows.Forms.DataGridView()
        Me.colLink = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colEmpNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departmentCombo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.EmployeeListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MobileNoText
        '
        Me.MobileNoText.Location = New System.Drawing.Point(496, 36)
        Me.MobileNoText.Name = "MobileNoText"
        Me.MobileNoText.Size = New System.Drawing.Size(219, 24)
        Me.MobileNoText.TabIndex = 12
        '
        'EmployeeName
        '
        Me.EmployeeName.Location = New System.Drawing.Point(132, 39)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(270, 24)
        Me.EmployeeName.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mobile No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Employee Name"
        '
        'HireDatePicker
        '
        Me.HireDatePicker.Location = New System.Drawing.Point(496, 66)
        Me.HireDatePicker.Name = "HireDatePicker"
        Me.HireDatePicker.Size = New System.Drawing.Size(219, 24)
        Me.HireDatePicker.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Hire Date"
        '
        'EmployeeListGrid
        '
        Me.EmployeeListGrid.AllowUserToAddRows = False
        Me.EmployeeListGrid.AllowUserToDeleteRows = False
        Me.EmployeeListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeListGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLink, Me.colEmpNo})
        Me.EmployeeListGrid.Location = New System.Drawing.Point(24, 150)
        Me.EmployeeListGrid.Name = "EmployeeListGrid"
        Me.EmployeeListGrid.ReadOnly = True
        Me.EmployeeListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeListGrid.Size = New System.Drawing.Size(711, 290)
        Me.EmployeeListGrid.TabIndex = 15
        '
        'colLink
        '
        Me.colLink.DataPropertyName = "EmpNo"
        Me.colLink.HeaderText = "Select"
        Me.colLink.Name = "colLink"
        Me.colLink.ReadOnly = True
        Me.colLink.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colLink.Text = "Select"
        Me.colLink.UseColumnTextForLinkValue = True
        '
        'colEmpNo
        '
        Me.colEmpNo.DataPropertyName = "EmpNo"
        Me.colEmpNo.HeaderText = "EmpNo"
        Me.colEmpNo.Name = "colEmpNo"
        Me.colEmpNo.ReadOnly = True
        Me.colEmpNo.Visible = False
        '
        'departmentCombo
        '
        Me.departmentCombo.FormattingEnabled = True
        Me.departmentCombo.Location = New System.Drawing.Point(132, 69)
        Me.departmentCombo.Name = "departmentCombo"
        Me.departmentCombo.Size = New System.Drawing.Size(270, 24)
        Me.departmentCombo.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Department"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(132, 105)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(131, 29)
        Me.SearchButton.TabIndex = 18
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CloseButton.Location = New System.Drawing.Point(269, 105)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(133, 29)
        Me.CloseButton.TabIndex = 19
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SearchEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 452)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.departmentCombo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EmployeeListGrid)
        Me.Controls.Add(Me.HireDatePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MobileNoText)
        Me.Controls.Add(Me.EmployeeName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SearchEmployeeForm"
        Me.Text = "Search for Employee"
        CType(Me.EmployeeListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MobileNoText As TextBox
    Friend WithEvents EmployeeName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HireDatePicker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents EmployeeListGrid As DataGridView
    Friend WithEvents departmentCombo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents colLink As DataGridViewLinkColumn
    Friend WithEvents colEmpNo As DataGridViewTextBoxColumn
End Class
