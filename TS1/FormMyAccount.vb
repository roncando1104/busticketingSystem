Public Class formMyAccount
    Private Sub LinkMain_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkMain.LinkClicked
        FormMenu.Show()
        Me.Hide()

    End Sub
    Private Sub LinkBook_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkBook.LinkClicked
        FormBooking.Show()
        FormBooking.TxtUID.Text = TextBox1.Text
        FormBooking.TxtName.Text = Label1.Text
        Me.Hide()
    End Sub

    Private Sub LinkPayment_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkPayment.LinkClicked
        FormTeller.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormCancellation.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        End
    End Sub

    Private Sub cboChangePW_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cboChangePW.CheckedChanged
        FormChangePW.Show()
        FormChangePW.TxtUID.Text = TextBox1.Text
        FormChangePW.TextBox1.Text = TextBox2.Text
        Me.Hide()
    End Sub
End Class

