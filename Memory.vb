Public Class Memory
    Dim ticks As Int16
    Dim seconds As Int16
    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        If MsgBox("Abandonner la partie en cours ?", vbYesNo, "Abandon") = vbYes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNomJoueur.Text = Accueil.cbxNom.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ticks += 1
        seconds = (Timer.Interval - ticks) / 1000
        lblTimer.Text = seconds / 60 & ":" & seconds Mod 60
    End Sub

    Private Sub carte11_Click(sender As Object, e As EventArgs) Handles carte11.Click
        If Timer.Enabled = False Then
            Timer.Enabled = True
            Timer.Start()
            Ticks = 0
        End If
    End Sub

    Private Sub btnTestTimer_Click(sender As Object, e As EventArgs) Handles btnTestTimer.Click
        If Timer.Enabled = False Then
            Timer.Enabled = True
            Timer.Start()
            ticks = 0
        End If
    End Sub
End Class