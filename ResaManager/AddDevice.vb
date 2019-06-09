Public Class AddDevice
    Dim CheckOK = False
    Dim DevGetDataOK = False

    '장치 최종프리뷰 업데이트값
    Dim devip As String = Nothing
    Dim devauth As String = Nothing

    Dim devid As String = Nothing '설정값이니 막 변경 금지!!!
    Dim localip As String = Nothing
    Dim pm25 As String = Nothing
    Dim pm10 As String = Nothing
    Dim ipstr As String = Nothing

    Dim updtime As String = Nothing

    Public isEditing As Boolean = False
    Public editname As String = Nothing
    Public editPrevMode As String = "pause"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not CheckOK Then
            DeviceCheck.RunWorkerAsync()
            AdressTextBox.Enabled = False
            AuthCodeBox.Enabled = False
            HideChkBox.Enabled = False
        End If
    End Sub

    Private Sub DeviceCheck_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DeviceCheck.DoWork
        CheckOK = False
        Dim tmpdata As String = resaCall(AdressTextBox.Text, AuthCodeBox.Text, "/info")

        If tmpdata = Nothing Then
            MsgBox("확인에 실패하였습니다." + vbCr + "주소가 맞는지 확인해 주시기 바랍니다.", vbCritical)
        Else
            'MsgBox(tmpdata)

            If tmpdata.Contains("<infodata>") Then
                devip = AdressTextBox.Text
                devauth = AuthCodeBox.Text
                MsgBox("확인에 성공하였습니다. (기기명: " + getData(tmpdata, "id") + ")", vbInformation)
                CheckOK = True
            Else
                If tmpdata.Contains("<title>ResaDevice") Then
                    MsgBox("상호 인증 코드가 다릅니다.", vbCritical)
                Else
                    MsgBox("확인에 실패하였습니다." + vbCr + "주소가 맞는지 확인해 주시기 바랍니다.", vbCritical)
                End If
            End If

        End If
    End Sub

    Private Sub DeviceCheck_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DeviceCheck.RunWorkerCompleted
        If CheckOK Then
            DevPrevStatePanel.Show()
            DevicePrevUpdate.RunWorkerAsync()
            DetailPanel.Enabled = True
        Else
            DevPrevStatePanel.Hide()
            DevicePrevUpdate.CancelAsync()
            AdressTextBox.Enabled = True
            AuthCodeBox.Enabled = True
            HideChkBox.Enabled = True
            DetailPanel.Enabled = False
        End If
    End Sub

    Private Sub HideChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles HideChkBox.CheckedChanged
        AuthCodeBox.UseSystemPasswordChar = HideChkBox.Checked
    End Sub

    Private Sub AddDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isEditing And Not editname = Nothing Then '편집하는 것일시에
            If CheckDevDataExists(editname) Then

                DevPrevStatePanel.Show()
                CheckOK = True

                Text = "디바이스 편집"
                Label1.Text = "디바이스 편집"
                Button2.Text = "변경하기"

                Dim tmpdata = My.Settings.DeviceData

                'Clipboard.SetText(tmpdata)

                tmpdata = midReturn("<device='" + editname + "'>", "</mode>", tmpdata)
                devip = getData(tmpdata, "ip")
                devauth = getData(tmpdata, "auth")

                Button3.Hide()

                DevNameBox.Text = editname
                If tmpdata.Contains("<pm25>") Then pm25Updown.Value = Convert.ToInt32(getData(tmpdata, "pm25"))
                If tmpdata.Contains("<pm10>") Then pm10Updown.Value = Convert.ToInt32(getData(tmpdata, "pm10"))

                Dim settings As String = getData(tmpdata, "settings")
                Chk1_alert.Checked = settings.Contains("0")
                Chk2_telegram.Checked = settings.Contains("1")
                UpdateComboBox.SelectedIndex = Convert.ToInt32(getData(tmpdata, "update"))

                DevicePrevUpdate.RunWorkerAsync()


            End If

        Else


            DetailPanel.Enabled = False
            UpdateComboBox.SelectedIndex = 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If CheckOK Then

            '이름입력안함
            If DevNameBox.Text = Nothing Then
                MsgBox("디바이스의 고유 이름을 입력해 주십시오.", vbExclamation)
                GoTo donothing
            End If

            '편집 모드가 아닌데 이미 존재할시
            If CheckDevDataExists(DevNameBox.Text) And isEditing = False Then
                MsgBox("이미 존재하는 이름입니다. 다른 이름으로 지정하거나 해당 디바이스 설정을 지워 주시기 바랍니다.", vbExclamation)
                GoTo donothing
                '편집 모드인데 이미 존재할시 ->그것이 자신인지 확인
            ElseIf CheckDevDataExists(DevNameBox.Text) And isEditing = True Then
                If Not editname = DevNameBox.Text Then '수정한 이름이 자신이 아닌데도 일치하는 놈이존재 ->이거는 겹치는 것이다
                    MsgBox("이미 존재하는 이름입니다. 다른 이름으로 지정하거나 해당 디바이스 설정을 지워 주시기 바랍니다.", vbExclamation)
                    GoTo donothing
                End If
            End If

            'pm수치 너무 낮을때
            If pm10Updown.Value < 50 Or pm25Updown.Value < 50 Then
                If MsgBox("대기 알림 기준이 너무 낮습니다. 너무 잦게 알림이 울릴 수 있습니다." + vbCr + vbCr + "그래도 계속하시겠습니까?", vbExclamation + vbYesNo) = vbNo Then
                    GoTo donothing
                End If
            End If

            '셋팅값 만들기
            Dim settings As String = Nothing

            If Chk1_alert.Checked Then settings += "0"
            If Chk2_telegram.Checked Then settings += "1"

            If isEditing Then
                UpdateDevData(editname, devid, devauth, devip, pm10Updown.Value, pm25Updown.Value, UpdateComboBox.SelectedIndex, settings, "active")

                If Not editname = DevNameBox.Text Then '이름을 새로이 수정하는 경우
                    My.Settings.DeviceData = My.Settings.DeviceData.Replace("<device='" + editname + "'>", "<device='" + DevNameBox.Text + "'>")
                End If

                Main.DeviceList_Modify("DevPanel_" + editname, DevNameBox.Text)
            Else
                SaveDevData(DevNameBox.Text, devid, devauth, devip, pm10Updown.Value, pm25Updown.Value, UpdateComboBox.SelectedIndex, settings, "active")
                Main.DeviceList_Add(ReturnDevData(DevNameBox.Text, devid, devauth, devip, pm10Updown.Value, pm25Updown.Value, UpdateComboBox.SelectedIndex, settings, "active"))
            End If

            MsgBox("저장되었습니다.", vbInformation)

            '메인폼에 추가



        Else
            MsgBox("디바이스와 연결을 확인한 후 추가할 수 있습니다.", vbExclamation)
        End If

        '무작정 다시 로드하지 말고 추가하도록 하자
        'Main.DeviceList_load()
        Me.Close()

