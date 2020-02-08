Public Class Form2

    Private Sub EarnButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarnButton4.Click
        My.Settings.MSelect = "E3C1"
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub EarnButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarnButton5.Click
        My.Settings.MSelect = "E3C2"
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub EarnButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarnButton6.Click
        My.Settings.MSelect = "E3C3"
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub EarnButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarnButton1.Click
        My.Settings.MSelect = "NP"
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub EarnButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarnButton2.Click
        My.Settings.MSelect = "NT"
        Form4.Show()
        Me.Close()
    End Sub
End Class