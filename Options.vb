Public Class Options
    Private fileOptions = "options.txt"
    Private timerOn = True
    Private options As String
    Private optionsValues As List(Of String)
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optionsValues = loadOptions()
        applyOptions()


    End Sub

    Private Sub applyOptions()
        txt_TimerMin.Text = Str(Int(optionsValues(1) / 60))
        txt_TimerSec.Text = Str(Int(optionsValues(2) Mod 60))
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

    Public Function loadOptions()
        options = My.Computer.FileSystem.ReadAllText(fileOptions)
        Return Split(options, "|").ToList
    End Function

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

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub btn_AppliquerOptions_Click(sender As Object, e As EventArgs) Handles btn_AppliquerOptions.Click
        Dim strFile As String
        optionsValues(1) = txt_TimerMin.Text
        optionsValues(2) = txt_TimerSec.Text
        strFile = optionsValues(0)
        For i = 1 To optionsValues.Count - 1
            strFile = strFile & "|" & optionsValues(i)
        Next
        My.Computer.FileSystem.WriteAllText(fileOptions, strFile, False)
    End Sub
End Class