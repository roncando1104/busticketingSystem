Imports System.Data.OleDb

Public Class FormChangePW

    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr, dr2 As OleDbDataReader

    Private StrengthWords() As String = {"Very Very Weak", "Very Weak", "Weak", "Better", "Medium", "Strong", "Strongest"}

    Private Sub FormChangePW_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        datafile = "C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        connstring = provider & datafile
        myConnection.ConnectionString = connstring
    End Sub

    Private Sub BtnChangePW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangePW.Click
        Dim str2 As String
        Dim stConString As String
        myConnection.Open()

        If TxtNewPW.Text <> TxtRetypePW.Text Then
            MessageBox.Show("Password Mismatch", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtRetypePW.Text = ""
            TxtRetypePW.Focus()


        ElseIf TxtOldPW.Text <> TextBox1.Text Then
            MessageBox.Show("Password Mismatch", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            str2 = "UPDATE [USERS] SET [PASSWORD] = '" & TxtRetypePW.Text & "' WHERE [PASSWORD] = '" & TxtOldPW.Text & "' AND [USER_ID] = " & TxtUID.Text
            Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
            cmd2.Parameters.Add(New OleDbParameter("PASSWORD", (TxtRetypePW.Text)))

            Try
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()
                myConnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            stConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"

            MessageBox.Show("Password has been updated", "PASSWORD UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Exit Sub

            End
        End If
        myConnection.Close()


        Exit Sub
    End Sub

    Private Sub TxtNewPW_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNewPW.KeyUp
        CalculateMeter()
    End Sub

    Sub CalculateMeter()
        Dim score As Integer
        Dim password As String = TxtNewPW.Text
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

   
    Private Sub cboShowPW_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cboShowPW.CheckedChanged
        TxtOldPW.UseSystemPasswordChar = Not cboShowPW.Checked
        TxtNewPW.UseSystemPasswordChar = Not cboShowPW.Checked
        TxtRetypePW.UseSystemPasswordChar = Not cboShowPW.Checked
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        formMyAccount.Show()
        Me.Hide()
    End Sub
End Class