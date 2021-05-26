Public Class Memory
    Const MAX_TIME As Integer = 60
    Private ticks As Integer
    Private cartes As New ArrayList
    Private cartesRetournees As New ArrayList
    Private rdmCartesTab() As Integer = New Integer(4) {0, 0, 0, 0, 0}
    Private score As Integer = 0
    Private joueur As Joueur

    Public Sub setJoueur(joueur As Joueur)
        Me.joueur = joueur
    End Sub


    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        If MsgBox("Abandonner la partie en cours ?", vbYesNo, "Abandon") = vbYes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNomJoueur.Text = Accueil.cbxNom.Text
        Timer.Interval = 1000
        Dim carteValue As Integer = 0

        For Each carte As PictureBox In gbxCartes.Controls
            carteValue = getRandomImg()
            cartes.Add(New Carte(My.Resources.ResourceManager.GetObject("Card" & carteValue), carte, carteValue))
        Next carte

    End Sub

    Private Function getRandomImg() As Integer
        Dim i As Integer = CInt(Int((5 * Rnd())))
        While rdmCartesTab(i) > 3
            i = CInt(Int((5 * Rnd())))
        End While
        rdmCartesTab(i) += 1

        Return i

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ticks += 1
        Dim minutes = Format$(Math.Round((MAX_TIME - ticks) / 60) - 1, "00")
        Dim secondes = Format$(Math.Round((MAX_TIME - ticks) Mod 60), "00")
        lblTimer.Text = minutes & " : " & secondes

        If isGameFinished() Then
            stopGame()
        End If
    End Sub

    Private Sub stopGame()
        Timer.Stop()
        For Each carte As Carte In cartes
            carte.desactiverCarte()
        Next carte
        MsgBox("La partie est finie")
        If joueur.isScoreBetter(score, ticks) Then
            joueur.setBestScore(score, ticks)
            ModuleJoueurs.saveJoueurs()
        End If
    End Sub

    Private Function isGameFinished() As Boolean
        If ticks = 60 Then
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

        If Timer.Enabled = False Then
            Timer.Enabled = True
            ticks = 0
            Timer.Start()
        End If

        Dim carte As Carte = getCarte(sender)
        carte.retournerCarte()

        If cartesRetournees.Contains(carte) = False Then
            cartesRetournees.Add(carte)
        Else
            cartesRetournees.Remove(carte)
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
            carte.retournerCarte()
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


End Class