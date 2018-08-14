<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class demo1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.lblpara = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.csaproject.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(306, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(568, 537)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.csaproject.My.Resources.Resources.bg56
        Me.Panel1.Controls.Add(Me.lbllogin)
        Me.Panel1.Controls.Add(Me.lblpara)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 537)
        Me.Panel1.TabIndex = 4
        '
        'lbllogin
        '
        Me.lbllogin.BackColor = System.Drawing.Color.Transparent
        Me.lbllogin.Font = New System.Drawing.Font("Tempus Sans ITC", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbllogin.Location = New System.Drawing.Point(31, 33)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(234, 58)
        Me.lbllogin.TabIndex = 2
        Me.lbllogin.Text = "Welcome"
        Me.lbllogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpara
        '
        Me.lblpara.BackColor = System.Drawing.Color.Transparent
        Me.lblpara.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpara.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblpara.Location = New System.Drawing.Point(45, 122)
        Me.lblpara.Name = "lblpara"
        Me.lblpara.Size = New System.Drawing.Size(209, 386)
        Me.lblpara.TabIndex = 3
        Me.lblpara.Text = "Hospitality is not about inviting people into our Perfect Homes ," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It's all about" &
    " inviting people in our.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IMPERFECT HEARTS.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'demo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 537)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "demo1"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "demo1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbllogin As Label
    Friend WithEvents lblpara As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