donothing:

    End Sub

    Private Sub DevicePrevUpdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DevicePrevUpdate.DoWork
        DevGetDataOK = True

        Threading.Thread.Sleep(1000)

        Try
            Dim devdata As String = resaCall(devip, devauth, "/info")
            'MsgBox(devdata)
            devdata = getData(devdata, "infodata")

            localip = "불러오기 실패"
            pm25 = "-"
            pm10 = "-"

            If devdata.Contains("<id>") Then devid = getData(devdata, "id")
            If devdata.Contains("<ip>") Then localip = getData(devdata, "ip")
            If devdata.Contains("<pm25>") Then pm25 = getData(devdata, "pm25")
            If devdata.Contains("<pm10>") Then pm10 = getData(devdata, "pm10")
        Catch ex As Exception
            DevGetDataOK = False
        End Try
        updtime = "업데이트: " + DateTime.Now.ToString("HH:mm:ss")

        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub DevicePrevUpdate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DevicePrevUpdate.RunWorkerCompleted
        If CheckOK Then
            If DevGetDataOK Then
                DeviceNameLabel.Text = "ID: " + devid
                AirStateLabel.Text = "현재 대기: pm2.5: " + pm25 + "㎍/㎥|pm10: " + pm10 + "㎍/㎥"
                DevIPLabel.Text = "로컬 IP: " + localip
            Else
                DeviceNameLabel.Text = "오류 발생 (4초 뒤 다시 시도)"
                AirStateLabel.Text = "현재 대기: "
                DevIPLabel.Text = "로컬 IP: "
            End If
            UpdateEventLabel.Text = updtime
            DevicePrevUpdate.RunWorkerAsync()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckOK = False
        AdressTextBox.Enabled = True
        AuthCodeBox.Enabled = True
        HideChkBox.Enabled = True
        DetailPanel.Enabled = False
        DeviceCheck.CancelAsync()
        DevicePrevUpdate.CancelAsync()
        DevPrevStatePanel.Hide()
    End Sub
End Class