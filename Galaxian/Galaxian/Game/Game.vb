Public Class Game

    Private _form As Form1

    Public Sub New(parent As Form)
        _form = parent
    End Sub

    Public Sub Initialize()
        ' Init engine components
    End Sub

    Public Sub Run()
        _form.Show()
    End Sub
End Class
