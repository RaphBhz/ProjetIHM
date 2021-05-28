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
        Me.txt_TimerMin = New System.Windows.Forms.TextBox()
        Me.txt_TimerSec = New System.Windows.Forms.TextBox()
        Me.lbl_timeSep = New System.Windows.Forms.Label()
        Me.btn_desactiver = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.btn_AppliquerOptions = New System.Windows.Forms.Button()
        Me.changeThemeButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txt_TimerMin
        '
        Me.txt_TimerMin.Location = New System.Drawing.Point(101, 6)
        Me.txt_TimerMin.Name = "txt_TimerMin"
        Me.txt_TimerMin.Size = New System.Drawing.Size(27, 20)
        Me.txt_TimerMin.TabIndex = 1
        '
        'txt_TimerSec
        '
        Me.txt_TimerSec.Location = New System.Drawing.Point(150, 6)
        Me.txt_TimerSec.Name = "txt_TimerSec"
        Me.txt_TimerSec.Size = New System.Drawing.Size(27, 20)
        Me.txt_TimerSec.TabIndex = 2
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
        'btn_desactiver
        '
        Me.btn_desactiver.Location = New System.Drawing.Point(213, 4)
        Me.btn_desactiver.Name = "btn_desactiver"
        Me.btn_desactiver.Size = New System.Drawing.Size(76, 23)
        Me.btn_desactiver.TabIndex = 4
        Me.btn_desactiver.Text = "Désactiver"
        Me.btn_desactiver.UseVisualStyleBackColor = True
        '
        'btn_quitter
        '
        Me.btn_quitter.Location = New System.Drawing.Point(20, 301)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitter.TabIndex = 6
        Me.btn_quitter.Text = "Retour"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'btn_AppliquerOptions
        '
        Me.btn_AppliquerOptions.Location = New System.Drawing.Point(101, 301)
        Me.btn_AppliquerOptions.Name = "btn_AppliquerOptions"
        Me.btn_AppliquerOptions.Size = New System.Drawing.Size(75, 23)
        Me.btn_AppliquerOptions.TabIndex = 7
        Me.btn_AppliquerOptions.Text = "Appliquer"
        Me.btn_AppliquerOptions.UseVisualStyleBackColor = True
        '
        'changeThemeButton
        '
        Me.changeThemeButton.Location = New System.Drawing.Point(213, 48)
        Me.changeThemeButton.Name = "changeThemeButton"
        Me.changeThemeButton.Size = New System.Drawing.Size(156, 34)
        Me.changeThemeButton.TabIndex = 8
        Me.changeThemeButton.Text = "Changer thème"
        Me.changeThemeButton.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProjetIHM.My.Resources.Resources.Card1
        Me.PictureBox3.Location = New System.Drawing.Point(220, 105)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(84, 121)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProjetIHM.My.Resources.Resources.Card2
        Me.PictureBox4.Location = New System.Drawing.Point(325, 105)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(84, 121)
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetIHM.My.Resources.Resources.Card0
        Me.PictureBox2.Location = New System.Drawing.Point(116, 105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 121)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ProjetIHM.My.Resources.Resources.Card3
        Me.PictureBox5.Location = New System.Drawing.Point(432, 105)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(84, 121)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetIHM.My.Resources.Resources.BackCard
        Me.PictureBox1.Location = New System.Drawing.Point(10, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 121)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ProjetIHM.My.Resources.Resources.Card4
        Me.PictureBox6.Location = New System.Drawing.Point(535, 105)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(84, 121)
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.changeThemeButton)
        Me.Controls.Add(Me.btn_AppliquerOptions)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_desactiver)
        Me.Controls.Add(Me.lbl_timeSep)
        Me.Controls.Add(Me.txt_TimerSec)
        Me.Controls.Add(Me.txt_TimerMin)
        Me.Controls.Add(Me.lbl_Timer)
        Me.MaximumSize = New System.Drawing.Size(647, 381)
        Me.MinimumSize = New System.Drawing.Size(647, 381)
        Me.Name = "Options"
        Me.Text = "Options"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Timer As Label
    Friend WithEvents txt_TimerMin As TextBox
    Friend WithEvents txt_TimerSec As TextBox
    Friend WithEvents lbl_timeSep As Label
    Friend WithEvents btn_desactiver As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents btn_AppliquerOptions As Button
    Friend WithEvents changeThemeButton As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
