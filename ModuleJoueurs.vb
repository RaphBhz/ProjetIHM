Module ModuleJoueurs
    Private joueurs As String()
    Private nomFile = "noms.txt"
    Public Sub NouvelleEntree(nom As String)
        Dim sFile = My.Computer.FileSystem.ReadAllText(nomFile)
        joueurs = Split(sFile, "|")
        Dim joueurEntre = Array.Find(joueurs, Function(s) s = nom)
        If joueurEntre IsNot Nothing Then
            'Ajouter une partie à son compteur
        Else
            My.Computer.FileSystem.WriteAllText(nomFile, nom & "|", True)
        End If
    End Sub
    Public Function getNomFile()
        Return nomFile
    End Function
End Module

'Public Class Joueur
'    Private nom As String
'    Private scoreMax As Int16
'   Private tempsMin As Int16
'   Private nbParties As Int16
'  Private tempsJeu As Int16

'Public Function GetNom()
'    Return Me.nom
'  End Function

'  Public Sub AjouterPartie()
'       Me.nbParties += 1
'    End Sub
'   Public Sub New(nouvNom As String)
'    nom = nouvNom
'   scoreMax = 0
'  nbParties = 1
'    tempsJeu = 0
'     tempsMin = Nothing
'    End Sub
'End Class"
