Imports Telegram.Bot

Public Class Form1
    Dim TBot As TelegramBotClient = New TelegramBotClient("656975719:AAF88Um_PKxud2R3LJySOhNtFemwjF35Q1c")
    Public debugging As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Tme = TBot.GetMeAsync().Result

        'MsgBox("이름: " + Tme.FirstName)

        TBot.SendTextMessageAsync(TextBox2.Text, TextBox1.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not debugging Then
            Me.Opacity = 0
            WindowState = FormWindowState.Minimized
            FormBorderStyle = FormBorderStyle.None
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(webget("http://192.168.0.15/" + request.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteDevData(delnamebox.Text)
        MsgBox(My.Settings.DeviceData)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '백그라운드에서 Main을 로드

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UpdateDevData(delnamebox.Text, "id", "auth", "ip", 123, 123, 123, "123", "active")
        MsgBox(My.Settings.DeviceData)
    End Sub

    Private Sub ResaManager_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ResaManager.MouseDoubleClick
        Main.Show()
        Main.Activate()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not debugging Then Me.Hide()

        Main.Opacity = 0

        'Main.ShowInTaskbar = False
        'Main.Activate()
        Main.Show()
        Main.Hide()
        'Main.FormActivated = True
        'Main.ShowInTaskbar = True

        Main.Opacity = 1

        ResaManager.BalloonTipIcon = ToolTipIcon.None
        ResaManager.BalloonTipTitle = "Resa 매니저가 실행되었습니다"
        ResaManager.BalloonTipText = "트레이 아이콘을 더블 클릭하여 자세한 설정 열기"

        ResaManager.ShowBalloonTip(10000)
    End Sub

    Private Sub Menu_OpenMain_Click(sender As Object, e As EventArgs) Handles Menu_OpenMain.Click
        Main.Show()
        Main.Activate()
    End Sub

    Private Sub Menu_Exit_Click(sender As Object, e As EventArgs) Handles Menu_Exit.Click
        If MsgBox("현재 활성화되었던 모든 프로세스가 중지되고 종료됩니다. 계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Main.DeviceList_Add(ReturnDevData("디바이스" + DateTime.Now.ToString("yyyymmddHHmmss"), "Undefined", "0000", "localhost", 200, 200, 1, "01", "pause"))
        SaveDevData("디바이스" + DateTime.Now.ToString("yyyymmddHHmmss"), "Undefined", "0000", "localhost", 200, 200, 1, "01", "pause")
    End Sub
End Class
