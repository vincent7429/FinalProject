<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditForm))
        Me.title = New System.Windows.Forms.Label()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenPassword = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.Visability = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.btnCancelButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Visability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Location = New System.Drawing.Point(172, 9)
        Me.title.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(104, 34)
        Me.title.TabIndex = 0
        Me.title.Text = "Edit Form"
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(68, 55)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(361, 36)
        Me.txtNickname.TabIndex = 1
        Me.txtNickname.Text = "Nickname"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(68, 98)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(361, 36)
        Me.txtUserName.TabIndex = 4
        Me.txtUserName.Text = "Email/Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(68, 142)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(361, 36)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Text = "Password"
        '
        'txtWeb
        '
        Me.txtWeb.Location = New System.Drawing.Point(68, 187)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(361, 36)
        Me.txtWeb.TabIndex = 9
        Me.txtWeb.Text = "Website URL/App Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Save Icon by Icons8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 34)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Save"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 34)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Cancel"
        '
        'btnGenPassword
        '
        Me.btnGenPassword.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnGenPassword.ForeColor = System.Drawing.Color.Black
        Me.btnGenPassword.Location = New System.Drawing.Point(116, 229)
        Me.btnGenPassword.Name = "btnGenPassword"
        Me.btnGenPassword.Size = New System.Drawing.Size(228, 46)
        Me.btnGenPassword.TabIndex = 16
        Me.btnGenPassword.Text = "Generate Password"
        Me.btnGenPassword.UseVisualStyleBackColor = False
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.RosyBrown
        Me.ErrorLabel.Location = New System.Drawing.Point(16, 285)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(58, 34)
        Me.ErrorLabel.TabIndex = 17
        Me.ErrorLabel.Text = "Error"
        '
        'Visability
        '
        Me.Visability.BackgroundImage = CType(resources.GetObject("Visability.BackgroundImage"), System.Drawing.Image)
        Me.Visability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Visability.Location = New System.Drawing.Point(435, 142)
        Me.Visability.Name = "Visability"
        Me.Visability.Size = New System.Drawing.Size(38, 38)
        Me.Visability.TabIndex = 15
        Me.Visability.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Location = New System.Drawing.Point(60, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 73)
        Me.btnSave.TabIndex = 11
        Me.btnSave.TabStop = False
        '
        'btnCancelButton
        '
        Me.btnCancelButton.BackgroundImage = CType(resources.GetObject("btnCancelButton.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelButton.Location = New System.Drawing.Point(257, 355)
        Me.btnCancelButton.Name = "btnCancelButton"
        Me.btnCancelButton.Size = New System.Drawing.Size(87, 73)
        Me.btnCancelButton.TabIndex = 10
        Me.btnCancelButton.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(13, 187)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(12, 142)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(12, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 472)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.btnGenPassword)
        Me.Controls.Add(Me.Visability)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancelButton)
        Me.Controls.Add(Me.txtWeb)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNickname)
        Me.Controls.Add(Me.title)
        Me.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "EditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditForm"
        CType(Me.Visability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents txtNickname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txtWeb As TextBox
    Friend WithEvents btnCancelButton As PictureBox
    Friend WithEvents btnSave As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Visability As PictureBox
    Friend WithEvents btnGenPassword As Button
    Friend WithEvents ErrorLabel As Label
End Class
