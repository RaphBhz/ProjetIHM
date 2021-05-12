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
        cbxNom.Items.Clear()
        Dim sFile = My.Computer.FileSystem.ReadAllText(ModuleJoueurs.getNomFile)
        Dim joueurs = Split(sFile, "|")
        For Each nom As String In joueurs
            If nom <> "" Then
                cbxNom.Items.Add(nom)
            End If
        Next
    End Sub
End Class
