<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SignUp = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SignUp)
        Me.Panel1.Controls.Add(Me.LoginButton)
        Me.Panel1.Controls.Add(Me.Close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(365, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 420)
        Me.Panel1.TabIndex = 0
        '
        'SignUp
        '
        Me.SignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SignUp.Location = New System.Drawing.Point(23, 208)
        Me.SignUp.Name = "SignUp"
        Me.SignUp.Size = New System.Drawing.Size(327, 44)
        Me.SignUp.TabIndex = 5
        Me.SignUp.Text = "Register Account"
        Me.SignUp.UseVisualStyleBackColor = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginButton.ForeColor = System.Drawing.Color.Black
        Me.LoginButton.Location = New System.Drawing.Point(23, 143)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(327, 44)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Close
        '
        Me.Close.BackgroundImage = CType(resources.GetObject("Close.BackgroundImage"), System.Drawing.Image)
        Me.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Close.Location = New System.Drawing.Point(306, 0)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(65, 50)
        Me.Close.TabIndex = 2
        Me.Close.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comfortaa", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Password Manager"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(727, 408)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comfortaa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Close As PictureBox
    Friend WithEvents SignUp As Button
    Friend WithEvents LoginButton As Button
End Class
