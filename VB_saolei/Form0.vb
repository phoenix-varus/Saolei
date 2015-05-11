Public Class Form0
    Dim a As Integer
    Private Sub Form0_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\kaichang.mp4"
        a = 0
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub AxWindowsMediaPlayer1_MediaChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_MediaChangeEvent) Handles AxWindowsMediaPlayer1.MediaChange
        a = a + 1
        If a = 3 Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class