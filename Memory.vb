Public Class Memory
    Private MAX_TIME As Integer
    Private ticks As Integer
    Private cartes As New ArrayList
    Private cartesRetournees As New ArrayList
    Private rdmCartesTab(19) As Integer
    Private score As Integer = 0
    Private timeScore As Integer = 0
    Private joueur As Joueur
    Private timerModified As Boolean
    Private optionsValues As Integer()
    Private timerOn As Boolean
    Private gameStopped As Integer = -1

    Public Sub setJoueur(joueur As Joueur)
        Me.joueur = joueur
    End Sub

    Private Sub applyOptions()
        If optionsValues(0) = 0 Then
            timerOn = False
        Else
            timerOn = True
        End If
        MAX_TIME = optionsValues(1) * 60 + optionsValues(2)
    End Sub

    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        If MsgBox("Abandonner la partie en cours ?", vbYesNo, "Abandon") = vbYes Then
            joueur.addTime(ticks)
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i = 0
        initRdmCartesTab()
        shuffleCartes()
        optionsValues = Options.loadOptions()
        applyOptions()
        lblNomJoueur.Text = Accueil.cbxNom.Text
        Timer.Interval = 1000
        Dim carteValue As Integer = 0

        Dim minutes = Format$(Int((MAX_TIME) / 60), "00")
        Dim secondes = Format$(Int((MAX_TIME) Mod 60), "00")
        lblTimer.Text = minutes & " : " & secondes

        If Not timerOn Then
            lblTimer.Text = "Désactivé"
        End If

        For Each carte As PictureBox In gbxCartes.Controls
            carteValue = rdmCartesTab(i)
            cartes.Add(New Carte(My.Resources.ResourceManager.GetObject("Card" & carteValue), carte, carteValue))
            i += 1
        Next carte

    End Sub

    Private Sub shuffleCartes()
        Dim r As Random = New Random()
        rdmCartesTab = rdmCartesTab.OrderBy(Function(a) r.Next()).ToArray
    End Sub

    Private Function getRandomImg(i As Integer) As Integer
        Return rdmCartesTab(i)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ticks += 1
        If timerOn Then
            Dim minutes = Format$(Int((MAX_TIME - ticks) / 60), "00")
            Dim secondes = Format$(Int((MAX_TIME - ticks) Mod 60), "00")
            lblTimer.Text = minutes & " : " & secondes
        End If

        If isGameFinished() Then
            joueur.addTime(ticks)
            stopGame()
        End If
    End Sub

    Private Sub stopGame()
        Timer.Stop()
        For Each carte As Carte In cartes
            carte.desactiverCarte()
        Next carte
        MsgBox("La partie est finie")
        If joueur.isScoreBetter(score, timeScore) Then
            joueur.setBestScore(score, timeScore)
            ModuleJoueurs.saveJoueurs()
        End If
        Me.Close()
        Accueil.Show()
    End Sub

    Private Function isGameFinished() As Boolean
        If ticks = MAX_TIME And timerOn Then
            Return True
        End If

        If score = 5 Then
            Return True
        End If

        Return False
    End Function


    Private Sub carte11_Click(sender As PictureBox, e As EventArgs) Handles carte11.Click, carte12.Click, carte13.Click, carte14.Click, carte15.Click,
            carte21.Click, carte22.Click, carte23.Click, carte24.Click, carte25.Click,
            carte31.Click, carte32.Click, carte33.Click, carte34.Click, carte35.Click,
            carte41.Click, carte42.Click, carte43.Click, carte44.Click, carte45.Click

        If gameStopped = 1 Then
            Return
        End If

        If Timer.Enabled = False Then
            gameStopped = 0
            Timer.Enabled = True
            ticks = 0
            Timer.Start()
        End If



        Dim carte As Carte = getCarte(sender)

        If carte.getEtatRetournee Then
            Return
        End If

        carte.retournerCarte()


        If cartesRetournees.Contains(carte) = False Then
            cartesRetournees.Add(carte)
        End If

        If cartesRetournees.Count = 0 Then
            Return
        End If

        If Not checkAllCartesRetournees() Then
            wait(1)
            'MsgBox("10")
            resetAllCartes()
        ElseIf areCartesCarre() Then
            lockAllCartesRetournees()
            score += 1
            timeScore = ticks
        End If

    End Sub

    Private Sub lockAllCartesRetournees()
        For Each carte As Carte In cartesRetournees
            carte.desactiverCarte()
        Next
        cartesRetournees.Clear()
    End Sub

    Private Function areCartesCarre() As Boolean
        Return cartesRetournees.Count = 4
    End Function

    Private Function checkAllCartesRetournees() As Boolean
        Dim carteRef As Integer = cartesRetournees(0).getImgValue()
        For Each carte As Carte In cartesRetournees
            If carte.getImgValue() <> carteRef Then
                Return False
            End If
        Next carte
        Return True
    End Function

    Private Sub resetAllCartes()

        For Each carte As Carte In cartesRetournees
            carte.setFaceBackCarte()
        Next carte
        cartesRetournees.Clear()

    End Sub

    Private Function getCarte(source As PictureBox) As Carte
        For Each carte As Carte In cartes
            If source.Equals(carte.getPicBox()) Then
                Return carte
            End If
        Next carte
    End Function

    Private Sub wait(secondes As Integer)
        Dim i As Integer
        For i = 1 To secondes
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub

    Private Sub initRdmCartesTab()
        For i = 0 To rdmCartesTab.Length - 1
            rdmCartesTab(i) = i Mod 5
        Next
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        If gameStopped = -1 Then
            MsgBox("Impossible de mettre une partie en pause si elle n'est pas commencée ou finie", vbOKOnly, "Pause")
            Return
        End If

        If gameStopped = 0 Then
            Timer.Stop()
            gameStopped = 1
        Else
            Timer.Start()
            gameStopped = 0
        End If

    End Sub
End Class
