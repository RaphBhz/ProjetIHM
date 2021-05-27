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
        scoreMax = CInt(tmpStr(1))
        tempsMin = CInt(tmpStr(2))
        nbParties = CInt(tmpStr(3))
        tempsJeu = CInt(tmpStr(4))
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

    Public Sub addTime(t As Int16)
        Me.tempsJeu += t
    End Sub

    Public Function afficheScore() As String
        Dim strTime = Format$(Int(Me.getTime / 60), "00") & " minutes et " & Format$(Int(Me.getTime Mod 60), "00") & " secondes."
        Return Me.GetNom & " : " & vbCrLf & "Meilleur score : " & Me.getScore & "pts en " & strTime & vbCrLf & Me.nbParties & " parties jouées pour un total de " & Format$(Int(Me.tempsJeu / 60), "00") & " minutes et " & Format$(Int(Me.tempsJeu Mod 60), "00") & " secondes."
    End Function
End Class