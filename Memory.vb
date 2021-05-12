Public Class Memory
    Dim timeMax = 600
    Dim ticks As Int16
    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        If MsgBox("Abandonner la partie en cours ?", vbYesNo, "Abandon") = vbYes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNomJoueur.Text = Accueil.cbxNom.Text
        Timer.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ticks += 1
        lblTimer.Text = Math.Round((timeMax - ticks) / 60) - 1 & " : " & Math.Round((timeMax - ticks) Mod 60)
    End Sub

    Private Sub carte11_Click(sender As Object, e As EventArgs) Handles carte11.Click, carte12.Click, carte13.Click, carte14.Click, carte15.Click,
            carte21.Click, carte22.Click, carte23.Click, carte24.Click, carte25.Click,
            carte31.Click, carte32.Click, carte33.Click, carte34.Click, carte35.Click,
            carte41.Click, carte42.Click, carte43.Click, carte44.Click, carte45.Click

        If Timer.Enabled = False Then
            Timer.Enabled = True
            ticks = 0
            Timer.Start()
        End If
    End Sub

End Class