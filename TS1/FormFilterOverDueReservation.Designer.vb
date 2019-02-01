<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilterOverDueReservation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TxtStat = New System.Windows.Forms.TextBox()
        Me.BtnDelOverDue = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(30, 46)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'TxtStat
        '
        Me.TxtStat.Enabled = False
        Me.TxtStat.Location = New System.Drawing.Point(30, 336)
        Me.TxtStat.Name = "TxtStat"
        Me.TxtStat.Size = New System.Drawing.Size(100, 20)
        Me.TxtStat.TabIndex = 3
        Me.TxtStat.Visible = False
        '
        'BtnDelOverDue
        '
        Me.BtnDelOverDue.Image = Global.TS1.My.Resources.Resources.due
        Me.BtnDelOverDue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelOverDue.Location = New System.Drawing.Point(54, 234)
        Me.BtnDelOverDue.Name = "BtnDelOverDue"
        Me.BtnDelOverDue.Size = New System.Drawing.Size(179, 53)
        Me.BtnDelOverDue.TabIndex = 2
        Me.BtnDelOverDue.Text = "REMOVE OVER DUE RESERVATION"
        Me.BtnDelOverDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelOverDue.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(13, 293)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(122, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "GO BACK TO MENU >>"
        '
        'FormFilterOverDueReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(291, 318)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TxtStat)
        Me.Controls.Add(Me.BtnDelOverDue)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormFilterOverDueReservation"
        Me.Text = "OVERDUE RESERVATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents BtnDelOverDue As System.Windows.Forms.Button
    Friend WithEvents TxtStat As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
