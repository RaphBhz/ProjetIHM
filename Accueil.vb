Public Class Accueil
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
            ModuleJoueurs.nouvelleEntree(cbxNom.Text)
            Dim NouvMemory As Memory
            NouvMemory = New Memory
            NouvMemory.Show()
            NouvMemory = Nothing
        End If
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxNom.Items.Clear()
        For i As Integer = 1 To ModuleJoueurs.joueurs.Count()
            cbxNom.Items.Add(ModuleJoueurs.joueurs.ElementAt(i))
        Next
    End Sub
End Class
