Public Class Accueil

    'Evènement suivant le clic sur bouton quitter qui arrête l'application et la ferme
    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If MsgBox("Fermer l'application ?", vbYesNo, "Quitter") = vbYes Then
            Accueil.ActiveForm.Close()
        End If
    End Sub

    'Evènement suivant le clic sur bouton jouer qui ouvre la fenêtre de jeu de Memory
    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        If cbxNom.Text.Length < 3 Then
            MsgBox("Entrez un nom d'une longueur minimum de 3 caractères.", vbOKOnly, "Erreur")
        ElseIf cbxNom.Text.Length > 18 Then
            MsgBox("Entrez un nom d'une longueur maximum de 18 caractères", vbOKOnly, "Erreur")
        Else
            Me.Hide()
            cbxNom.Items.Add(cbxNom.Text)
            ModuleJoueurs.NouvelleEntree(cbxNom.Text)
            Dim NouvMemory As Memory = New Memory()
            NouvMemory.Show()
            NouvMemory.setJoueur(ModuleJoueurs.getJoueur(cbxNom.Text))
        End If
    End Sub

    'Evènement suivant le chargement de la fenêtre d'accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initJoueurs()
        cbxNom.Items.Clear()
        Dim listeJoueurs = getNomsJoueurs()
        For Each nom As String In listeJoueurs
            If nom <> "" Then
                cbxNom.Items.Add(nom)
            End If
        Next
    End Sub

    'Evènement suivant la fermeture de la fenêtre d'accueil qui sauvegarde les données de chaque joueur
    Private Sub Accueil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        saveJoueurs()
    End Sub

    'Evènement suivant le clic sur le bouton score qui ouvre la fenêtre de consultation des scores et cache l'accueil
    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Me.Hide()
        Dim newScoresForm As Scores
        newScoresForm = New Scores
        newScoresForm.Show()
        newScoresForm = Nothing
    End Sub

    'Evènement suivant le clic sur le bouton options qui ouvre la fenêtre de changment des options et cache l'accueil
    Private Sub btn_options_Click(sender As Object, e As EventArgs) Handles btn_options.Click
        Dim NouvOptions As Options = New Options()
        Me.Hide()
        NouvOptions.Show()
    End Sub

End Class
