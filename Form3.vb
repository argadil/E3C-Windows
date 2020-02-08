Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.MSelect = "E3C1" Then
            Label1.Text = "Saisie en cours : E3C Session 1"
            NumericUpDown4.Enabled = False
            NumericUpDown5.Enabled = False
            NumericUpDown6.Enabled = False
            EarnCheckBox1.Enabled = False
            NumericUpDown1.Value = My.Settings.LVA1
            NumericUpDown2.Value = My.Settings.LVB1
            NumericUpDown3.Value = My.Settings.HG1
        ElseIf My.Settings.MSelect = "E3C2" Then
            Label1.Text = "Saisie en cours : E3C Session 2"
            NumericUpDown6.Enabled = False
            EarnCheckBox1.Enabled = False
            NumericUpDown1.Value = My.Settings.LVA2
            NumericUpDown2.Value = My.Settings.LVB2
            NumericUpDown3.Value = My.Settings.HG2
            NumericUpDown4.Value = My.Settings.ES1
            NumericUpDown5.Value = My.Settings.SPE1
        ElseIf My.Settings.MSelect = "E3C3" Then
            Label1.Text = "Saisie en cours : E3C Session 3"
            NumericUpDown5.Enabled = False
            NumericUpDown1.Value = My.Settings.LVA3
            NumericUpDown2.Value = My.Settings.LVB3
            NumericUpDown3.Value = My.Settings.HG3
            NumericUpDown4.Value = My.Settings.ES2
        End If
    End Sub

    Private Sub EarnButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarnButton2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub EarnButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarnButton1.Click
        If My.Settings.MSelect = "E3C1" Then
            If MsgBox("Souhaitez vous valider la saisie suivante :" & vbNewLine & "LV1 : " & NumericUpDown1.Value & "/20" &
       vbNewLine & "LV2 : " & NumericUpDown2.Value & "/20" & vbNewLine & "Histoire-Géo : " & NumericUpDown3.Value &
       "/20", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                My.Settings.LVA1 = NumericUpDown1.Value
                My.Settings.LVB1 = NumericUpDown2.Value
                My.Settings.HG1 = NumericUpDown3.Value
                My.Settings.E3C1 = "Ok"
                Form2.Show()
                Me.Close()
            End If
        ElseIf My.Settings.MSelect = "E3C2" Then
            If MsgBox("Souhaitez vous valider la saisie suivante :" & vbNewLine & "LV1 : " & NumericUpDown1.Value & "/20" &
       vbNewLine & "LV2 : " & NumericUpDown2.Value & "/20" & vbNewLine & "Histoire-Géo : " & NumericUpDown3.Value &
       "/20" & vbNewLine & "Enseignement Scientifique : " & NumericUpDown4.Value & "/20" &
       vbNewLine & "Spécialité : " & NumericUpDown5.Value & "/20", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                My.Settings.LVA2 = NumericUpDown1.Value
                My.Settings.LVB2 = NumericUpDown2.Value
                My.Settings.HG2 = NumericUpDown3.Value
                My.Settings.ES1 = NumericUpDown4.Value
                My.Settings.SPE1 = NumericUpDown5.Value
                My.Settings.E3C2 = "Ok"
                Form2.Show()
                Me.Close()
            End If
        ElseIf My.Settings.MSelect = "E3C3" And EarnCheckBox1.Checked = False Then
            If MsgBox("Souhaitez vous valider la saisie suivante :" & vbNewLine & "LV1 : " & NumericUpDown1.Value & "/20" &
       vbNewLine & "LV2 : " & NumericUpDown2.Value & "/20" & vbNewLine & "Histoire-Géo : " & NumericUpDown3.Value &
       "/20" & vbNewLine & "Enseignement Scientifique : " & NumericUpDown4.Value & "/20" & vbNewLine &
       "EPS : " & "Dispensé.e", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                My.Settings.LVA3 = NumericUpDown1.Value
                My.Settings.LVB3 = NumericUpDown2.Value
                My.Settings.HG3 = NumericUpDown3.Value
                My.Settings.ES2 = NumericUpDown4.Value
                My.Settings.EPS = NumericUpDown6.Value
                My.Settings.E3C3 = "Ok"
                Form2.Show()
                Me.Close()
            End If
        ElseIf My.Settings.MSelect = "E3C3" And EarnCheckBox1.Checked = True Then
            If MsgBox("Souhaitez vous valider la saisie suivante :" & vbNewLine & "LV1 : " & NumericUpDown1.Value & "/20" &
       vbNewLine & "LV2 : " & NumericUpDown2.Value & "/20" & vbNewLine & "Histoire-Géo : " & NumericUpDown3.Value &
       "/20" & vbNewLine & "Enseignement Scientifique : " & NumericUpDown4.Value & "/20" & vbNewLine &
       "EPS : Dispensé.e", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                My.Settings.LVA3 = NumericUpDown1.Value
                My.Settings.LVB3 = NumericUpDown2.Value
                My.Settings.HG3 = NumericUpDown3.Value
                My.Settings.ES2 = NumericUpDown4.Value
                My.Settings.EPS = "Dispense"
                My.Settings.E3C3 = "Ok"
                Form2.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub EarnCheckBox1_CheckedChanged(ByVal sender As System.Object) Handles EarnCheckBox1.CheckedChanged
        If EarnCheckBox1.Checked = True Then
            NumericUpDown6.Enabled = False
        Else
            NumericUpDown6.Enabled = True
        End If
    End Sub
End Class