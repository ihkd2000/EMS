<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentForm
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
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DepartmentText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DepartmentsListGrid = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DepNoText = New System.Windows.Forms.TextBox()
        CType(Me.DepartmentsListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddNewButton
        '
        Me.AddNewButton.Location = New System.Drawing.Point(127, 152)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(89, 29)
        Me.AddNewButton.TabIndex = 11
        Me.AddNewButton.Text = "Add New"
        Me.AddNewButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(241, 152)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(89, 29)
        Me.UpdateButton.TabIndex = 12
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(346, 152)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(89, 29)
        Me.CloseButton.TabIndex = 13
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DepartmentText
        '
        Me.DepartmentText.Location = New System.Drawing.Point(127, 58)
        Me.DepartmentText.Name = "DepartmentText"
        Me.DepartmentText.Size = New System.Drawing.Size(308, 23)
        Me.DepartmentText.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Department"
        '
        'DescriptionText
        '
        Me.DescriptionText.Location = New System.Drawing.Point(127, 87)
        Me.DescriptionText.Multiline = True
        Me.DescriptionText.Name = "DescriptionText"
        Me.DescriptionText.Size = New System.Drawing.Size(308, 49)
        Me.DescriptionText.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Description"
        '
        'DepartmentsListGrid
        '
        Me.DepartmentsListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartmentsListGrid.Location = New System.Drawing.Point(24, 205)
        Me.DepartmentsListGrid.Name = "DepartmentsListGrid"
        Me.DepartmentsListGrid.Size = New System.Drawing.Size(411, 165)
        Me.DepartmentsListGrid.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Dep No."
        '
        'DepNoText
        '
        Me.DepNoText.Enabled = False
        Me.DepNoText.Location = New System.Drawing.Point(127, 29)
        Me.DepNoText.Name = "DepNoText"
        Me.DepNoText.Size = New System.Drawing.Size(308, 23)
        Me.DepNoText.TabIndex = 15
        '
        'DepartmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(463, 382)
        Me.Controls.Add(Me.DepartmentsListGrid)
        Me.Controls.Add(Me.DescriptionText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DepNoText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DepartmentText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddNewButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DepartmentForm"
        Me.Text = "Departments"
        CType(Me.DepartmentsListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddNewButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents DepartmentText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DescriptionText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DepartmentsListGrid As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DepNoText As TextBox
End Class
