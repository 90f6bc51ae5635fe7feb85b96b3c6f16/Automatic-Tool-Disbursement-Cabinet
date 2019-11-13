Public Class BorderColor
    Protected Declare Function CreateRectRgn Lib "gdi32.dll" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
    Protected Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
    Protected Declare Function CreateSolidBrush Lib "gdi32.dll" (ByVal crColor As Integer) As Integer
    Protected Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    Protected Declare Function FrameRgn Lib "gdi32.dll" (ByVal hdc As Integer, ByVal hRgn As Integer, ByVal hBrush As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer

    Sub SetBorderColor(ByVal Ctl As Control, ByVal lColor As Color, Optional ByVal BorderWidth As Integer = 1)
        Dim i As Integer

        i = CreateRectRgn(BorderWidth, BorderWidth, Ctl.Width - BorderWidth, Ctl.Height - BorderWidth)
        SetWindowRgn(Ctl.Handle, i, False)

        i = CreateRectRgn(Ctl.Left, Ctl.Top, Ctl.Width + Ctl.Left, Ctl.Height + Ctl.Top)
        FrameRgn(GetDC(Ctl.Parent.Handle), i, CreateSolidBrush(CInt(ColorTranslator.ToWin32(lColor))), BorderWidth, BorderWidth)
    End Sub
End Class
