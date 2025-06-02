Public Class Auth ' citation to Hugeicons, Google, Gemini, StackOverFlow, and VB Forums 
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
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click ' back button and loads previous lines
        Me.Hide()
        Dim loginForm As New Login()
        loginForm.Show()
    End Sub

    Private Sub Visability_Click(sender As Object, e As EventArgs) Handles Visability.Click ' handles visability of password
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            Visability.BackgroundImage = Image.FromFile("view-off-slash-Stroke-Rounded.png")
        Else
            txtPassword.PasswordChar = "*"
            Visability.BackgroundImage = Image.FromFile("view-Stroke-Rounded.png")
        End If
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim sql As String = "SELECT * FROM creds WHERE Username = @Username"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text) ' method inspired from vbForums by circatrix
        connect.Open() ' Open the connection to the database
        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim storedPassword As String = reader("Password").ToString()
            If txtPassword.Text = storedPassword Then
                MainForm.user = txtUsername.Text
                ' Proceed to the next form or functionality
                Me.Hide()
                MainForm.Show()
            Else
                errorLabel.Text = "Incorrect Password." & vbNewLine & "Please try again."
            End If
        Else
            errorLabel.Text = "Account does not exist." & vbNewLine & "Please exit and register for an account."
        End If
        connect.Close()
    End Sub

    Private Sub Auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        errorLabel.Text = ""
    End Sub



End Class