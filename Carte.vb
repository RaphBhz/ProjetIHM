Public Class Carte
    Private image As Image
    Private imageValue As Integer
    Private retournee As Boolean
    Private carte As PictureBox

    Public Sub New(image As Image, carte As PictureBox, imgValue As Integer)
        Me.image = image
        Me.retournee = False
        Me.carte = carte
        Me.imageValue = imgValue
    End Sub

    Public Sub desactiverCarte()
        carte.Enabled = False
    End Sub

    Public Function getImgValue()
        Return Me.imageValue
    End Function

    Public Function getImage()
        Return Me.image
    End Function

    Public Sub setFaceBackCarte()
        If Not carte.Enabled Then
            Return
        End If
        carte.Image = My.Resources.ResourceManager.GetObject("BackCard")
        retournee = False

    End Sub

    Public Sub retournerCarte()
        If Not carte.Enabled Then
            Return
        End If

        carte.Image = image
        retournee = True

        'If Not retournee Then
        'carte.Image = image
        'retournee = True
        'Else
        'carte.Image = My.Resources.ResourceManager.GetObject("BackCard")
        'retournee = False
        'End If
    End Sub

    Public Function getEtatRetournee()
        Return Me.retournee
    End Function

    Public Function getPicBox() As PictureBox
        Return Me.carte
    End Function
End Class
