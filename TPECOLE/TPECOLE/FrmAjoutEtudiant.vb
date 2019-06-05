Public Class FrmAjoutEtudiant

    Private Sub EtudiantsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EtudiantsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EtudiantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)

    End Sub

    Private Sub FrmAjoutEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'M3GAG3SDataSet.Etudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EtudiantsTableAdapter.Fill(Me.M3GAG3SDataSet.Etudiants)

    End Sub
End Class