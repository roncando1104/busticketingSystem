Imports System.Data.OleDb
Public Class FormBus2
    Dim availableIcon2 As New System.Drawing.Bitmap(My.Resources.unbooked)
    Dim provisionalIcon2 As New System.Drawing.Bitmap(My.Resources.reserved)
    Dim bookedIcon2 As New System.Drawing.Bitmap(My.Resources.booked)
    Dim MaxSelected As Integer
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

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As Control

        For Each d In Me.Controls
            If TypeOf (d) Is PictureBox Then
                CType(d, PictureBox).Image = availableIcon2
                AddHandler d.Click, AddressOf A1_Click
            End If
        Next

        Call UpdateBookings1()


    End Sub

    Sub UpdateBookings1()

        Dim stSQLa, stSQL2 As String
        stSQLa = "SELECT ORDER_NO, USER_ID, SEAT_NO FROM BOOKING"
        stSQL2 = "SELECT TRAVEL_ID, SEAT_NO, TICKET_NO, DESTINATION FROM BUS2"

        Dim stConString1 As String

        stConString1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        Dim conBooking2 As OleDbConnection
        Dim conBus2 As OleDbConnection

        conBooking2 = New OleDbConnection
        conBus2 = New OleDbConnection
        conBooking2.ConnectionString = stConString1
        conBus2.ConnectionString = stConString1
        conBooking2.Open()
        conBus2.Open()

        Dim cmdSelectBooking As OleDbCommand
        Dim cmdSelectBus2 As OleDbCommand
        cmdSelectBooking = New OleDbCommand
        cmdSelectBus2 = New OleDbCommand
        cmdSelectBooking.CommandText = stSQLa
        cmdSelectBus2.CommandText = stSQL2
        cmdSelectBooking.Connection = conBooking2
        cmdSelectBus2.Connection = conBus2

        Dim dsBooking2 As New DataSet
        Dim daBooking2 As New OleDbDataAdapter(cmdSelectBooking)
        Dim dsBus2 As New DataSet
        Dim daBus2 As New OleDbDataAdapter(cmdSelectBus2)
        daBooking2.Fill(dsBooking2, "BOOKINGs")
        conBooking2.Close()
        daBus2.Fill(dsBus2, "BUS2")
        conBus2.Close()

        'MsgBox(dsBooking2.Tables("BOOKINGs").Rows.Count)
        'MsgBox(dsBooking2.Tables("BOOKING").Rows(0)(1))
        'Dim stOut As String = Nothing
        ' Dim t3 As DataTable
        'Dim row4 As DataRow

        'this is the viewer of the seats
        't3 = dsBooking2.Tables("BOOKINGs")
        'For Each row4 In t3.Rows
        'stOut = stOut & row(0) & " " & row(1) & " " & row(2) & vbNewLine
        'CType(Controls(row4("SEAT_NO")), PictureBox).Image = bookedIcon2

        'Next
        'MsgBox(stOut)
        Dim t2 As DataTable
        Dim row2 As DataRow


        t2 = dsBus2.Tables("BUS2")
        For Each row2 In t2.Rows
            'stOut = stOut & row(0) & " " & row(1) & " " & row(2) & vbNewLine
            CType(Controls(row2("SEAT_NO")), PictureBox).Image = bookedIcon2

        Next
        'MsgBox(stOut)

        If dsBus2.Tables("BUS2").Rows.Count = 38 Then
            MessageBox.Show("This Bus is already sold out!", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End If


        'Dim t4 As DataTable
        'Dim row3 As DataRow


        't4 = dsBus2.Tables("BUS2")
        'For Each row3 In t4.Rows
        'stOut = stOut & row(0) & " " & row(1) & " " & row(2) & vbNewLine
        'CType(Controls(row3("SEAT_NO")), PictureBox).Image = bookedIcon2

        'Next
        'MsgBox(stOut)

    End Sub

    Private Sub A1_Click(sender As System.Object, e As System.EventArgs)
        If CType(sender, PictureBox).Image Is availableIcon2 Then
            CType(sender, PictureBox).Image = provisionalIcon2
            MaxSelected = MaxSelected + 1
           
        ElseIf CType(sender, PictureBox).Image Is provisionalIcon2 Then
            CType(sender, PictureBox).Image = availableIcon2
            MaxSelected = MaxSelected - 1
        End If
    End Sub

    Private Sub BtnDone_Click(sender As System.Object, e As System.EventArgs) Handles btnDone.Click

        Dim d As Control
        Dim aSelected As Boolean

        For Each d In Me.Controls
            If TypeOf (d) Is PictureBox Then
                If CType(d, PictureBox).Image Is provisionalIcon2 Then
                    aSelected = True
                    'MsgBox("You have already reserved your seat... Thank you")
                    'Dim SelectedSeat As String


                    FormBooking.Show()
                    'SelectedSeat.Show()

                    Me.Hide()
                    Exit For

                End If
                'AddHandler c.Click, AddressOf pb1_Click
            End If

        Next
        If aSelected = False Then
            MsgBox("Please select a seat")
            Exit Sub
        End If
        If vld(TxtUID) = False Then
            Exit Sub
        End If
        Dim stSQLInserts, stSQLInsert2 As String
        stSQLInserts = "INSERT INTO BOOKING ([USER_ID], [SEAT_NO]) VALUES (3, pb8)"
        stSQLInsert2 = "INSERT INTO BUS2 ([USER_ID]) VALUES (3, E1)"

        Dim stConString1 As String

        stConString1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"

        Dim conBooking2 As OleDbConnection
        Dim conBus2 As OleDbConnection
        conBooking2 = New OleDbConnection
        conBooking2.ConnectionString = stConString1
        conBus2 = New OleDbConnection
        conBus2.ConnectionString = stConString1
        conBooking2.Open()
        conBus2.Open()

        Dim cmdMakeBooking As OleDbCommand
        Dim cmdBus2 As OleDbCommand
        cmdMakeBooking = New OleDbCommand
        cmdBus2 = New OleDbCommand
        'cmdMakeBookings.CommandText = stSQLInsert
        cmdMakeBooking.Connection = conBooking2
        cmdBus2.Connection = conBus2

        'cmdMakeBookings.ExecuteNonQuery()

        'Try

        'cmdMakeBookings.Dispose()
        'conBooking.Close()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

        Dim iseatNumb As String

        For Each d In Me.Controls
            If TypeOf (d) Is PictureBox Then
                If CType(d, PictureBox).Image Is provisionalIcon2 Then
                    MessageBox.Show("Please note your seat assignments for your reference", _
                                   "Booking Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    iseatNumb = Mid(CType(d, PictureBox).Name, 1)
                    MessageBox.Show(iseatNumb, "Your seat assignments", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MsgBox(iseatNum)
                    'AddHandler c.Click, AddressOf pb1_Click
                    stSQLInserts = "INSERT INTO BOOKING ([USER_ID], [SEAT_NO], [BUS_NO], [DATE_BOOKED], [STATUS]) VALUES ('" & Me.TxtUID.Text & "', '" & iseatNumb.ToString & "', 'Bus 2', '" & TextBox3.Text & "', 'unpaid' )"

                    stSQLInsert2 = "INSERT INTO BUS2 ([SEAT_NO], [TICKET_NO], [DESTINATION], [DATE_BOOKED], [STATUS]) VALUES ('" & iseatNumb.ToString & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', 'unpaid' )"
                    cmdMakeBooking.CommandText = stSQLInserts
                    cmdBus2.CommandText = stSQLInsert2
                    cmdMakeBooking.ExecuteNonQuery()
                    cmdBus2.ExecuteNonQuery()

                    'Try
                    'cmdMakeBooking.ExecuteNonQuery()
                    'cmdBus2.ExecuteNonQuery()
                    'cmdMakeBooking.Dispose()
                    'cmdBus2.Dispose()
                    'con.Close()
                    'Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'End Try

                End If
            End If
        Next

        conBooking2.Close()
        conBus2.Close()


        Call UpdateBookings1()

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        FormBooking.Show()
        Me.Hide()

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If LblNoOfSeat.Text = CStr(1).ToString Then
            If MaxSelected >= 1 Then
                Timer1.Stop()
                MessageBox.Show("You have selected max seat(s)!", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)

                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = False
                    End If
                Next
            Else
                Timer1.Start()
                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = True
                    End If
                Next

            End If

        ElseIf LblNoOfSeat.Text = CStr(2).ToString Then
            If MaxSelected >= 2 Then
                Timer1.Stop()
                MessageBox.Show("You have selected max seat(s)!", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = False
                    End If
                Next
            Else
                Timer1.Start()
                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = True
                    End If
                Next

            End If

        ElseIf LblNoOfSeat.Text = CStr(3).ToString Then
            If MaxSelected >= 3 Then
                Timer1.Stop()
                MessageBox.Show("You have selected max seat(s)!", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)

                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = False
                    End If
                Next
            Else
                Timer1.Start()
                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = True
                    End If
                Next

            End If

        ElseIf LblNoOfSeat.Text = CStr(4).ToString Then
            If MaxSelected >= 4 Then
                Timer1.Stop()
                MessageBox.Show("You have selected max seat(s)!", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)

                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = False
                    End If
                Next
            Else
                Timer1.Start()
                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = True
                    End If
                Next

            End If

        Else
            If MaxSelected >= CStr(5).ToString Then
                Timer1.Stop()
                MessageBox.Show("You have selected max seat(s)!", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)

                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = False
                    End If
                Next
            Else
                Timer1.Start()
                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        CType(c, PictureBox).Enabled = True
                    End If
                Next

            End If
        End If


    End Sub
End Class
    