Public Class Accueil
    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If MsgBox("Fermer l'application ?", vbYesNo, "Quitter") = vbYes Then
            Accueil.ActiveForm.Close()
        End If
    End Sub

    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        If cbxNom.Text.Length < 3 Then
            MsgBox("Entrez un nom d'une longueur minimum de 3 caractères.", vbOKOnly, "Erreur")
        Else
            Me.Hide()
            cbxNom.Items.Add(cbxNom.Text)
            ModuleJoueurs.NouvelleEntree(cbxNom.Text)
            Dim NouvMemory As Memory
            NouvMemory = New Memory
            NouvMemory.Show()
            NouvMemory = Nothing
        End If
    End Sub

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

    Private Sub Accueil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        saveJoueurs()
    End Sub
End Class
