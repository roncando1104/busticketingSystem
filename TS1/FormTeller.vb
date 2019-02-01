Imports System.Data.OleDb


Public Class FormTeller

    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr, dr2 As OleDbDataReader



    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        datafile = "C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        connstring = provider & datafile
        myConnection.ConnectionString = connstring

        txtStat.Hide()

    End Sub

    Private Sub BtnSearch_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearch.Click
        myConnection.Open()
        TxtQty.Clear()
        TxtAmt.Clear()
        Dim str As String       
        str = "SELECT * FROM PAYMENT WHERE (TICKET_NO = '" & Txtticket.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            TxtUID.Text = dr("USER_ID").ToString
            TxtQty.Text = dr("QUANTITY").ToString
            TxtAmt.Text = dr("FARE").ToString
            txtLoc.Text = dr("DESTINATION").ToString
        End While
        myConnection.Close()
        txtStat.Text = "paid"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FormBooking.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Txtticket.Clear()
        TxtQty.Clear()
        txtLoc.Clear()
        TxtAmt.Clear()
    End Sub

    Private Sub btnRecPay_Click(sender As System.Object, e As System.EventArgs) Handles btnRecPay.Click
        Dim str2, str3, strB1, strB2 As String
        Dim stConString As String
        myConnection.Open()

        str2 = "UPDATE [PAYMENT] SET [STATUS] = '" & txtStat.Text & "' WHERE [TICKET_NO]= '" & Txtticket.Text & "'"
        str3 = "UPDATE [BOOKING] SET [STATUS] = '" & txtStat.Text & "' WHERE [USER_ID]= '" & TxtUID.Text & "'"
        strB1 = "UPDATE [BUS1] SET [STATUS] = '" & txtStat.Text & "' WHERE [TICKET_NO]= '" & Txtticket.Text & "'"
        strB2 = "UPDATE [BUS2] SET [STATUS] = '" & txtStat.Text & "' WHERE [TICKET_NO]= '" & Txtticket.Text & "'"
        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
        Dim cmd3 As OleDbCommand = New OleDbCommand(str3, myConnection)
        Dim cmdB1 As OleDbCommand = New OleDbCommand(strB1, myConnection)
        Dim cmdB2 As OleDbCommand = New OleDbCommand(strB2, myConnection)
        cmd2.Parameters.Add(New OleDbParameter("STATUS", ("paid")))
        cmd3.Parameters.Add(New OleDbParameter("STATUS", ("paid")))
        cmdB1.Parameters.Add(New OleDbParameter("STATUS", ("paid")))
        cmdB2.Parameters.Add(New OleDbParameter("STATUS", ("paid")))
        Try
            cmd2.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            cmdB1.ExecuteNonQuery()
            cmdB2.ExecuteNonQuery()
            cmd2.Dispose()
            cmd3.Dispose()
            cmdB1.Dispose()
            cmdB2.Dispose()
            myConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        'dr2 = cmd2.ExecuteReader
        stConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"

        MessageBox.Show("Payment has been accepted", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
        myConnection.Close()
        If vld(Txtticket, TxtQty, txtLoc, TxtAmt) = False Then

        End If
        Exit Sub

        End
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

    

  
    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        TxtChange.Text = TxtCashTend.Text - TxtAmt.Text

    End Sub

    Private Sub TxtCashTend_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCashTend.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Invalid amount!", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtCashTend.BackColor = Color.Red
                TxtCashTend.Text = ""
            End If
        End If
    End Sub

   
End Class