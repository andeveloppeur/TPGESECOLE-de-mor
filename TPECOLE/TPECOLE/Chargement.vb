Public Class Chargement
    Dim iprogress As Integer
    Private Sub Chargement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = iprogress & "%"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        ProgressBar1.Value = iprogress
        iprogress += 10
        ProgressBar1.ForeColor = Color.Blue
        Label1.Text = iprogress & "%"
        If iprogress = 100 Then
            FrmMenu.Show()
            Me.Visible = False
            Timer1.Stop()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class