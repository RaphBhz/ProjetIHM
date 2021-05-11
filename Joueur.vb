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
        tempsMin = Nothing
    End Sub
End Class
