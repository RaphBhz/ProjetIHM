Public Class Joueur
    Private nom As String
    Private scoreMax As Int16
    Private tempsMin As Int16
    Private nbParties As Int16
    Private tempsJeu As Int16

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
    Public Sub New(strJoueurs As String, b As Boolean)
        Dim tmpStr = Split(strJoueurs, "/")
        nom = tmpStr(0)
        scoreMax = Convert.ToInt16(tmpStr(1))
        nbParties = Convert.ToInt16(tmpStr(2))
        tempsJeu = Convert.ToInt16(tmpStr(3))
        tempsMin = Convert.ToInt16(tmpStr(4))
    End Sub

    Public Overrides Function ToString() As String
        Return Me.nom & "/" & Me.scoreMax & "/" & Me.tempsMin & "/" & Me.nbParties & "/" & Me.tempsJeu & "|"
    End Function
End Class