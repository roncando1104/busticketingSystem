<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBooking))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListLocation = New System.Windows.Forms.ListBox()
        Me.Quan = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDisc2 = New System.Windows.Forms.TextBox()
        Me.TxtFair = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDisc = New System.Windows.Forms.TextBox()
        Me.cboDisc = New System.Windows.Forms.ComboBox()
        Me.BtnCompute = New System.Windows.Forms.Button()
        Me.TxtTtlAmt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboBusNum = New System.Windows.Forms.ComboBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtConNum = New System.Windows.Forms.TextBox()
        Me.TxtEMail = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtUID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTicketNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Quan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose Destination:"
        '
        'ListLocation
        '
        Me.ListLocation.FormattingEnabled = True
        Me.ListLocation.Items.AddRange(New Object() {"Bulacan", "Pampanga", "Tarlac", "Pangasinan"})
        Me.ListLocation.Location = New System.Drawing.Point(18, 54)
        Me.ListLocation.Name = "ListLocation"
        Me.ListLocation.Size = New System.Drawing.Size(90, 95)
        Me.ListLocation.TabIndex = 2
        '
        'Quan
        '
        Me.Quan.Location = New System.Drawing.Point(68, 166)
        Me.Quan.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Quan.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quan.Name = "Quan"
        Me.Quan.Size = New System.Drawing.Size(49, 20)
        Me.Quan.TabIndex = 3
        Me.Quan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "Feb. 27, 2017  8:13 PM"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(18, 223)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"6:00 AM", "1:30 PM", "7:00 PM"})
        Me.ComboBox1.Location = New System.Drawing.Point(17, 271)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date of Travel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Time of Travel"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtDisc2)
        Me.GroupBox1.Controls.Add(Me.TxtFair)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtDisc)
        Me.GroupBox1.Controls.Add(Me.cboDisc)
        Me.GroupBox1.Controls.Add(Me.BtnCompute)
        Me.GroupBox1.Controls.Add(Me.TxtTtlAmt)
        Me.GroupBox1.Controls.Add(Me.ListLocation)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Quan)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 379)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking Information:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(121, 349)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "TOTAL AMOUNT:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(152, 302)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Fare Rate:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(138, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Discount Rate:"
        '
        'txtDisc2
        '
        Me.txtDisc2.Enabled = False
        Me.txtDisc2.Location = New System.Drawing.Point(221, 321)
        Me.txtDisc2.Name = "txtDisc2"
        Me.txtDisc2.Size = New System.Drawing.Size(54, 20)
        Me.txtDisc2.TabIndex = 15
        '
        'TxtFair
        '
        Me.TxtFair.Enabled = False
        Me.TxtFair.Location = New System.Drawing.Point(221, 299)
        Me.TxtFair.Name = "TxtFair"
        Me.TxtFair.Size = New System.Drawing.Size(57, 20)
        Me.TxtFair.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(152, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Need Discount?"
        '
        'TxtDisc
        '
        Me.TxtDisc.Enabled = False
        Me.TxtDisc.Location = New System.Drawing.Point(281, 321)
        Me.TxtDisc.Name = "TxtDisc"
        Me.TxtDisc.Size = New System.Drawing.Size(27, 20)
        Me.TxtDisc.TabIndex = 14
        '
        'cboDisc
        '
        Me.cboDisc.FormattingEnabled = True
        Me.cboDisc.Items.AddRange(New Object() {"Student", "Senior Citizen", "PWD", "No Discount"})
        Me.cboDisc.Location = New System.Drawing.Point(155, 271)
        Me.cboDisc.Name = "cboDisc"
        Me.cboDisc.Size = New System.Drawing.Size(121, 21)
        Me.cboDisc.TabIndex = 11
        Me.cboDisc.Text = "Discount Type"
        '
        'BtnCompute
        '
        Me.BtnCompute.BackColor = System.Drawing.Color.DarkRed
        Me.BtnCompute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCompute.Location = New System.Drawing.Point(6, 350)
        Me.BtnCompute.Name = "BtnCompute"
        Me.BtnCompute.Size = New System.Drawing.Size(102, 23)
        Me.BtnCompute.TabIndex = 10
        Me.BtnCompute.Text = "Compute Price"
        Me.BtnCompute.UseVisualStyleBackColor = False
        '
        'TxtTtlAmt
        '
        Me.TxtTtlAmt.Enabled = False
        Me.TxtTtlAmt.Location = New System.Drawing.Point(221, 346)
        Me.TxtTtlAmt.Name = "TxtTtlAmt"
        Me.TxtTtlAmt.Size = New System.Drawing.Size(57, 20)
        Me.TxtTtlAmt.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cboBusNum)
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Me.BtnDone)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtConNum)
        Me.GroupBox2.Controls.Add(Me.TxtEMail)
        Me.GroupBox2.Controls.Add(Me.TxtName)
        Me.GroupBox2.Controls.Add(Me.TxtUID)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(358, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 250)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Information:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Select Bus and Seat:"
        '
        'cboBusNum
        '
        Me.cboBusNum.FormattingEnabled = True
        Me.cboBusNum.Items.AddRange(New Object() {"BUS-1", "BUS-2", "BUS-3"})
        Me.cboBusNum.Location = New System.Drawing.Point(97, 165)
        Me.cboBusNum.Name = "cboBusNum"
        Me.cboBusNum.Size = New System.Drawing.Size(121, 21)
        Me.cboBusNum.TabIndex = 25
        Me.cboBusNum.Tag = "Select a seat"
        Me.cboBusNum.Text = "All Bus"
        '
        'BtnCancel
        '
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancel.Location = New System.Drawing.Point(278, 215)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 24
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnDone
        '
        Me.BtnDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDone.Location = New System.Drawing.Point(207, 215)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(65, 23)
        Me.BtnDone.TabIndex = 22
        Me.BtnDone.Text = "Done"
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Bus Number:"
        '
        'TxtConNum
        '
        Me.TxtConNum.Location = New System.Drawing.Point(97, 104)
        Me.TxtConNum.Name = "TxtConNum"
        Me.TxtConNum.Size = New System.Drawing.Size(160, 20)
        Me.TxtConNum.TabIndex = 17
        Me.TxtConNum.Tag = "Please enter Contact Number"
        '
        'TxtEMail
        '
        Me.TxtEMail.Location = New System.Drawing.Point(97, 77)
        Me.TxtEMail.Name = "TxtEMail"
        Me.TxtEMail.Size = New System.Drawing.Size(160, 20)
        Me.TxtEMail.TabIndex = 16
        Me.TxtEMail.Tag = "Please enter E-mail"
        '
        'TxtName
        '
        Me.TxtName.Enabled = False
        Me.TxtName.Location = New System.Drawing.Point(97, 51)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(160, 20)
        Me.TxtName.TabIndex = 15
        Me.TxtName.Tag = "Please enter Name"
        '
        'TxtUID
        '
        Me.TxtUID.Enabled = False
        Me.TxtUID.Location = New System.Drawing.Point(97, 25)
        Me.TxtUID.Name = "TxtUID"
        Me.TxtUID.Size = New System.Drawing.Size(45, 20)
        Me.TxtUID.TabIndex = 11
        Me.TxtUID.Tag = "User ID is required"
        Me.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Contact Number :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "E-mail :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "User ID"
        '
        'TxtTicketNo
        '
        Me.TxtTicketNo.Enabled = False
        Me.TxtTicketNo.Location = New System.Drawing.Point(461, 117)
        Me.TxtTicketNo.Name = "TxtTicketNo"
        Me.TxtTicketNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtTicketNo.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(364, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "TICKET NO:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(421, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 52)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "LAR"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(518, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Bus Lines"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TS1.My.Resources.Resources.busBooking
        Me.PictureBox1.Location = New System.Drawing.Point(589, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.TS1.My.Resources.Resources.road1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTicketNo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBooking"
        Me.Text = "Travel Booking..."
        CType(Me.Quan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListLocation As System.Windows.Forms.ListBox
    Friend WithEvents Quan As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCompute As System.Windows.Forms.Button
    Friend WithEvents TxtTtlAmt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtConNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtEMail As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtUID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnDone As System.Windows.Forms.Button
    Friend WithEvents TxtTicketNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboBusNum As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtDisc As System.Windows.Forms.TextBox
    Friend WithEvents TxtFair As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboDisc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDisc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
