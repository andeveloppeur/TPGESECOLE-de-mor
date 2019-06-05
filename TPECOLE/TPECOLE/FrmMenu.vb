Public Class FrmMenu

    Private Sub AjouterUnUtilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnUtilisateurToolStripMenuItem.Click
        FrmUtilisateur.Show()
        Me.Visible = False
    End Sub

    Private Sub AjouterUnEmployerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnEmployerToolStripMenuItem.Click
        FrmEmployé.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHeure.Text = Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second
        LblDate.Text = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblHeure.Text = Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second
        LblDate.Text = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
    End Sub

    Private Sub ChangerLaCouleureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangerLaCouleureToolStripMenuItem.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Me.BackColor = ColorDialog1.Color
            FrmEmployé.BackColor = ColorDialog1.Color
            FrmListeEmpoyes.BackColor = ColorDialog1.Color
            FrmUtilisateur.BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub ParDefautToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParDefautToolStripMenuItem.Click

        Me.BackColor = Color.SaddleBrown
        FrmEmployé.BackColor = Color.SaddleBrown
        FrmListeEmpoyes.BackColor = Color.SaddleBrown
        FrmUtilisateur.BackColor = Color.SaddleBrown

    End Sub

    Private Sub AjouterUnEtudiantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnEtudiantToolStripMenuItem.Click
        FrmAjouterEtudiant.Show()
        Me.Close()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub InscrireUnEtudiantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscrireUnEtudiantToolStripMenuItem.Click
        FrmInscrireEtudiant.Show()
        Me.Visible = False
    End Sub
End Class
