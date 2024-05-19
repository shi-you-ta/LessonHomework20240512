Imports System
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())
        '1�D���K�\���̕��K
        '1.1
        '�N�������������K�\���p�^�[�����쐬���Ă��������B
        Console.WriteLine("�N���������")
        Dim inputDate As String = Console.ReadLine()
        '4��/2��/2���̕�����ƃ}�b�`���Ă��邩�m�F
        Dim dateString As String = "^\d{4}/?\d{1,2}/?\d{1,2}$"

        Try
            Dim match As MatchCollection = System.Text.RegularExpressions.Regex.Matches(inputDate, dateString)
            Dim matchDate As Match = match(0)
            Dim currentDate As Date = Date.Today

            '���݂����ߋ��̔N�����Ȃ�\������
            If matchDate.Value < currentDate.ToString() Then
                Console.WriteLine("���͂��ꂽ�N������" & matchDate.Value & "�ł��B")
            Else
                Console.WriteLine("���͂��ꂽ�N����" & matchDate.Value & "�́A�����̔N�����ł��B")
            End If

        Catch ex As Exception
            '�}�b�`���Ȃ������ꍇ
            Console.WriteLine("�N�����̕ϊ��Ɏ��s���܂����B")
        End Try

        Console.WriteLine()

        '1.2
        'Linux�̃f�B���N�g���p�X���������K�\���p�^�[�����쐬���Ă��������B
        Console.WriteLine("Linux�̃f�B���N�g���p�X���擾���܂�")
        Dim linuxDir As String = Console.ReadLine()
        '�ȉ���Linux�f�B���N�g���Ƀ}�b�`���鐳�K�\�����擾����
        Dim linuxString As String = "^/(?:[\w]+\/)*[\w]+$"

        Try
            Dim isMatch As MatchCollection = System.Text.RegularExpressions.Regex.Matches(linuxDir, linuxString)
            Dim isMatchLinux As Match = isMatch(0)

            If isMatchLinux.Success Then
                Console.WriteLine("���͂��ꂽ�f�B���N�g���F{0}", isMatchLinux)
            End If
        Catch ex As Exception
            Console.WriteLine("���͕����񂪐���������܂���")
        End Try
    End Sub
End Module
