Public Class FrmUtils
    Shared Sub RoundCorners(Form As Form)
        Dim Width = Form.Width
        Dim Height = Form.Height

        Form.FormBorderStyle = FormBorderStyle.None
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
        Form.Region = New Region(p)
    End Sub
End Class
