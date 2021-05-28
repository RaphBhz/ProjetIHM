'Classe représentant une carte
Public Class Carte
    'Image associée à la carte
    Private image As Image
    'L'identifiant de la carte
    Private imageValue As Integer
    'Booléen permet de savoir si la carte est retournée
    Private retournee As Boolean
    'La picturebox associée à la carte
    Private carte As PictureBox
    'Le suffixe de l'image
    Private imageName As String

    'Le constructeur d'une carte
    '@param image Image associée à la carte
    '@param carte carte associée à la carte
    '@param imgValue L'identifiant de la carte
    '@param imageName Le suffixe de l'image
    Public Sub New(image As Image, carte As PictureBox, imgValue As Integer, imageName As String)
        Me.image = image
        Me.retournee = False
        Me.carte = carte
        Me.imageValue = imgValue
        Me.imageName = imageName

    End Sub


    'Procédure permettant de désactiver la carte et de la rendre grise
    Public Sub desactiverCarte()
        carte.Enabled = False
        colorPicToGrey()
    End Sub

    'Fonction récupérant l'identifiant de la carte
    '@return L'identifiant de la carte
    Public Function getImgValue()
        Return Me.imageValue
    End Function

    'Fonction récupérant l'image de la carte
    '@return L'image de la carte
    Public Function getImage()
        Return Me.image
    End Function

    'Procédure permettant de remettre l'image arrière de la carte d'une carte
    Public Sub setFaceBackCarte()
        If Not carte.Enabled Then
            Return
        End If
        carte.Image = My.Resources.ResourceManager.GetObject("Back" & imageName)
        retournee = False

    End Sub

    'Procédure permettant de retourner une carte afin d'afficher son image
    Public Sub retournerCarte()
        If Not carte.Enabled Then
            Return
        End If

        carte.Image = image
        retournee = True

    End Sub

    'Procédure de rendre l'image de la carte en variations de gris
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

    'Fonction renvoyant l'attribut retournee
    '@return L'état retourné de la carte
    Public Function getEtatRetournee()
        Return Me.retournee
    End Function

    'Fonction renvoyant la pictureBox associée à la carte
    '@return La pictureBox associée à la carte
    Public Function getPicBox() As PictureBox
        Return Me.carte
    End Function
End Class
