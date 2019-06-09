Public Class DevicePanel
    Dim BtCol As Integer = 235
    Dim NormCol As Integer = 235
    Dim mouseEntered As Boolean = False

    'Public DeviceData As String = Nothing

    Public DevName As String = Nothing

    Dim DevID As String = Nothing
    Dim DevIP As String = Nothing '얘 또한 현재값
    Dim DevIP_set As String = Nothing '이것이 설정했던 값이고 얘로만 탐색하도록 한다!!!
    Dim DevAuth As String = Nothing
    Dim Devpm25 As String = 0 '이거는 라이브 값이니 헷갈리지 않도록 주의!!!!
    Dim Devpm10 As String = 0
    Dim Devpm25_set As String = 0
    Dim Devpm10_set As String = 0
    Dim DevUpdate As Integer = 0
    Dim DevSettings As String = Nothing
    Public DevMode As String = "pause"

    Dim PrevDevFailCount As Integer = 0
    Dim DevFailCount As Integer = 0

    Dim PrevSensorFailCount As Integer = 0
    Dim SensorFailCount As Integer = 0

    Dim WarnCount As Integer = 0

    Dim RecentPush As String = "None"
    Dim telegramMessage As String = Nothing

    Dim updateTime As String = Nothing

    Public first As Boolean = True

    Dim DevGetDataOK As Boolean = False
    Dim isDeviceUpdateBusy As Boolean = False '백그라운드워커가 바쁠때

    Dim MeEnabled As Boolean = True


    Function Sleeptime(devupdate As Integer) As Integer
        If SensorFailCount > 0 Or DevFailCount > 0 Then
            '센서 실패시 -> 단 3초 간격으로 요청
            Return 3
        Else
            Select Case devupdate
                Case 0
                    Return 2
                Case 1
                    Return 5
                Case 2
                    Return 10
                Case 3
                    Return 30
                Case 4
                    Return 60

                Case Else
                    Return 10
            End Select
        End If
    End Function


    Private Sub DeviceUpdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DeviceUpdate.DoWork
        isDeviceUpdateBusy = True

        Dim count As Integer = 0
        DevGetDataOK = True

        Do While ((count < Sleeptime(DevUpdate)) And DevMode = "active" And first = False)
            Threading.Thread.Sleep(1000)
            count += 1
            'Beep()
        Loop

        If DevMode = "active" Then
            Try
                Dim devdata As String = resaCall(DevIP_set, DevAuth, "/info")
                devdata = getData(devdata, "infodata")

                Devpm25 = "-"
                Devpm10 = "-"

                If devdata.Contains("<id>") Then DevID = getData(devdata, "id")
                If devdata.Contains("<ip>") Then DevIP = getData(devdata, "ip")
                If devdata.Contains("<pm25>") Then Devpm25 = getData(devdata, "pm25")
                If devdata.Contains("<pm10>") Then Devpm10 = getData(devdata, "pm10")
            Catch ex As Exception
                DevGetDataOK = False
            End Try
            updateTime = DateTime.Now.ToString("HH:mm:ss")
        End If

        first = False

    End Sub

    Private Sub DeviceUpdate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DeviceUpdate.RunWorkerCompleted

        'Beep()
        isDeviceUpdateBusy = False

        If DevMode = "stop" Then
            Anitimer.Stop()
            Me.Dispose()
            GoTo donothing
        End If

        If DevMode = "active" Then

            If DevGetDataOK Then
                DevFailCount = 0

                If Devpm25 = "-" Or Devpm10 = "-" Then '센서실패시
                    SensorFailCount += 1
                    PictureBox1.Image = My.Resources.sensor_fail
                    DeviceNameLabel.Text = DevName + " (" + DevID + ")"
                    DetailLabel.Text = "센서 수신 실패 (3초 후 다시 시도, " + SensorFailCount.ToString + "번째 시도중...)"
                    IPLabel.Text = "IP: " + DevIP_set + " (" + DevIP + ") | " + updateTime + " (" + Sleeptime(DevUpdate).ToString + "초)"
                Else '괜찮을시
                    PictureBox1.Image = My.Resources.device_ok
                    DeviceNameLabel.Text = DevName + " (" + DevID + ")"
                    DetailLabel.Text = "현재 대기: pm2.5: " + Devpm25 + "㎍/㎥|pm10: " + Devpm10 + "㎍/㎥"
                    IPLabel.Text = "IP: " + DevIP_set + " (" + DevIP + ") | " + updateTime + " (" + Sleeptime(DevUpdate).ToString + "초)"
                    SensorFailCount = 0
                    '기준치 이상일때는 텍스트 빨강표시
                    If (Convert.ToDouble(Devpm10) >= Convert.ToDouble(Devpm10_set)) Or (Convert.ToDouble(Devpm25) >= Convert.ToDouble(Devpm25_set)) Then
                        DetailLabel.ForeColor = Color.Red
                    Else
                        DetailLabel.ForeColor = Color.Black
                    End If
                End If
            Else
                DevFailCount += 1
                PictureBox1.Image = My.Resources.device_fail
                DeviceNameLabel.Text = DevName + " (" + DevID + ")"
                DetailLabel.Text = "접속 실패 (3초 후 다시 시도, " + DevFailCount.ToString + "번째 시도중...)"
                IPLabel.Text = "IP: " + DevIP_set + " | " + updateTime
            End If


            If My.Settings.UseTelegramPush And DevSettings.Contains("1") Then Telegram_PushEventChk()
            If DevSettings.Contains("0") Then WarnSound_EventChk()

            DeviceUpdate.RunWorkerAsync()
        ElseIf DevMode = "pause" Then

            PictureBox1.Image = My.Resources.device_pause
            DeviceNameLabel.Text = DevName + " (" + DevID + ")"
            DetailLabel.Text = "일시 정지"
            IPLabel.Text = "IP: " + DevIP_set
        End If


