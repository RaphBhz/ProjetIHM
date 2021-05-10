Public Class Memory
    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        If MsgBox("Abandonner la partie en cours ?", vbYesNo, "Abandon") = vbYes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNomJoueur.Text = Accueil.cbxNom.Text
    End Sub
End Class