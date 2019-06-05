Public Class FrmListeEmpoyes

    Private Sub EmployersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)

    End Sub

    Private Sub FrmListeEmpoyes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'M3GAG3SDataSet.Employers'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EmployersTableAdapter.Fill(Me.M3GAG3SDataSet.Employers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmEmployé.Show()
        Me.Visible = False
    End Sub
End Class