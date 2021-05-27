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
        colorPicToGrey()
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

    End Sub

    Private Sub colorPicToGrey()
        Dim pic As Bitmap = New Bitmap(carte.Image)
        Dim gray = New Bitmap(pic.Width, pic.Height)

        For x As Integer = 0 To (pic.Width) - 1
            For y As Integer = 0 To (pic.Height) - 1
                Dim c As Color = pic.GetPixel(x, y)
                Dim d As Integer = (CInt(c.R) + CInt(c.G) + CInt(c.B)) \ 3
                gray.SetPixel(x, y, Color.FromArgb(d, d, d))
            Next
        Next

        carte.Image = gray
    End Sub

    Public Function getEtatRetournee()
        Return Me.retournee
    End Function

    Public Function getPicBox() As PictureBox
        Return Me.carte
    End Function
End Class
