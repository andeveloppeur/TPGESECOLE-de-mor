Public Class FrmInscrireEtudiant

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '================>Code pour le bouton Quitter======================> 
        FrmMenu.Show()
        Me.Visible = False
    End Sub

    Private Sub EtudiantsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EtudiantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)

    End Sub

    Private Sub FrmInscrireEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'M3GAG3SDataSet.Etudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EtudiantsTableAdapter.Fill(Me.M3GAG3SDataSet.Etudiants)
        Me.EtudiantsBindingSource.MoveLast()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class