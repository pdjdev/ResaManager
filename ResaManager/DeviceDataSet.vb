Module DeviceDataSet

    Function CheckDevDataExists(name As String)
        Return My.Settings.DeviceData.Contains("<device='" + name + "'>")
    End Function

    Sub SaveDevData(name As String, id As String, auth As String, ip As String, pm10 As Integer, pm25 As Integer, update As Integer, settings As String, mode As String)

        Dim savedata As String = Nothing

        savedata = "<device='" + name + "'>" + vbCr
        savedata += "<id>" + id + "</id>" + vbCr
        savedata += "<auth>" + auth + "</auth>" + vbCr
        savedata += "<ip>" + ip + "</ip>" + vbCr
        savedata += "<pm10>" + pm10.ToString + "</pm10>" + vbCr
        savedata += "<pm25>" + pm25.ToString + "</pm25>" + vbCr
        savedata += "<update>" + update.ToString + "</update>" + vbCr
        savedata += "<settings>" + settings + "</settings>" + vbCr
        savedata += "<mode>" + mode + "</mode>" + vbCr
        savedata += "</device>" + vbCr

        My.Settings.DeviceData += savedata

    End Sub

    Sub DeleteDevData(name As String)

        Try

            Dim tmpData As String = My.Settings.DeviceData
            Dim xst As Integer = tmpData.IndexOf("<device='" + name + "'>") + 1
            Dim xend As Integer = Mid(tmpData, xst).IndexOf("</device>") + xst + 9
            tmpData = tmpData.Replace(Mid(tmpData, xst, xend), Nothing)
            My.Settings.DeviceData = tmpData

        Catch ex As Exception
            MsgBox("디바이스 정보 삭제에 실패하였습니다.", vbCritical)

        End Try

    End Sub

    Function ReturnDevData(name As String, id As String, auth As String, ip As String, pm10 As Integer, pm25 As Integer, update As Integer, settings As String, mode As String) As String

        Dim savedata As String = Nothing

        savedata = "<device='" + name + "'>" + vbCr
        savedata += "<id>" + id + "</id>" + vbCr
        savedata += "<auth>" + auth + "</auth>" + vbCr
        savedata += "<ip>" + ip + "</ip>" + vbCr
        savedata += "<pm10>" + pm10.ToString + "</pm10>" + vbCr
        savedata += "<pm25>" + pm25.ToString + "</pm25>" + vbCr
        savedata += "<update>" + update.ToString + "</update>" + vbCr
        savedata += "<settings>" + settings + "</settings>" + vbCr
        savedata += "<mode>" + mode + "</mode>" + vbCr
        savedata += "</device>" + vbCr

        Return savedata
    End Function

    Sub UpdateDevData(name As String, id As String, auth As String, ip As String, pm10 As Integer, pm25 As Integer, update As Integer, settings As String, mode As String)

        Dim savedata As String = Nothing

        savedata = "<device='" + name + "'>" + vbCr
        savedata += "<id>" + id + "</id>" + vbCr
        savedata += "<auth>" + auth + "</auth>" + vbCr
        savedata += "<ip>" + ip + "</ip>" + vbCr
        savedata += "<pm10>" + pm10.ToString + "</pm10>" + vbCr
        savedata += "<pm25>" + pm25.ToString + "</pm25>" + vbCr
        savedata += "<update>" + update.ToString + "</update>" + vbCr
        savedata += "<settings>" + settings + "</settings>" + vbCr
        savedata += "<mode>" + mode + "</mode>" + vbCr
        savedata += "</device>" + vbCr


        Try

            Dim tmpData As String = My.Settings.DeviceData
            Dim xst As Integer = tmpData.IndexOf("<device='" + name + "'>") + 1
            Dim xend As Integer = Mid(tmpData, xst).IndexOf("</device>") + xst + 9
            tmpData = tmpData.Replace(Mid(tmpData, xst, xend), savedata)
            My.Settings.DeviceData = tmpData

        Catch ex As Exception
            MsgBox("디바이스 정보 업데이트에 실패하였습니다.", vbCritical)

        End Try


    End Sub

End Module
