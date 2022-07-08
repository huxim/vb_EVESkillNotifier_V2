<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkmsgbox = New System.Windows.Forms.CheckBox()
        Me.chkballoon = New System.Windows.Forms.CheckBox()
        Me.chksound = New System.Windows.Forms.CheckBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.txtadvance = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.rdoDefault = New System.Windows.Forms.RadioButton()
        Me.rdoCustom = New System.Windows.Forms.RadioButton()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chkAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.chkMinimize = New System.Windows.Forms.CheckBox()
        Me.chkAutorun = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdOk, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdApply, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(256, 342)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(291, 34)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(4, 4)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(88, 26)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.Text = "确定"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(100, 4)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 26)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "取消"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdApply
        '
        Me.cmdApply.Enabled = False
        Me.cmdApply.Location = New System.Drawing.Point(196, 4)
        Me.cmdApply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(91, 26)
        Me.cmdApply.TabIndex = 2
        Me.cmdApply.Text = "应用(&A)"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "波形文件 (*.wav)|*.wav|所有文件 (*.*)|*.*"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 15000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkmsgbox)
        Me.TabPage1.Controls.Add(Me.chkballoon)
        Me.TabPage1.Controls.Add(Me.chksound)
        Me.TabPage1.Controls.Add(Me.txtPath)
        Me.TabPage1.Controls.Add(Me.txtadvance)
        Me.TabPage1.Controls.Add(Me.cmdBrowse)
        Me.TabPage1.Controls.Add(Me.rdoDefault)
        Me.TabPage1.Controls.Add(Me.rdoCustom)
        Me.TabPage1.Controls.Add(Me.cmdTest)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(523, 282)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "提醒设置"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkmsgbox
        '
        Me.chkmsgbox.AutoSize = True
        Me.chkmsgbox.Location = New System.Drawing.Point(24, 55)
        Me.chkmsgbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkmsgbox.Name = "chkmsgbox"
        Me.chkmsgbox.Size = New System.Drawing.Size(113, 19)
        Me.chkmsgbox.TabIndex = 1
        Me.chkmsgbox.Text = "弹出窗口(&O)"
        Me.chkmsgbox.UseVisualStyleBackColor = True
        '
        'chkballoon
        '
        Me.chkballoon.AutoSize = True
        Me.chkballoon.Location = New System.Drawing.Point(24, 20)
        Me.chkballoon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkballoon.Name = "chkballoon"
        Me.chkballoon.Size = New System.Drawing.Size(113, 19)
        Me.chkballoon.TabIndex = 0
        Me.chkballoon.Text = "系统通知(&T)"
        Me.chkballoon.UseVisualStyleBackColor = True
        '
        'chksound
        '
        Me.chksound.AutoSize = True
        Me.chksound.Location = New System.Drawing.Point(24, 90)
        Me.chksound.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chksound.Name = "chksound"
        Me.chksound.Size = New System.Drawing.Size(113, 19)
        Me.chksound.TabIndex = 2
        Me.chksound.Text = "声音提示(&S)"
        Me.chksound.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(76, 195)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(199, 25)
        Me.txtPath.TabIndex = 3
        '
        'txtadvance
        '
        Me.txtadvance.Location = New System.Drawing.Point(133, 231)
        Me.txtadvance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtadvance.MaxLength = 2
        Me.txtadvance.Name = "txtadvance"
        Me.txtadvance.Size = New System.Drawing.Size(51, 25)
        Me.txtadvance.TabIndex = 11
        Me.txtadvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(401, 192)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(100, 29)
        Me.cmdBrowse.TabIndex = 4
        Me.cmdBrowse.Text = "浏览(&B)..."
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'rdoDefault
        '
        Me.rdoDefault.AutoSize = True
        Me.rdoDefault.Location = New System.Drawing.Point(53, 125)
        Me.rdoDefault.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(127, 19)
        Me.rdoDefault.TabIndex = 7
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "默认提示音(&D)"
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'rdoCustom
        '
        Me.rdoCustom.AutoSize = True
        Me.rdoCustom.Location = New System.Drawing.Point(53, 160)
        Me.rdoCustom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoCustom.Name = "rdoCustom"
        Me.rdoCustom.Size = New System.Drawing.Size(142, 19)
        Me.rdoCustom.TabIndex = 8
        Me.rdoCustom.TabStop = True
        Me.rdoCustom.Text = "自定义提示音(&C)"
        Me.rdoCustom.UseVisualStyleBackColor = True
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(297, 192)
        Me.cmdTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(99, 29)
        Me.cmdTest.TabIndex = 9
        Me.cmdTest.Text = "测试(&E)"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 235)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "分钟提醒我"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 235)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "在事件到期前"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkAutoUpdate)
        Me.TabPage3.Controls.Add(Me.chkMinimize)
        Me.TabPage3.Controls.Add(Me.chkAutorun)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Size = New System.Drawing.Size(523, 282)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "应用设置"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkAutoUpdate
        '
        Me.chkAutoUpdate.AutoSize = True
        Me.chkAutoUpdate.Location = New System.Drawing.Point(32, 175)
        Me.chkAutoUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAutoUpdate.Name = "chkAutoUpdate"
        Me.chkAutoUpdate.Size = New System.Drawing.Size(188, 19)
        Me.chkAutoUpdate.TabIndex = 2
        Me.chkAutoUpdate.Text = "启动后自动检查更新(&U)"
        Me.chkAutoUpdate.UseVisualStyleBackColor = True
        '
        'chkMinimize
        '
        Me.chkMinimize.AutoSize = True
        Me.chkMinimize.Location = New System.Drawing.Point(32, 115)
        Me.chkMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMinimize.Name = "chkMinimize"
        Me.chkMinimize.Size = New System.Drawing.Size(143, 19)
        Me.chkMinimize.TabIndex = 1
        Me.chkMinimize.Text = "启动后最小化(&M)"
        Me.chkMinimize.UseVisualStyleBackColor = True
        '
        'chkAutorun
        '
        Me.chkAutorun.AutoSize = True
        Me.chkAutorun.Location = New System.Drawing.Point(32, 52)
        Me.chkAutorun.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAutorun.Name = "chkAutorun"
        Me.chkAutorun.Size = New System.Drawing.Size(143, 19)
        Me.chkAutorun.TabIndex = 0
        Me.chkAutorun.Text = "伴随系统启动(&S)"
        Me.chkAutorun.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(531, 311)
        Me.TabControl1.TabIndex = 2
        '
        'Options
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(563, 391)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设置"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chkmsgbox As CheckBox
    Friend WithEvents chkballoon As CheckBox
    Friend WithEvents chksound As CheckBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents txtadvance As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents rdoDefault As RadioButton
    Friend WithEvents rdoCustom As RadioButton
    Friend WithEvents cmdTest As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents chkAutoUpdate As CheckBox
    Friend WithEvents chkMinimize As CheckBox
    Friend WithEvents chkAutorun As CheckBox
    Friend WithEvents TabControl1 As TabControl
End Class
