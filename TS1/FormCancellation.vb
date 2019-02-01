Imports System.Data.OleDb

Public Class FormCancellation

    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr, dr2 As OleDbDataReader

    Private Sub FormCancellation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        datafile = "C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        connstring = provider & datafile
        myConnection.ConnectionString = connstring

    End Sub

    Private Sub BtnSearch_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearch.Click
        myConnection.Open()
        TxtDateBooked.Clear()
        TxtAmt.Clear()
        Dim str As String
        str = "SELECT * FROM PAYMENT WHERE (TICKET_NO = '" & Txtticket.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            TxtDateBooked.Text = dr("DATE_BOOKED").ToString
            txtStatus.Text = dr("STATUS").ToString
            TxtAmt.Text = dr("FARE").ToString
            TxtUID.Text = dr("USER_ID").ToString

        End While
        myConnection.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Dim paid As String

        If txtStatus.Text = "paid" Then
            MessageBox.Show("This is already paid" & vbNewLine & _
                            "You will not have any refund for this" & vbNewLine & _
                            "This reservation cannot be cancelled anymore", "BOOKING POLICY", MessageBoxButtons.OK _
                            , MessageBoxIcon.Warning)

        Else
            Dim strDue, strDue2, strB1, strB2 As String
            Dim stConString As String
            txtStatus.Text = "unpaid"
            myConnection.Open()
            stConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
            strDue = "DELETE FROM [PAYMENT] WHERE [STATUS]= '" & txtStatus.Text & "'"
            strDue2 = "DELETE FROM [BOOKING] WHERE [STATUS]= '" & txtStatus.Text & "'"
            strB1 = "DELETE FROM [BUS1] WHERE [STATUS]= '" & txtStatus.Text & "'"
            strB2 = "DELETE FROM [BUS2] WHERE [STATUS]= '" & txtStatus.Text & "'"
            Dim cmd3 As OleDbCommand = New OleDbCommand(strDue, myConnection)
            Dim cmd4 As OleDbCommand = New OleDbCommand(strDue2, myConnection)
            Dim cmd5 As OleDbCommand = New OleDbCommand(strB1, myConnection)
            Dim cmd6 As OleDbCommand = New OleDbCommand(strB2, myConnection)
            'cmd3.Parameters.Clear("DATE_BOOKED", CType(DateTimePicker1.Text, Date)
            Try
                cmd3.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                cmd5.ExecuteNonQuery()
                cmd6.ExecuteNonQuery()
                cmd3.Dispose()
                cmd4.Dispose()
                cmd5.Dispose()
                cmd6.Dispose()
                myConnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            'dr2 = cmd2.ExecuteReader

            MessageBox.Show("Your reservation has been successfully cancelled", "RESERVATION CANCELLATION" _
                            , MessageBoxButtons.OK, MessageBoxIcon.Information)
            If DialogResult.Yes Then
                End
           
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        formMyAccount.Show()
        Me.Hide()

    End Sub
End Class