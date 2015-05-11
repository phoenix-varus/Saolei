Public Class Form6

    Private Sub Form6_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        Form2.Enabled = True
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\chenggong.png")
    End Sub
End Class