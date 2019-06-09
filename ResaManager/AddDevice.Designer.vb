<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDevice
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDevice))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DevPrevStatePanel = New System.Windows.Forms.Panel()
        Me.UpdateEventLabel = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DevIPLabel = New System.Windows.Forms.Label()
        Me.DeviceNameLabel = New System.Windows.Forms.Label()
        Me.AirStateLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HideChkBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AuthCodeBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.DetailPanel = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UpdateComboBox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Chk1_alert = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Chk2_telegram = New System.Windows.Forms.CheckBox()
        Me.pm25Updown = New System.Windows.Forms.NumericUpDown()
        Me.DevNameBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pm10Updown = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeviceCheck = New System.ComponentModel.BackgroundWorker()
        Me.DevicePrevUpdate = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.DevPrevStatePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailPanel.SuspendLayout()
        CType(Me.pm25Updown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pm10Updown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DevPrevStatePanel)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.HideChkBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.AuthCodeBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.AdressTextBox)
        Me.Panel1.Controls.Add(Me.DetailPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel1.Size = New System.Drawing.Size(502, 340)
        Me.Panel1.TabIndex = 0
        '
        'DevPrevStatePanel
        '
        Me.DevPrevStatePanel.Controls.Add(Me.UpdateEventLabel)
        Me.DevPrevStatePanel.Controls.Add(Me.Button3)
        Me.DevPrevStatePanel.Controls.Add(Me.DevIPLabel)
        Me.DevPrevStatePanel.Controls.Add(Me.DeviceNameLabel)
        Me.DevPrevStatePanel.Controls.Add(Me.AirStateLabel)
        Me.DevPrevStatePanel.Controls.Add(Me.PictureBox1)
        Me.DevPrevStatePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DevPrevStatePanel.Location = New System.Drawing.Point(20, 20)
        Me.DevPrevStatePanel.Name = "DevPrevStatePanel"
        Me.DevPrevStatePanel.Size = New System.Drawing.Size(462, 94)
        Me.DevPrevStatePanel.TabIndex = 21
        Me.DevPrevStatePanel.Visible = False
        '
        'UpdateEventLabel
        '
        Me.UpdateEventLabel.AutoSize = True
        Me.UpdateEventLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.UpdateEventLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.UpdateEventLabel.Location = New System.Drawing.Point(462, 0)
        Me.UpdateEventLabel.Name = "UpdateEventLabel"
        Me.UpdateEventLabel.Size = New System.Drawing.Size(0, 15)
        Me.UpdateEventLabel.TabIndex = 9
        Me.UpdateEventLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(363, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 33)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "연결 취소"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DevIPLabel
        '
        Me.DevIPLabel.AutoSize = True
        Me.DevIPLabel.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DevIPLabel.Location = New System.Drawing.Point(86, 57)
        Me.DevIPLabel.Name = "DevIPLabel"
        Me.DevIPLabel.Size = New System.Drawing.Size(106, 17)
        Me.DevIPLabel.TabIndex = 7
        Me.DevIPLabel.Text = "로컬 IP: 로드중..."
        '
        'DeviceNameLabel
        '
        Me.DeviceNameLabel.AutoSize = True
        Me.DeviceNameLabel.Font = New System.Drawing.Font("맑은 고딕", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DeviceNameLabel.Location = New System.Drawing.Point(84, 17)
        Me.DeviceNameLabel.Name = "DeviceNameLabel"
        Me.DeviceNameLabel.Size = New System.Drawing.Size(113, 23)
        Me.DeviceNameLabel.TabIndex = 5
        Me.DeviceNameLabel.Text = "장치 로드중..."
        '
        'AirStateLabel
        '
        Me.AirStateLabel.AutoSize = True
        Me.AirStateLabel.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirStateLabel.Location = New System.Drawing.Point(85, 41)
        Me.AirStateLabel.Name = "AirStateLabel"
        Me.AirStateLabel.Size = New System.Drawing.Size(121, 17)
        Me.AirStateLabel.TabIndex = 6
        Me.AirStateLabel.Text = "현재 대기: 로드중..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ResaManager.My.Resources.Resources.deviceicon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.ResaManager.My.Resources.Resources.device_ok
        Me.PictureBox1.Location = New System.Drawing.Point(11, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(23, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(456, 1)
        Me.Panel3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "세부 설정"
        '
        'HideChkBox
        '
        Me.HideChkBox.AutoSize = True
        Me.HideChkBox.Checked = True
        Me.HideChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HideChkBox.Location = New System.Drawing.Point(310, 75)
        Me.HideChkBox.Name = "HideChkBox"
        Me.HideChkBox.Size = New System.Drawing.Size(62, 19)
        Me.HideChkBox.TabIndex = 2
        Me.HideChkBox.Text = "숨기기"
        Me.HideChkBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "상호 인증 코드"
        '
        'AuthCodeBox
        '
        Me.AuthCodeBox.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AuthCodeBox.Location = New System.Drawing.Point(214, 40)
        Me.AuthCodeBox.Name = "AuthCodeBox"
        Me.AuthCodeBox.Size = New System.Drawing.Size(158, 29)
        Me.AuthCodeBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "디바이스 주소 (IP)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "연결 확인"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdressTextBox
        '
        Me.AdressTextBox.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AdressTextBox.Location = New System.Drawing.Point(23, 40)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(185, 29)
        Me.AdressTextBox.TabIndex = 0
        '
        'DetailPanel
        '
        Me.DetailPanel.Controls.Add(Me.Label13)
        Me.DetailPanel.Controls.Add(Me.UpdateComboBox)
        Me.DetailPanel.Controls.Add(Me.Label12)
        Me.DetailPanel.Controls.Add(Me.Button2)
        Me.DetailPanel.Controls.Add(Me.Label11)
        Me.DetailPanel.Controls.Add(Me.Chk1_alert)
        Me.DetailPanel.Controls.Add(Me.Label10)
        Me.DetailPanel.Controls.Add(Me.Label9)
        Me.DetailPanel.Controls.Add(Me.Chk2_telegram)
        Me.DetailPanel.Controls.Add(Me.pm25Updown)
        Me.DetailPanel.Controls.Add(Me.DevNameBox)
        Me.DetailPanel.Controls.Add(Me.Label8)
        Me.DetailPanel.Controls.Add(Me.Label5)
        Me.DetailPanel.Controls.Add(Me.pm10Updown)
        Me.DetailPanel.Controls.Add(Me.Label6)
        Me.DetailPanel.Controls.Add(Me.Label7)
        Me.DetailPanel.Location = New System.Drawing.Point(12, 127)
        Me.DetailPanel.Name = "DetailPanel"
        Me.DetailPanel.Size = New System.Drawing.Size(478, 213)
        Me.DetailPanel.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(8, 189)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(325, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "너무 짧게 설정할 시 연결이 불안정할 수 있습니다."
        '
        'UpdateComboBox
        '
        Me.UpdateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UpdateComboBox.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.UpdateComboBox.FormattingEnabled = True
        Me.UpdateComboBox.Items.AddRange(New Object() {"매우 짧음 (2초)", "짧음 (5초)", "보통 (10초)", "길게 (30초)", "매우 길게 (1분)"})
        Me.UpdateComboBox.Location = New System.Drawing.Point(106, 160)
        Me.UpdateComboBox.Name = "UpdateComboBox"
        Me.UpdateComboBox.Size = New System.Drawing.Size(151, 25)
        Me.UpdateComboBox.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "업데이트 주기"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(367, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 40)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "추가하기"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "기기 설정"
        '
        'Chk1_alert
        '
        Me.Chk1_alert.AutoSize = True
        Me.Chk1_alert.Checked = True
        Me.Chk1_alert.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk1_alert.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Chk1_alert.Location = New System.Drawing.Point(11, 130)
        Me.Chk1_alert.Name = "Chk1_alert"
        Me.Chk1_alert.Size = New System.Drawing.Size(258, 24)
        Me.Chk1_alert.TabIndex = 18
        Me.Chk1_alert.Text = "초과시 경보 안내음 기기에서 출력"
        Me.Chk1_alert.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(191, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(276, 43)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "둘 중 하나 이상이 해당 수치를 넘어설 경우 알림이 전송됩니다. 값을 낮게 설정할 경우 너무 잦게 알림이 전송될 수 있으므로 주의 바랍니다."
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(8, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 31)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "목록, 연기 알림 메시지에서 표기될 명칭입니다 (예: 휴게소1)"
        '
        'Chk2_telegram
        '
        Me.Chk2_telegram.AutoSize = True
        Me.Chk2_telegram.Checked = True
        Me.Chk2_telegram.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk2_telegram.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Chk2_telegram.Location = New System.Drawing.Point(275, 130)
        Me.Chk2_telegram.Name = "Chk2_telegram"
        Me.Chk2_telegram.Size = New System.Drawing.Size(173, 24)
        Me.Chk2_telegram.TabIndex = 19
        Me.Chk2_telegram.Text = "텔레그램 알림 보내기"
        Me.Chk2_telegram.UseVisualStyleBackColor = True
        '
        'pm25Updown
        '
        Me.pm25Updown.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.pm25Updown.Location = New System.Drawing.Point(390, 28)
        Me.pm25Updown.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.pm25Updown.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.pm25Updown.Name = "pm25Updown"
        Me.pm25Updown.Size = New System.Drawing.Size(77, 29)
        Me.pm25Updown.TabIndex = 14
        Me.pm25Updown.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'DevNameBox
        '
        Me.DevNameBox.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DevNameBox.Location = New System.Drawing.Point(11, 28)
        Me.DevNameBox.Name = "DevNameBox"
        Me.DevNameBox.Size = New System.Drawing.Size(157, 29)
        Me.DevNameBox.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.Location = New System.Drawing.Point(333, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "pm2.5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "고유 이름"
        '
        'pm10Updown
        '
        Me.pm10Updown.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.pm10Updown.Location = New System.Drawing.Point(243, 28)
        Me.pm10Updown.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.pm10Updown.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.pm10Updown.Name = "pm10Updown"
        Me.pm10Updown.Size = New System.Drawing.Size(77, 29)
        Me.pm10Updown.TabIndex = 12
        Me.pm10Updown.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "대기 모니터링 알림 기준"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.Location = New System.Drawing.Point(190, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "pm10"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.Panel2.Size = New System.Drawing.Size(502, 69)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "디바이스 추가"
        '
        'DeviceCheck
        '
        Me.DeviceCheck.WorkerSupportsCancellation = True
        '
        'DevicePrevUpdate
        '
        Me.DevicePrevUpdate.WorkerSupportsCancellation = True
        '
        'AddDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(502, 409)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "디바이스 추가"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.DevPrevStatePanel.ResumeLayout(False)
        Me.DevPrevStatePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailPanel.ResumeLayout(False)
        Me.DetailPanel.PerformLayout()
        CType(Me.pm25Updown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pm10Updown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents HideChkBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AuthCodeBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DetailPanel As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Chk1_alert As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Chk2_telegram As CheckBox
    Friend WithEvents pm25Updown As NumericUpDown
    Friend WithEvents DevNameBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pm10Updown As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DeviceCheck As System.ComponentModel.BackgroundWorker
    Friend WithEvents DevPrevStatePanel As Panel
    Friend WithEvents DevIPLabel As Label
    Friend WithEvents DeviceNameLabel As Label
    Friend WithEvents AirStateLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DevicePrevUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button3 As Button
    Friend WithEvents UpdateEventLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents UpdateComboBox As ComboBox
    Friend WithEvents Label12 As Label
End Class
