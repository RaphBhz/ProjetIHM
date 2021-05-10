Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If MsgBox("Fermer l'application ?", vbYesNo, "Quitter") = vbYes Then
            Accueil.ActiveForm.Close()
        End If
    End Sub

    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        If cbxNom.Text.Length < 3 Then
            MsgBox("Entrez un nom d'une longueur minimum de 3 caractères.", vbOKOnly, "Erreur")
        Else
            Me.Hide()
            Dim NouvMemory As Memory
            NouvMemory = New Memory
            NouvMemory.Show()
            NouvMemory = Nothing
        End If
    End Sub
End Class