donothing:


    End Sub

    Sub Telegram_PushEventChk()

        Dim Nowpush = Nothing

        Try

            'n번 이상 접속 실패시 알림 문자
            If Not My.Settings.ConnectTryCount = 0 Then
                If DevFailCount >= My.Settings.ConnectTryCount And Not RecentPush = "Fail" Then
                    '카운트를 기록 > 다시 성공했을때 문자를 주기 위해서
                    PrevDevFailCount = DevFailCount
                    Nowpush = "Fail"
                    GoTo dopush
                ElseIf DevFailCount = 0 And PrevDevFailCount > 0 Then
                    '현재 실패 카운트가 0이 되었고 이전에 실패했었다면
                    PrevDevFailCount = DevFailCount
                    Nowpush = "FailRestored"
                    GoTo dopush
                End If
            End If

            'n번 이상 센서 실패시 알림 문자
            If Not My.Settings.SensorTryCount = 0 Then
                If SensorFailCount >= My.Settings.SensorTryCount And Not RecentPush = "SFail" Then
                    '카운트를 기록 > 다시 성공했을때 문자를 주기 위해서
                    PrevSensorFailCount = SensorFailCount
                    Nowpush = "SFail"
                    GoTo dopush
                ElseIf SensorFailCount = 0 And PrevSensorFailCount > 0 Then
                    '현재 실패 카운트가 0이 되었고 이전에 실패했었다면
                    PrevSensorFailCount = SensorFailCount
                    Nowpush = "SFailRestored"
                    GoTo dopush
                End If
            End If

            'pm10,2.5 기준치 초과시

            If (Convert.ToDouble(Devpm10) >= Convert.ToDouble(Devpm10_set)) Or (Convert.ToDouble(Devpm25) >= Convert.ToDouble(Devpm25_set)) Then
                If Not RecentPush = "air" Then
                    '반복되는 일이 없도록
                    Nowpush = "air"
                    GoTo dopush
                End If
            End If

            'pm10,2.5 기준치 내려갔을시 (이때는 둘 다(and) 내려가야함!!!)
            If (Convert.ToDouble(Devpm10) < Convert.ToDouble(Devpm10_set)) And (Convert.ToDouble(Devpm25) < Convert.ToDouble(Devpm25_set)) Then
                If RecentPush = "air" Then
                    '반복되는 일이 없도록
                    Nowpush = "airRestored"
                    GoTo dopush
                End If
            End If

        Catch ex As Exception

            '예외 (대개로 센서 오류로 옴)
        End Try

        '여기까지 왔다는건 알림 보낼 거리가 없다는 것
        GoTo endtask

