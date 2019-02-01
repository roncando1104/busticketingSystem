Public Class FormMenu

    Private Sub LinkMngdUser_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkMngdUser.LinkClicked
        FormAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub LinkMBookings_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkMBookings.LinkClicked
        FormBooking.Show()
        Me.Hide()

    End Sub

    Private Sub LinkPayment_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkPayment.LinkClicked
        FormTeller.Show()
        Me.Hide()

    End Sub

    Private Sub LinkOverDue_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkOverDue.LinkClicked
        FormFilterOverDueReservation.Show()
        Me.Hide()

    End Sub

    Private Sub LblLogout_Click(sender As System.Object, e As System.EventArgs) Handles LblLogout.Click
        End
    End Sub
End Class