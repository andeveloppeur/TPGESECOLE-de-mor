Public Class FrmEmployé

    Private Sub EmployersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)

    End Sub

    Private Sub FrmEmployé_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'M3GAG3SDataSet.Employers'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EmployersTableAdapter.Fill(Me.M3GAG3SDataSet.Employers)
        DateNaissanceDateTimePicker.Value = Date.Now.Date.Date

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployersBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.EmployersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
        MsgBox("Employé Ajouté avec Succès", vbInformation, "Information !!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.EmployersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
        MsgBox("Employé Modifié avec Succès", vbInformation, "Information !!!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.EmployersBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
        MsgBox("Employé Supprimé avec Succès", vbInformation, "Information !!!")
    End Sub

    Private Sub DateNaissanceDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateNaissanceDateTimePicker.ValueChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim rep = MsgBox("Voulez-Vous Fermer cette Fenetre ?", vbYesNo, "Confirmation de Fermeture")
        If rep = vbYes Then
            FrmMenu.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmListeEmpoyes.show()
        Me.Visible = False
    End Sub
End Class