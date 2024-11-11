Public Class Renderer

    Private Shared instance As Renderer

    Private _pictureBox As PictureBox
    Private _bitmap As Bitmap
    Private _graphics As Graphics

    Public Function Initialize(parent As Form1) As PictureBox
        _pictureBox = New PictureBox()
        With _pictureBox
            .Parent = parent
            .Dock = DockStyle.Fill
        End With
        _bitmap = New Bitmap(_pictureBox.Width, _pictureBox.Height)
        _pictureBox.Image = _bitmap
        _graphics = Graphics.FromImage(_bitmap)
        Return _pictureBox
    End Function

    Public Sub Render()
        _graphics.Clear(Color.Black)
        _graphics.FillRectangle(Brushes.White, 10, 10, 10, 10)
        _pictureBox.Image = _bitmap
    End Sub

    Public Shared Function GetInstance() As Renderer
        If instance Is Nothing Then
            instance = New Renderer()
        End If
        Return instance
    End Function
End Class
