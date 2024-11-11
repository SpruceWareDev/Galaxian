Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Game

    Private _form As Form1
    Private WithEvents _timer As Timer

    Public Sub New(parent As Form)
        _form = parent
    End Sub

    Public Sub Initialize()
        ' Setup form
        With _form
            .Text = "Galaxian"
            .Size = New Size(800, 600)
            .StartPosition = FormStartPosition.CenterScreen
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .MaximizeBox = False
            .MinimizeBox = False
            .KeyPreview = True
        End With
        ' Setup the timer
        _timer = New Timer()
        With _timer
            .Interval = 1000 / 60
            .Enabled = True
        End With
        AddHandler _timer.Tick, AddressOf Update
        ' Setup the renderer
        _form.Controls.Add(Renderer.GetInstance().Initialize(_form))
    End Sub

    Private Sub Update()
        Renderer.GetInstance().Render()
    End Sub

    Public Sub Run()
        _form.Show()
        _timer.Start()
    End Sub
End Class
