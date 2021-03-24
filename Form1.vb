Public Class FrmShapeSelect
    Private Sub FrmShapeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Width - 40, 0)
        p.AddArc(New Rectangle(Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Width, 40, Width, Height - 40)
        p.AddArc(New Rectangle(Width - 40, Height - 40, 40, 40), 0, 90)
        p.AddLine(Width - 40, Height, 40, Height)
        p.AddArc(New Rectangle(0, Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Region = New Region(p)
    End Sub


    Private Sub BtnSquare_Click(sender As Object, e As EventArgs) Handles BtnSquare.Click, BtnCircle.Click, BtnTriangle.Click
        Console.WriteLine(sender.Tags)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
