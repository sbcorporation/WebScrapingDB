Imports System.Net


Module Scraping

    Public Function GetHttp(url As String) As String
        Dim html As String = ""

        Dim cookie As CookieContainer = New CookieContainer()

        Dim httpReq As HttpWebRequest = HttpWebRequest.Create(url)

        httpReq.CookieContainer = cookie

        httpReq.Method = "GET"

        httpReq.Credentials = New NetworkCredential("username", "password")

        Using httpRes As HttpWebResponse = httpReq.GetResponse()
            For Each s As String In httpRes.Headers
                Console.WriteLine(s)
            Next

            Using Strm As System.IO.Stream = httpRes.GetResponseStream()
                Using sr As New System.IO.StreamReader(Strm, System.Text.Encoding.UTF8)
                    html = sr.ReadToEnd()
                End Using
            End Using

        End Using

        Console.WriteLine(html)

        GetHttp = html

    End Function


    Public Function GetSubstr(ByVal ht As String, ByVal key1 As String, ByVal key2 As String) As String
        Dim n1 As Long, n2 As Long
        Dim cn As String
        cn = ""
        n1 = InStr(1, ht, key1, vbTextCompare)
        If n1 > 0 Then
            n2 = InStr(n1 + Len(key1), ht, key1, vbTextCompare)
            If n2 > 0 Then
                cn = Mid(ht, n1 + Len(key1), n2 - (n1 + Len(key1)))
            End If
        End If
        GetSubstr = cn
    End Function

    Public Function GetSubstrArray(ByVal ht As String, ByVal key1 As String, ByVal key2 As String) As Object
        Dim SubStr() As String
        Dim c As Long
        Dim n1 As Long, n2 As Long
        Dim cn As String

        c = 0
        n1 = 1
        n2 = 0
        Do
            cn = ""
            n1 = InStr(n1, ht, key1, vbTextCompare)
            If n1 > 0 Then
                n2 = InStr(n1 + Len(key1), ht, key2, vbTextCompare)
                If n2 > 0 Then
                    cn = Mid(ht, n1 + Len(key1), n2 - (n1 + Len(key1)))
                    c = c + 1
                    n1 = n2 + Len(key2)
                Else
                    Exit Do
                End If
            Else
                Exit Do
            End If
        Loop

        ReDim SubStr(c)
        n1 = 1
        n2 = 0
        c = 0
        Do
            cn = ""
            n1 = InStr(n1, ht, key1, vbTextCompare)
            If n1 > 0 Then
                n2 = InStr(n1 + Len(key1), ht, key2, vbTextCompare)
                If n2 > 0 Then
                    cn = Mid(ht, n1 + Len(key1), n2 - (n1 + Len(key1)))
                    SubStr(c) = cn
                    c = c + 1
                    n1 = n2 + Len(key2)
                Else
                    Exit Do
                End If
            Else
                Exit Do
            End If
        Loop

        GetSubstrArray = SubStr

    End Function

End Module
