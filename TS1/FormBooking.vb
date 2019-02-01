Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class FormBooking

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

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


    Private Sub BtnCompute_Click(ByVal sender As System.Object, e As System.EventArgs) Handles BtnCompute.Click
        Dim Price, Quantity, Disc2, Disc3, Disc4 As Single
        Dim Disc As String

        If ListLocation.SelectedIndex = 0 Then
            Price = 150
            TxtFair.Text = Price
        ElseIf ListLocation.SelectedIndex = 1 Then
            Price = 300
            TxtFair.Text = Price
        ElseIf ListLocation.SelectedIndex = 2 Then
            Price = 450
            TxtFair.Text = Price
        ElseIf ListLocation.SelectedIndex = 3 Then
            Price = 600
            TxtFair.Text = Price
        Else
            MessageBox.Show("Please select a destination", "CanDo Bus Corp")
            Exit Sub
        End If

        Quantity = Quan.Text

        If Quantity = 0 Then
            MessageBox.Show("Please enter quantity", "CanDo Bus Corp")
            Exit Sub

        End If

        If cboDisc.SelectedIndex = 0 Then
            MessageBox.Show("Please bring your ID on your travel date", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Disc = "10%"
            Disc2 = 0.1
            TxtDisc.Text = Disc
            TxtTtlAmt.Text = FormatNumber(Price, 2)
            TxtFair.Text = FormatNumber(Price * Quantity, 2)
            txtDisc2.Text = FormatNumber(TxtFair.Text * Disc2, 2)
            TxtTtlAmt.Text = FormatNumber(TxtFair.Text - txtDisc2.Text, 2)
        ElseIf cboDisc.SelectedIndex = 1 Then
            MessageBox.Show("Please bring your ID on your travel date", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Disc = "20%"
            Disc3 = 0.2
            TxtDisc.Text = Disc
            TxtTtlAmt.Text = FormatNumber(Price, 2)
            TxtFair.Text = FormatNumber(Price * Quantity, 2)
            txtDisc2.Text = FormatNumber(TxtFair.Text * 0.2, 2)
            TxtTtlAmt.Text = FormatNumber(TxtFair.Text - txtDisc2.Text, 2)
        ElseIf cboDisc.SelectedIndex = 2 Then
            Disc = "30%"
            Disc4 = 0.3
            TxtDisc.Text = Disc
            TxtTtlAmt.Text = FormatNumber(Price, 2)
            TxtFair.Text = FormatNumber(Price * Quantity, 2)
            txtDisc2.Text = FormatNumber(TxtFair.Text * Disc4, 2)
            TxtTtlAmt.Text = FormatNumber(TxtFair.Text - txtDisc2.Text, 2)
        Else
            Disc = "0%"
            TxtDisc.Text = Disc
            TxtTtlAmt.Text = FormatNumber(Price, 2)
            TxtFair.Text = FormatNumber(Price * Quantity, 2)
            txtDisc2.Text = FormatNumber(0, 2)
            TxtTtlAmt.Text = FormatNumber(TxtFair.Text - txtDisc2.Text, 2)
        End If


        Dim pool As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim count = 0
        TxtTicketNo.Text = ""
        Dim cc As New Random
        Dim strpos = ""
        While count <= 5
            strpos = cc.Next(0, pool.Length)
            TxtTicketNo.Text = TxtTicketNo.Text & pool(strpos)
            count = count + 1

        End While
        BtnCompute.Enabled = False


    End Sub

    Private Sub BtnDone_Click(sender As System.Object, e As System.EventArgs) Handles BtnDone.Click
        Dim OBJ As New FormVoucher

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into PAYMENT([USER_ID], [TICKET_NO],[DATE_BOOKED],[DESTINATION],[QUANTITY],[FARE], [STATUS]) Values (?,?,?,?,?,?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("USER_ID", CType(TxtUID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("TICKET_NO", CType(TxtTicketNo.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DATE_BOOKED", CType(DateTimePicker1.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("DESTINATION", CType(ListLocation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("QUANTITY", CType(Quan.Value, String)))
        cmd.Parameters.Add(New OleDbParameter("FARE", CType(TxtTtlAmt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("STATUS", ("unpaid")))

       
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        If vld(TxtUID, TxtName, TxtEMail, TxtConNum, cboBusNum) = False Then
            Exit Sub
        Else
            OBJ.StringPass1 = ListLocation.Text
            OBJ.StringPass2 = Quan.Text
            OBJ.StringPass3 = DateTimePicker1.Text
            OBJ.StringPass4 = ComboBox1.Text
            OBJ.StringPass5 = TxtTtlAmt.Text
            OBJ.StringPass6 = TxtUID.Text
            OBJ.StringPass7 = TxtName.Text
            OBJ.StringPass8 = TxtEMail.Text
            OBJ.StringPass9 = TxtConNum.Text
            OBJ.StringPass10 = cboBusNum.Text
            OBJ.StringPass12 = TxtTicketNo.Text
            OBJ.StringPass13 = cboDisc.Text
            OBJ.StringPass14 = TxtDisc.Text
            OBJ.StringPass15 = TxtFair.Text
            OBJ.Show()
        End If
        Me.Hide()
        FormBus1.Hide()

    End Sub

    Private Sub cboBusNum_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboBusNum.SelectedIndexChanged
        If cboBusNum.SelectedIndex = 0 Then

            If vld(TxtUID, TxtName, TxtEMail, TxtConNum) = False Then
                Exit Sub
            End If
            FormBus1.LblNoOfSeat.Text = Quan.Value
            FormBus1.TxtUID.Text = TxtUID.Text
            FormBus1.TextBox1.Text = TxtTicketNo.Text
            FormBus1.TextBox2.Text = ListLocation.Text
            FormBus1.TextBox3.Text = DateTimePicker1.Text
            FormBus1.Show()


            Me.Hide()
        ElseIf cboBusNum.SelectedIndex = 1 Then
            If vld(TxtUID, TxtName, TxtEMail, TxtConNum) = False Then
                Exit Sub
            End If

            FormBus2.LblNoOfSeat.Text = Quan.Value
            FormBus2.TxtUID.Text = TxtUID.Text
            FormBus2.TextBox1.Text = TxtTicketNo.Text
            FormBus2.TextBox2.Text = ListLocation.Text
            FormBus2.TextBox3.Text = DateTimePicker1.Text
            FormBus2.Show()

            Me.Hide()

        End If
    End Sub


    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        End

    End Sub

    Private Sub TxtConNum_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtConNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtConNum.BackColor = Color.Red
                TxtConNum.Text = ""
            End If
        End If
    End Sub

    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If

    End Function

    Private Sub TxtEMail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtEMail.Validating
        Dim email As String = TxtEMail.Text
        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
                = MessageBox.Show("Invalid Email Address. " & _
                                  "Do you want to re-enter it?", "Email Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            TxtEMail.BackColor = Color.Red
            TxtEMail.Text = ""
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True

            End If

        End If

    End Sub

   
End Class