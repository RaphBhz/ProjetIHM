Module ModuleJoueurs
    Private joueurs As List(Of Joueur)
    Private nomFile = "noms.txt"
    Public Sub NouvelleEntree(nom As String)
        Dim joueurEntre = joueurs.FindIndex(Function(j As Joueur) j.GetNom() = nom)
        If joueurEntre <> -1 Then
            joueurs(joueurEntre).AjouterPartie()
        Else
            joueurs.Add(New Joueur(nom))
        End If
    End Sub

    Public Function getJoueur(nom As String) As Joueur
        For Each joueur As Joueur In joueurs
            If joueur.GetNom = nom Then
                Return joueur
            End If
        Next joueur
        Return Nothing

    End Function

    Public Function getNomFile()
        Return nomFile
    End Function

    Public Sub initJoueurs()
        joueurs = New List(Of Joueur)
        Dim sFile = My.Computer.FileSystem.ReadAllText(nomFile)
        Dim joueursStr = Split(sFile, "|")
        For i = 0 To joueursStr.Length - 1
            If (joueursStr(i) <> "") Then
                joueurs.Add(New Joueur(joueursStr(i), True))
            End If
        Next
    End Sub

    Public Function getNomsJoueurs()
        Dim noms As List(Of String)
        noms = New List(Of String)
        For i = 0 To joueurs.Count() - 1
            noms.Add(joueurs(i).GetNom)
        Next
        Return noms
    End Function

    Public Sub saveJoueurs()
        Dim strFile As String
        Dim txtJoueur As String
        strFile = ""
        For i = 0 To joueurs.Count() - 1
            txtJoueur = joueurs(i).ToString()
            strFile = strFile & txtJoueur
        Next
        My.Computer.FileSystem.WriteAllText(nomFile, strFile, False)
    End Sub

    Public Function getAllJoueurs()
        Return joueurs
    End Function
End Module
