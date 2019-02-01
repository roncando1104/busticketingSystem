<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCancellation
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
        Me.Txtticket = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAmt = New System.Windows.Forms.TextBox()
        Me.TxtDateBooked = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "User ID:"
        '
        'TxtUID
        '
        Me.TxtUID.Enabled = False
        Me.TxtUID.Location = New System.Drawing.Point(364, 34)
        Me.TxtUID.Name = "TxtUID"
        Me.TxtUID.Size = New System.Drawing.Size(46, 20)
        Me.TxtUID.TabIndex = 27
        Me.TxtUID.Tag = "Ticket Number is required"
        '
        'Txtticket
        '
        Me.Txtticket.Location = New System.Drawing.Point(103, 19)
        Me.Txtticket.Name = "Txtticket"
        Me.Txtticket.Size = New System.Drawing.Size(100, 20)
        Me.Txtticket.TabIndex = 21
        Me.Txtticket.Tag = "Ticket Number is required"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtAmt)
        Me.GroupBox1.Controls.Add(Me.TxtDateBooked)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 137)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOOKING INFO:"
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(100, 57)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 9
        Me.txtStatus.Tag = "This is a required field"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "STATUS:"
        '
        'TxtAmt
        '
        Me.TxtAmt.Enabled = False
        Me.TxtAmt.Location = New System.Drawing.Point(100, 85)
        Me.TxtAmt.Name = "TxtAmt"
        Me.TxtAmt.Size = New System.Drawing.Size(100, 20)
        Me.TxtAmt.TabIndex = 5
        Me.TxtAmt.Tag = "This is a required field"
        '
        'TxtDateBooked
        '
        Me.TxtDateBooked.Enabled = False
        Me.TxtDateBooked.Location = New System.Drawing.Point(100, 30)
        Me.TxtDateBooked.Name = "TxtDateBooked"
        Me.TxtDateBooked.Size = New System.Drawing.Size(100, 20)
        Me.TxtDateBooked.TabIndex = 7
        Me.TxtDateBooked.Tag = "This is a required field"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "AMOUNT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DATE BOOKED:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Enter Ticket No.:"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSearch.Image = Global.TS1.My.Resources.Resources.searchbtn
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(223, 12)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(99, 42)
        Me.BtnSearch.TabIndex = 24
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CANCEL RESERVATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(216, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 46)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormCancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(436, 298)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtUID)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.Txtticket)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCancellation"
        Me.Text = "FormCancellation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtUID As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Txtticket As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtAmt As System.Windows.Forms.TextBox
    Friend WithEvents TxtDateBooked As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
