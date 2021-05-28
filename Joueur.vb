Public Class Joueur
    Private nom As String
    Private scoreMax As Integer
    Private tempsMin As Integer
    Private nbParties As Integer
    Private tempsJeu As Integer

    'Fonction qui renvoie le nom du joueur'
    '@return String Le nom du joueur
    Public Function GetNom()
        Return Me.nom
    End Function

    'Sub qui ajoute une partie au compteur du joueur
    Public Sub AjouterPartie()
        Me.nbParties += 1
    End Sub

    'Constructeur de la classe joueur
    '@param nouvNom : String Le nom du nouveau joueur
    Public Sub New(nouvNom As String)
        nom = nouvNom
        scoreMax = 0
        nbParties = 1
        tempsJeu = 0
        tempsMin = 0
    End Sub

    'Sub qui remplace le meilleur score du joueur ainsi que le temps associé au score
    '@param score : Integer Le nouveau meilleur score
    '@param time : Interger Le remps associé au score
    Public Sub setBestScore(score As Integer, time As Integer)
        Me.scoreMax = score
        Me.tempsMin = time
    End Sub

    'Fonnction qui vérifie si un score entré est meilleur que le meilleur score d'un joueur
    '@param score le score à comparer
    '@param time le temps à comparer
    '@return Boolean True si le score est meilleur False sinon
    Public Function isScoreBetter(score As Integer, time As Integer) As Boolean
        If score < scoreMax Then
            Return False
        End If

        If score = scoreMax And time > tempsMin Then
            Return False
        End If

        Return True

    End Function

    'Constructeur de la classe joueur qui prend la chaîne de caractères du joueur stocké dans le fichier
    '@param strJoueur : String La châpine de caractères d'informations sur le joueur enregistrées dans le fichier
    '@param b : Boolean Permet de différencier de l'autre constructeur
    Public Sub New(strJoueurs As String, b As Boolean)
        Dim tmpStr = Split(strJoueurs, "/")
        nom = tmpStr(0)
        scoreMax = CInt(tmpStr(1))
        tempsMin = CInt(tmpStr(2))
        nbParties = CInt(tmpStr(3))
        tempsJeu = CInt(tmpStr(4))
    End Sub

    'Fonction qui renvoie la chaîne de caractères du joueur à stocker dans le fichier
    '@return String La chaîne de caractères du joueur à stocker dans le fichier
    Public Overrides Function ToString() As String
        Return Me.nom & "/" & Me.scoreMax & "/" & Me.tempsMin & "/" & Me.nbParties & "/" & Me.tempsJeu & "|"
    End Function

    'Fonction qui renvoie le meilleur score d'un joueur
    '@return Integer Le meilleur score du joueur
    Public Function getScore()
        Return scoreMax
    End Function

    'Fonction qui renvoie le temps correspondant au meilleur score du joueur
    '@return Integer Le temps correspondant au meilleur score du joueur en secondes
    Public Function getTime()
        Return tempsMin
    End Function

    'Sub qui ajoute du temps de jeu au temps de jeu total du joueur
    Public Sub addTime(t As Int16)
        Me.tempsJeu += t
    End Sub

    'Fonction qui renvoie une chaîne de caractères permettant d'afficher les statistiques d'un joueur
    '@return String La chaîne de caractères permettant d'afficher les statistiques d'un joueur
    Public Function afficheScore() As String
        Dim strTime = Format$(Int(Me.getTime / 60), "00") & " minutes et " & Format$(Int(Me.getTime Mod 60), "00") & " secondes."
        Return Me.GetNom & " : " & vbCrLf & "Meilleur score : " & Me.getScore & "pts en " & strTime & vbCrLf & Me.nbParties & " parties jouées pour un total de " & Format$(Int(Me.tempsJeu / 60), "00") & " minutes et " & Format$(Int(Me.tempsJeu Mod 60), "00") & " secondes."
    End Function
End Class