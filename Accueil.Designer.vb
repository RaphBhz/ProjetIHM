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
        Me.SuspendLayout()
        '
        'cbxNom
        '
        Me.cbxNom.FormattingEnabled = True
        Me.cbxNom.Location = New System.Drawing.Point(111, 6)
        Me.cbxNom.Name = "cbxNom"
        Me.cbxNom.Size = New System.Drawing.Size(121, 21)
        Me.cbxNom.TabIndex = 0
        '
        'lblDemandeNom
        '
        Me.lblDemandeNom.AutoSize = True
        Me.lblDemandeNom.Location = New System.Drawing.Point(12, 9)
        Me.lblDemandeNom.Name = "lblDemandeNom"
        Me.lblDemandeNom.Size = New System.Drawing.Size(93, 13)
        Me.lblDemandeNom.TabIndex = 1
        Me.lblDemandeNom.Text = "Entrez votre nom :"
        '
        'btnJouer
        '
        Me.btnJouer.Location = New System.Drawing.Point(85, 47)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(75, 23)
        Me.btnJouer.TabIndex = 2
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Location = New System.Drawing.Point(85, 77)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(75, 23)
        Me.btnScores.TabIndex = 3
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(85, 107)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 157)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.lblDemandeNom)
        Me.Controls.Add(Me.cbxNom)
        Me.Name = "Accueil"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxNom As ComboBox
    Friend WithEvents lblDemandeNom As Label
    Friend WithEvents btnJouer As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents btnQuitter As Button
End Class
