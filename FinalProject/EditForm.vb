Public Class EditForm ' citation to Hugeicons, Google, Gemini, StackOverFlow, and VB Forums 
    Inherits Form
    Public mode As String = "view" ' mode can be "edit", "new", or "view"
    ' source for code on StackOverFlow: https://stackoverflow.com/a/36729373
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Dim connect As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PasswordDatabase.accdb")
    Dim appMode As String
    Public primaryKeyValue As Integer

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Public Sub New(ByRef mode As String, ByRef index As Integer)
        Me.mode = mode ' Set the mode for the form
        primaryKeyValue = index ' Store the primary key value for editing or viewing

        ' This call is required by the designer.
        InitializeComponent()

        If mode = "edit" Then ' edit mode
            title.Text = "Edit Password"
            appMode = "edit"
            primaryKeyValue = index ' Set the primary key value for editing
            txtNickname.ReadOnly = False ' read only is false so user can edit
            txtPassword.ReadOnly = False
            txtUserName.ReadOnly = False
            txtWeb.ReadOnly = False
            txtNickname.Text = "" ' clear all textboxes in case
            txtPassword.Text = ""
            txtUserName.Text = ""
            txtWeb.Text = ""
            loadData() ' loads all data so user can modify it
        ElseIf mode = "new" Then
            title.Text = "New Password" 'new mode
            appMode = "new"
            txtNickname.ReadOnly = False ' read only is false so user can edit
            txtPassword.ReadOnly = False
            txtUserName.ReadOnly = False
            txtWeb.ReadOnly = False
            txtNickname.Text = "" ' clear all textboxes in case
            txtPassword.Text = ""
            txtUserName.Text = ""
            txtWeb.Text = ""
        ElseIf mode = "view" Then ' view mode
            title.Text = "View Password"
            appMode = "view"
            primaryKeyValue = index ' Set the primary key value for viewing
            txtNickname.ReadOnly = True ' read only is true so user cannot edit and only copy and paste
            txtPassword.ReadOnly = True ' 
            txtUserName.ReadOnly = True
            txtWeb.ReadOnly = True
            btnGenPassword.Visible = False

            loadData() ' load all data into form
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub editMode()
        title.Text = "Edit Password"
        If txtUserName.Text = "" Then ' checks if username field is blank. required field.
            ErrorLabel.Text = "Username field is blank. Please enter it in or *"
        ElseIf txtPassword.Text = "" Then ' checks if password field is blank. required field.
            ErrorLabel.Text = "Please enter a password." & vbNewLine & "Or generate one."
        ElseIf txtWeb.Text = "" Then ' checks if website field is blank. required field.
            ErrorLabel.Text = "Please enter the website this password is for."
        ElseIf txtNickname.Text = "" Then ' checks if nickname field is blank. required field.
            ErrorLabel.Text = "Please enter a nickname for this password."
        Else
            Dim sql As String = "UPDATE [database] SET [Username] = @Username, [Password] = @Password, [Website_App] = @Website, [Nickname] = @Nickname, [Date Last Modified] = @DateEdited WHERE ID = @ID" ' upda SQL query
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect) ' create command object
            cmd.Parameters.AddWithValue("@Username", txtUserName.Text) ' Use the username from the textbox
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Use the password from the textbox
            cmd.Parameters.AddWithValue("@Website", txtWeb.Text)  ' Use the website from the textbox
            cmd.Parameters.AddWithValue("@Nickname", txtNickname.Text) ' Use the nickname from the textbox
            cmd.Parameters.AddWithValue("@DateEdited", DateTime.Now) ' Use current date and time
            cmd.Parameters.AddWithValue("@ID", primaryKeyValue) ' Use the primary key value passed to the constructor
            cmd.ExecuteNonQuery() ' execute the command
            connect.Close()
            MessageBox.Show("Password updated successfully!") ' sucess message
            MainForm.Refresh() ' refresh main form to show changes
            Me.Dispose() ' close the edit form
        End If
    End Sub
    Private Sub newMode()
        title.Text = "New Password"
        If txtUserName.Text = "" Then ' checks if username field is blank. required field.
            ErrorLabel.Text = "Username field is blank. Please enter it in or *"
        ElseIf txtPassword.Text = "" Then ' checks if password field is blank. required field.
            ErrorLabel.Text = "Please enter a password." & vbNewLine & "Or generate one."
        ElseIf txtWeb.Text = "" Then ' checks if website field is blank. required field.
            ErrorLabel.Text = "Please enter a the website this password is for."
        ElseIf txtNickname.Text = "" Then ' checks if nickname field is blank. required field.
            ErrorLabel.Text = "Please enter a nickname for this password."
        Else
            ' Insert new password into the database
            Dim sql As String = "INSERT INTO [database] ([User], [Username], [Password], [Website_App], [Nickname], [Date Added]) VALUES (@User, @Username, @Password, @Website, @Nickname, @DateAdded)" ' insert SQL
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
            cmd.Parameters.AddWithValue("@User", MainForm.user) ' Use the user from MainForm
            cmd.Parameters.AddWithValue("@Username", txtUserName.Text) ' Use the username from the textbox
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Use the password from the textbox
            cmd.Parameters.AddWithValue("@Website", txtWeb.Text) ' Use the website from the textbox
            cmd.Parameters.AddWithValue("@Nickname", txtNickname.Text) ' Use the nickname from the textbox
            cmd.Parameters.AddWithValue("@DateAdded ", DateTime.Now) ' Use current date and time
            connect.Open()
            cmd.ExecuteNonQuery() ' execute the command
            connect.Close()
            MessageBox.Show("New password added successfully!") ' sucess message
            Me.Hide()
        End If
        MainForm.Refresh()
    End Sub
    Private Sub viewMode()
        Me.Dispose()
    End Sub
    Sub loadData() ' this function loads in all data from the database into the edit/view forms.
        Dim sql As String = "SELECT * FROM [database] WHERE ID = @ID"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connect)
        cmd.Parameters.AddWithValue("@ID", primaryKeyValue) ' Use the primary key value passed to the constructor
        connect.Open() ' open connection
        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader() 'read data from the database
        If reader.Read() Then 'insert all data into form that person can edit
            txtUserName.Text = reader("Username").ToString()
            txtPassword.Text = reader("Password").ToString()
            txtWeb.Text = reader("Website_App").ToString()
            txtNickname.Text = reader("Nickname").ToString()
        Else
            MessageBox.Show("No data found for the given ID.") 'rare case
        End If
    End Sub
    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorLabel.Text = "" ' clear error label on load
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If mode = "edit" Then ' check which mode the form is in
            editMode()
        ElseIf mode = "new" Then
            newMode()
        ElseIf mode = "view" Then
            Me.Dispose()
        End If ' save button click event
    End Sub

    Private Sub btnCancelButton_Click(sender As Object, e As EventArgs) Handles btnCancelButton.Click ' Cancel button click event
        Dim prompt As DialogResult = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If prompt = DialogResult.Yes Then
            Me.Hide() ' Close the form without saving changes
        End If
    End Sub

    Private Sub btnGenPassword_Click(sender As Object, e As EventArgs) Handles btnGenPassword.Click ' calls generate password function from main, calling the generator.
        txtPassword.Text = MainForm.generatePasword()
    End Sub

    Private Sub visability_click(sender As Object, e As EventArgs) Handles Visability.Click ' Toggle password visibility
        If txtPassword.PasswordChar = "*" Then ' checks if password char is set to * or not 
            txtPassword.PasswordChar = "" ' if it is set to *, then set it to nothing so it shows the password
            Visability.BackgroundImage = Image.FromFile("view-off-slash-Stroke-Rounded.png")
        Else
            txtPassword.PasswordChar = "*" 'if it is not set to *, then set it to * so it hides the password
            Visability.BackgroundImage = Image.FromFile("view-Stroke-Rounded.png")
        End If
    End Sub
End Class