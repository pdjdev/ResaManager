Imports System.IO
Imports System.Net
Imports Telegram.Bot

Module resaRequest

    Dim TBot As TelegramBotClient = New TelegramBotClient("") '텔레그램 봇 API

    Public Sub SendTMessage(chatID As String, message As String)
        If My.Computer.Network.IsAvailable Then
            Dim Tme = TBot.GetMeAsync().Result
            TBot.SendTextMessageAsync("@" + chatID, message)
        End If
    End Sub

    'web에서 문자열 가져오는 함수
    Public Function webget(url As String)
        Dim source = New System.Net.WebClient()

        source.Encoding = System.Text.Encoding.UTF8
        'MsgBox(url)

        Dim sourcestr As String = Nothing

        sourcestr = source.DownloadString(url)


        Return sourcestr
    End Function

    Public Function webReq(url As String)

        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Timeout = My.Settings.ConnectTimeout
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim status As String = response.StatusCode.ToString()


        Dim stream As Stream = response.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(stream)
        Dim text As String = reader.ReadToEnd()

        Return text

    End Function

    Public Function resaCall(adress As String, auth As String, request As String)
        Dim data As String = Nothing

        Try
            data = webReq("http://" + adress + "?/auth='" + auth + "'" + request)
        Catch ex As Exception

        End Try

        Return data
    End Function

    'xml형식 파일을 전체값에서 따로 추출하는 함수
    Public Function getData(datastr As String, name As String)

        Return midReturn("<" + name + ">", "</" + name + ">", datastr)

    End Function

    '중간의 문자열을 리턴하는 함수
    'Public Function midReturn(ByVal first As String, ByVal last As String, ByVal total As String) As String
    ' If last.Length < 1 Then
    '         midReturn = total.Substring(total.IndexOf(first))
    ' End If
    ' If first.Length < 1 Then
    '         midReturn = total.Substring(0, (total.IndexOf(last)))
    ' End If
    '
    '        midReturn = ((total.Substring(total.IndexOf(first), (total.IndexOf(last) - total.IndexOf(first)))).Replace(first, "")).Replace(last, "")
    '    End Function

    Public Function midReturn(ByVal first As String, ByVal last As String, ByRef total As String)
        If total.Contains(first) Then
            Dim FirstStart As Long = total.IndexOf(first) + first.Length + 1
            Return Trim(Mid$(total, FirstStart, total.Substring(FirstStart).IndexOf(last) + 1))
        Else
            Return Nothing
        End If
    End Function

End Module
