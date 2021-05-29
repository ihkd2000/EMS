<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.UsernameText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmployeeList = New System.Windows.Forms.ComboBox()
        Me.UsersList = New System.Windows.Forms.DataGridView()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserIDText = New System.Windows.Forms.TextBox()
        CType(Me.UsersList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(214, 153)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(84, 28)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(123, 153)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(85, 28)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'PasswordText
        '
        Me.PasswordText.Location = New System.Drawing.Point(123, 94)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(221, 23)
        Me.PasswordText.TabIndex = 4
        '
        'UsernameText
        '
        Me.UsernameText.Location = New System.Drawing.Point(123, 65)
        Me.UsernameText.Name = "UsernameText"
        Me.UsernameText.Size = New System.Drawing.Size(221, 23)
        Me.UsernameText.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee"
        '
        'EmployeeList
        '
        Me.EmployeeList.FormattingEnabled = True
        Me.EmployeeList.Location = New System.Drawing.Point(123, 123)
        Me.EmployeeList.Name = "EmployeeList"
        Me.EmployeeList.Size = New System.Drawing.Size(221, 24)
        Me.EmployeeList.TabIndex = 6
        '
        'UsersList
        '
        Me.UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersList.Location = New System.Drawing.Point(38, 195)
        Me.UsersList.Name = "UsersList"
        Me.UsersList.Size = New System.Drawing.Size(394, 150)
        Me.UsersList.TabIndex = 7
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(304, 153)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(84, 28)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User ID"
        '
        'UserIDText
        '
        Me.UserIDText.Enabled = False
        Me.UserIDText.Location = New System.Drawing.Point(123, 36)
        Me.UserIDText.Name = "UserIDText"
        Me.UserIDText.Size = New System.Drawing.Size(221, 23)
        Me.UserIDText.TabIndex = 5
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 367)
        Me.Controls.Add(Me.UsersList)
        Me.Controls.Add(Me.EmployeeList)
        Me.Controls.Add(Me.UserIDText)
        Me.Controls.Add(Me.UsernameText)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "UserForm"
        Me.Text = "User"
        CType(Me.UsersList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents UsernameText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmployeeList As ComboBox
    Friend WithEvents UsersList As DataGridView
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents UserIDText As TextBox
End Class
