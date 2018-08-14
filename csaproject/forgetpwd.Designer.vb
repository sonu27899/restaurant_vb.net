<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class forgetpwd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcpassword = New System.Windows.Forms.TextBox()
        Me.lblcpassword = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btncls = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OldLace
        Me.Label1.Location = New System.Drawing.Point(119, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 60)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Forgot Password"
        '
        'txtcpassword
        '
        Me.txtcpassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtcpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcpassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpassword.Location = New System.Drawing.Point(245, 308)
        Me.txtcpassword.Multiline = True
        Me.txtcpassword.Name = "txtcpassword"
        Me.txtcpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcpassword.Size = New System.Drawing.Size(338, 35)
        Me.txtcpassword.TabIndex = 42
        '
        'lblcpassword
        '
        Me.lblcpassword.AutoSize = True
        Me.lblcpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblcpassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcpassword.ForeColor = System.Drawing.Color.OldLace
        Me.lblcpassword.Location = New System.Drawing.Point(70, 296)
        Me.lblcpassword.Name = "lblcpassword"
        Me.lblcpassword.Size = New System.Drawing.Size(154, 52)
        Me.lblcpassword.TabIndex = 41
        Me.lblcpassword.Text = "Confirm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " PassWord:-"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(245, 243)
        Me.txtpassword.Multiline = True
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(338, 33)
        Me.txtpassword.TabIndex = 40
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblpassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.OldLace
        Me.lblpassword.Location = New System.Drawing.Point(79, 244)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(146, 26)
        Me.lblpassword.TabIndex = 39
        Me.lblpassword.Text = "PassWord:-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.SystemColors.Info
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(245, 183)
        Me.txtemail.Multiline = True
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(338, 33)
        Me.txtemail.TabIndex = 38
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.OldLace
        Me.lblemail.Location = New System.Drawing.Point(79, 179)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(126, 26)
        Me.lblemail.TabIndex = 37
        Me.lblemail.Text = "Email id:-"
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnsubmit.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.OldLace
        Me.btnsubmit.Location = New System.Drawing.Point(158, 411)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(125, 32)
        Me.btnsubmit.TabIndex = 44
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'btncls
        '
        Me.btncls.BackColor = System.Drawing.Color.LightSlateGray
        Me.btncls.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncls.ForeColor = System.Drawing.Color.OldLace
        Me.btncls.Location = New System.Drawing.Point(319, 411)
        Me.btncls.Name = "btncls"
        Me.btncls.Size = New System.Drawing.Size(125, 32)
        Me.btncls.TabIndex = 45
        Me.btncls.Text = "CLOSE"
        Me.btncls.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnclear.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.OldLace
        Me.btnclear.Location = New System.Drawing.Point(479, 411)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(125, 32)
        Me.btnclear.TabIndex = 46
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'forgetpwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.csaproject.My.Resources.Resources.bg56
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(681, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncls)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtcpassword)
        Me.Controls.Add(Me.lblcpassword)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblemail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "forgetpwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgetpwd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcpassword As TextBox
    Friend WithEvents lblcpassword As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btncls As Button
    Friend WithEvents btnclear As Button
End Class