dopush:
        telegramMessage = "[Resa 알림] " + DateTime.Now.ToString("HH:mm:ss") + vbCrLf


        Select Case Nowpush
            Case "Fail"
                telegramMessage += "디바이스 [" + DevName + "," + DevIP_set + "] 에 접속이 " + My.Settings.ConnectTryCount.ToString + "번 이상 실패하였습니다. 디바이스의 인터넷 환경과 전원 상태 등을 확인해 주시기 바랍니다."
            Case "FailRestored"
                telegramMessage += "디바이스 [" + DevName + "," + DevIP_set + "] 에 다시 접속이 복구되었습니다."
            Case "SFail"
                telegramMessage += "디바이스 [" + DevName + "," + DevIP_set + "] 센서 인식이 " + My.Settings.SensorTryCount.ToString + "번 이상 실패하였습니다. 디바이스의 센서 상태를 확인해 주세요."
            Case "SFailRestored"
                telegramMessage += "디바이스 [" + DevName + "," + DevIP_set + "] 에 센서 인식이 복구되었습니다."
            Case "air"
                telegramMessage += "디바이스 [" + DevName + "," + DevIP_set + "] 에서 대기 오염 농도가 기준치(" + Devpm25_set + "," + Devpm10_set + ")를 넘어섰습니다!" + vbCrLf + "현재 농도: pm2.5: " + Devpm25 + "㎍/㎥|pm10: " + Devpm10 + "㎍/㎥"
            Case "airRestored"
                telegramMessage += "디바이스 [" + DevName + "," + DevIP_set + "] 에서 대기 오염 농도가 기준치 아래로 내려갔습니다." + vbCrLf + "현재 농도: pm2.5: " + Devpm25 + "㎍/㎥|pm10: " + Devpm10 + "㎍/㎥"
        End Select


        RecentPush = Nowpush

        TelegramSend.RunWorkerAsync()
