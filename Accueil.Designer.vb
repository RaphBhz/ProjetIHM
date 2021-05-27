<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxNom = New System.Windows.Forms.ComboBox()
        Me.lblDemandeNom = New System.Windows.Forms.Label()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblSousTitre = New System.Windows.Forms.Label()
        Me.btn_options = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxNom
        '
        Me.cbxNom.FormattingEnabled = True
        Me.cbxNom.Location = New System.Drawing.Point(108, 81)
        Me.cbxNom.Name = "cbxNom"
        Me.cbxNom.Size = New System.Drawing.Size(121, 21)
        Me.cbxNom.TabIndex = 0
        '
        'lblDemandeNom
        '
        Me.lblDemandeNom.AutoSize = True
        Me.lblDemandeNom.Location = New System.Drawing.Point(9, 84)
        Me.lblDemandeNom.Name = "lblDemandeNom"
        Me.lblDemandeNom.Size = New System.Drawing.Size(93, 13)
        Me.lblDemandeNom.TabIndex = 1
        Me.lblDemandeNom.Text = "Entrez votre nom :"
        '
        'btnJouer
        '
        Me.btnJouer.Location = New System.Drawing.Point(82, 122)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(75, 23)
        Me.btnJouer.TabIndex = 2
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Location = New System.Drawing.Point(82, 152)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(75, 23)
        Me.btnScores.TabIndex = 3
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(82, 210)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Pristina", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(38, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(176, 52)
        Me.lblTitre.TabIndex = 5
        Me.lblTitre.Text = "4 Memory"
        '
        'lblSousTitre
        '
        Me.lblSousTitre.AutoSize = True
        Me.lblSousTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSousTitre.Location = New System.Drawing.Point(62, 48)
        Me.lblSousTitre.Name = "lblSousTitre"
        Me.lblSousTitre.Size = New System.Drawing.Size(110, 13)
        Me.lblSousTitre.TabIndex = 6
        Me.lblSousTitre.Text = "a concentration game"
        '
        'btn_options
        '
        Me.btn_options.Location = New System.Drawing.Point(82, 181)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Size = New System.Drawing.Size(75, 23)
        Me.btn_options.TabIndex = 7
        Me.btn_options.Text = "Options"
        Me.btn_options.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_options)
        Me.Controls.Add(Me.lblSousTitre)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.lblDemandeNom)
        Me.Controls.Add(Me.cbxNom)
        Me.Name = "Accueil"
        Me.Text = "Memory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxNom As ComboBox
    Friend WithEvents lblDemandeNom As Label
    Friend WithEvents btnJouer As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblSousTitre As Label
    Friend WithEvents btn_options As Button
End Class
