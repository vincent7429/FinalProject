<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auth))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Visability = New System.Windows.Forms.PictureBox()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Visability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Visability)
        Me.Panel1.Controls.Add(Me.errorLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.LoginButton)
        Me.Panel1.Controls.Add(Me.Back)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(353, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 411)
        Me.Panel1.TabIndex = 1
        '
        'Visability
        '
        Me.Visability.BackgroundImage = CType(resources.GetObject("Visability.BackgroundImage"), System.Drawing.Image)
        Me.Visability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Visability.Location = New System.Drawing.Point(321, 170)
        Me.Visability.Name = "Visability"
        Me.Visability.Size = New System.Drawing.Size(52, 36)
        Me.Visability.TabIndex = 11
        Me.Visability.TabStop = False
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.ForeColor = System.Drawing.Color.Coral
        Me.errorLabel.Location = New System.Drawing.Point(12, 231)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(75, 34)
        Me.errorLabel.TabIndex = 10
        Me.errorLabel.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 34)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Login with your master credentials!"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(43, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 36)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(43, 113)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 36)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(91, 170)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(224, 36)
        Me.txtPassword.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(91, 113)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(224, 36)
        Me.txtUsername.TabIndex = 5
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginButton.ForeColor = System.Drawing.Color.Black
        Me.LoginButton.Location = New System.Drawing.Point(35, 311)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(327, 44)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackgroundImage = CType(resources.GetObject("Back.BackgroundImage"), System.Drawing.Image)
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Back.Location = New System.Drawing.Point(308, 3)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(65, 50)
        Me.Back.TabIndex = 2
        Me.Back.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comfortaa", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Password Manager"
        '
        'Auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(727, 408)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Auth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auth"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Visability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoginButton As Button
    Friend WithEvents Back As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents errorLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Visability As PictureBox
End Class
