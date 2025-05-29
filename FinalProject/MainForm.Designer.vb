<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PasswordDatabaseDataSet = New FinalProject.PasswordDatabaseDataSet()
        Me.DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseTableAdapter = New FinalProject.PasswordDatabaseDataSetTableAdapters.databaseTableAdapter()
        Me.DatabaseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvPassword = New System.Windows.Forms.DataGridView()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NicknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Website_App = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateLastModifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabaseBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasswordDatabaseDataSet3 = New FinalProject.PasswordDatabaseDataSet3()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.ShowAll = New System.Windows.Forms.Button()
        Me.RefreshIcon = New System.Windows.Forms.PictureBox()
        Me.ExitPictur = New System.Windows.Forms.PictureBox()
        Me.ExitApp = New System.Windows.Forms.Button()
        Me.ViewIcon = New System.Windows.Forms.PictureBox()
        Me.DeleteIcon = New System.Windows.Forms.PictureBox()
        Me.btnDeletePassword = New System.Windows.Forms.Button()
        Me.EditIcon = New System.Windows.Forms.PictureBox()
        Me.AddIcon = New System.Windows.Forms.PictureBox()
        Me.Editing = New System.Windows.Forms.Label()
        Me.btnViewPassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditPassword = New System.Windows.Forms.Button()
        Me.addPassword = New System.Windows.Forms.Button()
        Me.LoginTag = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.PictureBox()
        Me.SearchFilters = New System.Windows.Forms.ComboBox()
        Me.SearchButton = New System.Windows.Forms.PictureBox()
        Me.SearchBar = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PasswordDatabaseDataSet2 = New FinalProject.PasswordDatabaseDataSet2()
        Me.DatabaseBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseTableAdapter1 = New FinalProject.PasswordDatabaseDataSet2TableAdapters.databaseTableAdapter()
        Me.DatabaseTableAdapter2 = New FinalProject.PasswordDatabaseDataSet3TableAdapters.databaseTableAdapter()
        CType(Me.PasswordDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordDatabaseDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeleteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordDatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordDatabaseDataSet
        '
        Me.PasswordDatabaseDataSet.DataSetName = "PasswordDatabaseDataSet"
        Me.PasswordDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseBindingSource
        '
        Me.DatabaseBindingSource.DataMember = "database"
        Me.DatabaseBindingSource.DataSource = Me.PasswordDatabaseDataSet
        '
        'DatabaseTableAdapter
        '
        Me.DatabaseTableAdapter.ClearBeforeFill = True
        '
        'DatabaseBindingSource1
        '
        Me.DatabaseBindingSource1.DataMember = "database"
        Me.DatabaseBindingSource1.DataSource = Me.PasswordDatabaseDataSet
        '
        'dgvPassword
        '
        Me.dgvPassword.AllowUserToAddRows = False
        Me.dgvPassword.AllowUserToDeleteRows = False
        Me.dgvPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPassword.AutoGenerateColumns = False
        Me.dgvPassword.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPassword.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPassword.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateAddedDataGridViewTextBoxColumn, Me.ID, Me.NicknameDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.Website_App, Me.DateLastModifiedDataGridViewTextBoxColumn})
        Me.dgvPassword.DataSource = Me.DatabaseBindingSource3
        Me.dgvPassword.GridColor = System.Drawing.Color.Black
        Me.dgvPassword.Location = New System.Drawing.Point(276, 55)
        Me.dgvPassword.Name = "dgvPassword"
        Me.dgvPassword.ReadOnly = True
        Me.dgvPassword.Size = New System.Drawing.Size(1138, 919)
        Me.dgvPassword.TabIndex = 0
        '
        'DateAddedDataGridViewTextBoxColumn
        '
        Me.DateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.Name = "DateAddedDataGridViewTextBoxColumn"
        Me.DateAddedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "Column2"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'NicknameDataGridViewTextBoxColumn
        '
        Me.NicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn.HeaderText = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn.Name = "NicknameDataGridViewTextBoxColumn"
        Me.NicknameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Website_App
        '
        Me.Website_App.DataPropertyName = "Website_App"
        Me.Website_App.HeaderText = "Website_App"
        Me.Website_App.Name = "Website_App"
        Me.Website_App.ReadOnly = True
        '
        'DateLastModifiedDataGridViewTextBoxColumn
        '
        Me.DateLastModifiedDataGridViewTextBoxColumn.DataPropertyName = "Date Last Modified"
        Me.DateLastModifiedDataGridViewTextBoxColumn.HeaderText = "Date Last Modified"
        Me.DateLastModifiedDataGridViewTextBoxColumn.Name = "DateLastModifiedDataGridViewTextBoxColumn"
        Me.DateLastModifiedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatabaseBindingSource3
        '
        Me.DatabaseBindingSource3.DataMember = "database"
        Me.DatabaseBindingSource3.DataSource = Me.PasswordDatabaseDataSet3
        '
        'PasswordDatabaseDataSet3
        '
        Me.PasswordDatabaseDataSet3.DataSetName = "PasswordDatabaseDataSet3"
        Me.PasswordDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(16, 840)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 53)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSettings.Location = New System.Drawing.Point(78, 840)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSettings.Size = New System.Drawing.Size(165, 53)
        Me.btnSettings.TabIndex = 17
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'ShowAll
        '
        Me.ShowAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowAll.ForeColor = System.Drawing.Color.Black
        Me.ShowAll.Location = New System.Drawing.Point(79, 371)
        Me.ShowAll.Name = "ShowAll"
        Me.ShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowAll.Size = New System.Drawing.Size(164, 53)
        Me.ShowAll.TabIndex = 16
        Me.ShowAll.Text = "Show All"
        Me.ShowAll.UseVisualStyleBackColor = False
        '
        'RefreshIcon
        '
        Me.RefreshIcon.BackgroundImage = CType(resources.GetObject("RefreshIcon.BackgroundImage"), System.Drawing.Image)
        Me.RefreshIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RefreshIcon.Location = New System.Drawing.Point(22, 371)
        Me.RefreshIcon.Name = "RefreshIcon"
        Me.RefreshIcon.Size = New System.Drawing.Size(50, 53)
        Me.RefreshIcon.TabIndex = 15
        Me.RefreshIcon.TabStop = False
        '
        'ExitPictur
        '
        Me.ExitPictur.BackgroundImage = CType(resources.GetObject("ExitPictur.BackgroundImage"), System.Drawing.Image)
        Me.ExitPictur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitPictur.Location = New System.Drawing.Point(4, 899)
        Me.ExitPictur.Name = "ExitPictur"
        Me.ExitPictur.Size = New System.Drawing.Size(68, 73)
        Me.ExitPictur.TabIndex = 14
        Me.ExitPictur.TabStop = False
        '
        'ExitApp
        '
        Me.ExitApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ExitApp.Location = New System.Drawing.Point(78, 910)
        Me.ExitApp.Name = "ExitApp"
        Me.ExitApp.Size = New System.Drawing.Size(165, 50)
        Me.ExitApp.TabIndex = 13
        Me.ExitApp.Text = "Exit App"
        Me.ExitApp.UseVisualStyleBackColor = False
        '
        'ViewIcon
        '
        Me.ViewIcon.BackgroundImage = CType(resources.GetObject("ViewIcon.BackgroundImage"), System.Drawing.Image)
        Me.ViewIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewIcon.Location = New System.Drawing.Point(22, 292)
        Me.ViewIcon.Name = "ViewIcon"
        Me.ViewIcon.Size = New System.Drawing.Size(44, 50)
        Me.ViewIcon.TabIndex = 12
        Me.ViewIcon.TabStop = False
        '
        'DeleteIcon
        '
        Me.DeleteIcon.BackgroundImage = CType(resources.GetObject("DeleteIcon.BackgroundImage"), System.Drawing.Image)
        Me.DeleteIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteIcon.Location = New System.Drawing.Point(22, 236)
        Me.DeleteIcon.Name = "DeleteIcon"
        Me.DeleteIcon.Size = New System.Drawing.Size(44, 50)
        Me.DeleteIcon.TabIndex = 11
        Me.DeleteIcon.TabStop = False
        '
        'btnDeletePassword
        '
        Me.btnDeletePassword.BackColor = System.Drawing.Color.Tomato
        Me.btnDeletePassword.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePassword.ForeColor = System.Drawing.Color.Black
        Me.btnDeletePassword.Location = New System.Drawing.Point(78, 236)
        Me.btnDeletePassword.Name = "btnDeletePassword"
        Me.btnDeletePassword.Size = New System.Drawing.Size(168, 50)
        Me.btnDeletePassword.TabIndex = 10
        Me.btnDeletePassword.Text = "Delete Password"
        Me.btnDeletePassword.UseVisualStyleBackColor = False
        '
        'EditIcon
        '
        Me.EditIcon.BackgroundImage = CType(resources.GetObject("EditIcon.BackgroundImage"), System.Drawing.Image)
        Me.EditIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EditIcon.Location = New System.Drawing.Point(22, 177)
        Me.EditIcon.Name = "EditIcon"
        Me.EditIcon.Size = New System.Drawing.Size(44, 50)
        Me.EditIcon.TabIndex = 9
        Me.EditIcon.TabStop = False
        '
        'AddIcon
        '
        Me.AddIcon.BackgroundImage = CType(resources.GetObject("AddIcon.BackgroundImage"), System.Drawing.Image)
        Me.AddIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddIcon.Location = New System.Drawing.Point(22, 116)
        Me.AddIcon.Name = "AddIcon"
        Me.AddIcon.Size = New System.Drawing.Size(44, 50)
        Me.AddIcon.TabIndex = 8
        Me.AddIcon.TabStop = False
        '
        'Editing
        '
        Me.Editing.AutoSize = True
        Me.Editing.BackColor = System.Drawing.Color.Transparent
        Me.Editing.ForeColor = System.Drawing.Color.White
        Me.Editing.Location = New System.Drawing.Point(28, 59)
        Me.Editing.Name = "Editing"
        Me.Editing.Size = New System.Drawing.Size(215, 34)
        Me.Editing.TabIndex = 6
        Me.Editing.Text = "Password Entries Edit"
        '
        'btnViewPassword
        '
        Me.btnViewPassword.BackColor = System.Drawing.Color.PowderBlue
        Me.btnViewPassword.ForeColor = System.Drawing.Color.Black
        Me.btnViewPassword.Location = New System.Drawing.Point(78, 292)
        Me.btnViewPassword.Name = "btnViewPassword"
        Me.btnViewPassword.Size = New System.Drawing.Size(168, 50)
        Me.btnViewPassword.TabIndex = 5
        Me.btnViewPassword.Text = "View Password"
        Me.btnViewPassword.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password Manager"
        '
        'btnEditPassword
        '
        Me.btnEditPassword.BackColor = System.Drawing.Color.Lavender
        Me.btnEditPassword.ForeColor = System.Drawing.Color.Black
        Me.btnEditPassword.Location = New System.Drawing.Point(78, 177)
        Me.btnEditPassword.Name = "btnEditPassword"
        Me.btnEditPassword.Size = New System.Drawing.Size(168, 50)
        Me.btnEditPassword.TabIndex = 1
        Me.btnEditPassword.Text = "Edit Password"
        Me.btnEditPassword.UseVisualStyleBackColor = False
        '
        'addPassword
        '
        Me.addPassword.BackColor = System.Drawing.Color.PaleGreen
        Me.addPassword.ForeColor = System.Drawing.Color.Black
        Me.addPassword.Location = New System.Drawing.Point(78, 116)
        Me.addPassword.Name = "addPassword"
        Me.addPassword.Size = New System.Drawing.Size(168, 50)
        Me.addPassword.TabIndex = 0
        Me.addPassword.Text = "Add Password"
        Me.addPassword.UseVisualStyleBackColor = False
        '
        'LoginTag
        '
        Me.LoginTag.AutoSize = True
        Me.LoginTag.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginTag.ForeColor = System.Drawing.Color.White
        Me.LoginTag.Location = New System.Drawing.Point(1092, 10)
        Me.LoginTag.Name = "LoginTag"
        Me.LoginTag.Size = New System.Drawing.Size(109, 46)
        Me.LoginTag.TabIndex = 3
        Me.LoginTag.Text = "Welcome, user!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Username)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'logout
        '
        Me.logout.BackgroundImage = CType(resources.GetObject("logout.BackgroundImage"), System.Drawing.Image)
        Me.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logout.Location = New System.Drawing.Point(1357, 8)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(57, 44)
        Me.logout.TabIndex = 4
        Me.logout.TabStop = False
        '
        'SearchFilters
        '
        Me.SearchFilters.FormattingEnabled = True
        Me.SearchFilters.Items.AddRange(New Object() {"Search by Nickname", "Search by Username", "Search by Website URL"})
        Me.SearchFilters.Location = New System.Drawing.Point(783, 10)
        Me.SearchFilters.Name = "SearchFilters"
        Me.SearchFilters.Size = New System.Drawing.Size(303, 42)
        Me.SearchFilters.TabIndex = 3
        '
        'SearchButton
        '
        Me.SearchButton.BackgroundImage = CType(resources.GetObject("SearchButton.BackgroundImage"), System.Drawing.Image)
        Me.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SearchButton.Location = New System.Drawing.Point(729, 9)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(48, 40)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.TabStop = False
        '
        'SearchBar
        '
        Me.SearchBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBar.Location = New System.Drawing.Point(276, 13)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(456, 36)
        Me.SearchBar.TabIndex = 0
        '
        'PasswordDatabaseDataSet2
        '
        Me.PasswordDatabaseDataSet2.DataSetName = "PasswordDatabaseDataSet2"
        Me.PasswordDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseBindingSource2
        '
        Me.DatabaseBindingSource2.DataMember = "database"
        Me.DatabaseBindingSource2.DataSource = Me.PasswordDatabaseDataSet2
        '
        'DatabaseTableAdapter1
        '
        Me.DatabaseTableAdapter1.ClearBeforeFill = True
        '
        'DatabaseTableAdapter2
        '
        Me.DatabaseTableAdapter2.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1412, 971)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SearchFilters)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.LoginTag)
        Me.Controls.Add(Me.ShowAll)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.dgvPassword)
        Me.Controls.Add(Me.RefreshIcon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitPictur)
        Me.Controls.Add(Me.addPassword)
        Me.Controls.Add(Me.ExitApp)
        Me.Controls.Add(Me.btnEditPassword)
        Me.Controls.Add(Me.ViewIcon)
        Me.Controls.Add(Me.btnViewPassword)
        Me.Controls.Add(Me.DeleteIcon)
        Me.Controls.Add(Me.Editing)
        Me.Controls.Add(Me.btnDeletePassword)
        Me.Controls.Add(Me.AddIcon)
        Me.Controls.Add(Me.EditIcon)
        Me.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.PasswordDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordDatabaseDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeleteIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordDatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PasswordDatabaseDataSet As PasswordDatabaseDataSet
    Friend WithEvents DatabaseBindingSource As BindingSource
    Friend WithEvents DatabaseTableAdapter As PasswordDatabaseDataSetTableAdapters.databaseTableAdapter
    Friend WithEvents DatabaseBindingSource1 As BindingSource
    Friend WithEvents dgvPassword As DataGridView
    Friend WithEvents addPassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditPassword As Button
    Friend WithEvents SearchFilters As ComboBox
    Friend WithEvents SearchButton As PictureBox
    Friend WithEvents SearchBar As TextBox
    Friend WithEvents LoginTag As Label
    Friend WithEvents logout As PictureBox
    Friend WithEvents Editing As Label
    Friend WithEvents btnViewPassword As Button
    Friend WithEvents AddIcon As PictureBox
    Friend WithEvents DeleteIcon As PictureBox
    Friend WithEvents btnDeletePassword As Button
    Friend WithEvents EditIcon As PictureBox
    Friend WithEvents ViewIcon As PictureBox
    Friend WithEvents ExitApp As Button
    Friend WithEvents ExitPictur As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RefreshIcon As PictureBox
    Friend WithEvents ShowAll As Button
    Friend WithEvents PasswordDatabaseDataSet2 As PasswordDatabaseDataSet2
    Friend WithEvents DatabaseBindingSource2 As BindingSource
    Friend WithEvents DatabaseTableAdapter1 As PasswordDatabaseDataSet2TableAdapters.databaseTableAdapter
    Friend WithEvents PasswordDatabaseDataSet3 As PasswordDatabaseDataSet3
    Friend WithEvents DatabaseBindingSource3 As BindingSource
    Friend WithEvents DatabaseTableAdapter2 As PasswordDatabaseDataSet3TableAdapters.databaseTableAdapter
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NicknameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Website_App As DataGridViewTextBoxColumn
    Friend WithEvents DateLastModifiedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSettings As Button
End Class
