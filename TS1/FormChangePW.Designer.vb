<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePW
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtUID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNewPW = New System.Windows.Forms.TextBox()
        Me.TxtRetypePW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnChangePW = New System.Windows.Forms.Button()
        Me.TxtOldPW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblProgressBar = New System.Windows.Forms.Label()
        Me.cboShowPW = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "User ID:"
        '
        'TxtUID
        '
        Me.TxtUID.Enabled = False
        Me.TxtUID.Location = New System.Drawing.Point(25, 25)
        Me.TxtUID.Name = "TxtUID"
        Me.TxtUID.Size = New System.Drawing.Size(46, 20)
        Me.TxtUID.TabIndex = 22
        Me.TxtUID.Tag = "Ticket Number is required"
        Me.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "New Password:"
        '
        'TxtNewPW
        '
        Me.TxtNewPW.Location = New System.Drawing.Point(25, 121)
        Me.TxtNewPW.MaxLength = 8
        Me.TxtNewPW.Name = "TxtNewPW"
        Me.TxtNewPW.Size = New System.Drawing.Size(136, 20)
        Me.TxtNewPW.TabIndex = 2
        Me.TxtNewPW.UseSystemPasswordChar = True
        '
        'TxtRetypePW
        '
        Me.TxtRetypePW.Location = New System.Drawing.Point(25, 185)
        Me.TxtRetypePW.MaxLength = 8
        Me.TxtRetypePW.Name = "TxtRetypePW"
        Me.TxtRetypePW.Size = New System.Drawing.Size(136, 20)
        Me.TxtRetypePW.TabIndex = 3
        Me.TxtRetypePW.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Re-Type Password:"
        '
        'BtnChangePW
        '
        Me.BtnChangePW.Location = New System.Drawing.Point(25, 226)
        Me.BtnChangePW.Name = "BtnChangePW"
        Me.BtnChangePW.Size = New System.Drawing.Size(128, 23)
        Me.BtnChangePW.TabIndex = 27
        Me.BtnChangePW.Text = "CHANGE PASSWORD"
        Me.BtnChangePW.UseVisualStyleBackColor = True
        '
        'TxtOldPW
        '
        Me.TxtOldPW.Location = New System.Drawing.Point(25, 74)
        Me.TxtOldPW.MaxLength = 8
        Me.TxtOldPW.Name = "TxtOldPW"
        Me.TxtOldPW.Size = New System.Drawing.Size(136, 20)
        Me.TxtOldPW.TabIndex = 1
        Me.TxtOldPW.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Old Password:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(418, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(46, 20)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.Tag = "Ticket Number is required"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 145)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 10)
        Me.ProgressBar1.TabIndex = 31
        '
        'lblProgressBar
        '
        Me.lblProgressBar.AutoSize = True
        Me.lblProgressBar.Location = New System.Drawing.Point(167, 124)
        Me.lblProgressBar.Name = "lblProgressBar"
        Me.lblProgressBar.Size = New System.Drawing.Size(10, 13)
        Me.lblProgressBar.TabIndex = 32
        Me.lblProgressBar.Text = "-"
        '
        'cboShowPW
        '
        Me.cboShowPW.AutoSize = True
        Me.cboShowPW.Location = New System.Drawing.Point(187, 187)
        Me.cboShowPW.Name = "cboShowPW"
        Me.cboShowPW.Size = New System.Drawing.Size(108, 17)
        Me.cboShowPW.TabIndex = 33
        Me.cboShowPW.Text = "Show Password?"
        Me.cboShowPW.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(169, 239)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 13)
        Me.LinkLabel1.TabIndex = 34
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Go Back To Your Account?"
        '
        'FormChangePW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 261)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cboShowPW)
        Me.Controls.Add(Me.lblProgressBar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtOldPW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnChangePW)
        Me.Controls.Add(Me.TxtRetypePW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNewPW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtUID)
        Me.Name = "FormChangePW"
        Me.Text = "CHANGE PASSWORD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtUID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNewPW As System.Windows.Forms.TextBox
    Friend WithEvents TxtRetypePW As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnChangePW As System.Windows.Forms.Button
    Friend WithEvents TxtOldPW As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProgressBar As System.Windows.Forms.Label
    Friend WithEvents cboShowPW As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
