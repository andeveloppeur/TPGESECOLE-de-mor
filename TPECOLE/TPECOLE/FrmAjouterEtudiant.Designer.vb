<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjouterEtudiant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAjouterEtudiant))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EtudiantsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtudiantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M3GAG3SDataSet = New TPECOLE.M3GAG3SDataSet()
        Me.MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.PrénomTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.Date_NaissanceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Lieu_NaissanceTextBox = New System.Windows.Forms.TextBox()
        Me.AdresseTextBox = New System.Windows.Forms.TextBox()
        Me.TéléphoneTextBox = New System.Windows.Forms.TextBox()
        Me.GenreComboBox = New System.Windows.Forms.ComboBox()
        Me.FilièreComboBox = New System.Windows.Forms.ComboBox()
        Me.Année_AcadémiqueComboBox = New System.Windows.Forms.ComboBox()
        Me.NiveauComboBox = New System.Windows.Forms.ComboBox()
        Me.EtudiantsTableAdapter = New TPECOLE.M3GAG3SDataSetTableAdapters.EtudiantsTableAdapter()
        Me.TableAdapterManager = New TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.EtudiantsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtudiantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M3GAG3SDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculeLabel
        '
        MatriculeLabel.AutoSize = True
        MatriculeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculeLabel.ForeColor = System.Drawing.Color.White
        MatriculeLabel.Location = New System.Drawing.Point(11, 19)
        MatriculeLabel.Name = "MatriculeLabel"
        MatriculeLabel.Size = New System.Drawing.Size(87, 20)
        MatriculeLabel.TabIndex = 2
        MatriculeLabel.Text = "Matricule:"
        '
        'PrénomLabel
        '
        PrénomLabel.AutoSize = True
        PrénomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrénomLabel.ForeColor = System.Drawing.Color.White
        PrénomLabel.Location = New System.Drawing.Point(11, 51)
        PrénomLabel.Name = "PrénomLabel"
        PrénomLabel.Size = New System.Drawing.Size(75, 20)
        PrénomLabel.TabIndex = 4
        PrénomLabel.Text = "Prénom:"
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomLabel.ForeColor = System.Drawing.Color.White
        NomLabel.Location = New System.Drawing.Point(11, 81)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(50, 20)
        NomLabel.TabIndex = 6
        NomLabel.Text = "Nom:"
        '
        'Date_NaissanceLabel
        '
        Date_NaissanceLabel.AutoSize = True
        Date_NaissanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_NaissanceLabel.ForeColor = System.Drawing.Color.White
        Date_NaissanceLabel.Location = New System.Drawing.Point(11, 111)
        Date_NaissanceLabel.Name = "Date_NaissanceLabel"
        Date_NaissanceLabel.Size = New System.Drawing.Size(141, 20)
        Date_NaissanceLabel.TabIndex = 8
        Date_NaissanceLabel.Text = "Date Naissance:"
        '
        'Lieu_NaissanceLabel
        '
        Lieu_NaissanceLabel.AutoSize = True
        Lieu_NaissanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lieu_NaissanceLabel.ForeColor = System.Drawing.Color.White
        Lieu_NaissanceLabel.Location = New System.Drawing.Point(11, 141)
        Lieu_NaissanceLabel.Name = "Lieu_NaissanceLabel"
        Lieu_NaissanceLabel.Size = New System.Drawing.Size(136, 20)
        Lieu_NaissanceLabel.TabIndex = 10
        Lieu_NaissanceLabel.Text = "Lieu Naissance:"
        '
        'AdresseLabel
        '
        AdresseLabel.AutoSize = True
        AdresseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdresseLabel.ForeColor = System.Drawing.Color.White
        AdresseLabel.Location = New System.Drawing.Point(11, 171)
        AdresseLabel.Name = "AdresseLabel"
        AdresseLabel.Size = New System.Drawing.Size(80, 20)
        AdresseLabel.TabIndex = 12
        AdresseLabel.Text = "Adresse:"
        '
        'TéléphoneLabel
        '
        TéléphoneLabel.AutoSize = True
        TéléphoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TéléphoneLabel.ForeColor = System.Drawing.Color.White
        TéléphoneLabel.Location = New System.Drawing.Point(11, 201)
        TéléphoneLabel.Name = "TéléphoneLabel"
        TéléphoneLabel.Size = New System.Drawing.Size(98, 20)
        TéléphoneLabel.TabIndex = 14
        TéléphoneLabel.Text = "Téléphone:"
        '
        'GenreLabel
        '
        GenreLabel.AutoSize = True
        GenreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenreLabel.ForeColor = System.Drawing.Color.White
        GenreLabel.Location = New System.Drawing.Point(11, 231)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New System.Drawing.Size(64, 20)
        GenreLabel.TabIndex = 16
        GenreLabel.Text = "Genre:"
        '
        'FilièreLabel
        '
        FilièreLabel.AutoSize = True
        FilièreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FilièreLabel.ForeColor = System.Drawing.Color.White
        FilièreLabel.Location = New System.Drawing.Point(11, 263)
        FilièreLabel.Name = "FilièreLabel"
        FilièreLabel.Size = New System.Drawing.Size(63, 20)
        FilièreLabel.TabIndex = 18
        FilièreLabel.Text = "Filière:"
        '
        'Année_AcadémiqueLabel
        '
        Année_AcadémiqueLabel.AutoSize = True
        Année_AcadémiqueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Année_AcadémiqueLabel.ForeColor = System.Drawing.Color.White
        Année_AcadémiqueLabel.Location = New System.Drawing.Point(11, 294)
        Année_AcadémiqueLabel.Name = "Année_AcadémiqueLabel"
        Année_AcadémiqueLabel.Size = New System.Drawing.Size(170, 20)
        Année_AcadémiqueLabel.TabIndex = 20
        Année_AcadémiqueLabel.Text = "Année Académique:"
        '
        'NiveauLabel
        '
        NiveauLabel.AutoSize = True
        NiveauLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NiveauLabel.ForeColor = System.Drawing.Color.White
        NiveauLabel.Location = New System.Drawing.Point(11, 324)
        NiveauLabel.Name = "NiveauLabel"
        NiveauLabel.Size = New System.Drawing.Size(68, 20)
        NiveauLabel.TabIndex = 22
        NiveauLabel.Text = "Niveau:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EtudiantsDataGridView)
        Me.GroupBox1.Controls.Add(MatriculeLabel)
        Me.GroupBox1.Controls.Add(Me.MatriculeTextBox)
        Me.GroupBox1.Controls.Add(PrénomLabel)
        Me.GroupBox1.Controls.Add(Me.PrénomTextBox)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(Me.NomTextBox)
        Me.GroupBox1.Controls.Add(Date_NaissanceLabel)
        Me.GroupBox1.Controls.Add(Me.Date_NaissanceDateTimePicker)
        Me.GroupBox1.Controls.Add(Lieu_NaissanceLabel)
        Me.GroupBox1.Controls.Add(Me.Lieu_NaissanceTextBox)
        Me.GroupBox1.Controls.Add(AdresseLabel)
        Me.GroupBox1.Controls.Add(Me.AdresseTextBox)
        Me.GroupBox1.Controls.Add(TéléphoneLabel)
        Me.GroupBox1.Controls.Add(Me.TéléphoneTextBox)
        Me.GroupBox1.Controls.Add(GenreLabel)
        Me.GroupBox1.Controls.Add(Me.GenreComboBox)
        Me.GroupBox1.Controls.Add(FilièreLabel)
        Me.GroupBox1.Controls.Add(Me.FilièreComboBox)
        Me.GroupBox1.Controls.Add(Année_AcadémiqueLabel)
        Me.GroupBox1.Controls.Add(Me.Année_AcadémiqueComboBox)
        Me.GroupBox1.Controls.Add(NiveauLabel)
        Me.GroupBox1.Controls.Add(Me.NiveauComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 364)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'EtudiantsDataGridView
        '
        Me.EtudiantsDataGridView.AutoGenerateColumns = False
        Me.EtudiantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EtudiantsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.EtudiantsDataGridView.DataSource = Me.EtudiantsBindingSource
        Me.EtudiantsDataGridView.GridColor = System.Drawing.Color.White
        Me.EtudiantsDataGridView.Location = New System.Drawing.Point(403, 21)
        Me.EtudiantsDataGridView.Name = "EtudiantsDataGridView"
        Me.EtudiantsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EtudiantsDataGridView.Size = New System.Drawing.Size(527, 323)
        Me.EtudiantsDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEtudiant"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Etudiant"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Matricule"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Matricule"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Prénom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Prénom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nom"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date_Naissance"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date Naissance"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Lieu_Naissance"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lieu Naissance"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Adresse"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Adresse"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Téléphone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Téléphone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Genre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Genre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Filière"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Filière"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Année_Académique"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Année Académique"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Niveau"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Niveau"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
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
        'MatriculeTextBox
        '
        Me.MatriculeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Matricule", True))
        Me.MatriculeTextBox.Location = New System.Drawing.Point(187, 21)
        Me.MatriculeTextBox.Name = "MatriculeTextBox"
        Me.MatriculeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MatriculeTextBox.TabIndex = 3
        '
        'PrénomTextBox
        '
        Me.PrénomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Prénom", True))
        Me.PrénomTextBox.Location = New System.Drawing.Point(187, 51)
        Me.PrénomTextBox.Name = "PrénomTextBox"
        Me.PrénomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrénomTextBox.TabIndex = 5
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Nom", True))
        Me.NomTextBox.Location = New System.Drawing.Point(187, 81)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomTextBox.TabIndex = 7
        '
        'Date_NaissanceDateTimePicker
        '
        Me.Date_NaissanceDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EtudiantsBindingSource, "Date_Naissance", True))
        Me.Date_NaissanceDateTimePicker.Location = New System.Drawing.Point(187, 111)
        Me.Date_NaissanceDateTimePicker.Name = "Date_NaissanceDateTimePicker"
        Me.Date_NaissanceDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_NaissanceDateTimePicker.TabIndex = 9
        '
        'Lieu_NaissanceTextBox
        '
        Me.Lieu_NaissanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Lieu_Naissance", True))
        Me.Lieu_NaissanceTextBox.Location = New System.Drawing.Point(187, 141)
        Me.Lieu_NaissanceTextBox.Name = "Lieu_NaissanceTextBox"
        Me.Lieu_NaissanceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Lieu_NaissanceTextBox.TabIndex = 11
        '
        'AdresseTextBox
        '
        Me.AdresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Adresse", True))
        Me.AdresseTextBox.Location = New System.Drawing.Point(187, 171)
        Me.AdresseTextBox.Name = "AdresseTextBox"
        Me.AdresseTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AdresseTextBox.TabIndex = 13
        '
        'TéléphoneTextBox
        '
        Me.TéléphoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Téléphone", True))
        Me.TéléphoneTextBox.Location = New System.Drawing.Point(187, 201)
        Me.TéléphoneTextBox.Name = "TéléphoneTextBox"
        Me.TéléphoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TéléphoneTextBox.TabIndex = 15
        '
        'GenreComboBox
        '
        Me.GenreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Genre", True))
        Me.GenreComboBox.FormattingEnabled = True
        Me.GenreComboBox.Items.AddRange(New Object() {"Masculin", "Féminin"})
        Me.GenreComboBox.Location = New System.Drawing.Point(187, 231)
        Me.GenreComboBox.Name = "GenreComboBox"
        Me.GenreComboBox.Size = New System.Drawing.Size(200, 21)
        Me.GenreComboBox.TabIndex = 17
        '
        'FilièreComboBox
        '
        Me.FilièreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Filière", True))
        Me.FilièreComboBox.FormattingEnabled = True
        Me.FilièreComboBox.Items.AddRange(New Object() {"Banque Finance Assurance", "Comptabilité", "Génie Informatique", "Maintenance", "Réseaux Télécom"})
        Me.FilièreComboBox.Location = New System.Drawing.Point(187, 262)
        Me.FilièreComboBox.Name = "FilièreComboBox"
        Me.FilièreComboBox.Size = New System.Drawing.Size(200, 21)
        Me.FilièreComboBox.TabIndex = 19
        '
        'Année_AcadémiqueComboBox
        '
        Me.Année_AcadémiqueComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Année_Académique", True))
        Me.Année_AcadémiqueComboBox.FormattingEnabled = True
        Me.Année_AcadémiqueComboBox.Items.AddRange(New Object() {"2014 / 2015", "2015 / 2016", "2016 / 2017", "2017 / 2018"})
        Me.Année_AcadémiqueComboBox.Location = New System.Drawing.Point(187, 293)
        Me.Année_AcadémiqueComboBox.Name = "Année_AcadémiqueComboBox"
        Me.Année_AcadémiqueComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Année_AcadémiqueComboBox.TabIndex = 21
        '
        'NiveauComboBox
        '
        Me.NiveauComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "Niveau", True))
        Me.NiveauComboBox.FormattingEnabled = True
        Me.NiveauComboBox.Items.AddRange(New Object() {"Brevet 1er année", "Brevet 2em année", "Licence 1", "Licence 2", "Licence 3", "Master 1", "Master 2"})
        Me.NiveauComboBox.Location = New System.Drawing.Point(187, 323)
        Me.NiveauComboBox.Name = "NiveauComboBox"
        Me.NiveauComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NiveauComboBox.TabIndex = 23
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Ajouter)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 50)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Nouveau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ajouter
        '
        Me.Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ajouter.Location = New System.Drawing.Point(130, 11)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(104, 35)
        Me.Ajouter.TabIndex = 4
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(257, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 35)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(376, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 35)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(828, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 73)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Quitter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Location = New System.Drawing.Point(498, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 50)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(290, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 11)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(318, 33)
        Me.TextBox1.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(330, 10)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 35)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Rechercher"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "AJOUTER UN(E) NOUVEl(LE) ETUDIANT(E)"
        '
        'FrmAjouterEtudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(939, 555)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAjouterEtudiant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AJOUTER ETUDIANT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EtudiantsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtudiantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M3GAG3SDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents M3GAG3SDataSet As TPECOLE.M3GAG3SDataSet
    Friend WithEvents EtudiantsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EtudiantsTableAdapter As TPECOLE.M3GAG3SDataSetTableAdapters.EtudiantsTableAdapter
    Friend WithEvents TableAdapterManager As TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrénomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_NaissanceDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lieu_NaissanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdresseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TéléphoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FilièreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Année_AcadémiqueComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NiveauComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EtudiantsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
