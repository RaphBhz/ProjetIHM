Public Class Joueur
    Public nom As String
    Public scoreMax As Int16
    Public tempsMin As Int16
    Public nbParties As Int16
    Public tempsJeu As Int16

    Public Sub New(nouvNom As String)
        nom = nouvNom
        scoreMax = 0
        nbParties = 1
        tempsJeu = 0
        tempsMin = Nothing
    End Sub
End Class
