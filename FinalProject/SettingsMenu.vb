Imports System.Security.Cryptography.X509Certificates

Public Class SettingsMenu ' citation to Hugeicons, Google, Gemini, StackOverFlow, and VB Forums 
    Inherits Form
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
    Private Sub sizeScroll_Scroll(sender As Object, e As EventArgs) Handles sizeScroll.Scroll
        scrollNum.Value = sizeScroll.Value
    End Sub

    Private Sub scrollNum_ValueChanged(sender As Object, e As EventArgs) Handles scrollNum.ValueChanged
        sizeScroll.Value = scrollNum.Value
    End Sub

    Private Sub saveIcon_Click(sender As Object, e As EventArgs) Handles saveIcon.Click
        MainForm.passwordLength = scrollNum.Value ' Update the password length in MainForm
        MainForm.authNeeded = authCheck.Checked ' Update the authentication requirement in MainForm
        Dim connect As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PasswordDatabase.accdb")
        Dim sql As String = "UPDATE creds SET passwordLength = @passwordLength, reAuthRequired = @reAuthRequired WHERE Username = @Username"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
        cmd.Parameters.AddWithValue("@passwordLength", scrollNum.Value)
        cmd.Parameters.AddWithValue("@reAuthRequired", authCheck.Checked)
        cmd.Parameters.AddWithValue("@Username", MainForm.user) ' method inspired from vbForums by circatrix
        connect.Open()
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Settings saved successfully.", "Settings")
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving settings: " & ex.Message)
        Finally
            connect.Close()
        End Try
        If authCheck.Checked = True Then
            MessageBox.Show("High level security is now in place. You will need to reauenticate for every sensitive action.")
        End If
        Me.Dispose()

    End Sub

    Private Sub SettingsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scrollNum.Value = MainForm.passwordLength
        sizeScroll.Value = MainForm.passwordLength
        authCheck.Checked = MainForm.authNeeded
    End Sub

    Private Sub cancelIcon_Click(sender As Object, e As EventArgs) Handles cancelIcon.Click
        Dim comfirmResult As DialogResult = MessageBox.Show("Are you sure you want to cancel? Any changes made will not be saved.", "Cancel Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If comfirmResult = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class