Public Class MainForm
    Public user As String ' citation to Hugeicons, Google, Gemini, StackOverFlow, and VB Forums 
    Public authenticated As Boolean = False
    Dim connect As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PasswordDatabase.accdb")
    'this code allows borderless window to be dragged around
    ' source for code on StackOverFlow: https://stackoverflow.com/a/36729373
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Public passwordLength As Integer
    Public authNeeded As Boolean

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Private Sub addPassword_Click(sender As Object, e As EventArgs) Handles addPassword.Click
        If authNeeded Then ' check if authentication is needed
            If reAuthentication() = False Then
                MessageBox.Show("Reauthentication Failed. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 'end sub procedure
            End If
        End If
        Dim editForm As New EditForm("new", -1) ' calls edit form, -1 because not applicable.
        editForm.Show()
    End Sub

    Private Sub btnEditPassword_Click(sender As Object, e As EventArgs) Handles btnEditPassword.Click
        If authNeeded Then ' check if authentication is needed
            If reAuthentication() = False Then
                MessageBox.Show("Reauthentication Failed. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 'end sub procedure
            End If
        End If
        If dgvPassword.SelectedRows.Count = 0 Then ' check if any row is selected
            MessageBox.Show("Please select a password to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 'end sub procedure
        End If
        Dim selectedIndex As Integer = dgvPassword.SelectedRows(0).Index ' get the index of the selected row
        Dim editForm As New EditForm("edit", dgvPassword.Rows(selectedIndex).Cells("ID").Value.ToString())
        editForm.Show() ' opens edit form with the ID of the selected password
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lastName As String = "" ' sets lastName to empty string
        Dim firstName As String = "" ' sets firstName to empty string
        Dim query As String = "SELECT * FROM creds WHERE Username = @Username" ' used to pull login info
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(query, connect) ' creates a new command object with the query and connection
        cmd.Parameters.AddWithValue("@Username", user) ' adds the username parameter to the command
        connect.Open() ' opens the connection to the database
        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader() ' executes the command and gets a data reader
        If reader.HasRows Then ' read data
            reader.Read()
            lastName = reader("Last Name").ToString()
            firstName = reader("First Name").ToString()
            passwordLength = CInt(reader("passwordLength")) ' password paramaters autosave
            authNeeded = CBool(reader("reAuthRequired")) ' -1 for true, 0 for false
        End If
        connect.Close()
        If lastName = "" And firstName = "" Then ' sets login text
            LoginTag.Text = "Welcome, " & user & "!" ' prevented through validation in registration form, but in case
        Else
            LoginTag.Text = "Welcome, " & lastName & ", " & firstName & "!" & vbNewLine & "(" & user & ")" 'sets login text to welcome user with their last name, first name, and username
        End If
        Refresh()

    End Sub

    Private Sub ShowAll_Click(sender As Object, e As EventArgs) Handles ShowAll.Click
        Refresh()
    End Sub

    Public Sub Refresh() ' set data grid view to only the users records
        Dim sql As String = "SELECT * FROM [database] WHERE [User] = @Username" 'SQL query to select all records for the user
        Dim ds As New DataSet()
        Dim dt As New DataTable()
        ds.Tables.Add(dt) ' creates a new DataTable to hold the results
        Dim da As New OleDb.OleDbDataAdapter(sql, connect) ' creates a new DataAdapter to fill the DataTable
        da.SelectCommand.Parameters.AddWithValue("@Username", user) ' adds the username parameter to the SQL query
        da.Fill(dt) ' fills the DataTable with the results of the SQL query
        dgvPassword.DataSource = dt.DefaultView ' sets the DataGridView's data source to the DataTable's default view
        SearchBar.Text = ""
        SearchFilters.SelectedIndex = -1 ' resets the search bar and filters

    End Sub

    Private Sub ExitApp_Click(sender As Object, e As EventArgs) Handles ExitApp.Click
        End
    End Sub

    Private Sub btnDeletePassword_Click(sender As Object, e As EventArgs) Handles btnDeletePassword.Click
        If authNeeded Then ' check if authentication is needed
            If reAuthentication() = False Then
                MessageBox.Show("Reauthentication Failed. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 'end sub procedure
            End If
        End If
        If False = dgvPassword.SelectedRows.Count Then ' check if any row is selected
            MessageBox.Show("Please select a password to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 'end sub procedure
        End If
        Dim selectedIndex As Integer = dgvPassword.SelectedRows(0).Index
        Dim passwordId As String = dgvPassword.Rows(selectedIndex).Cells("ID").Value.ToString()
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this password?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmResult = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM [database] WHERE ID = @ID"
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
            cmd.Parameters.AddWithValue("@ID", passwordId)
            connect.Open()
            cmd.ExecuteNonQuery()
            connect.Close()
            Refresh()
            MessageBox.Show("Password deleted successfully.")
        End If
    End Sub

    Private Sub btnViewPassword_Click(sender As Object, e As EventArgs) Handles btnViewPassword.Click
        If authNeeded Then ' check if authentication is needed
            If reAuthentication() = False Then
                MessageBox.Show("Reauthentication Failed. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 'end sub procedure
            End If
        End If
        If False = dgvPassword.SelectedRows.Count Then ' check if any row is selected
            MessageBox.Show("Please select a password to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 'end sub procedure
        End If
        Dim EditForm As New EditForm("view", dgvPassword.SelectedRows(0).Cells("ID").Value.ToString())
        EditForm.Show()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Dispose()
        Login.Show()
    End Sub

    Public Function generatePasword()
        ' list generated using gemini AI
        Dim password As String = ""
        Dim lowercase As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim uppercase As String() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim numbers As String() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim specialCharacters As String() = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "[", "]", "{", "}", "|", "\", ";", ":", "'", """", ",", ".", "<", ">", "/", "?"}
        Dim rnd As New Random()
        For i As Integer = 0 To passwordLength - 1
            Dim choice As Integer = rnd.Next(0, 3) ' 0 for lowercase, 1 for uppercase, 2 for numbers, 3 for special characters
            Select Case choice
                Case 0
                    ' Add a random lowercase letter
                    password &= lowercase(rnd.Next(0, lowercase.Length)) ' &= is similar to += in Java
                Case 1
                    ' Add a random uppercase letter
                    password &= uppercase(rnd.Next(0, uppercase.Length))
                Case 2
                    ' Add a random number
                    password &= numbers(rnd.Next(0, numbers.Length))
                Case 3
                    ' Add a random special character
                    password &= specialCharacters(rnd.Next(0, specialCharacters.Length))
            End Select
        Next
        Return password
    End Function

    Private Sub SettingsMenu_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If reAuthentication() = True Then
            SettingsMenu.Show()
        Else
            MessageBox.Show("Re-Authentication Failed. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Function reAuthentication() As Boolean
        Dim input As String = InputBox("As part of your security policies set on the machine, you will need to reauthenticate. Enter password:", "Please enter your password for " & user & " to continue:", "Password")
        Dim sql As String = "SELECT * FROM creds WHERE Username = @Username"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
        cmd.Parameters.AddWithValue("@Username", user)
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim storedPassword As String = reader("Password").ToString()
            If input = storedPassword Then
                Return True ' Authentication successful
            End If
        End If
        connect.Close()
        Return False ' Authentication failed
    End Function

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchFilters.SelectedIndex = -1 Then
            MessageBox.Show("Please select a search filter.")
        ElseIf SearchFilters.SelectedIndex = 0 Then
            ' Search by Nickname
            Dim searchTerm As String = SearchBar.Text.Trim()
            If searchTerm = "" Then
                MessageBox.Show("Please enter a nickname to search for.")
                Return
            End If
            Dim sql As String = "SELECT * FROM [database] WHERE [User] = @Username AND [Nickname] LIKE @SearchTerm"
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
            cmd.Parameters.AddWithValue("@Username", user)
            cmd.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            ds.Tables.Add(dt)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dgvPassword.DataSource = dt.DefaultView
        ElseIf SearchFilters.SelectedIndex = 1 Then
            ' Search by Username
            Dim searchTerm As String = SearchBar.Text.Trim()
            If searchTerm = "" Then
                MessageBox.Show("Please enter your username to search for.")
                Return
            End If
            Dim sql As String = "SELECT * FROM [database] WHERE [User] = @Username AND [Username] LIKE @SearchTerm"
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
            cmd.Parameters.AddWithValue("@Username", user)
            cmd.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            ds.Tables.Add(dt)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dgvPassword.DataSource = dt.DefaultView
        ElseIf SearchFilters.SelectedIndex = 2 Then
            ' Search by website
            Dim searchTerm As String = SearchBar.Text.Trim()
            If searchTerm = "" Then
                MessageBox.Show("Please enter a website to search for.")
                Return
            End If
            Dim sql As String = "SELECT * FROM [database] WHERE [User] = @Username AND [Website_App] LIKE @SearchTerm"
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
            cmd.Parameters.AddWithValue("@Username", user)
            cmd.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            ds.Tables.Add(dt)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dgvPassword.DataSource = dt.DefaultView
        End If
    End Sub
End Class