Public Class Form5

    Private Sub Form5_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        Form2.Enabled = True
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\shibai.jpg")
    End Sub
End Class