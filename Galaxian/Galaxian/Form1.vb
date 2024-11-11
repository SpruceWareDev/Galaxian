Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim game As New Game(Me)
        game.Initialize()
        game.Run()
    End Sub
End Class
