<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInscrireEtudiant
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MatriculeLabel As System.Windows.Forms.Label
        Dim PrénomLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim Date_NaissanceLabel As System.Windows.Forms.Label
        Dim Lieu_NaissanceLabel As System.Windows.Forms.Label
        Dim AdresseLabel As System.Windows.Forms.Label
        Dim TéléphoneLabel As System.Windows.Forms.Label
        Dim GenreLabel As System.Windows.Forms.Label
        Dim FilièreLabel As System.Windows.Forms.Label
        Dim Année_AcadémiqueLabel As System.Windows.Forms.Label
        Dim NiveauLabel As System.Windows.Forms.Label
        Dim InscrireLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EtudiantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M3GAG3SDataSet = New TPECOLE.M3GAG3SDataSet()
        Me.EtudiantsTableAdapter = New TPECOLE.M3GAG3SDataSetTableAdapters.EtudiantsTableAdapter()
        Me.TableAdapterManager = New TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager()
        Me.MatriculeComboBox = New System.Windows.Forms.ComboBox()
        Me.PrénomLabel1 = New System.Windows.Forms.Label()
        Me.NomLabel1 = New System.Windows.Forms.Label()
        Me.Date_NaissanceLabel1 = New System.Windows.Forms.Label()
        Me.Lieu_NaissanceLabel1 = New System.Windows.Forms.Label()
        Me.AdresseLabel1 = New System.Windows.Forms.Label()
        Me.TéléphoneLabel1 = New System.Windows.Forms.Label()
        Me.GenreLabel1 = New System.Windows.Forms.Label()
        Me.FilièreLabel1 = New System.Windows.Forms.Label()
        Me.Année_AcadémiqueComboBox = New System.Windows.Forms.ComboBox()
        Me.NiveauComboBox = New System.Windows.Forms.ComboBox()
        Me.InscrireComboBox = New System.Windows.Forms.ComboBox()
        MatriculeLabel = New System.Windows.Forms.Label()
        PrénomLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        Date_NaissanceLabel = New System.Windows.Forms.Label()
        Lieu_NaissanceLabel = New System.Windows.Forms.Label()
        AdresseLabel = New System.Windows.Forms.Label()
        TéléphoneLabel = New System.Windows.Forms.Label()
        GenreLabel = New System.Windows.Forms.Label()
        FilièreLabel = New System.Windows.Forms.Label()
        Année_AcadémiqueLabel = New System.Windows.Forms.Label()
        NiveauLabel = New System.Windows.Forms.Label()
        InscrireLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EtudiantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M3GAG3SDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(MatriculeLabel)
        Me.GroupBox1.Controls.Add(Me.MatriculeComboBox)
        Me.GroupBox1.Controls.Add(PrénomLabel)
        Me.GroupBox1.Controls.Add(Me.PrénomLabel1)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(Me.NomLabel1)
        Me.GroupBox1.Controls.Add(Date_NaissanceLabel)
        Me.GroupBox1.Controls.Add(Me.Date_NaissanceLabel1)
        Me.GroupBox1.Controls.Add(Lieu_NaissanceLabel)
        Me.GroupBox1.Controls.Add(Me.Lieu_NaissanceLabel1)
        Me.GroupBox1.Controls.Add(AdresseLabel)
        Me.GroupBox1.Controls.Add(Me.AdresseLabel1)
        Me.GroupBox1.Controls.Add(TéléphoneLabel)
        Me.GroupBox1.Controls.Add(Me.TéléphoneLabel1)
        Me.GroupBox1.Controls.Add(GenreLabel)
        Me.GroupBox1.Controls.Add(Me.GenreLabel1)
        Me.GroupBox1.Controls.Add(FilièreLabel)
        Me.GroupBox1.Controls.Add(Me.FilièreLabel1)
        Me.GroupBox1.Controls.Add(Année_AcadémiqueLabel)
        Me.GroupBox1.Controls.Add(Me.Année_AcadémiqueComboBox)
        Me.GroupBox1.Controls.Add(NiveauLabel)
        Me.GroupBox1.Controls.Add(Me.NiveauComboBox)
        Me.GroupBox1.Controls.Add(InscrireLabel)
        Me.GroupBox1.Controls.Add(Me.InscrireComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 393)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = " Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(73, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = " Inscrire un Etudiant"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(649, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 324)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'EtudiantsBindingSource
        '
        Me.EtudiantsBindingSource.DataMember = "Etudiants"
        Me.EtudiantsBindingSource.DataSource = Me.M3GAG3SDataSet
        '
        'M3GAG3SDataSet
        '
        Me.M3GAG3SDataSet.DataSetName = "M3GAG3SDataSet"
        Me.M3GAG3SDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EtudiantsTableAdapter
        '
        Me.EtudiantsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployersTableAdapter = Nothing
        Me.TableAdapterManager.EtudiantsTableAdapter = Me.EtudiantsTableAdapter
        Me.TableAdapterManager.PaiementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilisateursTableAdapter = Nothing
        '
        'MatriculeLabel
        '
        MatriculeLabel.AutoSize = True
        MatriculeLabel.Location = New System.Drawing.Point(29, 26)
        MatriculeLabel.Name = "MatriculeLabel"
        MatriculeLabel.Size = New System.Drawing.Size(53, 13)
        MatriculeLabel.TabIndex = 2
        MatriculeLabel.Text = "Matricule:"
        '
        'MatriculeComboBox
        '
        Me.MatriculeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Matricule", True))
        Me.MatriculeComboBox.FormattingEnabled = True
        Me.MatriculeComboBox.Location = New System.Drawing.Point(138, 23)
        Me.MatriculeComboBox.Name = "MatriculeComboBox"
        Me.MatriculeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MatriculeComboBox.TabIndex = 3
        '
        'PrénomLabel
        '
        PrénomLabel.AutoSize = True
        PrénomLabel.Location = New System.Drawing.Point(29, 47)
        PrénomLabel.Name = "PrénomLabel"
        PrénomLabel.Size = New System.Drawing.Size(46, 13)
        PrénomLabel.TabIndex = 4
        PrénomLabel.Text = "Prénom:"
        '
        'PrénomLabel1
        '
        Me.PrénomLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Prénom", True))
        Me.PrénomLabel1.Location = New System.Drawing.Point(138, 47)
        Me.PrénomLabel1.Name = "PrénomLabel1"
        Me.PrénomLabel1.Size = New System.Drawing.Size(121, 23)
        Me.PrénomLabel1.TabIndex = 5
        Me.PrénomLabel1.Text = "Label2"
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Location = New System.Drawing.Point(29, 70)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(32, 13)
        NomLabel.TabIndex = 6
        NomLabel.Text = "Nom:"
        '
        'NomLabel1
        '
        Me.NomLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Nom", True))
        Me.NomLabel1.Location = New System.Drawing.Point(138, 70)
        Me.NomLabel1.Name = "NomLabel1"
        Me.NomLabel1.Size = New System.Drawing.Size(121, 23)
        Me.NomLabel1.TabIndex = 7
        Me.NomLabel1.Text = "Label2"
        '
        'Date_NaissanceLabel
        '
        Date_NaissanceLabel.AutoSize = True
        Date_NaissanceLabel.Location = New System.Drawing.Point(29, 93)
        Date_NaissanceLabel.Name = "Date_NaissanceLabel"
        Date_NaissanceLabel.Size = New System.Drawing.Size(86, 13)
        Date_NaissanceLabel.TabIndex = 8
        Date_NaissanceLabel.Text = "Date Naissance:"
        '
        'Date_NaissanceLabel1
        '
        Me.Date_NaissanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Date_Naissance", True))
        Me.Date_NaissanceLabel1.Location = New System.Drawing.Point(138, 93)
        Me.Date_NaissanceLabel1.Name = "Date_NaissanceLabel1"
        Me.Date_NaissanceLabel1.Size = New System.Drawing.Size(121, 23)
        Me.Date_NaissanceLabel1.TabIndex = 9
        Me.Date_NaissanceLabel1.Text = "Label2"
        '
        'Lieu_NaissanceLabel
        '
        Lieu_NaissanceLabel.AutoSize = True
        Lieu_NaissanceLabel.Location = New System.Drawing.Point(29, 116)
        Lieu_NaissanceLabel.Name = "Lieu_NaissanceLabel"
        Lieu_NaissanceLabel.Size = New System.Drawing.Size(83, 13)
        Lieu_NaissanceLabel.TabIndex = 10
        Lieu_NaissanceLabel.Text = "Lieu Naissance:"
        '
        'Lieu_NaissanceLabel1
        '
        Me.Lieu_NaissanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Lieu_Naissance", True))
        Me.Lieu_NaissanceLabel1.Location = New System.Drawing.Point(138, 116)
        Me.Lieu_NaissanceLabel1.Name = "Lieu_NaissanceLabel1"
        Me.Lieu_NaissanceLabel1.Size = New System.Drawing.Size(121, 23)
        Me.Lieu_NaissanceLabel1.TabIndex = 11
        Me.Lieu_NaissanceLabel1.Text = "Label2"
        '
        'AdresseLabel
        '
        AdresseLabel.AutoSize = True
        AdresseLabel.Location = New System.Drawing.Point(29, 139)
        AdresseLabel.Name = "AdresseLabel"
        AdresseLabel.Size = New System.Drawing.Size(48, 13)
        AdresseLabel.TabIndex = 12
        AdresseLabel.Text = "Adresse:"
        '
        'AdresseLabel1
        '
        Me.AdresseLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Adresse", True))
        Me.AdresseLabel1.Location = New System.Drawing.Point(138, 139)
        Me.AdresseLabel1.Name = "AdresseLabel1"
        Me.AdresseLabel1.Size = New System.Drawing.Size(121, 23)
        Me.AdresseLabel1.TabIndex = 13
        Me.AdresseLabel1.Text = "Label2"
        '
        'TéléphoneLabel
        '
        TéléphoneLabel.AutoSize = True
        TéléphoneLabel.Location = New System.Drawing.Point(29, 162)
        TéléphoneLabel.Name = "TéléphoneLabel"
        TéléphoneLabel.Size = New System.Drawing.Size(61, 13)
        TéléphoneLabel.TabIndex = 14
        TéléphoneLabel.Text = "Téléphone:"
        '
        'TéléphoneLabel1
        '
        Me.TéléphoneLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Téléphone", True))
        Me.TéléphoneLabel1.Location = New System.Drawing.Point(138, 162)
        Me.TéléphoneLabel1.Name = "TéléphoneLabel1"
        Me.TéléphoneLabel1.Size = New System.Drawing.Size(121, 23)
        Me.TéléphoneLabel1.TabIndex = 15
        Me.TéléphoneLabel1.Text = "Label2"
        '
        'GenreLabel
        '
        GenreLabel.AutoSize = True
        GenreLabel.Location = New System.Drawing.Point(29, 185)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New System.Drawing.Size(39, 13)
        GenreLabel.TabIndex = 16
        GenreLabel.Text = "Genre:"
        '
        'GenreLabel1
        '
        Me.GenreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Genre", True))
        Me.GenreLabel1.Location = New System.Drawing.Point(138, 185)
        Me.GenreLabel1.Name = "GenreLabel1"
        Me.GenreLabel1.Size = New System.Drawing.Size(121, 23)
        Me.GenreLabel1.TabIndex = 17
        Me.GenreLabel1.Text = "Label2"
        '
        'FilièreLabel
        '
        FilièreLabel.AutoSize = True
        FilièreLabel.Location = New System.Drawing.Point(29, 208)
        FilièreLabel.Name = "FilièreLabel"
        FilièreLabel.Size = New System.Drawing.Size(37, 13)
        FilièreLabel.TabIndex = 18
        FilièreLabel.Text = "Filière:"
        '
        'FilièreLabel1
        '
        Me.FilièreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Filière", True))
        Me.FilièreLabel1.Location = New System.Drawing.Point(138, 208)
        Me.FilièreLabel1.Name = "FilièreLabel1"
        Me.FilièreLabel1.Size = New System.Drawing.Size(121, 23)
        Me.FilièreLabel1.TabIndex = 19
        Me.FilièreLabel1.Text = "Label2"
        '
        'Année_AcadémiqueLabel
        '
        Année_AcadémiqueLabel.AutoSize = True
        Année_AcadémiqueLabel.Location = New System.Drawing.Point(29, 237)
        Année_AcadémiqueLabel.Name = "Année_AcadémiqueLabel"
        Année_AcadémiqueLabel.Size = New System.Drawing.Size(103, 13)
        Année_AcadémiqueLabel.TabIndex = 20
        Année_AcadémiqueLabel.Text = "Année Académique:"
        '
        'Année_AcadémiqueComboBox
        '
        Me.Année_AcadémiqueComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Année_Académique", True))
        Me.Année_AcadémiqueComboBox.FormattingEnabled = True
        Me.Année_AcadémiqueComboBox.Location = New System.Drawing.Point(138, 234)
        Me.Année_AcadémiqueComboBox.Name = "Année_AcadémiqueComboBox"
        Me.Année_AcadémiqueComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Année_AcadémiqueComboBox.TabIndex = 21
        '
        'NiveauLabel
        '
        NiveauLabel.AutoSize = True
        NiveauLabel.Location = New System.Drawing.Point(29, 264)
        NiveauLabel.Name = "NiveauLabel"
        NiveauLabel.Size = New System.Drawing.Size(44, 13)
        NiveauLabel.TabIndex = 22
        NiveauLabel.Text = "Niveau:"
        '
        'NiveauComboBox
        '
        Me.NiveauComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Niveau", True))
        Me.NiveauComboBox.FormattingEnabled = True
        Me.NiveauComboBox.Location = New System.Drawing.Point(138, 261)
        Me.NiveauComboBox.Name = "NiveauComboBox"
        Me.NiveauComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NiveauComboBox.TabIndex = 23
        '
        'InscrireLabel
        '
        InscrireLabel.AutoSize = True
        InscrireLabel.Location = New System.Drawing.Point(29, 291)
        InscrireLabel.Name = "InscrireLabel"
        InscrireLabel.Size = New System.Drawing.Size(44, 13)
        InscrireLabel.TabIndex = 24
        InscrireLabel.Text = "Inscrire:"
        '
        'InscrireComboBox
        '
        Me.InscrireComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Inscrire", True))
        Me.InscrireComboBox.FormattingEnabled = True
        Me.InscrireComboBox.Location = New System.Drawing.Point(138, 288)
        Me.InscrireComboBox.Name = "InscrireComboBox"
        Me.InscrireComboBox.Size = New System.Drawing.Size(121, 21)
        Me.InscrireComboBox.TabIndex = 25
        '
        'FrmInscrireEtudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(862, 476)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmInscrireEtudiant"
        Me.Text = "FrmInscrireEtudiant"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.EtudiantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M3GAG3SDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents M3GAG3SDataSet As TPECOLE.M3GAG3SDataSet
    Friend WithEvents EtudiantsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EtudiantsTableAdapter As TPECOLE.M3GAG3SDataSetTableAdapters.EtudiantsTableAdapter
    Friend WithEvents TableAdapterManager As TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PrénomLabel1 As System.Windows.Forms.Label
    Friend WithEvents NomLabel1 As System.Windows.Forms.Label
    Friend WithEvents Date_NaissanceLabel1 As System.Windows.Forms.Label
    Friend WithEvents Lieu_NaissanceLabel1 As System.Windows.Forms.Label
    Friend WithEvents AdresseLabel1 As System.Windows.Forms.Label
    Friend WithEvents TéléphoneLabel1 As System.Windows.Forms.Label
    Friend WithEvents GenreLabel1 As System.Windows.Forms.Label
    Friend WithEvents FilièreLabel1 As System.Windows.Forms.Label
    Friend WithEvents Année_AcadémiqueComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NiveauComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InscrireComboBox As System.Windows.Forms.ComboBox
End Class
