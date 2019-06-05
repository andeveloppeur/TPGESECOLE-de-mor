<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployé
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
        Dim AdresseLabel As System.Windows.Forms.Label
        Dim NumTéléphoneLabel As System.Windows.Forms.Label
        Dim DateNaissanceLabel As System.Windows.Forms.Label
        Dim LieudeNaissanceLabel As System.Windows.Forms.Label
        Dim FonctionLabel As System.Windows.Forms.Label
        Dim TypeDeContratLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployé))
        Me.M3GAG3SDataSet = New TPECOLE.M3GAG3SDataSet()
        Me.EmployersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployersTableAdapter = New TPECOLE.M3GAG3SDataSetTableAdapters.EmployersTableAdapter()
        Me.TableAdapterManager = New TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager()
        Me.MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.PrénomTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.AdresseTextBox = New System.Windows.Forms.TextBox()
        Me.NumTéléphoneTextBox = New System.Windows.Forms.TextBox()
        Me.DateNaissanceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LieudeNaissanceTextBox = New System.Windows.Forms.TextBox()
        Me.FonctionComboBox = New System.Windows.Forms.ComboBox()
        Me.TypeDeContratComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Label1 = New System.Windows.Forms.Label()
        MatriculeLabel = New System.Windows.Forms.Label()
        PrénomLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        AdresseLabel = New System.Windows.Forms.Label()
        NumTéléphoneLabel = New System.Windows.Forms.Label()
        DateNaissanceLabel = New System.Windows.Forms.Label()
        LieudeNaissanceLabel = New System.Windows.Forms.Label()
        FonctionLabel = New System.Windows.Forms.Label()
        TypeDeContratLabel = New System.Windows.Forms.Label()
        CType(Me.M3GAG3SDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculeLabel
        '
        MatriculeLabel.AutoSize = True
        MatriculeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculeLabel.ForeColor = System.Drawing.Color.White
        MatriculeLabel.Location = New System.Drawing.Point(23, 24)
        MatriculeLabel.Name = "MatriculeLabel"
        MatriculeLabel.Size = New System.Drawing.Size(82, 18)
        MatriculeLabel.TabIndex = 3
        MatriculeLabel.Text = "Matricule:"
        '
        'PrénomLabel
        '
        PrénomLabel.AutoSize = True
        PrénomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrénomLabel.ForeColor = System.Drawing.Color.White
        PrénomLabel.Location = New System.Drawing.Point(23, 54)
        PrénomLabel.Name = "PrénomLabel"
        PrénomLabel.Size = New System.Drawing.Size(72, 18)
        PrénomLabel.TabIndex = 5
        PrénomLabel.Text = "Prénom:"
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomLabel.ForeColor = System.Drawing.Color.White
        NomLabel.Location = New System.Drawing.Point(23, 84)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(49, 18)
        NomLabel.TabIndex = 7
        NomLabel.Text = "Nom:"
        '
        'AdresseLabel
        '
        AdresseLabel.AutoSize = True
        AdresseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdresseLabel.ForeColor = System.Drawing.Color.White
        AdresseLabel.Location = New System.Drawing.Point(23, 174)
        AdresseLabel.Name = "AdresseLabel"
        AdresseLabel.Size = New System.Drawing.Size(74, 18)
        AdresseLabel.TabIndex = 9
        AdresseLabel.Text = "Adresse:"
        '
        'NumTéléphoneLabel
        '
        NumTéléphoneLabel.AutoSize = True
        NumTéléphoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumTéléphoneLabel.ForeColor = System.Drawing.Color.White
        NumTéléphoneLabel.Location = New System.Drawing.Point(23, 204)
        NumTéléphoneLabel.Name = "NumTéléphoneLabel"
        NumTéléphoneLabel.Size = New System.Drawing.Size(91, 18)
        NumTéléphoneLabel.TabIndex = 11
        NumTéléphoneLabel.Text = "Téléphone:"
        '
        'DateNaissanceLabel
        '
        DateNaissanceLabel.AutoSize = True
        DateNaissanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateNaissanceLabel.ForeColor = System.Drawing.Color.White
        DateNaissanceLabel.Location = New System.Drawing.Point(23, 114)
        DateNaissanceLabel.Name = "DateNaissanceLabel"
        DateNaissanceLabel.Size = New System.Drawing.Size(160, 18)
        DateNaissanceLabel.TabIndex = 13
        DateNaissanceLabel.Text = "Date de  Naissance:"
        '
        'LieudeNaissanceLabel
        '
        LieudeNaissanceLabel.AutoSize = True
        LieudeNaissanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LieudeNaissanceLabel.ForeColor = System.Drawing.Color.White
        LieudeNaissanceLabel.Location = New System.Drawing.Point(23, 144)
        LieudeNaissanceLabel.Name = "LieudeNaissanceLabel"
        LieudeNaissanceLabel.Size = New System.Drawing.Size(151, 18)
        LieudeNaissanceLabel.TabIndex = 15
        LieudeNaissanceLabel.Text = "Lieu de Naissance:"
        '
        'FonctionLabel
        '
        FonctionLabel.AutoSize = True
        FonctionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FonctionLabel.ForeColor = System.Drawing.Color.White
        FonctionLabel.Location = New System.Drawing.Point(23, 235)
        FonctionLabel.Name = "FonctionLabel"
        FonctionLabel.Size = New System.Drawing.Size(79, 18)
        FonctionLabel.TabIndex = 17
        FonctionLabel.Text = "Fonction:"
        '
        'TypeDeContratLabel
        '
        TypeDeContratLabel.AutoSize = True
        TypeDeContratLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeDeContratLabel.ForeColor = System.Drawing.Color.White
        TypeDeContratLabel.Location = New System.Drawing.Point(23, 266)
        TypeDeContratLabel.Name = "TypeDeContratLabel"
        TypeDeContratLabel.Size = New System.Drawing.Size(136, 18)
        TypeDeContratLabel.TabIndex = 19
        TypeDeContratLabel.Text = "Type De Contrat:"
        '
        'M3GAG3SDataSet
        '
        Me.M3GAG3SDataSet.DataSetName = "M3GAG3SDataSet"
        Me.M3GAG3SDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployersBindingSource
        '
        Me.EmployersBindingSource.DataMember = "Employers"
        Me.EmployersBindingSource.DataSource = Me.M3GAG3SDataSet
        '
        'EmployersTableAdapter
        '
        Me.EmployersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployersTableAdapter = Me.EmployersTableAdapter
        Me.TableAdapterManager.EtudiantsTableAdapter = Nothing
        Me.TableAdapterManager.PaiementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilisateursTableAdapter = Nothing
        '
        'MatriculeTextBox
        '
        Me.MatriculeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployersBindingSource, "Matricule", True))
        Me.MatriculeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculeTextBox.Location = New System.Drawing.Point(198, 19)
        Me.MatriculeTextBox.Name = "MatriculeTextBox"
        Me.MatriculeTextBox.Size = New System.Drawing.Size(260, 22)
        Me.MatriculeTextBox.TabIndex = 4
        '
        'PrénomTextBox
        '
        Me.PrénomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployersBindingSource, "Prénom", True))
        Me.PrénomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrénomTextBox.Location = New System.Drawing.Point(198, 49)
        Me.PrénomTextBox.Name = "PrénomTextBox"
        Me.PrénomTextBox.Size = New System.Drawing.Size(260, 22)
        Me.PrénomTextBox.TabIndex = 6
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployersBindingSource, "Nom", True))
        Me.NomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomTextBox.Location = New System.Drawing.Point(198, 79)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(260, 22)
        Me.NomTextBox.TabIndex = 8
        '
        'AdresseTextBox
        '
        Me.AdresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployersBindingSource, "Adresse", True))
        Me.AdresseTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdresseTextBox.Location = New System.Drawing.Point(198, 169)
        Me.AdresseTextBox.Name = "AdresseTextBox"
        Me.AdresseTextBox.Size = New System.Drawing.Size(260, 22)
        Me.AdresseTextBox.TabIndex = 10
        '
        'NumTéléphoneTextBox
        '
        Me.NumTéléphoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployersBindingSource, "NumTéléphone", True))
        Me.NumTéléphoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumTéléphoneTextBox.Location = New System.Drawing.Point(198, 199)
        Me.NumTéléphoneTextBox.Name = "NumTéléphoneTextBox"
        Me.NumTéléphoneTextBox.Size = New System.Drawing.Size(260, 22)
        Me.NumTéléphoneTextBox.TabIndex = 12
        '
        'DateNaissanceDateTimePicker
        '
        Me.DateNaissanceDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployersBindingSource, "DateNaissance", True))
        Me.DateNaissanceDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateNaissanceDateTimePicker.Location = New System.Drawing.Point(198, 109)
        Me.DateNaissanceDateTimePicker.Name = "DateNaissanceDateTimePicker"
        Me.DateNaissanceDateTimePicker.Size = New System.Drawing.Size(260, 22)
        Me.DateNaissanceDateTimePicker.TabIndex = 14
        '
        'LieudeNaissanceTextBox
        '
        Me.LieudeNaissanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployersBindingSource, "LieudeNaissance", True))
        Me.LieudeNaissanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LieudeNaissanceTextBox.Location = New System.Drawing.Point(198, 139)
        Me.LieudeNaissanceTextBox.Name = "LieudeNaissanceTextBox"
        Me.LieudeNaissanceTextBox.Size = New System.Drawing.Size(260, 22)
        Me.LieudeNaissanceTextBox.TabIndex = 16
        '
        'FonctionComboBox
        '
        Me.FonctionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployersBindingSource, "Fonction", True))
        Me.FonctionComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FonctionComboBox.FormattingEnabled = True
        Me.FonctionComboBox.Items.AddRange(New Object() {"Secrétaire", "Bibiliothéquaire", "Femme Nétoyeuse", "Technicien", "Gardien", "Informaticien", "Rousource Humaine", "Comptable", "Charger de Communication", ""})
        Me.FonctionComboBox.Location = New System.Drawing.Point(198, 229)
        Me.FonctionComboBox.Name = "FonctionComboBox"
        Me.FonctionComboBox.Size = New System.Drawing.Size(260, 24)
        Me.FonctionComboBox.TabIndex = 18
        '
        'TypeDeContratComboBox
        '
        Me.TypeDeContratComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployersBindingSource, "TypeDeContrat", True))
        Me.TypeDeContratComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeDeContratComboBox.FormattingEnabled = True
        Me.TypeDeContratComboBox.Items.AddRange(New Object() {"CDD", "CDI", "Non Contractuel"})
        Me.TypeDeContratComboBox.Location = New System.Drawing.Point(198, 260)
        Me.TypeDeContratComboBox.Name = "TypeDeContratComboBox"
        Me.TypeDeContratComboBox.Size = New System.Drawing.Size(260, 24)
        Me.TypeDeContratComboBox.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(MatriculeLabel)
        Me.GroupBox1.Controls.Add(Me.TypeDeContratComboBox)
        Me.GroupBox1.Controls.Add(Me.AdresseTextBox)
        Me.GroupBox1.Controls.Add(AdresseLabel)
        Me.GroupBox1.Controls.Add(TypeDeContratLabel)
        Me.GroupBox1.Controls.Add(Me.MatriculeTextBox)
        Me.GroupBox1.Controls.Add(Me.FonctionComboBox)
        Me.GroupBox1.Controls.Add(PrénomLabel)
        Me.GroupBox1.Controls.Add(FonctionLabel)
        Me.GroupBox1.Controls.Add(Me.PrénomTextBox)
        Me.GroupBox1.Controls.Add(Me.LieudeNaissanceTextBox)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(LieudeNaissanceLabel)
        Me.GroupBox1.Controls.Add(Me.NomTextBox)
        Me.GroupBox1.Controls.Add(Me.DateNaissanceDateTimePicker)
        Me.GroupBox1.Controls.Add(DateNaissanceLabel)
        Me.GroupBox1.Controls.Add(Me.NumTéléphoneTextBox)
        Me.GroupBox1.Controls.Add(NumTéléphoneLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 291)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(494, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(149, 291)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(6, 197)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(137, 37)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "Liste Employés"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(6, 242)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 37)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Fermer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 37)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nouveau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(654, 456)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BorderColor = System.Drawing.Color.White
        Me.OvalShape1.BorderWidth = 3
        Me.OvalShape1.FillColor = System.Drawing.Color.White
        Me.OvalShape1.Location = New System.Drawing.Point(6, 6)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(134, 132)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(163, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 79)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "EMPLOYERS"
        '
        'FrmEmployé
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(654, 456)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmployé"
        Me.Text = "Employer"
        CType(Me.M3GAG3SDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents M3GAG3SDataSet As TPECOLE.M3GAG3SDataSet
    Friend WithEvents EmployersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployersTableAdapter As TPECOLE.M3GAG3SDataSetTableAdapters.EmployersTableAdapter
    Friend WithEvents TableAdapterManager As TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrénomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdresseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumTéléphoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateNaissanceDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LieudeNaissanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FonctionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TypeDeContratComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
