Public Class UserForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        'Now lets start to ad new user we will use the simplest form of adding a user

        ' First we will check for if the same user exsits

        Dim username As String = UsernameText.Text
        Dim password As String = PasswordText.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            Dim getData As New EmployeeDAL
            Dim sqlGetUser As String = "Select * from muser where username='" & username & "' and "
            sqlGetUser = sqlGetUser + " password='" & password & "'"

            If getData.getScalar(sqlGetUser) <= 0 Then
                'Allow to create the username and password
                Dim sqlInserUser As String
                sqlInserUser = "insert into muser(username,password,empno) values("
                sqlInserUser = sqlInserUser + "'" & username & "','" & password & "',1)"

                getData.getScalar(sqlInserUser)

                MessageBox.Show("User has been created successfully")

                'Referesh the grid with the new user
                getUserList()
            Else
                'Notify that the username is exists
                MessageBox.Show("Username exists please try different username")

            End If
        Else
            MessageBox.Show("Empty username or password not accepted")
        End If


    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getUserList()

    End Sub

    Private Sub getUserList()
        Dim getData As New EmployeeDAL
        Dim sqlGetUser As String = "Select * from muser"

        Dim dtUser As New DataTable
        dtUser = getData.getDetails(sqlGetUser)

        UsersList.DataSource = dtUser
    End Sub

    Private Sub UsersList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersList.CellContentClick





    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        ' Now we will upate the added user
        'We will use the same method of adding the user, except we will use the UPDATE statment
        'And Also we will click on the userList grid to copy data to text emelemnt

        Dim username As String = UsernameText.Text
        Dim password As String = PasswordText.Text
        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            Dim getData As New EmployeeDAL
            '   Dim sqlGetUser As String = "Update  muser set Password='" & password & "' where  "
            '  sqlGetUser = sqlGetUser + " UserID=" & UserIDText.Text

            '   If getData.getScalar(sqlGetUser) <= 0 Then
            'Allow to create the username and password
            Dim sqlInserUser As String
            sqlInserUser = "Update  muser set password = '" & password & "' "
            sqlInserUser = sqlInserUser + "where userID=" & UserIDText.Text

            'clearing text elements
            UpdateButton.Enabled = False
            UsernameText.Text = ""
            PasswordText.Text = ""
            UserIDText.Text = ""

            getData.getScalar(sqlInserUser)
            MessageBox.Show("User has been updated successfully")
            getUserList()

        Else


        End If

    End Sub



    Private Sub UsersList_MouseClick(sender As Object, e As MouseEventArgs) Handles UsersList.MouseClick
        ' we will use mouse click on the grid view instead of select change to prevent select row when loading the form
        UserIDText.Text = UsersList.CurrentRow.Cells(0).Value
        UsernameText.Text = UsersList.CurrentRow.Cells(1).Value
        PasswordText.Text = ""

        UpdateButton.Enabled = True
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class