Public Class Regristration ' citation to Hugeicons, Google, Gemini, StackOverFlow, and VB Forums 
    ' source for code on StackOverFlow: https://stackoverflow.com/a/36729373
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Dim connect As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PasswordDatabase.accdb")


    Private Sub Visability_Click(sender As Object, e As EventArgs) Handles Visability.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            Visability.BackgroundImage = Image.FromFile("view-off-slash-Stroke-Rounded.png")
        Else
            txtPassword.PasswordChar = "*"
            Visability.BackgroundImage = Image.FromFile("view-Stroke-Rounded.png")
        End If
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        If txtUsername.Text = "" Then
            errorLabel.Text = "Username cannot be empty."
        ElseIf txtPassword.Text = "" Then
            errorLabel.Text = "Password cannot be empty."
        ElseIf txtFirstName.Text = "" Then
            errorLabel.Text = "First Name cannot be empty."
        ElseIf txtLastName.Text = "" Then
            errorLabel.Text = "Last Name cannot be empty."
        Else
            Dim sqlCheck As String = "SELECT COUNT(*) FROM creds WHERE Username = @Username"
            Dim cmdCheck As OleDb.OleDbCommand = New OleDb.OleDbCommand(sqlCheck, connect)
            cmdCheck.Parameters.AddWithValue("@Username", txtUsername.Text)
            connect.Open()
            Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
            connect.Close()
            If count > 0 Then
                errorLabel.Text = "Username already exists." & vbNewLine & "Please choose a different username."
                Return
            End If
            Dim sql As String = "INSERT INTO creds ([Username], [Password], [First Name], [Last Name]) VALUES (@Username, @Password, @FirstName, @LastName)"
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
            connect.Open()
            cmd.ExecuteNonQuery()
            connect.Close()
        End If
        MessageBox.Show("Registration successful! You can now log in.")
        Me.Dispose()
        Dim loginForm As New Login()
        loginForm.Show()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub Regristration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        errorLabel.Text = ""
    End Sub
End Class