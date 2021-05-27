<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.lbl_Timer = New System.Windows.Forms.Label()
        Me.txt_TimerSec = New System.Windows.Forms.TextBox()
        Me.txt_TimerMin = New System.Windows.Forms.TextBox()
        Me.lbl_timeSep = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Timer
        '
        Me.lbl_Timer.AutoSize = True
        Me.lbl_Timer.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Timer.Name = "lbl_Timer"
        Me.lbl_Timer.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Timer.TabIndex = 0
        Me.lbl_Timer.Text = "Valeur du timer :"
        '
        'txt_TimerSec
        '
        Me.txt_TimerSec.Location = New System.Drawing.Point(101, 6)
        Me.txt_TimerSec.Name = "txt_TimerSec"
        Me.txt_TimerSec.Size = New System.Drawing.Size(27, 20)
        Me.txt_TimerSec.TabIndex = 1
        '
        'txt_TimerMin
        '
        Me.txt_TimerMin.Location = New System.Drawing.Point(150, 6)
        Me.txt_TimerMin.Name = "txt_TimerMin"
        Me.txt_TimerMin.Size = New System.Drawing.Size(27, 20)
        Me.txt_TimerMin.TabIndex = 2
        '
        'lbl_timeSep
        '
        Me.lbl_timeSep.AutoSize = True
        Me.lbl_timeSep.Location = New System.Drawing.Point(134, 9)
        Me.lbl_timeSep.Name = "lbl_timeSep"
        Me.lbl_timeSep.Size = New System.Drawing.Size(10, 13)
        Me.lbl_timeSep.TabIndex = 3
        Me.lbl_timeSep.Text = ":"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 336)
        Me.Controls.Add(Me.lbl_timeSep)
        Me.Controls.Add(Me.txt_TimerMin)
        Me.Controls.Add(Me.txt_TimerSec)
        Me.Controls.Add(Me.lbl_Timer)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Timer As Label
    Friend WithEvents txt_TimerSec As TextBox
    Friend WithEvents txt_TimerMin As TextBox
    Friend WithEvents lbl_timeSep As Label
End Class
