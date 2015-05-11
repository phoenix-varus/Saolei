Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\lei.jpg")
    End Sub
End Class