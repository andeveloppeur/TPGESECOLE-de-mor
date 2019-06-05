<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnUtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AjouterUnEmployerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EspaceEtudiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnEtudiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InscrireUnEtudiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PaiementEtudiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutiltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonnaliserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangerLaCouleureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParDefautToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AidesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblHeure = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblDate = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrateurToolStripMenuItem, Me.EspaceEtudiantToolStripMenuItem, Me.OutiltToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrateurToolStripMenuItem
        '
        Me.AdministrateurToolStripMenuItem.Checked = True
        Me.AdministrateurToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AdministrateurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnUtilisateurToolStripMenuItem, Me.ToolStripSeparator3, Me.AjouterUnEmployerToolStripMenuItem, Me.ToolStripSeparator4})
        Me.AdministrateurToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrateurToolStripMenuItem.Image = CType(resources.GetObject("AdministrateurToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdministrateurToolStripMenuItem.Name = "AdministrateurToolStripMenuItem"
        Me.AdministrateurToolStripMenuItem.Size = New System.Drawing.Size(165, 29)
        Me.AdministrateurToolStripMenuItem.Text = "Administrateur"
        '
        'AjouterUnUtilisateurToolStripMenuItem
        '
        Me.AjouterUnUtilisateurToolStripMenuItem.Image = CType(resources.GetObject("AjouterUnUtilisateurToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjouterUnUtilisateurToolStripMenuItem.Name = "AjouterUnUtilisateurToolStripMenuItem"
        Me.AjouterUnUtilisateurToolStripMenuItem.Size = New System.Drawing.Size(264, 30)
        Me.AjouterUnUtilisateurToolStripMenuItem.Text = "Ajouter un Utilisateur"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(261, 6)
        '
        'AjouterUnEmployerToolStripMenuItem
        '
        Me.AjouterUnEmployerToolStripMenuItem.Image = CType(resources.GetObject("AjouterUnEmployerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjouterUnEmployerToolStripMenuItem.Name = "AjouterUnEmployerToolStripMenuItem"
        Me.AjouterUnEmployerToolStripMenuItem.Size = New System.Drawing.Size(264, 30)
        Me.AjouterUnEmployerToolStripMenuItem.Text = "Ajouter un Employer"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(261, 6)
        '
        'EspaceEtudiantToolStripMenuItem
        '
        Me.EspaceEtudiantToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnEtudiantToolStripMenuItem, Me.ToolStripSeparator2, Me.InscrireUnEtudiantToolStripMenuItem, Me.ToolStripSeparator1, Me.PaiementEtudiantToolStripMenuItem})
        Me.EspaceEtudiantToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EspaceEtudiantToolStripMenuItem.Image = CType(resources.GetObject("EspaceEtudiantToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EspaceEtudiantToolStripMenuItem.Name = "EspaceEtudiantToolStripMenuItem"
        Me.EspaceEtudiantToolStripMenuItem.Size = New System.Drawing.Size(173, 29)
        Me.EspaceEtudiantToolStripMenuItem.Text = "Espace Etudiant"
        '
        'AjouterUnEtudiantToolStripMenuItem
        '
        Me.AjouterUnEtudiantToolStripMenuItem.Image = CType(resources.GetObject("AjouterUnEtudiantToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjouterUnEtudiantToolStripMenuItem.Name = "AjouterUnEtudiantToolStripMenuItem"
        Me.AjouterUnEtudiantToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.AjouterUnEtudiantToolStripMenuItem.Text = "Ajouter un Etudiant"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(247, 6)
        '
        'InscrireUnEtudiantToolStripMenuItem
        '
        Me.InscrireUnEtudiantToolStripMenuItem.Image = CType(resources.GetObject("InscrireUnEtudiantToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InscrireUnEtudiantToolStripMenuItem.Name = "InscrireUnEtudiantToolStripMenuItem"
        Me.InscrireUnEtudiantToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.InscrireUnEtudiantToolStripMenuItem.Text = "Inscrire Un Etudiant"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(247, 6)
        '
        'PaiementEtudiantToolStripMenuItem
        '
        Me.PaiementEtudiantToolStripMenuItem.Image = CType(resources.GetObject("PaiementEtudiantToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PaiementEtudiantToolStripMenuItem.Name = "PaiementEtudiantToolStripMenuItem"
        Me.PaiementEtudiantToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.PaiementEtudiantToolStripMenuItem.Text = "Paiement   Etudiant"
        '
        'OutiltToolStripMenuItem
        '
        Me.OutiltToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonnaliserToolStripMenuItem, Me.ToolStripSeparator5, Me.AidesToolStripMenuItem})
        Me.OutiltToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutiltToolStripMenuItem.Image = CType(resources.GetObject("OutiltToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OutiltToolStripMenuItem.Name = "OutiltToolStripMenuItem"
        Me.OutiltToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.OutiltToolStripMenuItem.Text = "Outils"
        '
        'PersonnaliserToolStripMenuItem
        '
        Me.PersonnaliserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangerLaCouleureToolStripMenuItem, Me.ParDefautToolStripMenuItem})
        Me.PersonnaliserToolStripMenuItem.Name = "PersonnaliserToolStripMenuItem"
        Me.PersonnaliserToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.PersonnaliserToolStripMenuItem.Text = "Personnaliser"
        '
        'ChangerLaCouleureToolStripMenuItem
        '
        Me.ChangerLaCouleureToolStripMenuItem.Name = "ChangerLaCouleureToolStripMenuItem"
        Me.ChangerLaCouleureToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.ChangerLaCouleureToolStripMenuItem.Text = "Changer La Couleure"
        '
        'ParDefautToolStripMenuItem
        '
        Me.ParDefautToolStripMenuItem.Name = "ParDefautToolStripMenuItem"
        Me.ParDefautToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.ParDefautToolStripMenuItem.Text = "Par Defaut"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(194, 6)
        '
        'AidesToolStripMenuItem
        '
        Me.AidesToolStripMenuItem.Name = "AidesToolStripMenuItem"
        Me.AidesToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.AidesToolStripMenuItem.Text = "Aides"
        '
        'LblHeure
        '
        Me.LblHeure.AutoSize = True
        Me.LblHeure.BackColor = System.Drawing.Color.Transparent
        Me.LblHeure.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeure.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblHeure.Location = New System.Drawing.Point(32, 389)
        Me.LblHeure.Name = "LblHeure"
        Me.LblHeure.Size = New System.Drawing.Size(83, 25)
        Me.LblHeure.TabIndex = 2
        Me.LblHeure.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(34, 311)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(39, 13)
        Me.LblDate.TabIndex = 3
        Me.LblDate.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(859, 470)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 470)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.LblHeure)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministrateurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnUtilisateurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnEmployerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EspaceEtudiantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnEtudiantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InscrireUnEtudiantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PaiementEtudiantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutiltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonnaliserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AidesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblHeure As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents ChangerLaCouleureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ParDefautToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
