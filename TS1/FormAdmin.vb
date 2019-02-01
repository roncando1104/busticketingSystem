Imports System.Data.OleDb
Public Class FormAdmin

    Dim con As New OleDb.OleDbConnection
    Dim ds, ds2, ds3, ds4 As New DataSet
    Dim da, da2, da3, da4 As New OleDb.OleDbDataAdapter
    Dim sql, sql2, sql3, sql4 As String
    Dim connString As String
    Dim path As String
    Dim inc As Integer
    Dim maxrows As Integer

    Private StrengthWords() As String = {"Very Very Weak", "Very Weak", "Weak", "Better", "Medium", "Strong", "Strongest"}

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

    Private Sub USERSBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles USERSBindingNavigatorSaveItem.Click

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Ticketing_SystemDataSet41.PAYMENT' table. You can move, or remove it, as needed.
        'Me.PAYMENTTableAdapter1.Fill(Me.Ticketing_SystemDataSet41.PAYMENT)
        'TODO: This line of code loads data into the 'Ticketing_SystemDataSet4.PAYMENT' table. You can move, or remove it, as needed.
        'Me.PAYMENTTableAdapter.Fill(Me.Ticketing_SystemDataSet4.PAYMENT)

        Try
            path = "C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path

            con = New OleDbConnection(connString)
            con.Open()
            sql = "Select * from USERS"
            sql2 = "Select * from BOOKING"
            sql3 = "Select * from PAYMENT"

            da = New OleDb.OleDbDataAdapter(sql, con)
            da2 = New OleDb.OleDbDataAdapter(sql2, con)
            da3 = New OleDb.OleDbDataAdapter(sql3, con)
            da.Fill(ds, "Ticketing System")
            da2.Fill(ds2, "Ticketing System")
            da3.Fill(ds3, "Ticketing System")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        NavigateRecords()
        USERSDataGridView.DataSource = ds.Tables("Ticketing System")
        BOOKINGDataGridView.DataSource = ds2.Tables("Ticketing System")
        PAYMENTDataGridView.DataSource = ds3.Tables("Ticketing System")

    End Sub

    Private Sub BtnCreate_Click(sender As System.Object, e As System.EventArgs) Handles BtnCreate.Click
        clearFields()
        BtnCreate.Enabled = False
        BtnDel.Enabled = False
        BtnEdit.Enabled = False

    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click

        If TextBox7.Text <> TextBox9.Text Then
            MessageBox.Show("Password Mismatch", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox7.Text = ""
            TextBox7.Focus()
            Exit Sub
            saveContact()
            loadGridView()
        End If
    End Sub

    Private Sub deleteData()
        Try

            If con.State = ConnectionState.Closed Then
                con.Open()

            End If

            If MessageBox.Show("Do you really want to delete this record?", "Delete",
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.No Then

                MessageBox.Show("Operation cancelled")
                Exit Sub
            ElseIf TextBox1.Text <> "" Then
                sql = "delete * from USERS where USER_ID = " & CInt(TextBox1.Text)

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    con.Close()
                    MessageBox.Show("Delete Successful")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub deleteData2()
        Try

            If con.State = ConnectionState.Closed Then
                con.Open()

            End If
            If vld(txtORNO) = False Then
                Exit Sub
            End If
            If MessageBox.Show("Do you really want to delete this record?", "Delete",
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.No Then

                MessageBox.Show("Operation cancelled")
                Exit Sub
            ElseIf TextBox1.Text <> "" Then
                sql = "delete * from BOOKING where ORDER_NO = " & CInt(txtORNO.Text)

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    con.Close()
                    MessageBox.Show("Delete Successful")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BtnDel_Click(sender As System.Object, e As System.EventArgs) Handles BtnDel.Click

        deleteData()
        loadGridView()
        clearFields()

    End Sub

    Private Sub saveContact()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox8.Text <> "" And
                TextBox6.Text <> "" And TextBox7.Text <> "" Then

                sql = "Insert into USERS([FIRST_NAME], [LAST_NAME], [ADDRESS], [CITY], [DOB], [USER_NAME], [PASSWORD])" & _
                        "values(?,?,?,?,?,?,?)"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                'cmd.Parameters.Add(New OleDbParameter("USER_ID", CType(TextBox1.ToString, String)))
                cmd.Parameters.Add(New OleDbParameter("FIRST_NAME", CType(TextBox2.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("LAST_NAME", CType(TextBox3.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("ADDRESS", CType(TextBox4.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("CITY", CType(TextBox5.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("DOB", CType(TextBox8.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("USER_NAME", CType(TextBox6.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("PASSWORD", CType(TextBox7.Text, String)))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    con.Close()
                    MessageBox.Show("Data Inserted")
                    clearFields()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Fill all fields")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
        BtnCreate.Enabled = True
        BtnDel.Enabled = True
        BtnEdit.Enabled = True

    End Sub

    Private Sub clearFields()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox8.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub


    Private Sub loadGridView()
        USERSDataGridView.DataSource.Clear()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()

            End If
            sql = "Select * from USERS"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Ticketing System")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        USERSDataGridView.DataSource = ds.Tables("Ticketing System")
    End Sub
    Private Sub loadGridView2()
        BOOKINGDataGridView.DataSource.Clear()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()

            End If
            sql2 = "Select * from BOOKING"
            da2 = New OleDb.OleDbDataAdapter(sql2, con)
            da2.Fill(ds, "Ticketing System")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        BOOKINGDataGridView.DataSource = ds2.Tables("Ticketing System")
    End Sub

    Private Sub loadGridView3()
        PAYMENTDataGridView.DataSource.Clear()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()

            End If
            sql3 = "Select * from PAYMENT"
            da3 = New OleDb.OleDbDataAdapter(sql3, con)
            da3.Fill(ds3, "Ticketing System")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        PAYMENTDataGridView.DataSource = ds3.Tables("Ticketing System")
    End Sub

    Private Sub NavigateRecords()

        TextBox1.Text = ds.Tables("Ticketing System").Rows(inc).Item(0)
        TextBox2.Text = ds.Tables("Ticketing System").Rows(inc).Item(1)
        TextBox3.Text = ds.Tables("Ticketing System").Rows(inc).Item(2)
        TextBox4.Text = ds.Tables("Ticketing System").Rows(inc).Item(3)
        TextBox5.Text = ds.Tables("Ticketing System").Rows(inc).Item(4)
        TextBox8.Text = ds.Tables("Ticketing System").Rows(inc).Item(5)
        TextBox6.Text = ds.Tables("Ticketing System").Rows(inc).Item(6)
        TextBox7.Text = ds.Tables("Ticketing System").Rows(inc).Item(7)
        maxrows = ds.Tables("Ticketing System").Rows.Count

    End Sub


    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click
        editData()
        loadGridView()
    End Sub

    Private Sub editData()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()

            End If

            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And
                TextBox8.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" Then

                sql = "update USERS set FIRST_NAME = '" & TextBox2.Text & "', " & _
                "LAST_NAME = '" & TextBox3.Text & "', " & "ADDRESS = '" & TextBox4.Text & "', " & _
                "CITY = '" & TextBox5.Text & "', " & "DOB = '" & TextBox8.Text & "', " & _
                "USER_NAME = ' " & TextBox6.Text & "', " & "PASSWORD = '" & TextBox7.Text & "'" & " where USER_ID = " & CInt(TextBox1.Text) & ""

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    con.Close()
                    MessageBox.Show("Update Successful")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("One or more fields are left blank")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BtnFirst_Click(sender As System.Object, e As System.EventArgs) Handles BtnFirst.Click
        If inc <> 0 Then
            inc = 0
            NavigateRecords()

        End If
    End Sub

    Private Sub BtnNext_Click(sender As System.Object, e As System.EventArgs) Handles BtnNext.Click
        If inc <> maxrows - 1 Then
            inc = inc + 1
            NavigateRecords()
        Else
            MessageBox.Show("No Records")
        End If
    End Sub

    Private Sub BtnPrev_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrev.Click
        If inc <> 0 Then
            inc = inc - 1
            NavigateRecords()
        Else
            MessageBox.Show("No Records")
        End If
    End Sub

    Private Sub BtnLast_Click(sender As System.Object, e As System.EventArgs) Handles BtnLast.Click
        Try
            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                NavigateRecords()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnClear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox8.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub Bus1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Bus1ToolStripMenuItem.Click
        FormBus1.Show()
        FormBus1.BtnDone.Visible = False
        FormBus1.BtnCancel.Visible = False
        FormBus1.Label28.Visible = False
        FormBus1.Label29.Visible = False
        FormBus1.Label31.Visible = False
        FormBus1.LblNoOfSeat.Visible = False
        FormBus1.TxtUID.Visible = False
    End Sub

    Private Sub Bus2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Bus2ToolStripMenuItem.Click
        FormBus2.Show()
        FormBus2.btnDone.Visible = False
        FormBus2.btnCancel.Visible = False
        FormBus2.Label28.Visible = False
        FormBus2.Label29.Visible = False
        FormBus2.Label31.Visible = False
        FormBus2.LblNoOfSeat.Visible = False
        FormBus2.TxtUID.Visible = False
    End Sub


    Private Sub BtnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSales.Click
        Dim total As Double = 0
        For i As Integer = 0 To PAYMENTDataGridView.RowCount - 1
            total += PAYMENTDataGridView.Rows(i).Cells(5).Value

        Next
        TxtSales.Text = FormatNumber(total, 2)
    End Sub

    Private Sub BtnTellerMode_Click(sender As System.Object, e As System.EventArgs)
        FormTeller.Show()

    End Sub

    Private Sub BtnRem_Click(sender As System.Object, e As System.EventArgs) Handles BtnRem.Click
        deleteData2()
        loadGridView2()
      
    End Sub

    Private Sub TextBox9_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyUp
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



    'Private Sub BtnSerRec_Click(sender As System.Object, e As System.EventArgs) Handles BtnSerRec.Click
    '   sql = "SELECT * FROM USERS WHERE [USER_ID]='" & TextBox1.Text & "'"
    '  Try
    '     con.Open()
    '    da = New OleDb.OleDbDataAdapter(sql, con)
    '   da.Fill(ds, "Ticketing System")
    '  USERSDataGridView.DataSource = ds

    '    Catch ex As Exception
    '       MsgBox(ex.Message)

    '    End Try
    '   con.Close()
    'End Sub

   


    'Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
    'Dim dt4 As DataTable
    '   sql = "SELECT * FROM USERS WHERE [USER_ID]='" & TextBox1.Text & "'"
    '
    '   dt4 = New DataTable

    '    Try
    '       con.Open()
    '      da = New OleDb.OleDbDataAdapter(sql, con)
    '     da.Fill(dt4, "Ticketing System")

    '    Catch ex As Exception
    '       MsgBox(ex.Message)
    '  End Try
    ' con.Close()

    'End Sub

  

   

    Private Sub cboShowPW_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cboShowPW.CheckedChanged
        TextBox9.UseSystemPasswordChar = Not cboShowPW.Checked
        TextBox7.UseSystemPasswordChar = Not cboShowPW.Checked
    End Sub

   
End Class