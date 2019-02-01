Imports System.Data.OleDb

Public Class FormFilterOverDueReservation


    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr, dr2 As OleDbDataReader

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = My.Computer.Clock.LocalTime.ToString
    End Sub
    Private Sub FormFilterOverDueReservation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        datafile = "C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        connstring = provider & datafile
        myConnection.ConnectionString = connstring
    End Sub

    Private Sub BtnDelOverDue_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelOverDue.Click
        Dim strDue, strDue2, strB1, strB2 As String
        Dim stConString As String
        TxtStat.Text = "unpaid"
        myConnection.Open()
        stConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        strDue = "DELETE FROM [PAYMENT] WHERE [DATE_BOOKED]<#" & Today & "# AND [STATUS]= '" & TxtStat.Text & "'"
        strDue2 = "DELETE FROM [BOOKING] WHERE [DATE_BOOKED]<#" & Today & "# AND [STATUS]= '" & TxtStat.Text & "'"
        strB1 = "DELETE FROM [BUS1] WHERE [DATE_BOOKED]<#" & Today & "# AND [STATUS]= '" & TxtStat.Text & "'"
        strB2 = "DELETE FROM [BUS2] WHERE [DATE_BOOKED]<#" & Today & "# AND [STATUS]= '" & TxtStat.Text & "'"
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

        MessageBox.Show("Successfully Deleted" + vbNewLine + "GO BACK TO MAIN MENU?", "ADMIN", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If DialogResult.Yes Then
            FormMenu.Show()
            Me.Hide()
        Else
            End
        End If

    End Sub

   
   
    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormMenu.Show()
        Me.Hide()

    End Sub
End Class