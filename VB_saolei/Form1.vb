Public Class Form1
    Public lieshu As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\huilang.jpg")
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lieshu = 6
        Me.Hide()
        Form2.Show()
        My.Application.DoEvents()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lieshu = 9
        Me.Hide()
        Form2.Show()
        My.Application.DoEvents()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lieshu = 12
        Me.Hide()
        Form2.Show()
        My.Application.DoEvents()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lieshu = 20
        Me.Hide()
        Form2.Show()
        My.Application.DoEvents()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        lieshu = 30
        Me.Hide()
        Form2.Show()
        My.Application.DoEvents()
    End Sub
    
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Form0.Close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
    End Sub
End Class
