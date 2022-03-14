Imports System.Web

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "東京都"
        TextBox2.Text = "プログラマー"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False

        TextBox3.Text = ""
        TextBox4.Text = ""

        'Indeed検索リクエストURL作成
        Dim request_url As String = "https://jp.indeed.com/jobs?q=" + HttpUtility.UrlEncode(TextBox2.Text) + "&l=" + HttpUtility.UrlEncode(TextBox1.Text)

        Label6.Text = "WebRequest送信先：" + request_url

        'Webリクエスト送信
        Dim html As String = GetHttp(request_url)

        'リクエスト結果をTextBox3に入力
        TextBox3.Text = html

        '企業名を抽出
        Dim companyList() As String = GetSubstrArray(html, "<span class=""companyName"">", "</span>")

        'データベース接続
        mysql_cn()

        'データベースに追加
        For Each company As String In companyList

            If company <> "" Then

                If company.Contains("companyName") = True Then
                    company = GetSubstr(company, "noopener"">", "</a>")
                End If

                If company <> "" Then
                    Dim sql1 As String = "insert into posts values('" + company + "');"

                    Dim rs As String = mysql_result_no(sql1)

                    If rs = "Complete" Then
                        TextBox4.Text = TextBox4.Text & "[OK]" & company & vbCrLf
                    Else
                        TextBox4.Text = TextBox4.Text & "[ERROR]" & company & vbCrLf
                    End If

                End If

            End If

        Next

        'データベース切断
        mysql_cl()

        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ViewUpdate()
        ListBox1.Items.Clear()

        'データベース接続
        Call mysql_cn()

        Dim sql1 As String = "select * from posts"

        Dim dTb1 As DataTable = mysql_result_return(sql1)

        If dTb1.Rows.Count = 0 Then

        Else
            For Each DRow As DataRow In dTb1.Rows

                ListBox1.Items.Add(DRow.Item(0))

            Next
        End If

        'データベース切断
        Call mysql_cl()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ViewUpdate()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.SelectedItems.Count > 0 Then

            Button4.Enabled = False

            Dim company = ListBox1.SelectedItem.ToString
            If company <> "" Then
                'データベース接続
                Call mysql_cn()

                Dim sql1 As String = "delete from posts where company='" + company + "'"

                Dim rs As String = mysql_result_no(sql1)

                If rs = "Complete" Then
                    MsgBox("「" + company + "」を削除しました。")
                Else
                    MsgBox("「" + company + "」を削除できませんでした。")
                End If

                'データベース切断
                Call mysql_cl()

                ViewUpdate()
            End If

            Button4.Enabled = True

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox1.SelectedItems.Count > 0 Then

            Button5.Enabled = False

            Dim company = ListBox1.SelectedItem.ToString
            If company <> "" Then

                Dim new_company As String = InputBox("変更", "変更後の社名を入力して下さい。")

                If new_company <> "" Then

                    'データベース接続
                    Call mysql_cn()

                    Dim sql1 As String = "update posts set company='" + new_company + "' where company='" + company + "'"
                    Clipboard.SetText(sql1)
                    Dim rs As String = mysql_result_no(sql1)

                    If rs = "Complete" Then
                        MsgBox("「" + company + "」を「" + new_company + "」に変更しました。")
                    Else
                        MsgBox("「" + company + "」を「" + new_company + "」に変更できませんでした。")
                    End If

                    'データベース切断
                    Call mysql_cl()

                    ViewUpdate()

                End If


            End If

            Button5.Enabled = True

        End If
    End Sub
End Class
