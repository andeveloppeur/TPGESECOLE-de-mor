Public Class FrmAjouterEtudiant

    Private Sub EtudiantsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EtudiantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)

    End Sub

    Private Sub FrmAjouterEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'M3GAG3SDataSet.Etudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EtudiantsTableAdapter.Fill(Me.M3GAG3SDataSet.Etudiants)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Code pour avoir acces pour ajouter
        Me.EtudiantsBindingSource.AddNew()
    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Me.Validate()
        Me.EtudiantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
        MsgBox("Nouvel Etudiant ajouté avcec succes !!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Code pourmodifier un étudiant 
        Me.Validate()
        Me.EtudiantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
        MsgBox("L'Etudiant a étéModifié avcec succes !!!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Code pour supprimer un étudiant 
        Dim rep = MsgBox("Voulez-vous Supprimer Cet étudiant(e) ?", vbYesNo, "Attention vous allez supprimé  une étudiant ")
        If rep = vbYes Then
            Me.Validate()
            Me.EtudiantsBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.M3GAG3SDataSet)
            MsgBox("L'Etudiant a été supprimé avcec succes !!!")
        Else

        End If
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Code pour fermerla fenettre Ajouté éTUDIANT 
        Dim rep = MsgBox("Voulez-Vous Fermer cette Fenetre ?", vbYesNo, "Confirmation de Fermeture")
        If rep = vbYes Then
            FrmMenu.Show()
            Me.Visible = False
        End If
    End Sub
End Class