<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Memory
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
        Me.lblJoueur = New System.Windows.Forms.Label()
        Me.lblTemps = New System.Windows.Forms.Label()
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.lblNomJoueur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblJoueur
        '
        Me.lblJoueur.AutoSize = True
        Me.lblJoueur.Location = New System.Drawing.Point(13, 13)
        Me.lblJoueur.Name = "lblJoueur"
        Me.lblJoueur.Size = New System.Drawing.Size(45, 13)
        Me.lblJoueur.TabIndex = 0
        Me.lblJoueur.Text = "Joueur :"
        '
        'lblTemps
        '
        Me.lblTemps.AutoSize = True
        Me.lblTemps.Location = New System.Drawing.Point(314, 13)
        Me.lblTemps.Name = "lblTemps"
        Me.lblTemps.Size = New System.Drawing.Size(86, 13)
        Me.lblTemps.TabIndex = 1
        Me.lblTemps.Text = "- Temps restant :"
        '
        'btnAbandon
        '
        Me.btnAbandon.Location = New System.Drawing.Point(713, 8)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(75, 23)
        Me.btnAbandon.TabIndex = 2
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = True
        '
        'lblNomJoueur
        '
        Me.lblNomJoueur.AutoSize = True
        Me.lblNomJoueur.Location = New System.Drawing.Point(64, 13)
        Me.lblNomJoueur.Name = "lblNomJoueur"
        Me.lblNomJoueur.Size = New System.Drawing.Size(10, 13)
        Me.lblNomJoueur.TabIndex = 3
        Me.lblNomJoueur.Text = " "
        '
        'Memory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNomJoueur)
        Me.Controls.Add(Me.btnAbandon)
        Me.Controls.Add(Me.lblTemps)
        Me.Controls.Add(Me.lblJoueur)
        Me.Name = "Memory"
        Me.Text = "Memory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJoueur As Label
    Friend WithEvents lblTemps As Label
    Friend WithEvents btnAbandon As Button
    Friend WithEvents lblNomJoueur As Label
End Class
