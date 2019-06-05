Public Class FrmUtilisateur

    Private Sub UtilisateursBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UtilisateursBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)

    End Sub

    Private Sub FrmUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'M3GAG3SDataSet.Utilisateurs'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.UtilisateursTableAdapter.Fill(Me.M3GAG3SDataSet.Utilisateurs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim rep = MsgBox("Voulez-Vous Fermer cette Fenetre ?", vbYesNo, "Confirmation de Fermeture")
        If rep = vbYes Then
            FrmMenu.Show()
            Me.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UtilisateursBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.UtilisateursBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
        MsgBox("Employé Ajouté avec Succès", vbInformation, "Information !!!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.UtilisateursBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
        MsgBox("Employé Modifié avec Succès", vbInformation, "Information !!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.UtilisateursBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
        MsgBox("Employé Supprimer avec Succès", vbInformation, "Information !!!")
    End Sub
End Class