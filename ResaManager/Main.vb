Imports System.Security.Principal

Public Class Main
    Dim CurrentPanel = 1
    Dim BT_activeColor As Color = Color.FromArgb(250, 250, 250)
    Dim BT_highlightColor As Color = Color.FromArgb(235, 235, 235)
    Dim BT_normalColor As Color = Color.FromArgb(224, 224, 224)

    Dim count = 0
    Dim DeviceItemData(255) As String

    Public FormActivated As Boolean = False

    Dim optionChanged As Boolean = False

    Dim debugcount As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles debugBT.Click

        Form1.debugging = True
        Form1.Opacity = 1
        Form1.WindowState = FormWindowState.Normal
        Form1.FormBorderStyle = FormBorderStyle.FixedSingle
        Form1.ShowInTaskbar = True

        Form1.Show()
        'Dim newPanel As New DevicePanel
        'newPanel.Dock = DockStyle.Top
        'ListPanel.Controls.Add(newPanel)
    End Sub

    Sub PanelSelector(panel As Integer)


        '설정 나오거나 들어올때를 위해서
        If CurrentPanel = 3 Then
            '설정에서 나올때
            If optionChanged Then
                If MsgBox("변경 사항을 저장하지 않으시겠습니까?", vbYesNo + vbQuestion) = vbNo Then
                    GoTo donothing
                End If
            End If
        ElseIf panel = 3 Then
            '설정으로 들어올때
            SensorTryCountNum.Value = My.Settings.SensorTryCount
            ConnectTryCountNum.Value = My.Settings.ConnectTryCount
            TimeoutNum.Value = My.Settings.ConnectTimeout
            TopmostChk.Checked = My.Settings.TopMost
            SetStartupChk.Checked = checkStartUp()
            optionChanged = False
            SaveSettingsBT.Enabled = False
        End If


        CurrentPanel = panel

        PN1.Hide()
        PN2.Hide()
        PN3.Hide()

        PNBT1.Image = My.Resources.bt1_0
        PNBT2.Image = My.Resources.bt2_0
        PNBT3.Image = My.Resources.bt3_0
        PNBT1.BackColor = BT_normalColor
        PNBT2.BackColor = BT_normalColor
        PNBT3.BackColor = BT_normalColor


        Select Case panel
            Case 1
                PN1.Show()
                PNBT1.BackColor = BT_activeColor
                PNBT1.Image = My.Resources.bt1_1
            Case 2
                PN2.Show()
                PNBT2.BackColor = BT_activeColor
                PNBT2.Image = My.Resources.bt2_1
            Case 3
                PN3.Show()
                PNBT3.BackColor = BT_activeColor
                PNBT3.Image = My.Resources.bt3_1
        End Select

