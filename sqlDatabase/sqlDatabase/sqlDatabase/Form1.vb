Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'App.configからデータベース接続文字列の読み込み
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("sqlDatabase.My.MySettings.Database1ConnectionString").ConnectionString

        Using conn As New SqlConnection(connectionString)
            'データベースをオープンする
            conn.Open()
            'テーブル内の全ての列を結果として取得する
            Dim sql As String = "SELECT * FROM [Table];"
            'sqlCommandクラスをインスタンス化してsqlコマンドをデータベースに実行
            Using command As New SqlCommand(sql, conn)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        For i = 0 To 4
                            TextBox1.AppendText($"{reader(i)},")
                        Next
                        TextBox1.AppendText($"{vbCrLf}")
                    End While
                End Using
            End Using
            End Using
    End Sub
End Class
