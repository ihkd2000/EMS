Imports System.Windows.Forms

Public Class EMSParent

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New DepartmentForm
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        ChildForm.Show()
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private m_ChildFormNumber As Integer

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New EmployeeDataForm

        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        ChildForm.Show()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New SearchEmployeeForm
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        ChildForm.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New UserForm
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        ChildForm.Show()
    End Sub
End Class
