Imports MySql.Data.MySqlClient

Module DB

    Public mysqlCon As New MySqlConnection
    Public sqlCommand As New MySqlCommand

    Public Sub mysql_cn()
        'MySQLへ接続

        Dim sqlbuilder = New MySqlConnectionStringBuilder()

        sqlbuilder.Server = "localhost"
        sqlbuilder.SslMode = MySqlSslMode.None
        sqlbuilder.Port = 3306

        sqlbuilder.UserID = "" 'ユーザーID
        sqlbuilder.Password = "" 'パスワード
        sqlbuilder.Database = "" 'データベース名

        Dim ConStr = sqlbuilder.ToString()

        mysqlCon.ConnectionString = ConStr

        Try
            mysqlCon.Open()
            MsgBox("SUCCESS")

        Catch ex As Exception
            MsgBox("ERROR")

        End Try


    End Sub

    Public Sub mysql_cl()
        'MySQL接続クローズ

        mysqlCon.Close()
    End Sub

    Public Function mysql_result_return(ByVal query As String) As DataTable
        'データセットを返す処理(SELECT)
        Dim dt As New DataTable()
        Try
            Dim Adapter = New MySqlDataAdapter(query, mysqlCon)

            Dim Ds As New DataSet
            Adapter.Fill(dt)

            Return dt
        Catch ex As Exception

            Return dt
        End Try

    End Function

    Public Function mysql_result_no(ByVal query As String)
        'データセットを返さない処理(DELETE、UPDATE、INSERT)
        Try
            sqlCommand.Connection = mysqlCon
            sqlCommand.CommandText = query
            sqlCommand.ExecuteNonQuery()

            Return "Complete"
        Catch ex As Exception

            Return ex.Message
        End Try

    End Function

End Module
