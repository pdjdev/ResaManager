<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DevicePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DeviceNameLabel = New System.Windows.Forms.Label()
        Me.DetailLabel = New System.Windows.Forms.Label()
        Me.IPLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lef_shad_pan = New System.Windows.Forms.Panel()
        Me.left_shad = New System.Windows.Forms.PictureBox()
        Me.top_left_shad = New System.Windows.Forms.PictureBox()
        Me.bot_left_shad = New System.Windows.Forms.PictureBox()
        Me.rig_shad_pan = New System.Windows.Forms.Panel()
        Me.right_shad = New System.Windows.Forms.PictureBox()
        Me.top_rig_shad = New System.Windows.Forms.PictureBox()
        Me.bot_right_shad = New System.Windows.Forms.PictureBox()
        Me.DeviceUpdate = New System.ComponentModel.BackgroundWorker()
        Me.Anitimer = New System.Windows.Forms.Timer(Me.components)
        Me.DeviceMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu1PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu3EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu4DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu5ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.재시작ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IP주소출력ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarnPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelegramSend = New System.ComponentModel.BackgroundWorker()
        Me.DeviceResetLauncher = New System.ComponentModel.BackgroundWorker()
        Me.top_shad = New System.Windows.Forms.PictureBox()
        Me.bot_shad = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lef_shad_pan.SuspendLayout()
        CType(Me.left_shad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.top_left_shad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_left_shad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rig_shad_pan.SuspendLayout()
        CType(Me.right_shad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.top_rig_shad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_right_shad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeviceMenu.SuspendLayout()
        CType(Me.top_shad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_shad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeviceNameLabel
        '
        Me.DeviceNameLabel.AutoSize = True
        Me.DeviceNameLabel.Font = New System.Drawing.Font("맑은 고딕", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DeviceNameLabel.Location = New System.Drawing.Point(77, 6)
        Me.DeviceNameLabel.Name = "DeviceNameLabel"
        Me.DeviceNameLabel.Size = New System.Drawing.Size(146, 23)
        Me.DeviceNameLabel.TabIndex = 1
        Me.DeviceNameLabel.Text = "DeviceNameLabel"
        '
        'DetailLabel
        '
        Me.DetailLabel.AutoSize = True
        Me.DetailLabel.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DetailLabel.Location = New System.Drawing.Point(78, 31)
        Me.DetailLabel.Name = "DetailLabel"
        Me.DetailLabel.Size = New System.Drawing.Size(52, 17)
        Me.DetailLabel.TabIndex = 2
        Me.DetailLabel.Text = "로드 중"
        '
        'IPLabel
        '
        Me.IPLabel.AutoSize = True
        Me.IPLabel.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.IPLabel.Location = New System.Drawing.Point(79, 47)
        Me.IPLabel.Name = "IPLabel"
        Me.IPLabel.Size = New System.Drawing.Size(50, 17)
        Me.IPLabel.TabIndex = 3
        Me.IPLabel.Text = "IPLabel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IPLabel)
        Me.Panel1.Controls.Add(Me.DeviceNameLabel)
        Me.Panel1.Controls.Add(Me.DetailLabel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(358, 69)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ResaManager.My.Resources.Resources.deviceicon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.ResaManager.My.Resources.Resources.device_wait
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lef_shad_pan
        '
        Me.lef_shad_pan.Controls.Add(Me.left_shad)
        Me.lef_shad_pan.Controls.Add(Me.top_left_shad)
        Me.lef_shad_pan.Controls.Add(Me.bot_left_shad)
        Me.lef_shad_pan.Dock = System.Windows.Forms.DockStyle.Left
        Me.lef_shad_pan.Location = New System.Drawing.Point(0, 0)
        Me.lef_shad_pan.Name = "lef_shad_pan"
        Me.lef_shad_pan.Size = New System.Drawing.Size(10, 89)
        Me.lef_shad_pan.TabIndex = 6
        '
        'left_shad
        '
        Me.left_shad.BackgroundImage = Global.ResaManager.My.Resources.Resources.left
        Me.left_shad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.left_shad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.left_shad.Location = New System.Drawing.Point(0, 10)
        Me.left_shad.Name = "left_shad"
        Me.left_shad.Size = New System.Drawing.Size(10, 69)
        Me.left_shad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.left_shad.TabIndex = 7
        Me.left_shad.TabStop = False
        '
        'top_left_shad
        '
        Me.top_left_shad.BackgroundImage = Global.ResaManager.My.Resources.Resources.top_l
        Me.top_left_shad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.top_left_shad.Dock = System.Windows.Forms.DockStyle.Top
        Me.top_left_shad.Location = New System.Drawing.Point(0, 0)
        Me.top_left_shad.Name = "top_left_shad"
        Me.top_left_shad.Size = New System.Drawing.Size(10, 10)
        Me.top_left_shad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.top_left_shad.TabIndex = 6
        Me.top_left_shad.TabStop = False
        '
        'bot_left_shad
        '
        Me.bot_left_shad.BackgroundImage = Global.ResaManager.My.Resources.Resources.bot_l
        Me.bot_left_shad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bot_left_shad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bot_left_shad.Location = New System.Drawing.Point(0, 79)
        Me.bot_left_shad.Name = "bot_left_shad"
        Me.bot_left_shad.Size = New System.Drawing.Size(10, 10)
        Me.bot_left_shad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bot_left_shad.TabIndex = 5
        Me.bot_left_shad.TabStop = False
        '
        'rig_shad_pan
        '
        Me.rig_shad_pan.Controls.Add(Me.right_shad)
        Me.rig_shad_pan.Controls.Add(Me.top_rig_shad)
        Me.rig_shad_pan.Controls.Add(Me.bot_right_shad)
        Me.rig_shad_pan.Dock = System.Windows.Forms.DockStyle.Right
        Me.rig_shad_pan.Location = New System.Drawing.Point(368, 0)
        Me.rig_shad_pan.Name = "rig_shad_pan"
        Me.rig_shad_pan.Size = New System.Drawing.Size(10, 89)
        Me.rig_shad_pan.TabIndex = 7
        '
        'right_shad
        '
        Me.right_shad.BackgroundImage = Global.ResaManager.My.Resources.Resources.rig
        Me.right_shad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.right_shad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.right_shad.Location = New System.Drawing.Point(0, 10)
        Me.right_shad.Name = "right_shad"
        Me.right_shad.Size = New System.Drawing.Size(10, 69)
        Me.right_shad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.right_shad.TabIndex = 9
        Me.right_shad.TabStop = False
        '
        'top_rig_shad
        '
        Me.top_rig_shad.BackgroundImage = Global.ResaManager.My.Resources.Resources.top_r
        Me.top_rig_shad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.top_rig_shad.Dock = System.Windows.Forms.DockStyle.Top
        Me.top_rig_shad.Location = New System.Drawing.Point(0, 0)
        Me.top_rig_shad.Name = "top_rig_shad"
        Me.top_rig_shad.Size = New System.Drawing.Size(10, 10)
        Me.top_rig_shad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.top_rig_shad.TabIndex = 8
        Me.top_rig_shad.TabStop = False
        '
        'bot_right_shad
        '
        Me.bot_right_shad.BackgroundImage = Global.ResaManager.My.Resources.Resources.bot_r
        Me.bot_right_shad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bot_right_shad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bot_right_shad.Location = New System.Drawing.Point(0, 79)
        Me.bot_right_shad.Name = "bot_right_shad"
        Me.bot_right_shad.Size = New System.Drawing.Size(10, 10)
        Me.bot_right_shad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bot_right_shad.TabIndex = 7
        Me.bot_right_shad.TabStop = False
        '
        'DeviceUpdate
        '
        Me.DeviceUpdate.WorkerSupportsCancellation = True
        '
        'Anitimer
        '
        Me.Anitimer.Enabled = True
        Me.Anitimer.Interval = 10
        '
        'DeviceMenu
        '
        Me.DeviceMenu.BackColor = System.Drawing.Color.White
        Me.DeviceMenu.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DeviceMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1PauseToolStripMenuItem, Me.Menu2RefreshToolStripMenuItem, Me.Menu3EditToolStripMenuItem, Me.Menu4DeleteToolStripMenuItem, Me.Menu5ActionToolStripMenuItem})
        Me.DeviceMenu.Name = "DeviceMenu"
        Me.DeviceMenu.ShowImageMargin = False
        Me.DeviceMenu.Size = New System.Drawing.Size(180, 134)
        '
        'Menu1PauseToolStripMenuItem
        '
        Me.Menu1PauseToolStripMenuItem.Name = "Menu1PauseToolStripMenuItem"
        Me.Menu1PauseToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.Menu1PauseToolStripMenuItem.Text = "일시 정지"
        '
        'Menu2RefreshToolStripMenuItem
        '
        Me.Menu2RefreshToolStripMenuItem.Name = "Menu2RefreshToolStripMenuItem"
        Me.Menu2RefreshToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.Menu2RefreshToolStripMenuItem.Text = "새로 고침"
        Me.Menu2RefreshToolStripMenuItem.Visible = False
        '
        'Menu3EditToolStripMenuItem
        '
        Me.Menu3EditToolStripMenuItem.Name = "Menu3EditToolStripMenuItem"
        Me.Menu3EditToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.Menu3EditToolStripMenuItem.Text = "이 디바이스 편집"
        '
        'Menu4DeleteToolStripMenuItem
        '
        Me.Menu4DeleteToolStripMenuItem.Name = "Menu4DeleteToolStripMenuItem"
        Me.Menu4DeleteToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.Menu4DeleteToolStripMenuItem.Text = "이 디바이스 삭제"
        '
        'Menu5ActionToolStripMenuItem
        '
        Me.Menu5ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.재시작ToolStripMenuItem, Me.IP주소출력ToolStripMenuItem, Me.WarnPlayToolStripMenuItem})
        Me.Menu5ActionToolStripMenuItem.Name = "Menu5ActionToolStripMenuItem"
        Me.Menu5ActionToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.Menu5ActionToolStripMenuItem.Text = "이 디바이스를..."
        '
        '재시작ToolStripMenuItem
        '
        Me.재시작ToolStripMenuItem.Name = "재시작ToolStripMenuItem"
        Me.재시작ToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.재시작ToolStripMenuItem.Text = "재시작"
        '
        'IP주소출력ToolStripMenuItem
        '
        Me.IP주소출력ToolStripMenuItem.Name = "IP주소출력ToolStripMenuItem"
        Me.IP주소출력ToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.IP주소출력ToolStripMenuItem.Text = "IP 주소 출력"
        '
        'WarnPlayToolStripMenuItem
        '
        Me.WarnPlayToolStripMenuItem.Name = "WarnPlayToolStripMenuItem"
        Me.WarnPlayToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.WarnPlayToolStripMenuItem.Text = "대기 이상 경고음 출력"
        '
        'TelegramSend
        '
        Me.TelegramSend.WorkerSupportsCancellation = True
        '
        'DeviceResetLauncher
        '
        Me.DeviceResetLauncher.WorkerSupportsCancellation = True
        '
        'top_shad
        '
        Me.top_shad.BackgroundImage = Global.ResaManager.My.Resources.Resources.top
        Me.top_shad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.top_shad.Dock = System.Windows.Forms.DockStyle.Top
        Me.top_shad.Location = New System.Drawing.Point(10, 0)
        Me.top_shad.Name = "top_shad"
        Me.top_shad.Size = New System.Drawing.Size(358, 10)
        Me.top_shad.TabIndex = 5
        Me.top_shad.TabStop = False
        '
        'bot_shad
        '
        Me.bot_shad.BackgroundImage = Global.ResaManager.My.Resources.Resources.bot
        Me.bot_shad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bot_shad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bot_shad.Location = New System.Drawing.Point(10, 79)
        Me.bot_shad.Name = "bot_shad"
        Me.bot_shad.Size = New System.Drawing.Size(358, 10)
        Me.bot_shad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bot_shad.TabIndex = 4
        Me.bot_shad.TabStop = False
        '
        'DevicePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.top_shad)
        Me.Controls.Add(Me.bot_shad)
        Me.Controls.Add(Me.lef_shad_pan)
        Me.Controls.Add(Me.rig_shad_pan)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DevicePanel"
        Me.Size = New System.Drawing.Size(378, 89)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lef_shad_pan.ResumeLayout(False)
        CType(Me.left_shad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.top_left_shad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_left_shad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rig_shad_pan.ResumeLayout(False)
        CType(Me.right_shad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.top_rig_shad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_right_shad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeviceMenu.ResumeLayout(False)
        CType(Me.top_shad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_shad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DeviceNameLabel As Label
    Friend WithEvents DetailLabel As Label
    Friend WithEvents IPLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bot_shad As PictureBox
    Friend WithEvents top_shad As PictureBox
    Friend WithEvents lef_shad_pan As Panel
    Friend WithEvents left_shad As PictureBox
    Friend WithEvents top_left_shad As PictureBox
    Friend WithEvents bot_left_shad As PictureBox
    Friend WithEvents rig_shad_pan As Panel
    Friend WithEvents right_shad As PictureBox
    Friend WithEvents top_rig_shad As PictureBox
    Friend WithEvents bot_right_shad As PictureBox
    Friend WithEvents DeviceUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents Anitimer As Timer
    Friend WithEvents DeviceMenu As ContextMenuStrip
    Friend WithEvents Menu1PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu2RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu3EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu4DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TelegramSend As System.ComponentModel.BackgroundWorker
    Friend WithEvents Menu5ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 재시작ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IP주소출력ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeviceResetLauncher As System.ComponentModel.BackgroundWorker
    Friend WithEvents WarnPlayToolStripMenuItem As ToolStripMenuItem
End Class
