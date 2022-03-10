Imports System.Web

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "福岡県北九州市"
        TextBox2.Text = "プログラマー"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False

        TextBox3.Text = ""
        TextBox4.Text = ""

        Dim request_url As String = "https://jp.indeed.com/jobs?q=" + HttpUtility.UrlEncode(TextBox2.Text) + "&l=" + HttpUtility.UrlEncode(TextBox1.Text)
        MsgBox(request_url)

        Dim html As String = GetHttp(request_url)
        TextBox3.Text = html

        Dim companyList() As String = GetSubstrArray(html, "<span class=""companyName"">", "</span>")
        For Each company As String In companyList
            TextBox4.Text = TextBox4.Text & company & vbCrLf
        Next

        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mysql_cn()

        mysql_cl()

    End Sub
End Class
