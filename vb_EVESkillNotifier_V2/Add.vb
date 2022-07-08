'EVENotifier,����EVE�����ѹ���.
'��Ȩ����(C) 2009 huxim
'������Ϊ������������������������������������GNUͨ�ù�����Ȩ����Ա������ٴη�����/���޸ģ����������ݵ��Ǳ���Ȩ�ĵ����棬������ѡ�ģ���һ�պ��еİ汾��
'�������ǻ���ʹ��Ŀ�Ķ����Է�����Ȼ�������κε������Σ����޶������Ի��ض�Ŀ����������Ϊ��Ĭʾ�Ե��������������GNUͨ�ù�����Ȩ��
'��Ӧ���յ������ڱ������GNUͨ�ù�����Ȩ�ĸ��������û�У������
'<http://www.gnu.org/licenses/>.
'������ϵhuxim123@gmail.com

Public Class Add

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If txtNotiName.Text = "" Then
                MsgBox("��������������!", MsgBoxStyle.Exclamation, "����")
            Else

                Dim newTime As New Main.time
                newTime.notiName = txtNotiName.Text
                If rdbLefttime.Checked = True Then
                    Dim duration As System.TimeSpan
                    duration = New System.TimeSpan(nbrDay.Value, nbrHour.Value, nbrMin.Value, nbrSec.Value)
                    newTime.timeFinish = Main.DatetimeNow.Add(duration)
                Else
                    newTime.timeFinish = dtpTime.Value
                End If
                newTime.timeNotify = newTime.timeFinish.Add(New System.TimeSpan(0, 0, -Main.myOptions.opadvance, 0))

                Main.timeColl.Add(newTime)
                Main.savetime()
                Main.showTimes()

                If newTime.timeFinish.Hour = 11 Then
                    MsgBox("�¼����ʱ������������ά��,��ע��.", MsgBoxStyle.Exclamation, "����")
                ElseIf newTime.timeFinish.Hour = 12 Then
                    MsgBox("�¼���10������,��������������ά���ӳ�.", MsgBoxStyle.Information, "��Ϣ")
                End If
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
                'Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox("�������ʱ���ִ���!" + Chr(13) & Chr(10) + "������Ϣ:" + ex.Message, MsgBoxStyle.Exclamation, "����")
            nbrDay.Value = 0
            nbrHour.Value = 0
            nbrMin.Value = 0
            nbrSec.Value = 0
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        'Me.Dispose()
    End Sub

    Shadows Sub Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNotiName.Text = ""
        nbrDay.Value = 0
        nbrHour.Value = 0
        nbrMin.Value = 0
        nbrSec.Value = 0

    End Sub

    Private Sub nbrDay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrDay.Click
        nbrDay.Select(0, 20)
    End Sub

    Private Sub nbrDay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrDay.GotFocus
        nbrDay.Select(0, 20)
    End Sub

    Private Sub nbrHour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrHour.Click
        nbrHour.Select(0, 2)
    End Sub

    Private Sub nbrHour_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrHour.GotFocus
        nbrHour.Select(0, 2)
    End Sub

    Private Sub nbrMin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrMin.Click
        nbrMin.Select(0, 2)
    End Sub

    Private Sub nbrMin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrMin.GotFocus
        nbrMin.Select(0, 2)
    End Sub

    Private Sub nbrSec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrSec.Click
        nbrSec.Select(0, 2)
    End Sub

    Private Sub nbrSec_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrSec.GotFocus
        nbrSec.Select(0, 2)
    End Sub

    'ճ�������о�ʱ��
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim text As String = ""
        Try
            If My.Computer.Clipboard.ContainsText Then
                text = My.Computer.Clipboard.GetText
            End If
            text = text.Replace("�������<t><right><color=0xFFFFFF00>", " ")

            'Dim textArray() As String = text.Split(text, " "c)
            Dim textArray() As String = text.Split(" ")
            Dim timeArray() As String = {"0", "0", "0", "0"}

            If text.Contains("��") Then
                timeArray(0) = textArray(Array.IndexOf(textArray, "��") - 1)
            End If
            If text.Contains("Сʱ") Then
                timeArray(1) = textArray(Array.IndexOf(textArray, "Сʱ") - 1)
            End If
            If text.Contains("��") Then
                timeArray(2) = textArray(Array.IndexOf(textArray, "��") - 1)
            End If
            If text.Contains("��") Then
                timeArray(3) = textArray(Array.IndexOf(textArray, "��") - 1)
            End If

            nbrDay.Value = timeArray(0)
            nbrHour.Value = timeArray(1)
            nbrMin.Value = timeArray(2)
            nbrSec.Value = timeArray(3)
        Catch ex As Exception
            MsgBox("���ʼ����巢������!" + Chr(13) & Chr(10) + "������Ϣ:" + ex.Message, MsgBoxStyle.Exclamation, "����")
        End Try
    End Sub

    Shadows Sub Add_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtNotiName.Focus()
        dtpTime.Value = Main.DatetimeNow
    End Sub

    Private Sub rdbLefttime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbLefttime.CheckedChanged
        rdbChange()
    End Sub

    Private Sub rdbTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTime.CheckedChanged
        rdbChange()
    End Sub

    Private Sub rdbChange()
        If rdbLefttime.Checked = True Then
            nbrDay.Enabled = True
            nbrHour.Enabled = True
            nbrMin.Enabled = True
            nbrSec.Enabled = True
            Button1.Enabled = True
            dtpTime.Enabled = False
        Else
            nbrDay.Enabled = False
            nbrHour.Enabled = False
            nbrMin.Enabled = False
            nbrSec.Enabled = False
            Button1.Enabled = False
            dtpTime.Enabled = True
        End If
    End Sub
End Class
