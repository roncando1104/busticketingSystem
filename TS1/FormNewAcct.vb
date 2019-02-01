Imports System.Data.OleDb


Public Class CreateAcct

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private StrengthWords() As String = {"Very Very Weak", "Very Weak", "Weak", "Better", "Medium", "Strong", "Strongest"}


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()


    End Sub

   

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        If TextBox8.Text <> TextBox9.Text Then
            MessageBox.Show("Password Mismatch", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox8.Text = ""
            TextBox8.Focus()
            Exit Sub

        Else

            MessageBox.Show("Your account has been created", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            dataFile = "C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
            connString = provider & dataFile
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim str As String
            str = "Insert into USERS([FIRST_NAME],[LAST_NAME],[ADDRESS],[CITY],[DOB],[USER_NAME],[PASSWORD]) Values (?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            'cmd.Parameters.Add(New OleDbParameter("USER_ID", CType(TextBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("FIRST_NAME", CType(TextBox2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("LAST_NAME", CType(TextBox3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("ADDRESS", CType(TextBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("CITY", CType(TextBox5.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("DOB", CType(TextBox6.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("USER_NAME", CType(TextBox7.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PASSWORD", CType(TextBox8.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox8.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub BtnLogin_Click(sender As System.Object, e As System.EventArgs)
        
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub cboShowPW_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cboShowPW.CheckedChanged
        TextBox8.UseSystemPasswordChar = Not cboShowPW.Checked
        TextBox9.UseSystemPasswordChar = Not cboShowPW.Checked
    End Sub

    Private Sub TextBox9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyUp
        CalculateMeter()
    End Sub

    Sub CalculateMeter()
        Dim score As Integer
        Dim password As String = TextBox9.Text
        If (password.Length > 6) Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") And _
            System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then
            score += 1
        End If

        If System.Text.RegularExpressions.Regex.IsMatch(password, "\d+") Then
            score += 1
        End If

        If System.Text.RegularExpressions.Regex.IsMatch(password, "[!,@,#,$,%,^,&,*,?,_,~,-,/""]") Then
            score += 1
        End If

        If (password.Length >= 6) Then score += 1
        If (password.Length > 7) Then score += 1
        ProgressBar1.Value = score / 6 * 100
        lblProgressBar.Width = 50 * score
        lblProgressBar.Text = StrengthWords(score)
        lblProgressBar.TextAlign = ContentAlignment.MiddleCenter
        'lblProgressBar.BackColor = GetColor(score)
        lblProgressBar.ForeColor = GetColor(score)

    End Sub

    Private Function GetColor(ByVal score As Integer) As Color
        Select Case score

            Case 0
                Return Color.Red
            Case 1
                Return Color.Red
            Case 2
                Return Color.Purple
            Case 3
                Return Color.LightGreen
            Case 4
                Return Color.MediumSeaGreen
            Case 5
                Return Color.Green
            Case 6
                Return Color.DarkGreen

        End Select
    End Function
   
End Class
