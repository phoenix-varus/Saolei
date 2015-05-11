Public Class Form2
    Dim tb(1000) As TextBox
    Dim bt(1000) As Button
    Dim i As Integer
    Dim zongshu As Integer
    Dim hangshu As Integer
    Dim tb1 As TextBox
    Dim tb2 As TextBox
    Dim lb1 As Label
    Dim lb2 As Label
    Dim biaoji As Integer
    '--------------------------------------------------------------------------------支持系统关闭图标关闭所有进程
    Private Sub Form2_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        If biaoji = 0 Then
            Me.Close()
            Form0.Close()
            Form1.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Form6.Close()
        End If
    End Sub
    '-----------------------------------------------------------------------------------------
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------------------------------------------------------获取难度级别进行初始化
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        biaoji = 0
        hangshu = Form1.lieshu
        zongshu = hangshu * hangshu
        Me.Width = 30 + 20 * hangshu
        Me.Height = 105 + 20 * hangshu
        '------------------------------------------------------------------------------
        '-----------------------------------------------------------------------------雷区的初始化排版
        tb(zongshu) = New TextBox
        bt(zongshu) = New Button
        For i = 0 To zongshu - 1
            bt(i) = New Button
            bt(i).Size = New Size(20, 20)
            bt(i).Left = 10 + (i Mod hangshu) * 20
            bt(i).Top = 35 + (i - (i Mod hangshu)) / hangshu * 20
            bt(i).BackColor = Color.DeepSkyBlue
            Me.Controls.Add(bt(i))
            AddHandler bt(i).MouseDown, AddressOf Mouse_Down
            tb(i) = New TextBox
            tb(i).Size = New Size(20, 20)
            tb(i).Left = 10 + (i Mod hangshu) * 20
            tb(i).Top = 35 + (i - (i Mod hangshu)) / hangshu * 20
            tb(i).Enabled = False
            tb(i).BackColor = Color.SkyBlue
            Me.Controls.Add(tb(i))
        Next
        '-----------------------------------------------------------------------------------
        '----------------------------------------------------------------------------计数器textbox的添加
        tb1 = New TextBox
        tb1.Width = 40
        tb1.Height = 20
        tb1.Left = 10
        tb1.Top = 40 + 20 * hangshu
        tb1.Enabled = False
        tb1.BackColor = Color.Gold
        Me.Controls.Add(tb1)
        tb1.Text = (zongshu - (zongshu Mod 8)) / 8
        lb1 = New Label
        lb1.Width = 20
        lb1.Height = 20
        lb1.Left = 50
        lb1.Top = 45 + 20 * hangshu
        lb1.Text = "雷"
        lb1.ForeColor = Color.Red
        Me.Controls.Add(lb1)
        '---------------------------------------------------------------------------------
        '-----------------------------------------------------------------------------计时器textbox的添加
        tb2 = New TextBox
        tb2.Width = 40
        tb2.Height = 20
        tb2.Left = 10 + 20 * (hangshu - 2)
        tb2.Top = 40 + 20 * hangshu
        tb2.Enabled = False
        tb2.BackColor = Color.Gold
        Me.Controls.Add(tb2)
        Timer1.Enabled = True
        tb2.Text = 0
        lb2 = New Label
        lb2.Width = 20
        lb2.Height = 20
        lb2.Left = 10 + 20 * (hangshu - 3)
        lb2.Top = 45 + 20 * hangshu
        lb2.Text = "时"
        lb2.ForeColor = Color.Green
        Me.Controls.Add(lb2)
        '---------------------------------------------------------------------------------
        Lei()
        Panding()
        jishu()
    End Sub
    '-----------------------------------------------------------------------------------随机对雷区布雷操作
    Public Sub Lei()
        Dim lei((zongshu - (zongshu Mod 8)) / 8) As Integer
        For i = 0 To (zongshu - (zongshu Mod 8)) / 8 - 1
            Randomize()
            lei(i) = Int((zongshu - 1) * Rnd())
        Next
        For i = 0 To (zongshu - (zongshu Mod 8)) / 8 - 1
            For j = 0 To (zongshu - (zongshu Mod 8)) / 8 - 1
                If lei(i) = lei(j) And i <> j Then
                    lei(j) = Int((zongshu - 1) * Rnd())
                End If
            Next
        Next
        '--------------------------------------------
        For i = 0 To (zongshu - (zongshu Mod 8)) / 8 - 1
            tb(lei(i)).Text = "۞"
        Next

        For i = 0 To zongshu - 1
            If tb(i).Text = "۞" Then

            Else
                tb(i).Text = 0
            End If
        Next
        '----------------------------------------------------------------------------------
    End Sub
    '---------------------------------------------------------------------------------雷周围的数字的计算
    Public Sub Panding()
        For i = 0 To zongshu - 1
            If tb(i).Text = "۞" Then
                If (i - (hangshu + 1)) >= 0 Then
                    If tb(i - (hangshu + 1)).Text <> "۞" And (i - (hangshu + 1)) \ hangshu + 1 = i \ hangshu Then
                        tb(i - (hangshu + 1)).Text = tb(i - (hangshu + 1)).Text + 1
                    End If
                End If
                If (i - hangshu) >= 0 Then
                    If tb(i - hangshu).Text <> "۞" And (i - hangshu) \ hangshu + 1 = i \ hangshu Then
                        tb(i - hangshu).Text = tb(i - hangshu).Text + 1
                    End If
                End If
                If (i - (hangshu - 1)) >= 0 Then
                    If tb(i - (hangshu - 1)).Text <> "۞" And (i - (hangshu - 1)) \ hangshu + 1 = i \ hangshu Then
                        tb(i - (hangshu - 1)).Text = tb(i - (hangshu - 1)).Text + 1
                    End If
                End If
                If (i - 1) >= 0 Then
                    If tb(i - 1).Text <> "۞" And (i - 1) \ hangshu = i \ hangshu Then
                        tb(i - 1).Text = tb(i - 1).Text + 1
                    End If
                End If
                If (i + 1) <= zongshu - 1 Then
                    If tb(i + 1).Text <> "۞" And (i + 1) \ hangshu = i \ hangshu Then
                        tb(i + 1).Text = tb(i + 1).Text + 1
                    End If
                End If
                If (i + (hangshu - 1)) <= zongshu - 1 Then
                    If tb(i + (hangshu - 1)).Text <> "۞" And (i + (hangshu - 1)) \ hangshu - 1 = i \ hangshu Then
                        tb(i + (hangshu - 1)).Text = tb(i + (hangshu - 1)).Text + 1
                    End If
                End If
                If (i + hangshu) <= zongshu - 1 Then
                    If tb(i + hangshu).Text <> "۞" And (i + hangshu) \ hangshu - 1 = i \ hangshu Then
                        tb(i + hangshu).Text = tb(i + hangshu).Text + 1
                    End If
                End If
                If (i + (hangshu + 1)) <= zongshu - 1 Then
                    If tb(i + (hangshu + 1)).Text <> "۞" And (i + (hangshu + 1)) \ hangshu - 1 = i \ hangshu Then
                        tb(i + (hangshu + 1)).Text = tb(i + (hangshu + 1)).Text + 1
                    End If
                End If
            End If
        Next
    End Sub
    '---------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------鼠标左右键功能代码
    Public Sub Mouse_Down(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim a As Integer
        Dim b As Integer
        
        For i = 0 To zongshu - 1
            If DirectCast(sender, Button).Name = bt(i).Name Then
                Select Case e.Button
                    Case Windows.Forms.MouseButtons.Left
                        sender.visible = False
                        If tb(i).Text = "۞" And bt(i).Visible = False Then
                            a = 1
                            For j = 0 To zongshu - 1
                                If tb(j).Text = "۞" Then
                                    bt(j).Visible = False
                                End If
                                My.Application.DoEvents()
                            Next
                            Exit For
                            My.Application.DoEvents()
                        ElseIf tb(i).Text <> "۞" And bt(i).Visible = False Then
                            b = b + 1
                            For j = 0 To zongshu - 1
                                If (j - 1) >= 0 Then
                                    If bt(j).Visible = False And tb(j).Text = "0" And tb(j - 1).Text <> "۞" And (j \ hangshu) = (j - 1) \ hangshu Then
                                        bt(j - 1).Visible = False
                                    End If
                                End If
                                My.Application.DoEvents()
                                If (j + 1) <= zongshu - 1 Then
                                    If bt(j).Visible = False And tb(j).Text = "0" And tb(j + 1).Text <> "۞" And (j \ hangshu) = (j + 1) \ hangshu Then
                                        bt(j + 1).Visible = False
                                    End If
                                End If
                                My.Application.DoEvents()
                                If (j - hangshu) >= 0 Then
                                    If bt(j).Visible = False And tb(j).Text = "0" And tb(j - hangshu).Text <> "۞" And (j \ hangshu) - 1 = (j - hangshu) \ hangshu Then
                                        bt(j - hangshu).Visible = False
                                    End If
                                End If
                                My.Application.DoEvents()
                                If (j + hangshu) <= zongshu - 1 Then
                                    If bt(j).Visible = False And tb(j).Text = "0" And tb(j + hangshu).Text <> "۞" And (j \ hangshu) + 1 = (j + hangshu) \ hangshu Then
                                        bt(j + hangshu).Visible = False
                                    End If
                                End If
                                My.Application.DoEvents()
                            Next
                            My.Application.DoEvents()
                        End If
                    Case Windows.Forms.MouseButtons.Right
                        If sender.text = "" Then
                            sender.text = "☠"
                            Exit For
                        ElseIf sender.text = "☠" Then
                            sender.text = "?"
                            Exit For
                        ElseIf sender.text = "?" Then
                            sender.text = ""
                            Exit For
                        End If
                        If tb(i).Text <> "۞" And bt(i).Visible = False Then
                            b = b + 1
                        End If
                End Select
            End If
        Next
        My.Application.DoEvents()  
        '-------------------------------------------------------------------踩到雷的回应
        If a = 1 Then
            Me.Enabled = False
            Form5.Show()
        End If
        '------------------------------------------
        If b = zongshu - ((zongshu - (zongshu Mod 8)) / 8) And a <> 99 Then
            Me.Enabled = False
            Form6.Show()
        End If
        jishu()
        '------------------------------------------------------------------
    End Sub
    '-------------------------------------------------------------------------------------
    Private Sub jishu()
        Dim c As Integer
        c = (zongshu - (zongshu Mod 8)) / 8
        '--------------------------------------------------------------------------
        '计数器功能代码
        For i = 0 To zongshu - 1
            If bt(i).Text = "☠" Then
                c = c - 1
            End If
            My.Application.DoEvents()
            If bt(i).Text = "☠" And tb(i).Text <> "۞" And bt(i).Visible = False Then
                c = c + 1
            End If
        Next
        tb1.Text = c
        My.Application.DoEvents()
    End Sub
    '----------------------------------------------------------------------------------菜单栏功能代码实现
    Private Sub 重新开始ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重新开始ToolStripMenuItem.Click
        For i = 0 To zongshu - 1
            bt(i).Visible = True
            bt(i).Text = ""
            tb(i).Text = 0
        Next
        tb2.Text = 0
        Lei()
        Panding()
        tb1.Text = (zongshu - (zongshu Mod 8)) / 8
        jishu()
    End Sub
    Private Sub 难度设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 难度设置ToolStripMenuItem.Click
        biaoji = 1
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
        Form0.Close()
        Form1.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
    End Sub
    Private Sub 版本信息ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 版本信息ToolStripMenuItem1.Click
        Form4.Show()
    End Sub
    Private Sub 意见反馈ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 意见反馈ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://user.qzone.qq.com/997882763/infocenter")
    End Sub
    Private Sub 游戏规则ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 游戏规则ToolStripMenuItem.Click
        Form3.Show()
    End Sub
    '-----------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------计时器
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tb2.Text = tb2.Text + 1
    End Sub
End Class