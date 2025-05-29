Public Class Login ' citation to Hugeicons, Google, Gemini, StackOverFlow, and VB Forums 
    'this code allows to move the form
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

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        End ' close the program
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Me.Hide()
        Dim authForm As New Auth() ' open login page
        authForm.Show()
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        Me.Hide()
        Dim registrationForm As New Regristration() ' open registration page
        registrationForm.Show()
    End Sub
End Class
