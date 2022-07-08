<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.notiName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeFinish = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出XToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.视图VToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.窗口置顶TToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具TToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.循环计时器LToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.选项OToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.使用帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.检查更新UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于AToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        resources.ApplyResources(Me.SplitContainer1.Panel1, "SplitContainer1.Panel1")
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTimeNow)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        resources.ApplyResources(Me.SplitContainer1.Panel2, "SplitContainer1.Panel2")
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.TabStop = False
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'lblTimeNow
        '
        resources.ApplyResources(Me.lblTimeNow, "lblTimeNow")
        Me.lblTimeNow.Name = "lblTimeNow"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'SplitContainer2
        '
        resources.ApplyResources(Me.SplitContainer2, "SplitContainer2")
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        resources.ApplyResources(Me.SplitContainer2.Panel1, "SplitContainer2.Panel1")
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer2.Panel2
        '
        resources.ApplyResources(Me.SplitContainer2.Panel2, "SplitContainer2.Panel2")
        Me.SplitContainer2.Panel2.Controls.Add(Me.cmdStop)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cmdDel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cmdEdit)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cmdAdd)
        Me.SplitContainer2.TabStop = False
        '
        'ListView1
        '
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.notiName, Me.timeFinish})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Name = "ListView1"
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'notiName
        '
        resources.ApplyResources(Me.notiName, "notiName")
        '
        'timeFinish
        '
        resources.ApplyResources(Me.timeFinish, "timeFinish")
        '
        'cmdStop
        '
        resources.ApplyResources(Me.cmdStop, "cmdStop")
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdDel
        '
        resources.ApplyResources(Me.cmdDel, "cmdDel")
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        resources.ApplyResources(Me.cmdEdit, "cmdEdit")
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        resources.ApplyResources(Me.cmdAdd, "cmdAdd")
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem1, Me.视图VToolStripMenuItem1, Me.工具TToolStripMenuItem1, Me.帮助HToolStripMenuItem1})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        '文件FToolStripMenuItem1
        '
        resources.ApplyResources(Me.文件FToolStripMenuItem1, "文件FToolStripMenuItem1")
        Me.文件FToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出XToolStripMenuItem1})
        Me.文件FToolStripMenuItem1.Name = "文件FToolStripMenuItem1"
        '
        '退出XToolStripMenuItem1
        '
        resources.ApplyResources(Me.退出XToolStripMenuItem1, "退出XToolStripMenuItem1")
        Me.退出XToolStripMenuItem1.Name = "退出XToolStripMenuItem1"
        '
        '视图VToolStripMenuItem1
        '
        resources.ApplyResources(Me.视图VToolStripMenuItem1, "视图VToolStripMenuItem1")
        Me.视图VToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.窗口置顶TToolStripMenuItem1})
        Me.视图VToolStripMenuItem1.Name = "视图VToolStripMenuItem1"
        '
        '窗口置顶TToolStripMenuItem1
        '
        resources.ApplyResources(Me.窗口置顶TToolStripMenuItem1, "窗口置顶TToolStripMenuItem1")
        Me.窗口置顶TToolStripMenuItem1.CheckOnClick = True
        Me.窗口置顶TToolStripMenuItem1.Name = "窗口置顶TToolStripMenuItem1"
        '
        '工具TToolStripMenuItem1
        '
        resources.ApplyResources(Me.工具TToolStripMenuItem1, "工具TToolStripMenuItem1")
        Me.工具TToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.循环计时器LToolStripMenuItem1, Me.选项OToolStripMenuItem1})
        Me.工具TToolStripMenuItem1.Name = "工具TToolStripMenuItem1"
        '
        '循环计时器LToolStripMenuItem1
        '
        resources.ApplyResources(Me.循环计时器LToolStripMenuItem1, "循环计时器LToolStripMenuItem1")
        Me.循环计时器LToolStripMenuItem1.Name = "循环计时器LToolStripMenuItem1"
        '
        '选项OToolStripMenuItem1
        '
        resources.ApplyResources(Me.选项OToolStripMenuItem1, "选项OToolStripMenuItem1")
        Me.选项OToolStripMenuItem1.Name = "选项OToolStripMenuItem1"
        '
        '帮助HToolStripMenuItem1
        '
        resources.ApplyResources(Me.帮助HToolStripMenuItem1, "帮助HToolStripMenuItem1")
        Me.帮助HToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.使用帮助HToolStripMenuItem, Me.检查更新UToolStripMenuItem, Me.关于AToolStripMenuItem1})
        Me.帮助HToolStripMenuItem1.Name = "帮助HToolStripMenuItem1"
        '
        '使用帮助HToolStripMenuItem
        '
        resources.ApplyResources(Me.使用帮助HToolStripMenuItem, "使用帮助HToolStripMenuItem")
        Me.使用帮助HToolStripMenuItem.Name = "使用帮助HToolStripMenuItem"
        '
        '检查更新UToolStripMenuItem
        '
        resources.ApplyResources(Me.检查更新UToolStripMenuItem, "检查更新UToolStripMenuItem")
        Me.检查更新UToolStripMenuItem.Name = "检查更新UToolStripMenuItem"
        '
        '关于AToolStripMenuItem1
        '
        resources.ApplyResources(Me.关于AToolStripMenuItem1, "关于AToolStripMenuItem1")
        Me.关于AToolStripMenuItem1.Name = "关于AToolStripMenuItem1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'NotifyIcon1
        '
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        '
        'ContextMenuStrip1
        '
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 视图VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 窗口置顶TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 工具TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 选项OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Google日历GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 在线帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblTimeNow As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents 循环计时器LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents notiName As System.Windows.Forms.ColumnHeader
    Friend WithEvents timeFinish As System.Windows.Forms.ColumnHeader
    Friend WithEvents 文件FToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 视图VToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 窗口置顶TToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 工具TToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 循环计时器LToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 选项OToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 使用帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 检查更新UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label22 As System.Windows.Forms.Label


End Class
