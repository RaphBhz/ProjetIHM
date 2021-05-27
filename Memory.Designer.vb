<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Memory
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Memory))
        Me.lblJoueur = New System.Windows.Forms.Label()
        Me.lblTemps = New System.Windows.Forms.Label()
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.lblNomJoueur = New System.Windows.Forms.Label()
        Me.carte11 = New System.Windows.Forms.PictureBox()
        Me.carte13 = New System.Windows.Forms.PictureBox()
        Me.carte12 = New System.Windows.Forms.PictureBox()
        Me.carte14 = New System.Windows.Forms.PictureBox()
        Me.carte15 = New System.Windows.Forms.PictureBox()
        Me.carte25 = New System.Windows.Forms.PictureBox()
        Me.carte35 = New System.Windows.Forms.PictureBox()
        Me.carte45 = New System.Windows.Forms.PictureBox()
        Me.carte44 = New System.Windows.Forms.PictureBox()
        Me.carte34 = New System.Windows.Forms.PictureBox()
        Me.carte24 = New System.Windows.Forms.PictureBox()
        Me.carte23 = New System.Windows.Forms.PictureBox()
        Me.carte22 = New System.Windows.Forms.PictureBox()
        Me.carte21 = New System.Windows.Forms.PictureBox()
        Me.carte31 = New System.Windows.Forms.PictureBox()
        Me.carte32 = New System.Windows.Forms.PictureBox()
        Me.carte33 = New System.Windows.Forms.PictureBox()
        Me.carte43 = New System.Windows.Forms.PictureBox()
        Me.carte42 = New System.Windows.Forms.PictureBox()
        Me.carte41 = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.gbxCartes = New System.Windows.Forms.GroupBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.PauseButton = New System.Windows.Forms.Button()
        CType(Me.carte11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carte41, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCartes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJoueur
        '
        Me.lblJoueur.AutoSize = True
        Me.lblJoueur.Location = New System.Drawing.Point(17, 16)
        Me.lblJoueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoueur.Name = "lblJoueur"
        Me.lblJoueur.Size = New System.Drawing.Size(60, 17)
        Me.lblJoueur.TabIndex = 0
        Me.lblJoueur.Text = "Joueur :"
        '
        'lblTemps
        '
        Me.lblTemps.AutoSize = True
        Me.lblTemps.Location = New System.Drawing.Point(232, 16)
        Me.lblTemps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTemps.Name = "lblTemps"
        Me.lblTemps.Size = New System.Drawing.Size(116, 17)
        Me.lblTemps.TabIndex = 1
        Me.lblTemps.Text = "- Temps restant :"
        '
        'btnAbandon
        '
        Me.btnAbandon.Location = New System.Drawing.Point(541, 10)
        Me.btnAbandon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(100, 28)
        Me.btnAbandon.TabIndex = 2
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = True
        '
        'lblNomJoueur
        '
        Me.lblNomJoueur.AutoSize = True
        Me.lblNomJoueur.Location = New System.Drawing.Point(85, 16)
        Me.lblNomJoueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNomJoueur.Name = "lblNomJoueur"
        Me.lblNomJoueur.Size = New System.Drawing.Size(12, 17)
        Me.lblNomJoueur.TabIndex = 3
        Me.lblNomJoueur.Text = " "
        '
        'carte11
        '
        Me.carte11.Image = Global.ProjetIHM.My.Resources.Resources.BackCard
        Me.carte11.Location = New System.Drawing.Point(8, 23)
        Me.carte11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte11.Name = "carte11"
        Me.carte11.Size = New System.Drawing.Size(119, 153)
        Me.carte11.TabIndex = 4
        Me.carte11.TabStop = False
        '
        'carte13
        '
        Me.carte13.Image = CType(resources.GetObject("carte13.Image"), System.Drawing.Image)
        Me.carte13.Location = New System.Drawing.Point(261, 23)
        Me.carte13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte13.Name = "carte13"
        Me.carte13.Size = New System.Drawing.Size(119, 153)
        Me.carte13.TabIndex = 5
        Me.carte13.TabStop = False
        '
        'carte12
        '
        Me.carte12.Image = CType(resources.GetObject("carte12.Image"), System.Drawing.Image)
        Me.carte12.Location = New System.Drawing.Point(135, 23)
        Me.carte12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte12.Name = "carte12"
        Me.carte12.Size = New System.Drawing.Size(119, 153)
        Me.carte12.TabIndex = 6
        Me.carte12.TabStop = False
        '
        'carte14
        '
        Me.carte14.Image = CType(resources.GetObject("carte14.Image"), System.Drawing.Image)
        Me.carte14.Location = New System.Drawing.Point(388, 23)
        Me.carte14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte14.Name = "carte14"
        Me.carte14.Size = New System.Drawing.Size(119, 153)
        Me.carte14.TabIndex = 7
        Me.carte14.TabStop = False
        '
        'carte15
        '
        Me.carte15.Image = CType(resources.GetObject("carte15.Image"), System.Drawing.Image)
        Me.carte15.Location = New System.Drawing.Point(515, 23)
        Me.carte15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte15.Name = "carte15"
        Me.carte15.Size = New System.Drawing.Size(119, 153)
        Me.carte15.TabIndex = 8
        Me.carte15.TabStop = False
        '
        'carte25
        '
        Me.carte25.Image = CType(resources.GetObject("carte25.Image"), System.Drawing.Image)
        Me.carte25.Location = New System.Drawing.Point(515, 183)
        Me.carte25.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte25.Name = "carte25"
        Me.carte25.Size = New System.Drawing.Size(119, 153)
        Me.carte25.TabIndex = 9
        Me.carte25.TabStop = False
        '
        'carte35
        '
        Me.carte35.Image = CType(resources.GetObject("carte35.Image"), System.Drawing.Image)
        Me.carte35.Location = New System.Drawing.Point(515, 343)
        Me.carte35.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte35.Name = "carte35"
        Me.carte35.Size = New System.Drawing.Size(119, 153)
        Me.carte35.TabIndex = 10
        Me.carte35.TabStop = False
        '
        'carte45
        '
        Me.carte45.Image = CType(resources.GetObject("carte45.Image"), System.Drawing.Image)
        Me.carte45.Location = New System.Drawing.Point(515, 503)
        Me.carte45.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte45.Name = "carte45"
        Me.carte45.Size = New System.Drawing.Size(119, 153)
        Me.carte45.TabIndex = 11
        Me.carte45.TabStop = False
        '
        'carte44
        '
        Me.carte44.Image = CType(resources.GetObject("carte44.Image"), System.Drawing.Image)
        Me.carte44.Location = New System.Drawing.Point(388, 503)
        Me.carte44.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte44.Name = "carte44"
        Me.carte44.Size = New System.Drawing.Size(119, 153)
        Me.carte44.TabIndex = 12
        Me.carte44.TabStop = False
        '
        'carte34
        '
        Me.carte34.Image = CType(resources.GetObject("carte34.Image"), System.Drawing.Image)
        Me.carte34.Location = New System.Drawing.Point(388, 343)
        Me.carte34.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte34.Name = "carte34"
        Me.carte34.Size = New System.Drawing.Size(119, 153)
        Me.carte34.TabIndex = 13
        Me.carte34.TabStop = False
        '
        'carte24
        '
        Me.carte24.Image = CType(resources.GetObject("carte24.Image"), System.Drawing.Image)
        Me.carte24.Location = New System.Drawing.Point(388, 183)
        Me.carte24.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte24.Name = "carte24"
        Me.carte24.Size = New System.Drawing.Size(119, 153)
        Me.carte24.TabIndex = 14
        Me.carte24.TabStop = False
        '
        'carte23
        '
        Me.carte23.Image = CType(resources.GetObject("carte23.Image"), System.Drawing.Image)
        Me.carte23.Location = New System.Drawing.Point(261, 183)
        Me.carte23.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte23.Name = "carte23"
        Me.carte23.Size = New System.Drawing.Size(119, 153)
        Me.carte23.TabIndex = 15
        Me.carte23.TabStop = False
        '
        'carte22
        '
        Me.carte22.Image = CType(resources.GetObject("carte22.Image"), System.Drawing.Image)
        Me.carte22.Location = New System.Drawing.Point(135, 183)
        Me.carte22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte22.Name = "carte22"
        Me.carte22.Size = New System.Drawing.Size(119, 153)
        Me.carte22.TabIndex = 16
        Me.carte22.TabStop = False
        '
        'carte21
        '
        Me.carte21.Image = CType(resources.GetObject("carte21.Image"), System.Drawing.Image)
        Me.carte21.Location = New System.Drawing.Point(8, 183)
        Me.carte21.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte21.Name = "carte21"
        Me.carte21.Size = New System.Drawing.Size(119, 153)
        Me.carte21.TabIndex = 17
        Me.carte21.TabStop = False
        '
        'carte31
        '
        Me.carte31.Image = CType(resources.GetObject("carte31.Image"), System.Drawing.Image)
        Me.carte31.Location = New System.Drawing.Point(8, 343)
        Me.carte31.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte31.Name = "carte31"
        Me.carte31.Size = New System.Drawing.Size(119, 153)
        Me.carte31.TabIndex = 18
        Me.carte31.TabStop = False
        '
        'carte32
        '
        Me.carte32.Image = CType(resources.GetObject("carte32.Image"), System.Drawing.Image)
        Me.carte32.Location = New System.Drawing.Point(135, 343)
        Me.carte32.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte32.Name = "carte32"
        Me.carte32.Size = New System.Drawing.Size(119, 153)
        Me.carte32.TabIndex = 19
        Me.carte32.TabStop = False
        '
        'carte33
        '
        Me.carte33.Image = CType(resources.GetObject("carte33.Image"), System.Drawing.Image)
        Me.carte33.Location = New System.Drawing.Point(261, 343)
        Me.carte33.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte33.Name = "carte33"
        Me.carte33.Size = New System.Drawing.Size(119, 153)
        Me.carte33.TabIndex = 20
        Me.carte33.TabStop = False
        '
        'carte43
        '
        Me.carte43.Image = CType(resources.GetObject("carte43.Image"), System.Drawing.Image)
        Me.carte43.Location = New System.Drawing.Point(261, 503)
        Me.carte43.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte43.Name = "carte43"
        Me.carte43.Size = New System.Drawing.Size(119, 153)
        Me.carte43.TabIndex = 21
        Me.carte43.TabStop = False
        '
        'carte42
        '
        Me.carte42.Image = CType(resources.GetObject("carte42.Image"), System.Drawing.Image)
        Me.carte42.Location = New System.Drawing.Point(135, 503)
        Me.carte42.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte42.Name = "carte42"
        Me.carte42.Size = New System.Drawing.Size(119, 153)
        Me.carte42.TabIndex = 22
        Me.carte42.TabStop = False
        '
        'carte41
        '
        Me.carte41.Image = CType(resources.GetObject("carte41.Image"), System.Drawing.Image)
        Me.carte41.Location = New System.Drawing.Point(8, 503)
        Me.carte41.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.carte41.Name = "carte41"
        Me.carte41.Size = New System.Drawing.Size(119, 153)
        Me.carte41.TabIndex = 23
        Me.carte41.TabStop = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'gbxCartes
        '
        Me.gbxCartes.Controls.Add(Me.carte31)
        Me.gbxCartes.Controls.Add(Me.carte41)
        Me.gbxCartes.Controls.Add(Me.carte11)
        Me.gbxCartes.Controls.Add(Me.carte42)
        Me.gbxCartes.Controls.Add(Me.carte13)
        Me.gbxCartes.Controls.Add(Me.carte43)
        Me.gbxCartes.Controls.Add(Me.carte12)
        Me.gbxCartes.Controls.Add(Me.carte33)
        Me.gbxCartes.Controls.Add(Me.carte14)
        Me.gbxCartes.Controls.Add(Me.carte32)
        Me.gbxCartes.Controls.Add(Me.carte15)
        Me.gbxCartes.Controls.Add(Me.carte25)
        Me.gbxCartes.Controls.Add(Me.carte21)
        Me.gbxCartes.Controls.Add(Me.carte35)
        Me.gbxCartes.Controls.Add(Me.carte22)
        Me.gbxCartes.Controls.Add(Me.carte45)
        Me.gbxCartes.Controls.Add(Me.carte23)
        Me.gbxCartes.Controls.Add(Me.carte44)
        Me.gbxCartes.Controls.Add(Me.carte24)
        Me.gbxCartes.Controls.Add(Me.carte34)
        Me.gbxCartes.Location = New System.Drawing.Point(16, 46)
        Me.gbxCartes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxCartes.Name = "gbxCartes"
        Me.gbxCartes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxCartes.Size = New System.Drawing.Size(641, 670)
        Me.gbxCartes.TabIndex = 24
        Me.gbxCartes.TabStop = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(355, 16)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(40, 17)
        Me.lblTimer.TabIndex = 25
        Me.lblTimer.Text = "-- : --"
        '
        'PauseButton
        '
        Me.PauseButton.Location = New System.Drawing.Point(277, 724)
        Me.PauseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(100, 28)
        Me.PauseButton.TabIndex = 26
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'Memory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 759)
        Me.ControlBox = False
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.gbxCartes)
        Me.Controls.Add(Me.lblNomJoueur)
        Me.Controls.Add(Me.btnAbandon)
        Me.Controls.Add(Me.lblTemps)
        Me.Controls.Add(Me.lblJoueur)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Memory"
        Me.Text = "Memory"
        CType(Me.carte11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carte41, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCartes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJoueur As Label
    Friend WithEvents lblTemps As Label
    Friend WithEvents btnAbandon As Button
    Friend WithEvents lblNomJoueur As Label
    Friend WithEvents carte11 As PictureBox
    Friend WithEvents carte13 As PictureBox
    Friend WithEvents carte12 As PictureBox
    Friend WithEvents carte14 As PictureBox
    Friend WithEvents carte15 As PictureBox
    Friend WithEvents carte25 As PictureBox
    Friend WithEvents carte35 As PictureBox
    Friend WithEvents carte45 As PictureBox
    Friend WithEvents carte44 As PictureBox
    Friend WithEvents carte34 As PictureBox
    Friend WithEvents carte24 As PictureBox
    Friend WithEvents carte23 As PictureBox
    Friend WithEvents carte22 As PictureBox
    Friend WithEvents carte21 As PictureBox
    Friend WithEvents carte31 As PictureBox
    Friend WithEvents carte32 As PictureBox
    Friend WithEvents carte33 As PictureBox
    Friend WithEvents carte43 As PictureBox
    Friend WithEvents carte42 As PictureBox
    Friend WithEvents carte41 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents gbxCartes As GroupBox
    Friend WithEvents lblTimer As Label
    Friend WithEvents PauseButton As Button
End Class