endtask:

    End Sub

    Sub WarnSound_EventChk()

        Dim playsound As Boolean = False

        Try


            'pm10,2.5 기준치 초과시

            If (Convert.ToDouble(Devpm10) >= Convert.ToDouble(Devpm10_set)) Or (Convert.ToDouble(Devpm25) >= Convert.ToDouble(Devpm25_set)) Then
                playsound = True
                WarnCount += 1
            End If

            'pm10,2.5 기준치 내려갔을시 (이때는 둘 다(and) 내려가야함!!!)
            If (Convert.ToDouble(Devpm10) < Convert.ToDouble(Devpm10_set)) And (Convert.ToDouble(Devpm25) < Convert.ToDouble(Devpm25_set)) Then
                WarnCount = 0
            End If


            If playsound And WarnCount = 1 Then '두번째부터는 원상 복귀(다시 0으로 초기화 후 경고)되지않은한 경고 X
                resaCall(DevIP_set, DevAuth, "/warn")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DevicePanel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'MsgBox(11)
        LoadDevData()

    End Sub

    Sub LoadDevData()

        Dim DevData = midReturn("<device='" + DevName + "'>", "</device>", My.Settings.DeviceData)

        Try
            DevID = getData(DevData, "id")
            DevAuth = getData(DevData, "auth")
            DevIP_set = getData(DevData, "ip")
            Devpm25_set = getData(DevData, "pm25")
            Devpm10_set = getData(DevData, "pm10")
            DevUpdate = getData(DevData, "update")
            DevSettings = getData(DevData, "settings")
            DevMode = getData(DevData, "mode")
        Catch ex As Exception

        End Try

        'MsgBox(DevUpdate)
        'MsgBox(Sleeptime(DevUpdate))

        DeviceNameLabel.Text = DevName
        IPLabel.Text = DevIP

        If DevMode = "active" And Not isDeviceUpdateBusy Then
            DeviceUpdate.RunWorkerAsync()

        ElseIf DevMode = "pause" Then
            PictureBox1.Image = My.Resources.device_pause
            DeviceNameLabel.Text = DevName + " (" + DevID + ")"
            DetailLabel.Text = "일시 정지"
            IPLabel.Text = "IP: " + DevIP_set
        End If

    End Sub

    Sub RefreshDevData()

    End Sub

    Private Sub Anitimer_Tick(sender As Object, e As EventArgs) Handles Anitimer.Tick
        If mouseEntered Then
            If BtCol < 255 Then
                BtCol += 1
                Panel1.BackColor = Color.FromArgb(BtCol, BtCol, BtCol)
            End If
        Else
            If BtCol > NormCol Then
                BtCol -= 1
                Panel1.BackColor = Color.FromArgb(BtCol, BtCol, BtCol)
            End If
        End If


    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter,
        PictureBox1.MouseEnter, DeviceNameLabel.MouseEnter, DetailLabel.MouseEnter, IPLabel.MouseEnter
        mouseEntered = True
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave,
        PictureBox1.MouseLeave, DeviceNameLabel.MouseLeave, DetailLabel.MouseLeave, IPLabel.MouseLeave
        mouseEntered = False
    End Sub

    Private Sub DevicePanel_Click(sender As Object, e As EventArgs) Handles Panel1.Click,
        PictureBox1.Click, DeviceNameLabel.Click, DetailLabel.Click, IPLabel.Click
        DeviceMenu.Show(Cursor.Position)
    End Sub

    Private Sub Menu1PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu1PauseToolStripMenuItem.Click
        If DevMode = "active" Then '여기서 정지시키기
            UpdateDevData(DevName, DevID, DevAuth, DevIP, Devpm10_set, Devpm25_set, DevUpdate, DevSettings, "pause")
            DevMode = "pause"
            DeviceUpdate.CancelAsync()
        ElseIf DevMode = "pause" Then '여기서 다시 발동걸기
            first = True
            UpdateDevData(DevName, DevID, DevAuth, DevIP, Devpm10_set, Devpm25_set, DevUpdate, DevSettings, "active")
            DevMode = "active"
            DetailLabel.Text = "로드 중"
            PictureBox1.Image = My.Resources.device_wait
            DeviceUpdate.RunWorkerAsync()
        End If
    End Sub

    Private Sub Menu3EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu3EditToolStripMenuItem.Click

        Dim EditDeviceForm As New AddDevice

        EditDeviceForm.isEditing = True
        EditDeviceForm.editname = DevName
        EditDeviceForm.editPrevMode = DevMode
        EditDeviceForm.SetDesktopLocation(Main.Location.X + Main.Size.Width / 2 - AddDevice.Size.Width / 2,
                                         Main.Location.Y + Main.Size.Height / 2 - AddDevice.Size.Height / 2)
        EditDeviceForm.Show()

    End Sub

    Private Sub Menu4DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu4DeleteToolStripMenuItem.Click
        If MsgBox("정말로 삭제하시겠습니까?" + vbCr + "(재등록을 원할 시 새로 추가해야 합니다)", vbQuestion + vbYesNo) = vbYes Then
            DeleteDevData(DevName)
            DevMode = "stop"
            Main.DeviceList_Delete(Me.Name)
            Me.Dispose()
        End If
    End Sub

    Private Sub DeviceMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DeviceMenu.Opening
        If DevMode = "active" Then
            Menu1PauseToolStripMenuItem.Text = "일시 정지"
        ElseIf DevMode = "pause" Then
            Menu1PauseToolStripMenuItem.Text = "활성화"
        End If
    End Sub

    Private Sub TelegramSend_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TelegramSend.DoWork
        SendTMessage(My.Settings.TelegramChatID, telegramMessage)
    End Sub

    Private Sub Menu5ActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu5ActionToolStripMenuItem.Click

    End Sub

    Private Sub 재시작ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 재시작ToolStripMenuItem.Click
        If MsgBox("디바이스가 재시작됩니다. 재연결까지 약 10초 이상이 소요됩니다. 계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            DeviceRestartMgr.SetDesktopLocation(Main.Location.X + Main.Size.Width / 2 - DeviceRestartMgr.Size.Width / 2,
                                                Main.Location.Y + Main.Size.Height / 2 - DeviceRestartMgr.Size.Height / 2)
            DeviceRestartMgr.ipAdress = DevIP_set
            DeviceRestartMgr.auth = DevAuth
            DeviceRestartMgr.Show()
            DeviceResetLauncher.RunWorkerAsync()
            DevMode = "pause"
        End If
    End Sub

    Private Sub IP주소출력ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IP주소출력ToolStripMenuItem.Click
        If MsgBox("디바이스의 스피커로 로컬 IP의 주소가 출력됩니다. 계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            resaCall(DevIP_set, DevAuth, "/sayip")
            MsgBox("출력이 완료되었습니다.", vbInformation)
        End If
    End Sub

    '걍 기다리는놈
    Private Sub DeviceResetLauncher_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DeviceResetLauncher.DoWork
        Threading.Thread.Sleep(15000)
    End Sub

    Private Sub DeviceResetLauncher_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DeviceResetLauncher.RunWorkerCompleted
        DeviceRestartMgr.Close()
        '다시 발동
        UpdateDevData(DevName, DevID, DevAuth, DevIP, Devpm10_set, Devpm25_set, DevUpdate, DevSettings, "active")
        DevMode = "active"
        DetailLabel.Text = "로드 중"
        PictureBox1.Image = My.Resources.device_wait
        DeviceUpdate.RunWorkerAsync()
    End Sub

    Private Sub WarnPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarnPlayToolStripMenuItem.Click
        If MsgBox("디바이스의 스피커로 대기 이상 경고음이 출력됩니다. 계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            resaCall(DevIP_set, DevAuth, "/warn")
            MsgBox("출력이 완료되었습니다.", vbInformation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(Me.Name)
    End Sub
End Class
