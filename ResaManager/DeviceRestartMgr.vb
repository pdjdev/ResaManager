Public Class DeviceRestartMgr
    Public ipAdress As String = Nothing
    Public auth As String = Nothing

    Private Sub DeviceRestartMgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            resaCall(ipAdress, auth, "/restart")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "디바이스가 완전히 재시작 될 때까지" + vbCr + "기다리는 중입니다...."
    End Sub
End Class