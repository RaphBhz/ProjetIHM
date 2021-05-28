Public Class Scores
    Private Const CROISSANT = 1
    Private Const DECROISSANT = -1
    Private ordre As Integer
    Private dataJoueurs As List(Of Joueur)

    'Evènement du lancement de la fenêtre des scores
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataJoueurs = getAllJoueurs()
        ordre = CROISSANT
        trierJoueurs()
        initialiserCbxJoueurs()
        initialiserLbxJoueurs()
    End Sub

    'Sub qui trie la liste des joueurs selon l'ordre courant (CROISSANT ou DECROISSANT)
    Private Sub trierJoueurs()
        Dim joueurTmp As Joueur
        For i = 0 To dataJoueurs.Count - 2
            For j = i To dataJoueurs.Count - 1
                If dataJoueurs(i).getScore = dataJoueurs(j).getScore Then
                    If (ordre * (dataJoueurs(j).getTime - dataJoueurs(i).getTime) > 0) Then
                        joueurTmp = dataJoueurs(i)
                        dataJoueurs(i) = dataJoueurs(j)
                        dataJoueurs(j) = joueurTmp
                    End If
                Else
                    If (ordre * (dataJoueurs(j).getScore - dataJoueurs(i).getScore) < 0) Then
                        joueurTmp = dataJoueurs(i)
                        dataJoueurs(i) = dataJoueurs(j)
                        dataJoueurs(j) = joueurTmp
                    End If
                End If
            Next
        Next
    End Sub

    'Evènement correspondant au clic sur le bouton de changement d'ordre de tri des joueurs
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub btnOrdre_Click(sender As Object, e As EventArgs) Handles btnOrdre.Click
        lbxScores.Items.Clear()
        If ordre = CROISSANT Then
            ordre = DECROISSANT
        Else
            ordre = CROISSANT
        End If
        trierJoueurs()
        initialiserLbxJoueurs()
    End Sub

    'Evènement correspondant au clic sur le bouton de retour au menu d'accueil
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
        Accueil.Show()
    End Sub

    'Sub qui permet d'afficher les statistiques d'un joueur précis
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub btnVoir_Click(sender As Object, e As EventArgs) Handles btnVoir.Click
        Dim idx = dataJoueurs.FindIndex(Function(j As Joueur) j.GetNom() = cbxScores.Text)
        If idx = -1 Then
            MsgBox("Le joueur entré n'a pas pu être trouvé", vbOK, "Joueur non enregistré")
        Else
            Dim j As Joueur
            j = dataJoueurs(idx)
            MsgBox(j.afficheScore, vbOK, "Meilleur score de " & j.GetNom)
        End If
    End Sub

    'Evènement qui permet de sélectionner dans la ComboBox le joueur sur lequel on clique dans la ListBox 
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub lbxScores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxScores.SelectedIndexChanged
        Dim idx = cbxScores.Items.IndexOf(Split(lbxScores.SelectedItem, " ")(0))
        cbxScores.SelectedIndex = idx
    End Sub

    'Sub qui initialise les valeurs de la ComboBox avec les données des joueurs chargées dans dataJoueurs
    Private Sub initialiserCbxJoueurs()
        cbxScores.Items.Clear()
        For i = 0 To dataJoueurs.Count - 1
            cbxScores.Items.Add(dataJoueurs(i).GetNom)
        Next
    End Sub

    'Sub qui initialise les valeurs de la ListBox avec les données des joueurs chargées dans dataJoueurs
    Private Sub initialiserLbxJoueurs()
        lbxScores.Items.Clear()
        For i = 0 To dataJoueurs.Count - 1
            Dim strTime = Int(dataJoueurs(i).getTime / 60) & "m" & dataJoueurs(i).getTime Mod 60 & "s"
            lbxScores.Items.Add(dataJoueurs(i).GetNom & " : " & dataJoueurs(i).getScore & "pts en " & strTime)
        Next
    End Sub
End Class