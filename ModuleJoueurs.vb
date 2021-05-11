Module ModuleJoueurs
    Private joueurs As List(Of Joueur)

    Public Sub PremiereEntree(nom As String)
        joueurs = New List(Of Joueur)
        joueurs.Add(New Joueur(nom))
    End Sub
    Public Sub NouvelleEntree(nom As String)
        Dim joueurEntre = joueurs.Find(Function(j) j.getNom = nom)
        If joueurEntre IsNot Nothing Then
            joueurEntre.ajouterPartie()
        Else
            joueurEntre = New Joueur(nom)
            joueurs.Add(joueurEntre)
        End If
    End Sub
    Public Function JoueursVide()
        Return joueurs Is Nothing
    End Function
End Module
