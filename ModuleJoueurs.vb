Module ModuleJoueurs
    Public joueurs As List(Of Joueur)

    Public Sub nouvelleEntree(nom As String)
        Dim joueurEntre = joueurs.Find(Function(j) j.nom = nom)
        If joueurEntre Is Nothing Then
            joueurEntre.nbParties += 1
        Else
            joueurEntre = New Joueur(nom)
            joueurs.Add(joueurEntre)
        End If
    End Sub
End Module
