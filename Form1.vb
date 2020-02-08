Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.E3CTotal & "/20"
        EarnProgressBar1.Value = My.Settings.E3CTotal * 5
    End Sub

    Private Sub EarnButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarnButton1.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class
