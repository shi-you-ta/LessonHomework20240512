Imports System
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())
        '1．正規表現の復習
        '1.1
        '年月日を示す正規表現パターンを作成してください。
        Console.WriteLine("年月日を入力")
        Dim inputDate As String = Console.ReadLine()
        '4桁/2桁/2桁の文字列とマッチしているか確認
        Dim dateString As String = "^\d{4}/?\d{1,2}/?\d{1,2}$"

        Try
            Dim match As MatchCollection = System.Text.RegularExpressions.Regex.Matches(inputDate, dateString)
            Dim matchDate As Match = match(0)
            Dim currentDate As Date = Date.Today

            '現在よりも過去の年月日なら表示する
            If matchDate.Value < currentDate.ToString() Then
                Console.WriteLine("入力された年月日は" & matchDate.Value & "です。")
            Else
                Console.WriteLine("入力された年月日" & matchDate.Value & "は、未来の年月日です。")
            End If

        Catch ex As Exception
            'マッチしなかった場合
            Console.WriteLine("年月日の変換に失敗しました。")
        End Try

        Console.WriteLine()

        '1.2
        'Linuxのディレクトリパスを示す正規表現パターンを作成してください。
        Console.WriteLine("Linuxのディレクトリパスを取得します")
        Dim linuxDir As String = Console.ReadLine()
        '以下にLinuxディレクトリにマッチする正規表現を取得する
        Dim linuxString As String = "^/(?:[\w]+\/)*[\w]+$"

        Try
            Dim isMatch As MatchCollection = System.Text.RegularExpressions.Regex.Matches(linuxDir, linuxString)
            Dim isMatchLinux As Match = isMatch(0)

            If isMatchLinux.Success Then
                Console.WriteLine("入力されたディレクトリ：{0}", isMatchLinux)
            End If
        Catch ex As Exception
            Console.WriteLine("入力文字列が正しくありません")
        End Try
    End Sub
End Module
