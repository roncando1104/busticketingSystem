<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.LinkMngdUser = New System.Windows.Forms.LinkLabel()
        Me.LinkMBookings = New System.Windows.Forms.LinkLabel()
        Me.LinkOverDue = New System.Windows.Forms.LinkLabel()
        Me.LinkPayment = New System.Windows.Forms.LinkLabel()
        Me.LblLogout = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkMngdUser
        '
        Me.LinkMngdUser.AutoSize = True
        Me.LinkMngdUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LinkMngdUser.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkMngdUser.Location = New System.Drawing.Point(45, 176)
        Me.LinkMngdUser.Name = "LinkMngdUser"
        Me.LinkMngdUser.Size = New System.Drawing.Size(206, 13)
        Me.LinkMngdUser.TabIndex = 4
        Me.LinkMngdUser.TabStop = True
        Me.LinkMngdUser.Text = "MANAGE USERS AND TRANSACTIONS"
        '
        'LinkMBookings
        '
        Me.LinkMBookings.AutoSize = True
        Me.LinkMBookings.Location = New System.Drawing.Point(312, 176)
        Me.LinkMBookings.Name = "LinkMBookings"
        Me.LinkMBookings.Size = New System.Drawing.Size(160, 13)
        Me.LinkMBookings.TabIndex = 5
        Me.LinkMBookings.TabStop = True
        Me.LinkMBookings.Text = "MANAGE BOOKING OF SEATS"
        '
        'LinkOverDue
        '
        Me.LinkOverDue.AutoSize = True
        Me.LinkOverDue.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkOverDue.Location = New System.Drawing.Point(67, 345)
        Me.LinkOverDue.Name = "LinkOverDue"
        Me.LinkOverDue.Size = New System.Drawing.Size(171, 13)
        Me.LinkOverDue.TabIndex = 6
        Me.LinkOverDue.TabStop = True
        Me.LinkOverDue.Text = "MANAGE OVER DUE BOOKINGS"
        '
        'LinkPayment
        '
        Me.LinkPayment.AutoSize = True
        Me.LinkPayment.LinkColor = System.Drawing.Color.Yellow
        Me.LinkPayment.Location = New System.Drawing.Point(318, 345)
        Me.LinkPayment.Name = "LinkPayment"
        Me.LinkPayment.Size = New System.Drawing.Size(146, 13)
        Me.LinkPayment.TabIndex = 7
        Me.LinkPayment.TabStop = True
        Me.LinkPayment.Text = "PAYMENT / TELLER MODE"
        '
        'LblLogout
        '
        Me.LblLogout.AutoSize = True
        Me.LblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.LblLogout.Location = New System.Drawing.Point(12, 9)
        Me.LblLogout.Name = "LblLogout"
        Me.LblLogout.Size = New System.Drawing.Size(61, 16)
        Me.LblLogout.TabIndex = 8
        Me.LblLogout.Text = "Log Out"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.TS1.My.Resources.Resources.overdue
        Me.PictureBox4.Location = New System.Drawing.Point(84, 204)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TS1.My.Resources.Resources.managePayment
        Me.PictureBox3.Location = New System.Drawing.Point(324, 204)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TS1.My.Resources.Resources.manageBooking
        Me.PictureBox2.Location = New System.Drawing.Point(324, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TS1.My.Resources.Resources.manageUser
        Me.PictureBox1.Location = New System.Drawing.Point(84, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.TS1.My.Resources.Resources.out
        Me.PictureBox5.Location = New System.Drawing.Point(76, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 24)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(532, 393)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.LblLogout)
        Me.Controls.Add(Me.LinkPayment)
        Me.Controls.Add(Me.LinkOverDue)
        Me.Controls.Add(Me.LinkMBookings)
        Me.Controls.Add(Me.LinkMngdUser)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormMenu"
        Me.Text = "ADMIN MENU"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkMngdUser As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkMBookings As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkOverDue As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkPayment As System.Windows.Forms.LinkLabel
    Friend WithEvents LblLogout As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
