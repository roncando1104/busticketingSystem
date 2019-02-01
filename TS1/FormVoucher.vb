Public Class FormVoucher
    Public Property StringPass1 As String
    Public Property StringPass2 As String
    Public Property StringPass3 As String
    Public Property StringPass4 As String
    Public Property StringPass5 As String
    Public Property StringPass6 As String
    Public Property StringPass7 As String
    Public Property StringPass8 As String
    Public Property StringPass9 As String
    Public Property StringPass10 As String
    Public Property StringPass12 As String
    Public Property StringPass13 As String
    Public Property StringPass14 As String
    Public Property StringPass15 As String




    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = StringPass1
        Label3.Text = StringPass2
        Label5.Text = StringPass3
        Label7.Text = StringPass4
        Label9.Text = StringPass5
        Label11.Text = StringPass6
        Label13.Text = StringPass7
        Label15.Text = StringPass8
        Label17.Text = StringPass9
        Label19.Text = StringPass10
        Label24.Text = StringPass12
        Label21.Text = StringPass15
        Label27.Text = StringPass13
        Label29.Text = "(" + StringPass14 + ")"
    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click


        PrintForm6.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm6.Print()


    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        MessageBox.Show("File has been saved", "LAR Bus Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        End
    End Sub

  
End Class