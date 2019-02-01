Imports System.Data.OleDb

Public Class FormLogIn

    Dim provider As String
    Dim datafile As String
    Dim conStr As String
    Dim myCon As OleDbConnection = New OleDbConnection

    'method for button login 
    Public Sub Login_Data()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        datafile = "C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        conStr = provider & datafile
        myCon.ConnectionString = conStr
        'will base the login credentials to the users table
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [USERS] WHERE [USER_NAME] = '" & TextBox1.Text & _
                                                   "' AND [PASSWORD] = '" & TextBox2.Text & "'", myCon)
        'will open the the database
        myCon.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False

        Dim ID As String = ""
        Dim FName As String = ""
        Dim LName As String = ""
        Dim ADDRESS As String = ""
        Dim CITY As String = ""
        Dim PW As String = ""
        'will find the user
        While dr.Read
            userFound = True
            FName = dr("FIRST_NAME").ToString
            LName = dr("LAST_NAME").ToString
            ID = dr("USER_ID").ToString
            ADDRESS = dr("ADDRESS").ToString
            CITY = dr("CITY").ToString
            PW = dr("PASSWORD").ToString
        End While

        If userFound = True Then
            FormMyAccount.Show()
            FormMyAccount.Label1.Text = FName & " " & LName
            FormMyAccount.TextBox1.Text = ID
            formMyAccount.LblAdd.Text = ADDRESS
            formMyAccount.LblCity.Text = CITY
            formMyAccount.TextBox2.Text = PW
        End If
        myCon.Close()

        con.Open()

        Dim dt As New DataTable("USERS")
        Dim rs As New OleDb.OleDbDataAdapter("Select * from USERS where USER_NAME = '" & TextBox1.Text & "' and PASSWORD = '" & TextBox2.Text & "'", con)
        Static trial As Byte
        Dim answer As Integer
        rs.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        Label1.Text = dt.Rows.Count

        rs.Dispose()
        con.Close()

        If Val(Label1.Text) = 1 Then
            If TextBox1.Text = "admin" AndAlso TextBox2.Text = "ron@1104" Then
                MessageBox.Show("You are logged in as Administrator", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
                formMyAccount.LinkBook.Visible = False
                formMyAccount.LinkPayment.Visible = False
                formMyAccount.LinkLabel1.Visible = False
                'FormMenu.Show()
                'Form8.Show()
                Me.Hide()

            ElseIf TextBox1.Text = "teller" AndAlso TextBox2.Text = "teller" Then
                formMyAccount.LinkMain.Visible = False
                formMyAccount.LinkBook.Visible = False
                formMyAccount.LinkLabel1.Visible = False
                'MessageBox.Show("You are logged in as Teller", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'FormTeller.Show()
                Me.Hide()
            Else
                formMyAccount.LinkMain.Visible = False
                formMyAccount.LinkPayment.Visible = False
                'MessageBox.Show("WELCOME!!!", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()

                'RetrieveUserID.Show()
                'FormBooking.Show()
                'Form8.Show()
            End If
        ElseIf trial = 2 Then
            MessageBox.Show("Unauthorized user, keep out...", "Password Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Close()
        Else

            answer = MessageBox.Show("Invalid username or password, Try Again?", "Password Entry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question)
            If answer = DialogResult.Retry Then
                trial = trial + 1
                TextBox2.Text = ""
                TextBox2.Focus()
            Else
                Close()

            End If
        End If
    End Sub
    Public Sub Display_Data()
        con.Open()

        Dim dt As New DataTable("USERS")
        Dim rs As New OleDb.OleDbDataAdapter("Select * from USERS", con)
        rs.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        Label1.Text = dt.Rows.Count
        rs.Dispose()
        con.Close()

    End Sub
    Private Sub LblCreateNewAcct_Click(sender As System.Object, e As System.EventArgs) Handles LblCreateNewAcct.Click

    End Sub

    Private Sub BtnLogin_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogin.Click
        If vld(TextBox1, TextBox2) = False Then
            Exit Sub
        End If
        Login_Data()

    End Sub




    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Display_Data()
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub LnkLblCreateNew_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkLblCreateNew.LinkClicked
        CreateAcct.Show()
        Me.Hide()
    End Sub

    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProvider1.SetError(ctl(i), ctl(i).tag)
                Return False
                Exit Function
            End If
        Next
        Return True

    End Function

    Private Sub cboAdmin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cboAdmin.CheckedChanged
        If vld(TextBox1, TextBox2) = False Then
            cboAdmin.Checked = False
            Exit Sub
        End If
        If TextBox1.Text = "admin" AndAlso cboAdmin.Checked Then
            'MsgBox("Hi Admin")
        Else
            MsgBox("You are not the Admin")
            TextBox1.Text = ""
            TextBox1.Focus()
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cboShowPW.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not cboShowPW.Checked
    End Sub
End Class