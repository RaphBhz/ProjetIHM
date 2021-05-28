<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Me.lbxScores = New System.Windows.Forms.ListBox()
        Me.btnOrdre = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.cbxScores = New System.Windows.Forms.ComboBox()
        Me.btnVoir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbxScores
        '
        Me.lbxScores.FormattingEnabled = True
        Me.lbxScores.Location = New System.Drawing.Point(12, 39)
        Me.lbxScores.Name = "lbxScores"
        Me.lbxScores.Size = New System.Drawing.Size(120, 95)
        Me.lbxScores.TabIndex = 0
        '
        'btnOrdre
        '
        Me.btnOrdre.Location = New System.Drawing.Point(12, 169)
        Me.btnOrdre.Name = "btnOrdre"
        Me.btnOrdre.Size = New System.Drawing.Size(120, 23)
        Me.btnOrdre.TabIndex = 1
        Me.btnOrdre.Text = "Changer l'ordre"
        Me.btnOrdre.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(12, 198)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(120, 23)
        Me.btnRetour.TabIndex = 2
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'cbxScores
        '
        Me.cbxScores.FormattingEnabled = True
        Me.cbxScores.Location = New System.Drawing.Point(12, 12)
        Me.cbxScores.Name = "cbxScores"
        Me.cbxScores.Size = New System.Drawing.Size(121, 21)
        Me.cbxScores.TabIndex = 3
        '
        'btnVoir
        '
        Me.btnVoir.Location = New System.Drawing.Point(12, 140)
        Me.btnVoir.Name = "btnVoir"
        Me.btnVoir.Size = New System.Drawing.Size(120, 23)
        Me.btnVoir.TabIndex = 4
        Me.btnVoir.Text = "Voir le joueur"
        Me.btnVoir.UseVisualStyleBackColor = True
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(144, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVoir)
        Me.Controls.Add(Me.cbxScores)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnOrdre)
        Me.Controls.Add(Me.lbxScores)
        Me.MaximumSize = New System.Drawing.Size(160, 274)
        Me.MinimumSize = New System.Drawing.Size(160, 274)
        Me.Name = "Scores"
        Me.Text = "Scores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbxScores As ListBox
    Friend WithEvents btnOrdre As Button
    Friend WithEvents btnRetour As Button
    Friend WithEvents cbxScores As ComboBox
    Friend WithEvents btnVoir As Button
End Class
