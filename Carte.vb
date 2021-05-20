Public Class Carte
    Private image As Image
    Private imageValue As Integer
    Private retournee As Boolean
    Private carte As PictureBox
    Private activee As Boolean

    Public Sub New(image As Image, carte As PictureBox, imgValue As Integer)
        Me.image = image
        Me.retournee = False
        Me.activee = True
        Me.carte = carte
        Me.imageValue = imgValue
    End Sub

    Public Sub desactiverCarte()
        Me.activee = False
        carte.Enabled = False
    End Sub

    Public Function getImgValue()
        Return Me.imageValue
    End Function

    Public Function getImage()
        Return Me.image
    End Function

    Public Sub retournerCarte()
        If Not activee Then
            Return
        End If

        If retournee = False Then
            carte.Image = image
            retournee = True
        Else
            carte.Image = My.Resources.ResourceManager.GetObject("BackCard")
            retournee = False
        End If
    End Sub

    Public Function getEtatRetournee()
        Return Me.retournee
    End Function

    Public Function getPicBox() As PictureBox
        Return Me.carte
    End Function
End Class
