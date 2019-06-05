Public Class FrmAuthentification

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rep = MsgBox("Voulez-vous Fermer cette Fenettre ?", vbYesNo, "Repondez à la question ?")
        If rep = vbYes Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtLog.Text = "admin" And TxtPass.Text = "admin" Then
            Chargement.Show()
            Me.Visible = False
        End If
    End Sub
End Class