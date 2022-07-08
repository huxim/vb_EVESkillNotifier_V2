'EVENotifier,����EVE�����ѹ���.
'��Ȩ����(C) 2009 huxim
'������Ϊ������������������������������������GNUͨ�ù�����Ȩ����Ա������ٴη�����/���޸ģ����������ݵ��Ǳ���Ȩ�ĵ����棬������ѡ�ģ���һ�պ��еİ汾��
'�������ǻ���ʹ��Ŀ�Ķ����Է�����Ȼ�������κε������Σ����޶������Ի��ض�Ŀ����������Ϊ��Ĭʾ�Ե��������������GNUͨ�ù�����Ȩ��
'��Ӧ���յ������ڱ������GNUͨ�ù�����Ȩ�ĸ��������û�У������
'<http://www.gnu.org/licenses/>.
'������ϵhuxim123@gmail.com

Public Class Options

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
        'Me.Dispose()
    End Sub

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkballoon.Checked = Main.myOptions.opballoon
        chkmsgbox.Checked = Main.myOptions.opmsgbox
        chksound.Checked = Main.myOptions.opsound
        rdoDefault.Checked = Main.myOptions.opdefault
        rdoCustom.Checked = Main.myOptions.opcustom
        txtPath.Text = Main.myOptions.oppath
        txtadvance.Text = Main.myOptions.opadvance
        'txtXML.Text = Main.myOptions.opXML
        chkAutorun.Checked = Main.myOptions.opAutorun
        chkMinimize.Checked = Main.myOptions.opMinimize
        chkAutoUpdate.Checked = Main.myOptions.opAutoUpdate

        cmdApply.Enabled = False

        If chksound.Checked = False Then
            rdoDefault.Enabled = False
            rdoCustom.Enabled = False
            txtPath.Enabled = False
            cmdTest.Enabled = False
            cmdBrowse.Enabled = False
        Else
            rdoDefault.Enabled = True
            rdoCustom.Enabled = True
            If rdoDefault.Checked = True Then
                txtPath.Enabled = False
                cmdTest.Enabled = False
                cmdBrowse.Enabled = False
            Else
                txtPath.Enabled = True
                cmdTest.Enabled = True
                cmdBrowse.Enabled = True
            End If
        End If
        'If chkGCal.Checked = True Then
        '    'txtXML.Enabled = True
        '    txtUserName.Enabled = True
        '    txtPassword.Enabled = True
        'Else
        '    'txtXML.Enabled = False
        '    txtUserName.Enabled = False
        '    txtPassword.Enabled = False
        'End If
    End Sub

    Private Sub rdoDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDefault.CheckedChanged
        If rdoDefault.Checked = True Then
            txtPath.Enabled = False
            cmdTest.Enabled = False
            cmdBrowse.Enabled = False
        Else
            txtPath.Enabled = True
            cmdTest.Enabled = True
            cmdBrowse.Enabled = True
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub rdoCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCustom.CheckedChanged
        If txtPath.Text = "" Then
            cmdTest.Enabled = False
        Else
            cmdTest.Enabled = True
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub chksound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksound.CheckedChanged
        If chksound.Checked = False Then
            rdoDefault.Enabled = False
            rdoCustom.Enabled = False
            txtPath.Enabled = False
            cmdTest.Enabled = False
            cmdBrowse.Enabled = False
        Else
            rdoDefault.Enabled = True
            rdoCustom.Enabled = True
            If rdoDefault.Checked = True Then
                txtPath.Enabled = False
                cmdTest.Enabled = False
                cmdBrowse.Enabled = False
            Else
                txtPath.Enabled = True
                cmdTest.Enabled = True
                cmdBrowse.Enabled = True
            End If
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Main.myOptions.oppath = OpenFileDialog1.FileName
            txtPath.Text = Main.myOptions.oppath
        End If
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        If txtPath.Text = "" And txtPath.Enabled = True Then

            MsgBox("��ָ����Ƶ�ļ�!", MsgBoxStyle.Exclamation, "����")
        Else
            Try
                My.Computer.Audio.Play(Main.myOptions.oppath, AudioPlayMode.Background)
            Catch ex As Exception
                MsgBox("���ִ���!" & ex.Message, MsgBoxStyle.Exclamation, "����")
            End Try
        End If
    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath.TextChanged
        If txtPath.Text = "" Then
            cmdTest.Enabled = False
        Else
            cmdTest.Enabled = True
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub chkballoon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkballoon.CheckedChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub chkmsgbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmsgbox.CheckedChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        If txtPath.Text = "" And txtPath.Enabled = True Then
            MsgBox("��ָ����Ƶ�ļ�!", MsgBoxStyle.Exclamation, "��Ƶ�ļ�δָ��")
        Else
            Try
                'main.myOptions.opballoon = chkballoon.Checked
                'main.myOptions.opmsgbox = chkmsgbox.Checked
                'main.myOptions.opsound = chksound.Checked
                'main.myOptions.opdefault = rdoDefault.Checked
                'main.myOptions.opcustom = rdoCustom.Checked
                'main.myOptions.oppath = txtPath.Text
                'Main.myOptions.opadvance = txtadvance.Text
                'Main.myOptions.opGCalendar = chkGCal.Checked
                ''Main.myOptions.opXML = txtXML.Text
                'Main.myOptions.opUserName = txtUserName.Text
                'Main.myOptions.opPassword = txtPassword.Text
                'Main.myOptions.opGAd = txtGAd.Text
                ''main.myTime.timeNotify = main.myTime.timeFinish.Add(New System.TimeSpan(0, 0, -main.myOptions.opadvance, 0))

                'For Each mytime As Main.time In Main.timeColl
                '    mytime.timeNotify = mytime.timeFinish.Add(New System.TimeSpan(0, 0, -Main.myOptions.opadvance, 0))
                'Next

                'Main.showTimes()
                'Main.saveoptions()
                'Main.savetime()
                'If Main.myOptions.opGCalendar Then
                '    Dim threadUpdateGoocal As New System.Threading.Thread(AddressOf Main.updateGooCal)
                '    threadUpdateGoocal.Start()
                'End If
                applyOptions()
                cmdApply.Enabled = False
            Catch ex As Exception
                MsgBox("���ִ���!" & ex.Message, MsgBoxStyle.Exclamation, "����")
            End Try

        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtPath.Text = "" And txtPath.Enabled = True Then
            MsgBox("��ָ����Ƶ�ļ�!", MsgBoxStyle.Exclamation, "��Ƶ�ļ�δָ��")
        Else
            Try
                'main.myOptions.opballoon = chkballoon.Checked
                'main.myOptions.opmsgbox = chkmsgbox.Checked
                'main.myOptions.opsound = chksound.Checked
                'main.myOptions.opdefault = rdoDefault.Checked
                'main.myOptions.opcustom = rdoCustom.Checked
                'main.myOptions.oppath = txtPath.Text
                'Main.myOptions.opadvance = txtadvance.Text
                'Main.myOptions.opGCalendar = chkGCal.Checked
                ''Main.myOptions.opXML = txtXML.Text
                'Main.myOptions.opUserName = txtUserName.Text
                'Main.myOptions.opPassword = txtPassword.Text
                'Main.myOptions.opGAd = txtGAd.Text
                ''main.myTime.timeNotify = main.myTime.timeFinish.Add(New System.TimeSpan(0, 0, -main.myOptions.opadvance, 0))

                'For Each mytime As Main.time In Main.timeColl
                '    mytime.timeNotify = mytime.timeFinish.Add(New System.TimeSpan(0, 0, -Main.myOptions.opadvance, 0))
                'Next

                'Main.showTimes()
                'Main.saveoptions()
                'Main.savetime()
                'If Main.myOptions.opGCalendar Then
                '    Dim threadUpdateGoocal As New System.Threading.Thread(AddressOf Main.updateGooCal)
                '    threadUpdateGoocal.Start()
                'End If
                applyOptions()
                Me.Close()
                'Me.Dispose()
            Catch ex As Exception
                MsgBox("���ִ���!" & ex.Message, MsgBoxStyle.Exclamation, "����")
            End Try
        End If
    End Sub


    Private Sub chkGCal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If chkGCal.Checked = True Then
        '    txtXML.Enabled = True
        '    txtUserName.Enabled = True
        '    txtPassword.Enabled = True
        '    txtGAd.Enabled = True
        '    chkSMS.Enabled = True
        '    chkMail.Enabled = True
        'Else
        '    txtXML.Enabled = False
        '    txtUserName.Enabled = False
        '    txtPassword.Enabled = False
        '    txtGAd.Enabled = False
        '    chkSMS.Enabled = False
        '    chkMail.Enabled = False
        'End If

        cmdApply.Enabled = True
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdApply.Enabled = True
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdApply.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/she-zhigoogle-ri-li")
    End Sub

    'Private Sub txtXML_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtXML.TextChanged
    '    cmdApply.Enabled = True
    'End Sub

    Private Sub applyOptions()
        Main.myOptions.opballoon = chkballoon.Checked
        Main.myOptions.opmsgbox = chkmsgbox.Checked
        Main.myOptions.opsound = chksound.Checked
        Main.myOptions.opdefault = rdoDefault.Checked
        Main.myOptions.opcustom = rdoCustom.Checked
        Main.myOptions.oppath = txtPath.Text
        Main.myOptions.opadvance = txtadvance.Text
        'Main.myOptions.opXML = txtXML.Text
        'main.myTime.timeNotify = main.myTime.timeFinish.Add(New System.TimeSpan(0, 0, -main.myOptions.opadvance, 0))
        Main.myOptions.opAutorun = chkAutorun.Checked
        Main.myOptions.opMinimize = chkMinimize.Checked
        Main.myOptions.opAutoUpdate = chkAutoUpdate.Checked


        For Each mytime As Main.time In Main.timeColl
            mytime.timeNotify = mytime.timeFinish.Add(New System.TimeSpan(0, 0, -Main.myOptions.opadvance, 0))
        Next

        Main.showTimes()
        Main.saveoptions()
        Main.savetime()
        Main.applyAutorun()
    End Sub

    Private Sub txtGAd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdApply.Enabled = True
    End Sub

    Private Sub chkAutorun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutorun.CheckedChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub chkMinimize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMinimize.CheckedChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub chkAutoUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoUpdate.CheckedChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub chkSMS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdApply.Enabled = True
    End Sub

    Private Sub chkMail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdApply.Enabled = True
    End Sub
End Class