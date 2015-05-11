<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.重新开始ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.难度设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.游戏规则ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.版本ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.版本信息ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.意见反馈ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Olive
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选项ToolStripMenuItem, Me.帮助ToolStripMenuItem, Me.版本ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '选项ToolStripMenuItem
        '
        Me.选项ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.重新开始ToolStripMenuItem, Me.难度设置ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.选项ToolStripMenuItem.Font = New System.Drawing.Font("华文楷体", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem"
        Me.选项ToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.选项ToolStripMenuItem.Text = "选项"
        '
        '重新开始ToolStripMenuItem
        '
        Me.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem"
        Me.重新开始ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.重新开始ToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.重新开始ToolStripMenuItem.Text = "重新开始"
        '
        '难度设置ToolStripMenuItem
        '
        Me.难度设置ToolStripMenuItem.Name = "难度设置ToolStripMenuItem"
        Me.难度设置ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.难度设置ToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.难度设置ToolStripMenuItem.Text = "难度设置"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.游戏规则ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Font = New System.Drawing.Font("华文楷体", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '游戏规则ToolStripMenuItem
        '
        Me.游戏规则ToolStripMenuItem.Name = "游戏规则ToolStripMenuItem"
        Me.游戏规则ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.游戏规则ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.游戏规则ToolStripMenuItem.Text = "游戏规则"
        '
        '版本ToolStripMenuItem
        '
        Me.版本ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.版本信息ToolStripMenuItem1, Me.意见反馈ToolStripMenuItem})
        Me.版本ToolStripMenuItem.Font = New System.Drawing.Font("华文楷体", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem"
        Me.版本ToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.版本ToolStripMenuItem.Text = "版本"
        '
        '版本信息ToolStripMenuItem1
        '
        Me.版本信息ToolStripMenuItem1.Name = "版本信息ToolStripMenuItem1"
        Me.版本信息ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.版本信息ToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.版本信息ToolStripMenuItem1.Text = "版本信息"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        '意见反馈ToolStripMenuItem
        '
        Me.意见反馈ToolStripMenuItem.Name = "意见反馈ToolStripMenuItem"
        Me.意见反馈ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.意见反馈ToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.意见反馈ToolStripMenuItem.Text = "意见反馈"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "扫雷"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 选项ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 难度设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 版本ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重新开始ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents 游戏规则ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 版本信息ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 意见反馈ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
