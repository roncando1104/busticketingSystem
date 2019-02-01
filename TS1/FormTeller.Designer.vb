<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTeller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTeller))
        Me.Txtticket = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRecPay = New System.Windows.Forms.Button()
        Me.TxtAmt = New System.Windows.Forms.TextBox()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtStat = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtCashTend = New System.Windows.Forms.TextBox()
        Me.TxtChange = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtUID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtticket
        '
        Me.Txtticket.Location = New System.Drawing.Point(112, 19)
        Me.Txtticket.Name = "Txtticket"
        Me.Txtticket.Size = New System.Drawing.Size(100, 20)
        Me.Txtticket.TabIndex = 0
        Me.Txtticket.Tag = "Ticket Number is required"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Ticket No.:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtLoc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnRecPay)
        Me.GroupBox1.Controls.Add(Me.TxtAmt)
        Me.GroupBox1.Controls.Add(Me.TxtQty)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 174)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAYMENT INFO:"
        '
        'Button3
        '
        Me.Button3.Image = Global.TS1.My.Resources.Resources.clearAll
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(133, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 30)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "CLEAR ALL"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(100, 57)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(100, 20)
        Me.txtLoc.TabIndex = 9
        Me.txtLoc.Tag = "This is a required field"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "LOCATION:"
        '
        'btnRecPay
        '
        Me.btnRecPay.Image = Global.TS1.My.Resources.Resources.recPay
        Me.btnRecPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecPay.Location = New System.Drawing.Point(9, 130)
        Me.btnRecPay.Name = "btnRecPay"
        Me.btnRecPay.Size = New System.Drawing.Size(118, 31)
        Me.btnRecPay.TabIndex = 5
        Me.btnRecPay.Text = "Receive Payment"
        Me.btnRecPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecPay.UseVisualStyleBackColor = True
        '
        'TxtAmt
        '
        Me.TxtAmt.Location = New System.Drawing.Point(100, 89)
        Me.TxtAmt.Name = "TxtAmt"
        Me.TxtAmt.Size = New System.Drawing.Size(100, 20)
        Me.TxtAmt.TabIndex = 5
        Me.TxtAmt.Tag = "This is a required field"
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(100, 30)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(100, 20)
        Me.TxtQty.TabIndex = 7
        Me.TxtQty.Tag = "This is a required field"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "AMOUNT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "QTY:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtStat
        '
        Me.txtStat.Location = New System.Drawing.Point(144, 350)
        Me.txtStat.Name = "txtStat"
        Me.txtStat.Size = New System.Drawing.Size(100, 20)
        Me.txtStat.TabIndex = 14
        Me.txtStat.Tag = "This is a required field"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = Global.TS1.My.Resources.Resources.out
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(37, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "LOG OUT"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chartreuse
        Me.Button1.Image = Global.TS1.My.Resources.Resources.addAny
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(37, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 27)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Book seat(s)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSearch.Image = Global.TS1.My.Resources.Resources.searchbtn
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(232, 12)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(99, 42)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TxtCashTend
        '
        Me.TxtCashTend.Location = New System.Drawing.Point(40, 53)
        Me.TxtCashTend.Name = "TxtCashTend"
        Me.TxtCashTend.Size = New System.Drawing.Size(100, 20)
        Me.TxtCashTend.TabIndex = 14
        Me.TxtCashTend.Tag = "This is a required field"
        '
        'TxtChange
        '
        Me.TxtChange.Location = New System.Drawing.Point(40, 92)
        Me.TxtChange.Name = "TxtChange"
        Me.TxtChange.Size = New System.Drawing.Size(100, 20)
        Me.TxtChange.TabIndex = 15
        Me.TxtChange.Tag = "This is a required field"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Change:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Cash Tendered:"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(51, 126)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 39)
        Me.btnCompute.TabIndex = 18
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnCompute)
        Me.GroupBox2.Controls.Add(Me.TxtCashTend)
        Me.GroupBox2.Controls.Add(Me.TxtChange)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 174)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'TxtUID
        '
        Me.TxtUID.Enabled = False
        Me.TxtUID.Location = New System.Drawing.Point(373, 34)
        Me.TxtUID.Name = "TxtUID"
        Me.TxtUID.Size = New System.Drawing.Size(46, 20)
        Me.TxtUID.TabIndex = 20
        Me.TxtUID.Tag = "Ticket Number is required"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(370, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "User ID:"
        '
        'FormTeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(437, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtUID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtStat)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.Txtticket)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTeller"
        Me.Text = "TELLER & PAYMENT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtticket As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecPay As System.Windows.Forms.Button
    Friend WithEvents TxtAmt As System.Windows.Forms.TextBox
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtStat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents TxtCashTend As System.Windows.Forms.TextBox
    Friend WithEvents TxtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtUID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
