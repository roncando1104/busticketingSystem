Imports System.Data.OleDb

Public Class FormBus1
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.unbooked)
    Dim provisionalIcon As New System.Drawing.Bitmap(My.Resources.reserved)
    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.booked)
    Dim MaxSelected As Integer

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

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        TextBox2.Visible = False

        Dim c As Control
        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableIcon

                AddHandler c.Click, AddressOf pb1_Click
            End If
        Next
        Call UpdateBookings()


    End Sub


    Sub UpdateBookings()

        Dim stSQL, stSQL1 As String
        stSQL = "SELECT ORDER_NO, USER_ID, SEAT_NO FROM BOOKING"
        stSQL1 = "SELECT TRAVEL_ID, SEAT_NO, TICKET_NO, DESTINATION FROM BUS1"

        Dim stConString As String

        stConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"
        Dim conBooking As OleDbConnection
        Dim conBus1 As OleDbConnection

        conBooking = New OleDbConnection
        conBus1 = New OleDbConnection
        conBooking.ConnectionString = stConString
        conBus1.ConnectionString = stConString
        conBooking.Open()
        conBus1.Open()

        Dim cmdSelectBookings As OleDbCommand
        Dim cmdSelectBus1 As OleDbCommand
        cmdSelectBookings = New OleDbCommand
        cmdSelectBus1 = New OleDbCommand
        cmdSelectBookings.CommandText = stSQL
        cmdSelectBus1.CommandText = stSQL1
        cmdSelectBookings.Connection = conBooking
        cmdSelectBus1.Connection = conBus1

        Dim dsBooking As New DataSet
        Dim daBooking As New OleDbDataAdapter(cmdSelectBookings)
        Dim dsBus1 As New DataSet
        Dim daBus1 As New OleDbDataAdapter(cmdSelectBus1)
        daBooking.Fill(dsBooking, "BOOKING")
        conBooking.Close()
        daBus1.Fill(dsBus1, "BUS1")
        conBus1.Close()

        'MsgBox(dsBooking.Tables("BOOKING").Rows.Count)
        'MsgBox(dsBooking.Tables("BOOKING").Rows(0)(1))
        'Dim stOut As String = Nothing
        'Dim t1 As DataTable
        'Dim row As DataRow

        'this is the viewer of seats
        't1 = dsBooking.Tables("BOOKING")
        'For Each row In t1.Rows
        'stOut = stOut & row(0) & " " & row(1) & " " & row(2) & vbNewLine
        'CType(Controls(row("SEAT_NO")), PictureBox).Image = bookedIcon

        'Next
        'MsgBox(stOut)

        Dim t2 As DataTable
        Dim row2 As DataRow


        t2 = dsBus1.Tables("BUS1")
        For Each row2 In t2.Rows
            'stOut = stOut & row(0) & " " & row(1) & " " & row(2) & vbNewLine
            CType(Controls(row2("SEAT_NO")), PictureBox).Image = bookedIcon

        Next
        'MsgBox(stOut)

        If dsBus1.Tables("BUS1").Rows.Count = 38 Then
            MessageBox.Show("This Bus is already sold out!", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End


        End If

    End Sub
    'Dim doclick As Boolean = True
    'Dim errorline As String
    Private Sub pb1_Click(sender As System.Object, e As System.EventArgs)

        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = provisionalIcon
            MaxSelected = MaxSelected + 1

            'If doclick = LblNoOfSeat.Text Then
            'If Mid(CType(sender, PictureBox).Name, 1) = LblNoOfSeat.Text Then
            'doclick = True
            'MessageBox.Show("You are only allowed to choose" + " " + LblNoOfSeat.Text + " " + "Seat(s)", _
            ' "Seat Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'End If
        ElseIf CType(sender, PictureBox).Image Is provisionalIcon Then
            CType(sender, PictureBox).Image = availableIcon
            MaxSelected = MaxSelected - 1
        End If
       

    End Sub

    Private Sub BtnDone_Click(sender As System.Object, e As System.EventArgs) Handles BtnDone.Click

        Dim c As Control
        Dim s1 As Boolean


        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                If CType(c, PictureBox).Image Is provisionalIcon Then

                    s1 = True
                    'MsgBox("You have already reserved your seat... Thank you")
                    'Form4.LblSeat1.Text = Mid(CType(c, PictureBox).Name, 1)
                    FormBooking.Show()

                    Me.Hide()
                    Exit For

                End If
                'AddHandler c.Click, AddressOf pb1_Click
            End If

        Next
        If s1 = False Then
            MsgBox("Please select a seat")
            Exit Sub
        End If
        If vld(TxtUID) = False Then
            Exit Sub
        End If
        Dim stSQLInsert As String
        Dim stSQLInsert1 As String
        stSQLInsert = "INSERT INTO BOOKING ([USER_ID], [SEAT_NO]) VALUES (3, pb8)"
        stSQLInsert1 = "INSERT INTO BUS1 ([USER_ID]) VALUES (3, E1)"

        Dim stConString As String

        stConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ronal\Desktop\itc22 project\Ticketing System.accdb"

        'Seats.ConnectionString = mySeats   
        Dim conBooking As OleDbConnection
        Dim conBus1 As OleDbConnection
        Dim mySeat As OleDbConnection
        conBooking = New OleDbConnection
        conBooking.ConnectionString = stConString
        conBus1 = New OleDbConnection
        conBus1.ConnectionString = stConString
        mySeat = New OleDbConnection
        mySeat.ConnectionString = stConString

        conBooking.Open()
        conBus1.Open()

        Dim cmdMakeBookings As OleDbCommand
        Dim cmdBus1 As OleDbCommand

        cmdMakeBookings = New OleDbCommand
        cmdBus1 = New OleDbCommand
        'cmdMakeBookings.CommandText = stSQLInsert
        cmdMakeBookings.Connection = conBooking
        cmdBus1.Connection = conBus1

        'cmdMakeBookings.ExecuteNonQuery()

        'Try

        'cmdMakeBookings.Dispose()
        'conBooking.Close()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

        Dim iseatNum As String

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                If CType(c, PictureBox).Image Is provisionalIcon Then
                    iseatNum = Mid(CType(c, PictureBox).Name, 1)
                    MessageBox.Show("Please note your seat assignments for your reference" + _
                                    vbNewLine + iseatNum, _
                                   "Booking Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    'AddHandler c.Click, AddressOf pb1_Click
                    stSQLInsert = "INSERT INTO BOOKING ([USER_ID], [SEAT_NO], [BUS_NO], [DATE_BOOKED], [STATUS]) VALUES ('" & Me.TxtUID.Text & "', '" & iseatNum.ToString & "', 'Bus 1', '" & TextBox3.Text & "', 'unpaid' )"
                    stSQLInsert1 = "INSERT INTO BUS1 ([SEAT_NO], [TICKET_NO], [DESTINATION], [DATE_BOOKED], [STATUS]) VALUES ('" & iseatNum.ToString & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', 'unpaid' )"
                    cmdMakeBookings.CommandText = stSQLInsert
                    cmdBus1.CommandText = stSQLInsert1
                    cmdMakeBookings.ExecuteNonQuery()
                    cmdBus1.ExecuteNonQuery()

                    'Dim cmdSeat As OleDbCommand = New OleDbCommand("SELECT [SEAT_NO] FROM [BOOKING] WHERE [USER_ID] = '" & TxtUID.Text & "'", mySeat)
                    'mySeat.Open()
                    'Dim dr As OleDbDataReader = cmdSeat.ExecuteReader
                    'Dim seatFound As Boolean = False

                    'Dim SNum As String = ""

                    'While dr.Read
                    'seatFound = True
                    'SNum = dr("SEAT_NO").ToString

                    'End While

                    'If seatFound = True Then
                    'FormBooking.Show()
                    'FormBooking.TxtSeats.Text = SNum

                    'End If
                    'mySeat.Close()

                    'Try
                    'cmdMakeBookings.ExecuteNonQuery()
                    'cmdBus1.ExecuteNonQuery()
                    'cmdMakeBookings.Dispose()
                    'cmdBus1.Dispose()
                    'con.Close()
                    'Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'End Try

                End If
            End If
        Next

        conBooking.Close()
        conBus1.Close()


        Call UpdateBookings()

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        FormBooking.Show()
        Me.Hide()

    End Sub


    'Private Sub TxtUID_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtUID.TextChanged
    '   If TxtUID.Text = FormatNumber(FormBooking.TxtUID.Text, 2) Then
    '      MessageBox.Show("User ID confirmed", "User ID Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    ' Else
    '    MessageBox.Show("Invalid User ID..." + vbNewLine + "Please use your own User ID", "Mismatch User ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '   If DialogResult.OK Then
    '      TxtUID.Clear()
    ' Else
    '    Exit Sub

    '        End If
    '   End If
    'End Sub



End Class