donothing:

    End Sub

    Private Sub PNBT_MouseEnter(sender As Object, e As EventArgs) Handles PNBT1.MouseEnter, PNBT2.MouseEnter, PNBT3.MouseEnter
        Dim obj As PictureBox = sender

        Select Case obj.Name
            Case PNBT1.Name
                If Not CurrentPanel = 1 Then obj.BackColor = BT_highlightColor
            Case PNBT2.Name
                If Not CurrentPanel = 2 Then obj.BackColor = BT_highlightColor
            Case PNBT3.Name
                If Not CurrentPanel = 3 Then obj.BackColor = BT_highlightColor
        End Select
    End Sub

    Private Sub PNBT_MouseLeave(sender As Object, e As EventArgs) Handles PNBT1.MouseLeave, PNBT2.MouseLeave, PNBT3.MouseLeave
        Dim obj As PictureBox = sender

        Select Case obj.Name
            Case PNBT1.Name
                If Not CurrentPanel = 1 Then obj.BackColor = BT_normalColor
            Case PNBT2.Name
                If Not CurrentPanel = 2 Then obj.BackColor = BT_normalColor
            Case PNBT3.Name
                If Not CurrentPanel = 3 Then obj.BackColor = BT_normalColor
        End Select
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(1)

        If Not FormActivated Then

            TelegramPushChk.Checked = My.Settings.UseTelegramPush
            TelegramIDTextBox.Text = My.Settings.TelegramChatID
            TelegramPanel.Enabled = TelegramPushChk.Checked

            TimeoutNum.Maximum = Integer.MaxValue
            PanelSelector(CurrentPanel)

            '업데이트 목록 실행
            DeviceList_load()

            'Beep()
            TopMost = My.Settings.TopMost
            FormActivated = True
        End If
    End Sub

    Sub DeviceList_Delete(name As String)

        For Each ctrls As DevicePanel In ListPanel.Controls
            If ctrls.Name = name Then
                ctrls.DevMode = "stop"
                ctrls.Dispose()
                Controls.Remove(ctrls)
            End If
        Next

    End Sub

    '디바이스 항목을 새로 추가할때
    Sub DeviceList_Add(devData As String)
        If devData.Contains("<device='") Then

            '항목 추가
            Dim newPanel As New DevicePanel
            newPanel.Dock = DockStyle.Top
            newPanel.DevName = midReturn("<device='", "'>", devData)
            'newPanel.DeviceData = DeviceItemData(count)
            '디바이스의 이름으로 디바이스패널 이름 지정 -> 나중에 삭제할때 중요함!!
            newPanel.Name = "DevPanel_" + midReturn("<device='", "'>", devData)

            ListPanel.Controls.Add(newPanel)

        Else
            MsgBox("디바이스 추가 도중 문제가 발생했습니다." + vbCr + "다시 시도해 주십시오.", vbCritical)
        End If
    End Sub

    '우선 Rename을 한다 -> newDevData를 준 다음에 싹 갈아엎게 한다
    Sub DeviceList_Modify(prevDevName As String, newDevName As String)

        For Each ctrls As DevicePanel In ListPanel.Controls
            If ctrls.Name = prevDevName Then
                ctrls.Name = "DevPanel_" + newDevName
                ctrls.DevName = newDevName
                ctrls.first = True
                ctrls.LoadDevData()

                If ctrls.DevMode = "active" Then
                    ctrls.DetailLabel.Text = "로드 중"
                    ctrls.PictureBox1.Image = My.Resources.device_wait
                End If
            End If
        Next

    End Sub

    Sub DeviceList_load()

        For Each ctrls As DevicePanel In ListPanel.Controls
            ctrls.DevMode = "stop"
            ctrls.Dispose()
            Controls.Remove(ctrls)
        Next

        ListPanel.Controls.Clear()

        Dim tmpdata = My.Settings.DeviceData

