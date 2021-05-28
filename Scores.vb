Public Class Scores
    Private Const CROISSANT = 1
    Private Const DECROISSANT = -1
    Private ordre As Integer
    Private dataJoueurs As List(Of Joueur)

    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataJoueurs = getAllJoueurs()
        ordre = CROISSANT
        trierJoueurs()
        initialiserCbxJoueurs()
        initialiserLbxJoueurs()
    End Sub

    Private Sub trierJoueurs()
        Dim joueurTmp As Joueur
        For i = 0 To dataJoueurs.Count - 2
            If dataJoueurs(i).getScore = dataJoueurs(i + 1).getScore Then
                If (ordre * (dataJoueurs(i).getTime - dataJoueurs(i + 1).getTime) > 0) Then
                    joueurTmp = dataJoueurs(i)
                    dataJoueurs(i) = dataJoueurs(i + 1)
                    dataJoueurs(i + 1) = joueurTmp
                    Continue For
                End If
            End If
            If (ordre * (dataJoueurs(i).getScore - dataJoueurs(i + 1).getScore) < 0) Then
                joueurTmp = dataJoueurs(i)
                dataJoueurs(i) = dataJoueurs(i + 1)
                dataJoueurs(i + 1) = joueurTmp
            End If
        Next
    End Sub

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

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
        Accueil.Show()
    End Sub
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

    Private Sub lbxScores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxScores.SelectedIndexChanged
        Dim idx = cbxScores.Items.IndexOf(Split(lbxScores.SelectedItem, " ")(0))
        cbxScores.SelectedIndex = idx
    End Sub

    Private Sub initialiserCbxJoueurs()
        cbxScores.Items.Clear()
        For i = 0 To dataJoueurs.Count - 1
            cbxScores.Items.Add(dataJoueurs(i).GetNom)
        Next
    End Sub

    Private Sub initialiserLbxJoueurs()
        lbxScores.Items.Clear()
        For i = 0 To dataJoueurs.Count - 1
            Dim strTime = Int(dataJoueurs(i).getTime / 60) & "m" & dataJoueurs(i).getTime Mod 60 & "s"
            lbxScores.Items.Add(dataJoueurs(i).GetNom & " : " & dataJoueurs(i).getScore & "pts en " & strTime)
        Next
    End Sub
End Class