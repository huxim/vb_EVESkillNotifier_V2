'EVENotifier,����EVE�����ѹ���.
'��Ȩ����(C) 2009 huxim
'������Ϊ������������������������������������GNUͨ�ù�����Ȩ����Ա������ٴη�����/���޸ģ����������ݵ��Ǳ���Ȩ�ĵ����棬������ѡ�ģ���һ�պ��еİ汾��
'�������ǻ���ʹ��Ŀ�Ķ����Է�����Ȼ�������κε������Σ����޶������Ի��ض�Ŀ����������Ϊ��Ĭʾ�Ե��������������GNUͨ�ù�����Ȩ��
'��Ӧ���յ������ڱ������GNUͨ�ù�����Ȩ�ĸ��������û�У������
'<http://www.gnu.org/licenses/>.
'������ϵhuxim123@gmail.com

Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports Microsoft.Win32


Public Class Main
    '===============�������==============
    Public timeColl As New Microsoft.VisualBasic.Collection() '�¼�����
    Public DatetimeNow As DateTime '��ǰʱ��
    'Public xmlPath As String = My.Application.Info.DirectoryPath
    Public TIMEFILENAME As String = My.Application.Info.DirectoryPath + "\time.xml" '����ʱ����ļ�
    Public OPFILENAME As String = My.Application.Info.DirectoryPath + "\options.xml" '�������õ��ļ�
    Dim indexes As ListView.SelectedIndexCollection 'ѡ�����Ŀ����
    Public index As Integer '��ʾ��ǰ�������¼��ڼ����е�����
    Public lblName As String '������������ʾ���¼�����
    Public lblDes As String '������������ʾ���¼�״̬(�������/�����)
    Public myOptions As New op '��ʾѡ��Ķ���
    '��ʱ����
    Dim i As Integer
    Dim j As Integer
    Public intLen As Integer '�����õ�....
    Dim newVer As Boolean = False '�Ƿ����°汾
    Dim ee As Integer = 0

    '����֪ͨ����̬���Ҽ��˵�
    Dim menuMain As ToolStripMenuItem = New ToolStripMenuItem
    Dim menuOption As ToolStripMenuItem = New ToolStripMenuItem
    Dim menuLoop As ToolStripMenuItem = New ToolStripMenuItem
    Dim menuExit As ToolStripMenuItem = New ToolStripMenuItem
    Dim menuAdd As ToolStripMenuItem = New ToolStripMenuItem
    Dim sep1 As ToolStripSeparator = New ToolStripSeparator
    Dim sep2 As ToolStripSeparator = New ToolStripSeparator
    '==================�������==============


    'ѡ����
    Public Class op
        '������ʾ
        Public opballoon As Boolean
        '����������ʾ
        Public opmsgbox As Boolean
        '������ʾ
        Public opsound As Boolean
        '�Զ�����Ƶ�ļ�·��
        Public oppath As String
        'Ĭ������
        Public opdefault As Boolean
        '�Զ�������
        Public opcustom As Boolean
        '��ǰʱ��
        Public opadvance As Integer
        'Google����
        Public opGCalendar As Boolean
        '������ַ
        'Public opXML As String '= "http://www.google.com/calendar/feeds/default/private/full"
        '�û���
        Public opUserName As String
        '����
        Public opPassword As String
        'G��ǰʱ��
        Public opGAd As Integer
        '������
        Public opAutorun As Boolean
        '��������С��
        Public opMinimize As Boolean
        '�����������
        Public opAutoUpdate As Boolean
        '����
        Public opSMS As Boolean
        '�ʼ�
        Public opMail As Boolean

        Public Sub New()
            opballoon = True
            opmsgbox = True
            opsound = True
            opdefault = True
            opcustom = False
            opadvance = 5
            opGCalendar = False
            opGAd = 20
            opAutorun = False
            opMinimize = False
            opAutoUpdate = False
            opSMS = False
            opMail = True
        End Sub
    End Class

    'ʱ��/�¼���
    Public Class time
        '����
        Public notiName As String
        '���ʱ��
        Public timeFinish As DateTime
        '����ʱ��
        Public timeNotify As DateTime
        '�Ѿ����ѻ��Ѿ����
        Public isNotified As Boolean
        Public isFinished As Boolean

        Public Sub New()
            isNotified = False
            isFinished = False
        End Sub

    End Class

    '������,ע����BackgroundWorker���ò�����
    Sub checkUpdate()
        Try
            Dim req As HttpWebRequest = WebRequest.Create("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/xia-zai")
            Dim res As HttpWebResponse = req.GetResponse()
            Dim strm As StreamReader = New StreamReader(res.GetResponseStream(), Encoding.UTF8)
            Dim sourceCode As String
            Dim tmpArray() As String
            Dim stringSeparators() As String = {"���°汾"}
            sourceCode = strm.ReadToEnd()
            tmpArray = sourceCode.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)
            sourceCode = tmpArray(1)
            tmpArray = sourceCode.Split(")")
            sourceCode = tmpArray(0)
            'MsgBox(sourceCode)
            Dim localVer As String() = {"0", "0", "0", "0"}
            Dim remoteVer As String() = {"0", "0", "0", "0"}
            newVer = False
            localVer = My.Application.Info.Version.ToString.Split(".")
            remoteVer = sourceCode.Split(".")
            For a As Integer = 0 To 3 Step 1
                If remoteVer(a) > localVer(a) Then
                    newVer = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("�����³���,������������." + Chr(13) & Chr(10) + "������Ϣ:" + ex.Message, MsgBoxStyle.Exclamation, "����")
        End Try
    End Sub

    '����֪ͨ����̬���Ҽ��˵�
    Sub setContextMenus()

        menuMain.Font = New Font(menuMain.Font, FontStyle.Bold)
        menuMain.Text = "��ʾ������(&M)"
        AddHandler menuMain.Click, AddressOf showMain

        menuOption.Text = "ѡ��(&O)..."
        AddHandler menuOption.Click, AddressOf showOption

        menuLoop.Text = "ѭ����ʱ��(&L)..."
        AddHandler menuLoop.Click, AddressOf showLoop

        menuExit.Text = "�˳�(&X)"
        AddHandler menuExit.Click, AddressOf exitProgram

        menuAdd.Text = "�������(&A)..."
        AddHandler menuAdd.Click, AddressOf cmdAdd_Click

    End Sub

    '��������
    Sub loadoptions()
        If My.Computer.FileSystem.FileExists(opFileName) = False Then
            'ע�͵�,���ٸ���
            'MsgBox("δ�ҵ������ļ�,���Զ�����Ĭ�������ļ�.", MsgBoxStyle.Information, "��Ϣ")
            defaultop()
        End If
        '����reader
        Dim readersettings As New XmlReaderSettings()
        readersettings.ConformanceLevel = ConformanceLevel.Fragment
        readersettings.IgnoreWhitespace = True
        readersettings.IgnoreComments = True
        Dim reader As XmlReader = XmlReader.Create(opFileName, readersettings)
        Try
            '��ȡxml
            reader.ReadToFollowing("opballoon")
            myOptions.opballoon = reader.ReadElementContentAsBoolean()
            myOptions.opmsgbox = reader.ReadElementContentAsBoolean()
            myOptions.opsound = reader.ReadElementContentAsBoolean()
            myOptions.oppath = reader.ReadElementContentAsString()
            myOptions.opdefault = reader.ReadElementContentAsBoolean()
            myOptions.opcustom = reader.ReadElementContentAsBoolean()
            myOptions.opadvance = reader.ReadElementContentAsInt()
            myOptions.opGCalendar = reader.ReadElementContentAsBoolean()
            'myOptions.opXML = reader.ReadElementContentAsString()
            myOptions.opUserName = reader.ReadElementContentAsString()
            myOptions.opPassword = decrypt(reader.ReadElementContentAsString())
            myOptions.opGAd = reader.ReadElementContentAsInt()
            myOptions.opAutorun = reader.ReadElementContentAsBoolean()
            myOptions.opMinimize = reader.ReadElementContentAsBoolean()
            myOptions.opAutoUpdate = reader.ReadElementContentAsBoolean()
            myOptions.opSMS = reader.ReadElementContentAsBoolean()
            myOptions.opMail = reader.ReadElementContentAsBoolean()
            reader.Close()
        Catch ex As Exception
            reader.Close()
            'ע�͵�,�Ա�֤�����ļ�����
            'MsgBox("�������ó��ִ���,���Զ�����Ĭ�������ļ�." + Chr(13) & Chr(10) + "������Ϣ:" + ex.Message, MsgBoxStyle.Information, "��Ϣ")
            'If My.Computer.FileSystem.FileExists(opFileName) Then
            '    My.Computer.FileSystem.DeleteFile(opFileName)
            'End If
            'defaultop()
            'loadoptions()
        End Try
    End Sub

    '����ʱ��
    Sub loadtime()
        If My.Computer.FileSystem.FileExists(timeFileName) = False Then
            'ע�͵�,���ٸ���
            'MsgBox("δ�ҵ�ʱ�������ļ�,���Զ������������ļ�.", MsgBoxStyle.Information, "��Ϣ")
            defaulttime()
        End If

        Dim reader As XmlTextReader = Nothing
        Try
            ' Load the reader with the data file and
            'ignore all white space nodes.
            reader = New XmlTextReader(timeFileName)
            reader.WhitespaceHandling = WhitespaceHandling.None

            ' Parse the file and display each of the nodes.
            reader.Read()
            If reader.IsStartElement("time") Then

                If reader.IsEmptyElement() Then
                    '�ձ��,��ʾû��ʱ������
                Else
                    '�ǿձ��,��ȡʱ��
                    reader.ReadStartElement() '�ƶ���ȡ��������ͷ
                    While reader.Name <> "time"
                        Dim myTime As New time
                        reader.ReadStartElement() '�ƶ���ȡ����<notiName>
                        reader.Read() '�ƶ���ȡ��������
                        myTime.notiName = reader.Value
                        reader.Read() '�ƶ���ȡ����</notiName>
                        reader.ReadEndElement() '�ƶ���ȡ����<timeFinish>
                        reader.Read() '�ƶ���ȡ�������ʱ��
                        myTime.timeFinish = reader.Value
                        reader.Read() '�ƶ���ȡ����</timeFinish>
                        reader.ReadEndElement() '�ƶ���ȡ����<timeNotify>
                        reader.Read() '�ƶ���ȡ��������ʱ��
                        myTime.timeNotify = reader.Value
                        reader.Read() '�ƶ���ȡ����</timeNotify>
                        reader.Read() '�ƶ���ȡ��������β
                        reader.ReadEndElement() '����ȡ���ƶ�����һ������ͷ
                        timeColl.Add(myTime)

                    End While
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("����ʱ����ִ���,���Զ������������ļ�.", MsgBoxStyle.Information, "��Ϣ")
            If My.Computer.FileSystem.FileExists(timeFileName) Then
                My.Computer.FileSystem.DeleteFile(timeFileName)
            End If
            defaulttime()
            loadtime()
        Finally
            If Not (reader Is Nothing) Then
                reader.Close()
            End If
        End Try
    End Sub

    '��������
    Sub saveoptions()
        'Try
        'xmlwriter��ʽ
        '����writer
        Dim writersettings As New XmlWriterSettings()
        writersettings.Indent = True
        writersettings.IndentChars = " "
        Dim writer As XmlWriter = XmlWriter.Create(opFileName, writersettings)
        Try
            'д��xml
            writer.WriteStartElement("op")
            writer.WriteElementString("opballoon", CStr(myOptions.opballoon).ToLower)
            writer.WriteElementString("opmsgbox", CStr(myOptions.opmsgbox).ToLower)
            writer.WriteElementString("opsound", CStr(myOptions.opsound).ToLower)
            writer.WriteElementString("oppath", CStr(myOptions.oppath))
            writer.WriteElementString("opdefault", CStr(myOptions.opdefault).ToLower)
            writer.WriteElementString("opcustom", CStr(myOptions.opcustom).ToLower)
            writer.WriteElementString("opadvance", myOptions.opadvance)
            writer.WriteElementString("opGCalendar", CStr(myOptions.opGCalendar).ToLower)
            'writer.WriteElementString("opXML", CStr(myOptions.opXML))
            writer.WriteElementString("opUserName", myOptions.opUserName)
            writer.WriteElementString("opPassword", encrypt(myOptions.opPassword))
            writer.WriteElementString("opGAd", myOptions.opGAd)
            writer.WriteElementString("opAutorun", CStr(myOptions.opAutorun).ToLower)
            writer.WriteElementString("opMinimize", CStr(myOptions.opMinimize).ToLower)
            writer.WriteElementString("opAutoUpdate", CStr(myOptions.opAutoUpdate).ToLower)
            writer.WriteElementString("opSMS", CStr(myOptions.opSMS).ToLower)
            writer.WriteElementString("opMail", CStr(myOptions.opMail).ToLower)
            writer.WriteEndElement()
            writer.Flush()
            writer.Close()
        Catch ex As Exception
            writer.Close()
            MsgBox("�������ó��ִ���,���Զ�����Ĭ�������ļ�." + Chr(13) & Chr(10) + "������Ϣ:" + ex.Message, MsgBoxStyle.Exclamation, "����")
            If My.Computer.FileSystem.FileExists(opFileName) Then
                My.Computer.FileSystem.DeleteFile(opFileName)
            End If
            defaultop()

        End Try
    End Sub

    '����ʱ��
    Sub savetime()

        'xmlwriter��ʽ
        '����writer
        Dim writersettings As New XmlWriterSettings()
        writersettings.Indent = True
        writersettings.IndentChars = " "
        Dim writer As XmlWriter = XmlWriter.Create(timeFileName, writersettings)
        Try
            'д��xml
            If timeColl.Count = 0 Then
                writer.WriteStartElement("time")
                writer.WriteEndElement()
            Else
                writer.WriteStartElement("time")
                For Each myTime As time In timeColl
                    writer.WriteStartElement("notiSetting")
                    writer.WriteElementString("notiName", myTime.notiName)
                    writer.WriteElementString("timeFinish", myTime.timeFinish)
                    writer.WriteElementString("timeNotify", myTime.timeNotify)
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            End If
            writer.Flush()
            writer.Close()
        Catch ex As Exception
            MsgBox("����ʱ����ִ���,���Զ������������ļ�." + Chr(13) & Chr(10) + "������Ϣ:" + ex.Message, MsgBoxStyle.Exclamation, "����")
            If My.Computer.FileSystem.FileExists(timeFileName) Then
                My.Computer.FileSystem.DeleteFile(timeFileName)
            End If
            defaulttime()
        End Try
    End Sub

    'дĬ������
    Sub defaultop()
        '����writer
        Dim writersettings As New XmlWriterSettings()
        writersettings.Indent = True
        writersettings.IndentChars = " "
        Dim writer As XmlWriter = XmlWriter.Create(opFileName, writersettings)
        'д��xml
        writer.WriteStartElement("op")
        writer.WriteElementString("opballoon", "true")
        writer.WriteElementString("opmsgbox", "true")
        writer.WriteElementString("opsound", "true")
        writer.WriteElementString("oppath", "")
        writer.WriteElementString("opdefault", "true")
        writer.WriteElementString("opcustom", "false")
        writer.WriteElementString("opadvance", "5")
        writer.WriteElementString("opGCalendar", "false")
        'writer.WriteElementString("opXML", CStr(myOptions.opXML))
        writer.WriteElementString("opUserName", "")
        writer.WriteElementString("opPassword", "")
        writer.WriteElementString("opadvance", "20")
        writer.WriteElementString("opAutorun", "false")
        writer.WriteElementString("opMinimize", "false")
        writer.WriteElementString("opAutoUpdate", "false")
        writer.WriteElementString("opSMS", "false")
        writer.WriteElementString("opMail", "true")
        writer.WriteEndElement()
        writer.Flush()
        writer.Close()
    End Sub

    'д��ʱ���ļ�
    Sub defaulttime()
        '����writer
        Dim writersettings As New XmlWriterSettings()
        writersettings.Indent = True
        writersettings.IndentChars = " "
        Dim writer As XmlWriter = XmlWriter.Create(timeFileName, writersettings)
        'д��xml
        writer.WriteStartElement("time")
        writer.WriteEndElement()
        writer.Flush()
        writer.Close()
    End Sub

    '��������
    Function encrypt(ByVal cleartext As String) As String
        Dim charArraystr() As Char = cleartext.ToCharArray
        Dim charArraykey() As Char = "key111".ToCharArray
        Dim intStrlen As Integer = Len(cleartext)
        Dim intKeylen As Integer = Len("key111")
        Dim intTimes As Integer = intStrlen \ intKeylen
        Dim intArrayresult(intStrlen) As Integer

        intLen = intStrlen * 2 + 1

        For i = 0 To intTimes - 1
            For j = 0 To intKeylen - 1
                intArrayresult(j + i * intKeylen) = AscW(charArraystr(j + i * intKeylen)) Xor AscW(charArraykey(j))
            Next
        Next

        For i = intTimes * intKeylen To intStrlen - 1
            intArrayresult(i) = AscW(charArraystr(i)) Xor AscW(charArraykey(i - intTimes * intKeylen))
        Next

        Dim txtStrText As String = ""
        For i = 0 To intStrlen - 1
            txtStrText = txtStrText & intArrayresult(i) & ","
        Next
        Return txtStrText
    End Function

    '��������
    Function decrypt(ByVal ciphertext As String) As String
        Dim charArraystr() As Char = ciphertext.ToCharArray
        Dim charArraykey() As Char = "key111".ToCharArray
        Dim intKeylen As Integer = Len("key111")
        Dim strArrayresult() As String = Split(charArraystr, ",")
        Dim intStrlen As Integer = strArrayresult.GetLength(0) - 1
        Dim intTimes As Integer = intStrlen \ intKeylen
        Dim n As Integer

        intLen = intStrlen * 2 + 1

        For i = 0 To intTimes - 1
            For j = 0 To intKeylen - 1
                n = Val(strArrayresult(j + i * intKeylen))
                strArrayresult(j + i * intKeylen) = ChrW(n Xor AscW(charArraykey(j)))
            Next
        Next

        For i = intTimes * intKeylen To intStrlen - 1
            n = Val(strArrayresult(i))
            strArrayresult(i) = ChrW(n Xor AscW(charArraykey(i - intTimes * intKeylen)))
        Next

        Dim txtStrText As String = ""
        For i = 0 To intStrlen - 1
            txtStrText = txtStrText & strArrayresult(i)
        Next
        Return txtStrText
    End Function

    '��timeColl�е�ʱ����µ�ListView,������֪ͨ�����Ҽ��˵�
    Sub showTimes()
        '�б�
        ListView1.Items.Clear()
        Dim i As Integer = 0
        '�˵�
        ContextMenuStrip1.Items.Clear()
        ContextMenuStrip1.Items.Add(menuMain)
        ContextMenuStrip1.Items.Add(menuOption)
        ContextMenuStrip1.Items.Add(menuLoop)
        ContextMenuStrip1.Items.Add(sep1)
        ContextMenuStrip1.Items.Add(menuAdd)

        For Each mytime As time In timeColl
            '�б�
            ListView1.Items.Add(mytime.notiName)
            'ListView1.Items(i).SubItems.Add(mytime.timeNotify)
            ListView1.Items(i).SubItems.Add(mytime.timeFinish)
            '�˵�
            '�����¼���Ŀ
            Dim menuEvent As ToolStripMenuItem = New ToolStripMenuItem
            menuEvent.Name = i
            menuEvent.Text = mytime.notiName + " - " + mytime.timeFinish
            AddHandler menuEvent.MouseMove, AddressOf event_MouseMove
            '�����༭�Ӳ˵�
            Dim menuEdit As ToolStripMenuItem = New ToolStripMenuItem
            menuEdit.Text = "�༭"
            AddHandler menuEdit.Click, AddressOf edit_Click
            '����ɾ���Ӳ˵�
            Dim menuDel As ToolStripMenuItem = New ToolStripMenuItem
            menuDel.Text = "ɾ��"
            AddHandler menuDel.Click, AddressOf del_Click
            '���Ӳ˵�װ��menuEvent
            menuEvent.DropDownItems.Add(menuEdit)
            menuEvent.DropDownItems.Add(menuDel)
            '���˵�װ��ContextMenuStrip1
            ContextMenuStrip1.Items.Add(menuEvent)
            i += 1
        Next
        changeColor()
        cmdDel.Enabled = False
        cmdEdit.Enabled = False
        '��̬�˵�ʣ�ಿ��
        ContextMenuStrip1.Items.Add(sep2)
        ContextMenuStrip1.Items.Add(menuExit)

    End Sub

    '������ɫ
    Sub changeColor()
        Dim i As Integer = 0
        For Each mytime As time In timeColl
            '�������
            If DatetimeNow > mytime.timeNotify Then

                '������ɫ
                ListView1.Items(i).BackColor = Color.Yellow
            End If
            '���
            If DatetimeNow > mytime.timeFinish Then

                '������ɫ
                ListView1.Items(i).BackColor = Color.Red
            End If

            i += 1
        Next
    End Sub
    '�˳�
    Private Sub exitProgram(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �˳�XToolStripMenuItem1.Click
        Me.Close()
    End Sub
    '�����ö�
    Private Sub �����ö�TToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �����ö�TToolStripMenuItem1.Click
        If �����ö�TToolStripMenuItem1.Checked = False Then
            Me.TopMost = False
        ElseIf �����ö�TToolStripMenuItem1.Checked = True Then
            Me.TopMost = True
        End If
    End Sub
    '����
    Private Sub ���߰���HToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ʹ�ð���HToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/bang-zhu")
    End Sub
    '����
    Private Sub ����AToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����AToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub
    '��ʱ��ÿ�����
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'ÿһ���Ӹ��µ�ǰʱ�䲢��ʾ
        DatetimeNow = DateTime.Now
        lblTimeNow.Text = DatetimeNow.ToString
        '����Ƿ񵽴�����ʱ��
        Dim i As Integer = 0
        For Each mytime As time In timeColl
            '�����
            If DatetimeNow > mytime.timeFinish And mytime.isFinished = False Then
                mytime.isFinished = True
                mytime.isNotified = True

                '������ɫ
                ListView1.Items(i).BackColor = Color.Red
                'If lblTimeNow.Text = mytime.timeFinish.ToString Then
                '������ʾ
                If myOptions.opballoon = True Then
                    NotifyIcon1.ShowBalloonTip(6000, "ע��!", mytime.notiName + "�����!", ToolTipIcon.Warning)
                End If

                '������ʾ
                If myOptions.opsound = True Then
                    Try
                        If myOptions.opdefault = True Then
                            My.Computer.Audio.Play(My.Resources.Windows_Ringin, AudioPlayMode.BackgroundLoop)
                        ElseIf myOptions.opcustom = True Then
                            My.Computer.Audio.Play(myOptions.oppath, AudioPlayMode.BackgroundLoop)
                        End If
                    Catch ex As Exception
                        MsgBox("���ִ���!" & ex.Message, MsgBoxStyle.Exclamation, "����")
                    End Try
                End If

                '��Ϣ������ʾ
                If myOptions.opmsgbox = True Then
                    Me.ShowInTaskbar = True
                    Me.WindowState = FormWindowState.Normal
                    lblName = mytime.notiName
                    lblDes = "�Ѿ����."
                    Dim Result As Integer

                    'Displays a MessageBox using the Question icon and specifying the No button as the default.
                    Result = MsgBox(lblName + Chr(13) & Chr(10) + lblDes, MessageBoxIcon.Warning, "��ע��")

                    ' Gets the result of the MessageBox display.
                    If Result = 1 Then
                        My.Computer.Audio.Stop()
                    End If
                End If

                '�������
            ElseIf DatetimeNow > mytime.timeNotify And mytime.isNotified = False Then
                mytime.isNotified = True

                '������ɫ
                ListView1.Items(i).BackColor = Color.Yellow
                'If lblTimeNow.Text = mytime.timeNotify.ToString Then
                '������ʾ
                If myOptions.opballoon = True Then
                    NotifyIcon1.ShowBalloonTip(6000, "ע��!", mytime.notiName + "�������.", ToolTipIcon.Info)
                End If

                '������ʾ
                If myOptions.opsound = True Then
                    Try
                        If myOptions.opdefault = True Then
                            My.Computer.Audio.Play(My.Resources.Windows_Ringin, AudioPlayMode.BackgroundLoop)
                        ElseIf myOptions.opcustom = True Then
                            My.Computer.Audio.Play(myOptions.oppath, AudioPlayMode.BackgroundLoop)
                        End If
                    Catch ex As Exception
                        MsgBox("���ִ���!" & ex.Message, MsgBoxStyle.Exclamation, "����")
                    End Try
                End If

                '��Ϣ������ʾ
                If myOptions.opmsgbox = True Then
                    Me.ShowInTaskbar = True
                    Me.WindowState = FormWindowState.Normal
                    lblName = mytime.notiName
                    lblDes = "�������."
                    Dim Result As Integer

                    'Displays a MessageBox using the Question icon and specifying the No button as the default.
                    Result = MsgBox(lblName + Chr(13) & Chr(10) + lblDes, MessageBoxIcon.Information, "��ע��")

                    ' Gets the result of the MessageBox display.
                    If Result = 1 Then
                        My.Computer.Audio.Stop()
                    End If
                End If
            End If
            i += 1
        Next
    End Sub
    'ֹͣ��ʾ����ť
    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        My.Computer.Audio.Stop()
    End Sub
    '��Ӧ������Ѱ�ť
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Add.ShowDialog()
    End Sub
    '��Ӧ�༭��ť
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Edit.ShowDialog()
    End Sub
    '��Ӧɾ����ť
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        delEvents()
    End Sub
    '�������һ������
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en")

        '����ʱ��ʾʱ��
        DatetimeNow = DateTime.Now
        lblTimeNow.Text = DatetimeNow.ToString

        '��������
        '�����������
        loadoptions()
        '��������ʱ��
        loadtime()
        '��ʾʱ��
        showTimes()
        '֪ͨ����̬���Ҽ��˵�
        setContextMenus()

        ''Ӧ�ó�������
        'applyNormalOptions()
        'MsgBox("load")
        'applyAutorun()
        'autoUpdate()

        '��ʼ��index
        indexes = Me.ListView1.SelectedIndices
        If indexes.Count = 1 Then
            index = indexes(0)
            cmdEdit.Enabled = True
            cmdDel.Enabled = True
        ElseIf indexes.Count > 1 Then
            cmdEdit.Enabled = False
            cmdDel.Enabled = True
        Else
            cmdEdit.Enabled = False
            cmdDel.Enabled = False
        End If
    End Sub
    '������ÿ����ʾ
    Private Sub Main_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Ӧ�ó�������
        applyNormalOptions()
        'MsgBox("shown")
        'applyMinimize()
    End Sub

    'Ӧ�ó�������
    Private Sub applyNormalOptions()
        applyAutorun()
        applyMinimize()
        autoUpdate()
    End Sub

    '������
    Sub applyAutorun()
        Try
            If myOptions.opAutorun = True Then
                Dim appFullPath As String = "" '����·��,���������ļ���
                Dim loaderFullPath As String = "" '�������������·��,���������ļ���
                Dim appDir As String = "" '��������Ŀ¼
                Dim loaderDir As String = "" '���������������Ŀ¼
                Dim appName As String = My.Application.Info.AssemblyName + ".exe"
                Dim loaderName As String = "EVENLoader.exe"
                Dim registryKey As String = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run"
                Dim isVM As Boolean = False
                appFullPath = My.Application.Info.DirectoryPath
                Dim shortCutPath As String
                ' ֱ�ӵ���COM����
                Dim wsh As Object = CreateObject("WScript.Shell")
                'ͨ����ȡ���������ж���������������������
                Dim processList() As Process
                processList = Process.GetProcesses
                For Each aProcess As Process In processList
                    If aProcess.ProcessName = "VM" Then
                        isVM = True
                        Exit For
                    End If
                Next

                Dim appString() As Char = "\APP"
                loaderDir = appFullPath.TrimEnd(appString)
                loaderFullPath = loaderDir + "\" + loaderName
                appDir = appFullPath
                appFullPath = appDir + "\" + appName

                If isVM = True Then
                    shortCutPath = loaderDir & "\EVENotifier.lnk"
                Else
                    shortCutPath = appDir & "\EVENotifier.lnk"
                End If

                Dim lnk As Object = wsh.CreateShortcut(shortCutPath)
                If isVM Then
                    With lnk
                        '.Arguments = "/?" '���ݲ���
                        .Description = "EVE������"
                        .IconLocation = appFullPath + ",0" 'ͼ��
                        .TargetPath = loaderFullPath
                        '.WindowStyle = 7 '�򿪴���ķ����С��
                        .WorkingDirectory = loaderDir '����·��
                        .Save() '�����ݷ�ʽ
                    End With

                    My.Computer.Registry.SetValue(registryKey, "EVENotifier", shortCutPath, Microsoft.Win32.RegistryValueKind.String)
                    'MsgBox("c:\windows\system32\cmd.exe /c """ + appPath + "")
                Else
                    With lnk
                        '.Arguments = "/?" '���ݲ���
                        .Description = "EVE������"
                        .IconLocation = appFullPath + ",0" 'ͼ��
                        .TargetPath = appFullPath
                        '.WindowStyle = 7 '�򿪴���ķ����С��
                        .WorkingDirectory = appDir '����·��
                        .Save() '�����ݷ�ʽ
                    End With
                    My.Computer.Registry.SetValue(registryKey, "EVENotifier", shortCutPath, Microsoft.Win32.RegistryValueKind.String)
                End If
            Else
                Dim rk As RegistryKey = Registry.CurrentUser
                rk = rk.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                If rk.GetValue("EVENotifier") <> Nothing Then
                    rk.DeleteValue("EVENotifier")
                End If
            End If
        Catch ex As Exception
            MsgBox("����ע������." + Chr(13) & Chr(10) + "������Ϣ:" + ex.Message, MsgBoxStyle.Exclamation, "����")
        End Try
    End Sub

    '��������С��
    Private Sub applyMinimize()
        If myOptions.opMinimize = True Then
            'Me.WindowState = FormWindowState.Minimized
            Me.Hide()
            'Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    '�����������
    Private Sub autoUpdate()
        If myOptions.opAutoUpdate Then
            BackgroundWorker2.RunWorkerAsync()
        End If
    End Sub
    '˫����Ŀ�ɱ༭
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Edit.ShowDialog()
    End Sub
    'ѡ��ĳ��/�����Ŀ,����index
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        indexes = Me.ListView1.SelectedIndices
        If indexes.Count = 1 Then
            index = indexes(0)
            cmdEdit.Enabled = True
            cmdDel.Enabled = True
        ElseIf indexes.Count > 1 Then
            cmdEdit.Enabled = False
            cmdDel.Enabled = True
        Else
            cmdEdit.Enabled = False
            cmdDel.Enabled = False
        End If
    End Sub
    '�����������ϵ���,ֹͣ����
    Private Sub NotifyIcon1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClicked
        My.Computer.Audio.Stop()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClosed
        'My.Computer.Audio.Stop()
    End Sub
    '˫��֪ͨ����ͼ��
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        showMain(sender, e)
        'Me.WindowState = FormWindowState.Normal
    End Sub

    '��С������
    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            'Me.ShowInTaskbar = False
            'Me.NotifyIcon1.Visible = True
            'Else
            '    Me.Show()
            '    'Me.NotifyIcon1.Visible = False
            '    'Me.ShowInTaskbar = True
            '    Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    '��ʾ������
    Private Sub showMain(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    '֪ͨ���������ʾ
    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove

        Dim timeTip As New System.Text.StringBuilder()
        For Each mytime As time In timeColl
            'timeTip += mytime.notiName + " - " + mytime.timeFinish + vbCrLf 'Chr(13) & Chr(10)
            timeTip = timeTip.Append(vbCrLf + mytime.notiName + " - " + mytime.timeFinish) 'Chr(13) & Chr(10)
        Next
        Dim txttip As String
        If timeTip.Length > 0 Then
            txttip = timeTip.Remove(0, 2).ToString
        Else
            txttip = "EVE������"
        End If
        If txttip.Length >= 64 Then
            NotifyIcon1.Text = txttip.Substring(0, 60) + "..."
        Else
            NotifyIcon1.Text = txttip
        End If
    End Sub
    'ѭ����ʱ��
    Private Sub showLoop(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ѭ����ʱ��LToolStripMenuItem1.Click
        frmloop.Show()
    End Sub
    'ѡ���
    Private Sub showOption(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ѡ��OToolStripMenuItem1.Click
        Options.ShowDialog()
    End Sub
    '֪ͨ����˵��༭�˵�
    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Edit.ShowDialog()
    End Sub
    '֪ͨ����˵�ɾ���˵�
    Private Sub del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delAEvent()
    End Sub
    '֪ͨ����˵�����ƶ�,����index
    Private Sub event_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim mItem As ToolStripMenuItem

        mItem = CType(sender, ToolStripMenuItem)
        index = mItem.Name
        'MsgBox(index)
        'NotifyIcon1.ShowBalloonTip(6000, index, index, ToolTipIcon.Warning)

    End Sub
    '�ֶ�������
    Private Sub ������UToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ������UToolStripMenuItem.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        checkUpdate()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim MessageHasNew As String = "�������°汾,Ҫת������ҳ��?"
        Dim MessageNoNew As String = "û�з����°汾."
        Dim Caption As String = "������"
        Dim ButtonsHasNew As Integer = MessageBoxButtons.YesNo
        Dim ButtonsNoNew As Integer = MessageBoxButtons.OK
        Dim Result As DialogResult
        If newVer Then
            'Displays a MessageBox using the Question icon and specifying the No button as the default.
            Result = MessageBox.Show(Me, MessageHasNew, Caption, ButtonsHasNew)

            ' Gets the result of the MessageBox display.
            If Result = Windows.Forms.DialogResult.Yes Then
                System.Diagnostics.Process.Start("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/xia-zai")
            End If
        Else
            MessageBox.Show(Me, MessageNoNew, Caption, ButtonsNoNew)
        End If
    End Sub
    'ɾ���¼���ʵ��
    Private Sub delEvents()
        ' Initializes variables to pass to the MessageBox.Show method.

        Dim Message As String = "" ' = "���Ҫɾ��'" + timeColl.Item(index + 1).notiName + "'ô?"
        Dim Caption As String = "ȷ��"
        Dim Buttons As Integer = MessageBoxButtons.YesNo
        Dim Result As DialogResult

        'If indexes.Count = 1 Then
        Message = "���Ҫɾ��""" + timeColl.Item(index + 1).notiName + """��?"
        If indexes.Count > 1 Then
            Message = "���Ҫɾ����" + indexes.Count.ToString + "����?"
        End If
        'Displays a MessageBox using the Question icon and specifying the No button as the default.
        Result = MessageBox.Show(Me, Message, Caption, MessageBoxButtons.YesNo)

        ' Gets the result of the MessageBox display.
        If Result = Windows.Forms.DialogResult.Yes Then

            ' ɾ����¼
            If indexes.Count > 1 Then
                For a As Integer = indexes.Count - 1 To 0 Step -1
                    index = indexes(a)
                    timeColl.Remove(index + 1)
                Next
            Else
                timeColl.Remove(index + 1)
            End If

            savetime()
            showTimes()
            ListView1.Focus()
            If index > 0 Then
                ListView1.Items(index - 1).Selected = True
            ElseIf index = 0 Then
                If ListView1.Items.Count > 0 Then
                    ListView1.Items(index).Selected = True
                End If
            End If

            If timeColl.Count = 0 Then
                cmdDel.Enabled = False
                cmdEdit.Enabled = False
            End If
        Else
            ListView1.Focus()
        End If
    End Sub
    'ɾ��һ���¼���ʵ��
    Private Sub delAEvent()
        ' Initializes variables to pass to the MessageBox.Show method.

        Dim Message As String = "" ' = "���Ҫɾ��'" + timeColl.Item(index + 1).notiName + "'ô?"
        Dim Caption As String = "ȷ��"
        Dim Buttons As Integer = MessageBoxButtons.YesNo
        Dim Result As DialogResult

        'If indexes.Count = 1 Then
        Message = "���Ҫɾ��""" + timeColl.Item(index + 1).notiName + """��?"
        'If indexes.Count > 1 Then
        '    Message = "���Ҫɾ����" + indexes.Count.ToString + "����?"
        'End If
        'Displays a MessageBox using the Question icon and specifying the No button as the default.
        Result = MessageBox.Show(Me, Message, Caption, MessageBoxButtons.YesNo)

        ' Gets the result of the MessageBox display.
        If Result = Windows.Forms.DialogResult.Yes Then

            ' ɾ����¼
            'If indexes.Count > 1 Then
            '    For a As Integer = indexes.Count - 1 To 0 Step -1
            '        index = indexes(a)
            '        timeColl.Remove(index + 1)
            '    Next
            'Else
            timeColl.Remove(index + 1)
            'End If

            savetime()
            showTimes()
            'ListView1.Focus()
            'If index > 0 Then
            '    ListView1.Items(index - 1).Selected = True
            'ElseIf index = 0 Then
            '    If ListView1.Items.Count > 0 Then
            '        ListView1.Items(index).Selected = True
            '    End If
            'End If

            'If timeColl.Count = 0 Then
            '    cmdDel.Enabled = False
            '    cmdEdit.Enabled = False
            'End If
        Else
            'ListView1.Focus()
        End If
    End Sub
    '�Զ�������
    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        checkUpdate()
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim MessageHasNew As String = "�������°汾,Ҫת������ҳ��?"
        'Dim MessageNoNew As String = "û�з����°汾."
        Dim Caption As String = "������"
        Dim ButtonsHasNew As Integer = MessageBoxButtons.YesNo
        'Dim ButtonsNoNew As Integer = MessageBoxButtons.OK
        Dim Result As DialogResult
        If newVer Then
            'Displays a MessageBox using the Question icon and specifying the No button as the default.
            Result = MessageBox.Show(Me, MessageHasNew, Caption, ButtonsHasNew)

            ' Gets the result of the MessageBox display.
            If Result = Windows.Forms.DialogResult.Yes Then
                System.Diagnostics.Process.Start("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/xia-zai")
            End If
            'Else
            'MessageBox.Show(Me, MessageNoNew, Caption, ButtonsNoNew)
        End If
    End Sub
    '�ʵ�
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        ee += 1
        If ee = 6 Then
            EasterEgg.ShowDialog()
            ee = 0
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class
