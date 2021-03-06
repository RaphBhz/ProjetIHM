Public Class Options
    Private fileOptions = "options.txt"
    Private timerOn = True
    Private options As String
    Private optionsValues As Integer()
    Private imageIndex As Integer = 0
    Private nomImage As String = "Card"

    'Procédure gérant l'évènement Load du formulaire
    'Récupère les options dans un fichier et les applique
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optionsValues = loadOptions()
        applyOptions()
    End Sub

    'Procédure permettant d'appliquer les options (les afficher) sur le formulaire
    Private Sub applyOptions()
        txt_TimerMin.Text = optionsValues(1)
        txt_TimerSec.Text = optionsValues(2)
        If optionsValues(0) = 0 Then
            timerOn = False
            txt_TimerSec.Enabled = False
            txt_TimerMin.Enabled = False
            btn_desactiver.Text = "Activer"
        Else
            timerOn = True
            btn_desactiver.Text = "Désactiver"
        End If
    End Sub

    'Fonction permettant de récupérer le préfixe des images à afficher
    '@return Le préfixe de l'image
    Public Function getImageOption() As String
        Dim tmpStr As String()
        Dim image As String
        options = My.Computer.FileSystem.ReadAllText(fileOptions)
        tmpStr = Split(options, "|")
        image = tmpStr(3)
        Return image
    End Function

    'Fonction permettant de récupérer les options dans un fichier
    Public Function loadOptions()
        Dim tmpStr As String()
        Dim rtTable As List(Of Integer)
        rtTable = New List(Of Integer)
        options = My.Computer.FileSystem.ReadAllText(fileOptions)
        tmpStr = Split(options, "|")
        For i = 0 To tmpStr.Length - 2
            rtTable.Add(CInt(tmpStr(i)))
        Next
        Return rtTable.ToArray
    End Function

    'Procédure gérant l'évènement click du bouton pour désactiver ou non le timer du jeu
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub btn_desactiver_Click(sender As Object, e As EventArgs) Handles btn_desactiver.Click
        If timerOn Then
            btn_desactiver.Text = "Activer"
            timerOn = False
            optionsValues(0) = 0
            txt_TimerSec.Enabled = False
            txt_TimerMin.Enabled = False
        Else
            timerOn = True
            optionsValues(0) = 1
            txt_TimerSec.Enabled = True
            txt_TimerMin.Enabled = True
            btn_desactiver.Text = "Désactiver"
        End If
    End Sub

    'Procédure gérant l'évènement click du bouton pour quitter le formulaire (bouton "retour")
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Close()
        Accueil.Show()
    End Sub

    'Procédure gérant l'évènement click du bouton pour appliquer les options (bouton "appliquer")
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub btn_AppliquerOptions_Click(sender As Object, e As EventArgs) Handles btn_AppliquerOptions.Click
        Dim strFile As String
        If CInt(txt_TimerSec.Text) > 59 Then
            MsgBox("Montnant de secondes invalide", vbOKOnly, "Erreur")
        Else
            optionsValues(1) = txt_TimerMin.Text
            optionsValues(2) = txt_TimerSec.Text
            strFile = optionsValues(0)
            For i = 1 To optionsValues.Length - 1
                strFile = strFile & "|" & Str(optionsValues(i))
            Next
            strFile = strFile & "|" & nomImage

            My.Computer.FileSystem.WriteAllText(fileOptions, strFile, False)
        End If
    End Sub

    'Procédure gérant l'évènement click du bouton pour changer le thème (bouton "changer le thème")
    '@param sender la source de l'event
    '@param e les arguments liés à l'event
    Private Sub changeThemeButton_Click(sender As Object, e As EventArgs) Handles changeThemeButton.Click
        imageIndex += 1
        If imageIndex Mod 2 = 0 Then
            nomImage = "Card"
        ElseIf imageIndex Mod 2 = 1 Then
            nomImage = "SD"
        End If

        PictureBox1.Image = My.Resources.ResourceManager.GetObject("Back" & nomImage)
        PictureBox2.Image = My.Resources.ResourceManager.GetObject(nomImage & "0")
        PictureBox3.Image = My.Resources.ResourceManager.GetObject(nomImage & "1")
        PictureBox4.Image = My.Resources.ResourceManager.GetObject(nomImage & "2")
        PictureBox5.Image = My.Resources.ResourceManager.GetObject(nomImage & "3")
        PictureBox6.Image = My.Resources.ResourceManager.GetObject(nomImage & "4")


    End Sub

End Class