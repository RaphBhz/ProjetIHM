Public Class Joueur
    Private nom As String
    Private scoreMax As Integer
    Private tempsMin As Integer
    Private nbParties As Integer
    Private tempsJeu As Integer

    Public Function GetNom()
        Return Me.nom
    End Function

    Public Sub AjouterPartie()
        Me.nbParties += 1
    End Sub
    Public Sub New(nouvNom As String)
        nom = nouvNom
        scoreMax = 0
        nbParties = 1
        tempsJeu = 0
        tempsMin = 0
    End Sub

    Public Sub setBestScore(score As Integer, time As Integer)
        Me.scoreMax = score
        Me.tempsMin = time
    End Sub

    Public Function isScoreBetter(score As Integer, time As Integer) As Boolean
        If score < scoreMax Then
            Return False
        End If

        If score = scoreMax And time > tempsMin Then
            Return False
        End If

        Return True

    End Function

    Public Sub New(strJoueurs As String, b As Boolean)
        Dim tmpStr = Split(strJoueurs, "/")
        nom = tmpStr(0)
        scoreMax = Convert.ToInt16(tmpStr(1))
        tempsMin = Convert.ToInt16(tmpStr(2))
        nbParties = Convert.ToInt16(tmpStr(3))
        tempsJeu = Convert.ToInt16(tmpStr(4))
    End Sub

    Public Overrides Function ToString() As String
        Return Me.nom & "/" & Me.scoreMax & "/" & Me.tempsMin & "/" & Me.nbParties & "/" & Me.tempsJeu & "|"
    End Function

    Public Function getScore()
        Return scoreMax
    End Function
    Public Function getTime()
        Return tempsMin
    End Function

    Public Function afficheScore() As String
        Dim strTime = Math.Round(Me.getTime / 60) & " minutes et " & Me.getTime Mod 60 & " secondes."
        Return Me.GetNom & " : " & vbCrLf & "Meilleur score : " & Me.getScore & " en " & strTime & vbCrLf & Me.nbParties & " parties jouées pour un total de " & tempsJeu
    End Function
End Class