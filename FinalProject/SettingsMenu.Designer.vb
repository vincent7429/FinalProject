<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsMenu))
        Me.sizeScroll = New System.Windows.Forms.TrackBar()
        Me.scrollNum = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.authCheck = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.saveIcon = New System.Windows.Forms.PictureBox()
        Me.cancelIcon = New System.Windows.Forms.PictureBox()
        CType(Me.sizeScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrollNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saveIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sizeScroll
        '
        Me.sizeScroll.Location = New System.Drawing.Point(12, 102)
        Me.sizeScroll.Maximum = 100
        Me.sizeScroll.Minimum = 8
        Me.sizeScroll.Name = "sizeScroll"
        Me.sizeScroll.Size = New System.Drawing.Size(542, 45)
        Me.sizeScroll.TabIndex = 0
        Me.sizeScroll.Value = 8
        '
        'scrollNum
        '
        Me.scrollNum.Location = New System.Drawing.Point(560, 102)
        Me.scrollNum.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.scrollNum.Name = "scrollNum"
        Me.scrollNum.Size = New System.Drawing.Size(84, 36)
        Me.scrollNum.TabIndex = 2
        Me.scrollNum.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Random Password Generator Size"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(32, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 84)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'authCheck
        '
        Me.authCheck.AutoSize = True
        Me.authCheck.Location = New System.Drawing.Point(36, 153)
        Me.authCheck.Name = "authCheck"
        Me.authCheck.Size = New System.Drawing.Size(608, 38)
        Me.authCheck.TabIndex = 5
        Me.authCheck.Text = "Require Reauthentication every time a change is requested."
        Me.authCheck.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(436, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 34)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Cancel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 34)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Save"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Save Icon by Icons8"
        '
        'saveIcon
        '
        Me.saveIcon.BackgroundImage = CType(resources.GetObject("saveIcon.BackgroundImage"), System.Drawing.Image)
        Me.saveIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.saveIcon.Location = New System.Drawing.Point(145, 197)
        Me.saveIcon.Name = "saveIcon"
        Me.saveIcon.Size = New System.Drawing.Size(87, 73)
        Me.saveIcon.TabIndex = 16
        Me.saveIcon.TabStop = False
        '
        'cancelIcon
        '
        Me.cancelIcon.BackgroundImage = CType(resources.GetObject("cancelIcon.BackgroundImage"), System.Drawing.Image)
        Me.cancelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cancelIcon.Location = New System.Drawing.Point(342, 197)
        Me.cancelIcon.Name = "cancelIcon"
        Me.cancelIcon.Size = New System.Drawing.Size(87, 73)
        Me.cancelIcon.TabIndex = 15
        Me.cancelIcon.TabStop = False
        '
        'SettingsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(657, 324)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.saveIcon)
        Me.Controls.Add(Me.cancelIcon)
        Me.Controls.Add(Me.authCheck)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scrollNum)
        Me.Controls.Add(Me.sizeScroll)
        Me.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "SettingsMenu"
        Me.Text = "SettingsMenu"
        Me.TopMost = True
        CType(Me.sizeScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrollNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saveIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancelIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sizeScroll As TrackBar
    Friend WithEvents scrollNum As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents authCheck As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents saveIcon As PictureBox
    Friend WithEvents cancelIcon As PictureBox
End Class
