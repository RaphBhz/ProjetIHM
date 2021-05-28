Module ModuleJoueurs
    Private joueurs As List(Of Joueur)
    Private nomFile = "noms.txt"

    'Sub qui enregistre une nouvelle entrée dans les joueurs. Vérifie si le joueur existe déjà. Si oui, son compteur de parties est actualisé, sinon, un nouveau joueur est créé
    Public Sub NouvelleEntree(nom As String)
        Dim joueurEntre = joueurs.FindIndex(Function(j As Joueur) j.GetNom() = nom)
        If joueurEntre <> -1 Then
            joueurs(joueurEntre).AjouterPartie()
        Else
            joueurs.Add(New Joueur(nom))
        End If
    End Sub

    'Fonction qui renvoie un joueur dont le nom correspond à celui entré en paramètre
    '@param nom : String Le nom du joueur recherché
    '@return Joueur Le joueur dont le nom correspond au paramères (Nothing si introuvable)
    Public Function getJoueur(nom As String) As Joueur
        For Each joueur As Joueur In joueurs
            If joueur.GetNom = nom Then
                Return joueur
            End If
        Next joueur
        Return Nothing

    End Function

    'Fonction qui renvoie le nom du fichier de sauvegarde des joueurs
    '@return String Le nom de fichier de sauvegarde des joueurs
    Public Function getNomFile()
        Return nomFile
    End Function

    'Sub qui initialise le tableau contenant les valeurs des statistiques de tous les joueurs enregistrés dans le fichier
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

    'Fonction qui renvoie une liste de tous les noms des joueurs existants
    '@return List(Of String) Liste de tous les noms des joueurs enregistrés
    Public Function getNomsJoueurs()
        Dim noms As List(Of String)
        noms = New List(Of String)
        For i = 0 To joueurs.Count() - 1
            noms.Add(joueurs(i).GetNom)
        Next
        Return noms
    End Function

    'Sub qui sauvegarde les joueurs contenus dans le tableau contenant tous les joueurs vers le fichier de sauvegarde
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

    'Fonction qui retourne toutes les informations des joueurs
    '@return List(Of Joueur) Liste des informations de tous les joueurs
    Public Function getAllJoueurs()
        Return joueurs
    End Function
End Module