ret:
        If tmpdata.Contains("<device='") Then

            Dim FirstStart As Long = tmpdata.IndexOf("<device='") + 1

            DeviceItemData(count) = Trim(Mid$(tmpdata, FirstStart, tmpdata.Substring(FirstStart).IndexOf("</device>") + 1))

            tmpdata = Mid(tmpdata, tmpdata.IndexOf("</device>") + 10, tmpdata.Length)

            '항목 추가
            Dim newPanel As New DevicePanel
            newPanel.Dock = DockStyle.Top
            newPanel.DevName = midReturn("<device='", "'>", DeviceItemData(count))
            'newPanel.DeviceData = DeviceItemData(count)
            '디바이스의 이름으로 디바이스패널 이름 지정 -> 나중에 삭제할때 중요함!!
            newPanel.Name = "DevPanel_" + midReturn("<device='", "'>", DeviceItemData(count))

            ListPanel.Controls.Add(newPanel)

            count += 1
            GoTo ret

        End If
    End Sub

    Private Sub PNBT_Click(sender As Object, e As EventArgs) Handles PNBT1.Click, PNBT2.Click, PNBT3.Click
        Dim obj As PictureBox = sender

        Select Case obj.Name
            Case PNBT1.Name
                PanelSelector(1)
            Case PNBT2.Name
                PanelSelector(2)
            Case PNBT3.Name
                PanelSelector(3)
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Form1.MainRestart()

        If MsgBox("모든 디바이스가 다시 로드됩니다. 계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            DeviceList_load()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddDevice.SetDesktopLocation(Me.Location.X + Me.Size.Width / 2 - AddDevice.Size.Width / 2,
                                     Me.Location.Y + Me.Size.Height / 2 - AddDevice.Size.Height / 2)
        AddDevice.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TelegramIDTextBox.Text = Nothing Then
            MsgBox("공개 채널 주소를 입력하여 주십시오", vbExclamation)
        Else
            TelegramIDTextBox.Enabled = False
            Button5.Enabled = False
            Button3.Enabled = False
            TelegramTest.RunWorkerAsync()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TelegramIDTextBox.Text = Nothing Then
            MsgBox("공개 채널 주소를 입력하여 주십시오", vbExclamation)
        Else
            My.Settings.UseTelegramPush = True
            My.Settings.TelegramChatID = TelegramIDTextBox.Text
            MsgBox("설정이 저장되었습니다.", vbInformation)
        End If
    End Sub

    Private Sub TelegramTest_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TelegramTest.DoWork
        SendTMessage(TelegramIDTextBox.Text, "Resa 알림 테스트 메시지입니다." + vbCrLf + "이 메시지를 수신하였다면 성공적으로 알림이 활성화 된 것입니다.")
    End Sub

    Private Sub TelegramTest_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles TelegramTest.RunWorkerCompleted
        MsgBox("전송이 완료되었습니다. 메시지를 확인해 주세요." + vbCr + vbCr + "만약 수신받지 못한 경우 다음을 확인하세요: " + vbCr + "- '공개 채널' 설정 여부" + vbCr + "- Resa 알리미 관리자 추가 여부", vbInformation)
        TelegramIDTextBox.Enabled = True
        Button5.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub TelegramPushChk_CheckedChanged(sender As Object, e As EventArgs) Handles TelegramPushChk.CheckedChanged

        If My.Settings.UseTelegramPush = True And TelegramPushChk.Checked = False Then
            If MsgBox("체크를 해제하면 알림이 비활성화됩니다. 계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
                My.Settings.UseTelegramPush = False
            Else
                TelegramPushChk.Checked = True
            End If
        End If

        TelegramPanel.Enabled = TelegramPushChk.Checked
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("현재 활성화되었던 모든 프로세스가 중지되고 종료됩니다. 계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            Form1.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub


    '시작프로그램 설정관련코드================================================================================================

    Public Function checkStartUp() As Boolean
        Dim destlnk As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\ResaManager.lnk"

        If IO.File.Exists(destlnk) Then
            If GetTargetPath(destlnk) = Application.ExecutablePath Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Sub SetStartup()
        Dim Path As String
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)

        Path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\ResaManager.lnk"

        Dim wsh As Object = CreateObject("WScript.Shell")

        Dim MyShortcut
        MyShortcut = wsh.CreateShortcut(Path)
        MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(Application.ExecutablePath)
        MyShortcut.WindowStyle = 4
        MyShortcut.Save()
    End Sub

    Sub RemoveStartup()
        My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\ResaManager.lnk")
    End Sub

    Function GetTargetPath(ByVal FileName As String)
        Dim Obj As Object
        Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object
        Shortcut = Obj.CreateShortcut(FileName)
        GetTargetPath = Shortcut.TargetPath
    End Function

    '시작프로그램 설정관련코드================================================================================================

    Private Sub OptionChanged_Event(sender As Object, e As EventArgs) Handles SensorTryCountNum.ValueChanged,
        ConnectTryCountNum.ValueChanged, TimeoutNum.ValueChanged, TopmostChk.CheckedChanged, SetStartupChk.CheckedChanged
        optionChanged = True
        SaveSettingsBT.Enabled = True
    End Sub

    '설정 저장
    Private Sub SaveSettingsBT_Click(sender As Object, e As EventArgs) Handles SaveSettingsBT.Click
        My.Settings.SensorTryCount = SensorTryCountNum.Value
        My.Settings.ConnectTryCount = ConnectTryCountNum.Value
        My.Settings.ConnectTimeout = TimeoutNum.Value
        My.Settings.TopMost = TopmostChk.Checked

        Try
            If SetStartupChk.Checked Then
                SetStartup()
            Else
                If checkStartUp() Then
                    RemoveStartup()
                End If
            End If
        Catch ex As Exception
            MsgBox("시작프로그램 설정 중 오류가 발생했습니다." + vbCr + "해당 설정을 제외한 설정은 저장됩니다.", vbCritical)
        End Try

        My.Settings.Save()
        My.Settings.Reload()

        TopMost = My.Settings.TopMost

        optionChanged = False
        SaveSettingsBT.Enabled = False

    End Sub

    Private Sub ResetBT_Click(sender As Object, e As EventArgs) Handles ResetBT.Click
        If MsgBox("정말로 초기화 하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            My.Settings.Reset()
            My.Settings.Save()

            MsgBox("프로그램이 종료됩니다. 다시 실행해 주세요.", vbInformation)
            Form1.Close()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        debugcount += 1

        If debugcount > 10 Then
            debugBT.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox(My.Resources.info, vbInformation)
    End Sub
End Class