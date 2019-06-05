<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtilisateur
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
        Dim PrénomLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim FonctionLabel As System.Windows.Forms.Label
        Dim LoginLabel As System.Windows.Forms.Label
        Dim Mot_de_PasseLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtilisateur))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PrénomTextBox = New System.Windows.Forms.TextBox()
        Me.UtilisateursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M3GAG3SDataSet = New TPECOLE.M3GAG3SDataSet()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.FonctionComboBox = New System.Windows.Forms.ComboBox()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.Mot_de_PasseTextBox = New System.Windows.Forms.TextBox()
        Me.UtilisateursTableAdapter = New TPECOLE.M3GAG3SDataSetTableAdapters.UtilisateursTableAdapter()
        Me.TableAdapterManager = New TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UtilisateursDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Label1 = New System.Windows.Forms.Label()
        PrénomLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        FonctionLabel = New System.Windows.Forms.Label()
        LoginLabel = New System.Windows.Forms.Label()
        Mot_de_PasseLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UtilisateursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M3GAG3SDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UtilisateursDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrénomLabel
        '
        PrénomLabel.AutoSize = True
        PrénomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrénomLabel.ForeColor = System.Drawing.Color.White
        PrénomLabel.Location = New System.Drawing.Point(56, 18)
        PrénomLabel.Name = "PrénomLabel"
        PrénomLabel.Size = New System.Drawing.Size(68, 20)
        PrénomLabel.TabIndex = 2
        PrénomLabel.Text = "Prénom:"
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomLabel.ForeColor = System.Drawing.Color.White
        NomLabel.Location = New System.Drawing.Point(56, 50)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(46, 20)
        NomLabel.TabIndex = 4
        NomLabel.Text = "Nom:"
        '
        'FonctionLabel
        '
        FonctionLabel.AutoSize = True
        FonctionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FonctionLabel.ForeColor = System.Drawing.Color.White
        FonctionLabel.Location = New System.Drawing.Point(56, 83)
        FonctionLabel.Name = "FonctionLabel"
        FonctionLabel.Size = New System.Drawing.Size(75, 20)
        FonctionLabel.TabIndex = 6
        FonctionLabel.Text = "Fonction:"
        '
        'LoginLabel
        '
        LoginLabel.AutoSize = True
        LoginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoginLabel.ForeColor = System.Drawing.Color.White
        LoginLabel.Location = New System.Drawing.Point(56, 115)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(52, 20)
        LoginLabel.TabIndex = 8
        LoginLabel.Text = "Login:"
        '
        'Mot_de_PasseLabel
        '
        Mot_de_PasseLabel.AutoSize = True
        Mot_de_PasseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mot_de_PasseLabel.ForeColor = System.Drawing.Color.White
        Mot_de_PasseLabel.Location = New System.Drawing.Point(56, 148)
        Mot_de_PasseLabel.Name = "Mot_de_PasseLabel"
        Mot_de_PasseLabel.Size = New System.Drawing.Size(110, 20)
        Mot_de_PasseLabel.TabIndex = 10
        Mot_de_PasseLabel.Text = "Mot de Passe:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(PrénomLabel)
        Me.GroupBox1.Controls.Add(Me.PrénomTextBox)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(Me.NomTextBox)
        Me.GroupBox1.Controls.Add(FonctionLabel)
        Me.GroupBox1.Controls.Add(Me.FonctionComboBox)
        Me.GroupBox1.Controls.Add(LoginLabel)
        Me.GroupBox1.Controls.Add(Me.LoginTextBox)
        Me.GroupBox1.Controls.Add(Mot_de_PasseLabel)
        Me.GroupBox1.Controls.Add(Me.Mot_de_PasseTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PrénomTextBox
        '
        Me.PrénomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Prénom", True))
        Me.PrénomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrénomTextBox.Location = New System.Drawing.Point(185, 16)
        Me.PrénomTextBox.Name = "PrénomTextBox"
        Me.PrénomTextBox.Size = New System.Drawing.Size(218, 22)
        Me.PrénomTextBox.TabIndex = 3
        '
        'UtilisateursBindingSource
        '
        Me.UtilisateursBindingSource.DataMember = "Utilisateurs"
        Me.UtilisateursBindingSource.DataSource = Me.M3GAG3SDataSet
        '
        'M3GAG3SDataSet
        '
        Me.M3GAG3SDataSet.DataSetName = "M3GAG3SDataSet"
        Me.M3GAG3SDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Nom", True))
        Me.NomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomTextBox.Location = New System.Drawing.Point(185, 48)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(218, 22)
        Me.NomTextBox.TabIndex = 5
        '
        'FonctionComboBox
        '
        Me.FonctionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Fonction", True))
        Me.FonctionComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FonctionComboBox.FormattingEnabled = True
        Me.FonctionComboBox.Items.AddRange(New Object() {"Administrateur", "Secrétaire", "Comptable", "Directeur Général", "Directeur des Etudes", "Technicien"})
        Me.FonctionComboBox.Location = New System.Drawing.Point(185, 79)
        Me.FonctionComboBox.Name = "FonctionComboBox"
        Me.FonctionComboBox.Size = New System.Drawing.Size(218, 24)
        Me.FonctionComboBox.TabIndex = 7
        '
        'LoginTextBox
        '
        Me.LoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Login", True))
        Me.LoginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginTextBox.Location = New System.Drawing.Point(185, 113)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(218, 22)
        Me.LoginTextBox.TabIndex = 9
        '
        'Mot_de_PasseTextBox
        '
        Me.Mot_de_PasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateursBindingSource, "Mot de Passe", True))
        Me.Mot_de_PasseTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mot_de_PasseTextBox.Location = New System.Drawing.Point(185, 145)
        Me.Mot_de_PasseTextBox.Name = "Mot_de_PasseTextBox"
        Me.Mot_de_PasseTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Mot_de_PasseTextBox.Size = New System.Drawing.Size(218, 22)
        Me.Mot_de_PasseTextBox.TabIndex = 11
        '
        'UtilisateursTableAdapter
        '
        Me.UtilisateursTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployersTableAdapter = Nothing
        Me.TableAdapterManager.EtudiantsTableAdapter = Nothing
        Me.TableAdapterManager.PaiementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilisateursTableAdapter = Me.UtilisateursTableAdapter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(453, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(193, 177)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(6, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(181, 35)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Fermer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(102, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 35)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(6, 71)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 35)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button2.Location = New System.Drawing.Point(102, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(6, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Nouveau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UtilisateursDataGridView
        '
        Me.UtilisateursDataGridView.AutoGenerateColumns = False
        Me.UtilisateursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UtilisateursDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UtilisateursDataGridView.DataSource = Me.UtilisateursBindingSource
        Me.UtilisateursDataGridView.Location = New System.Drawing.Point(3, 312)
        Me.UtilisateursDataGridView.Name = "UtilisateursDataGridView"
        Me.UtilisateursDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UtilisateursDataGridView.Size = New System.Drawing.Size(643, 148)
        Me.UtilisateursDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdUtilisateur"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdUtilisateur"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Prénom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Prénom"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fonction"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fonction"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Login"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Login"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Mot de Passe"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mot de Passe"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(650, 463)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BorderColor = System.Drawing.Color.White
        Me.OvalShape1.BorderWidth = 3
        Me.OvalShape1.Location = New System.Drawing.Point(7, 6)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(128, 122)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(161, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 79)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "UTILISATEUR"
        '
        'FrmUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(650, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UtilisateursDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUtilisateur"
        Me.Text = "UTILISATEUR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UtilisateursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M3GAG3SDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UtilisateursDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents M3GAG3SDataSet As TPECOLE.M3GAG3SDataSet
    Friend WithEvents UtilisateursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtilisateursTableAdapter As TPECOLE.M3GAG3SDataSetTableAdapters.UtilisateursTableAdapter
    Friend WithEvents TableAdapterManager As TPECOLE.M3GAG3SDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrénomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FonctionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LoginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mot_de_PasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UtilisateursDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
