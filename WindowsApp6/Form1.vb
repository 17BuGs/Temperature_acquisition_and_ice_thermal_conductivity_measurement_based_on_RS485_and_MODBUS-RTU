'基于MODBUS-RTU通信协议的上位机温度采集程序
Imports System.IO.Ports

Public Class Form1

    Dim strPVD As String     'PV值
    Public Count_Time As Double = 0    '定义并初始化计时
    Public Data() As String     '定义Data数组，供Form2继承
    Dim Delta_T1_Array(4) As Double     '定义delta数组，用于判断准稳态
    Dim Delta_T2_Array(4) As Double
    Dim Ratio_Of_Delta_T(4) As Double   '定义温差比值，用于计算导热系数
    Public Heat_Conductivity_Coefficient As String
    Dim Save_Address As String = "D:\新建文件夹\Test.txt"    '文件保存路径

    '打开窗体时，判断串口是否打开
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog    '设置窗体边界不可改变
        Me.MaximizeBox = False  '取消最大化
        Me.AutoSize = True      '自动调整窗口大小

        Me.ButSetSC.Enabled = False

        '设置时钟频率
        Timer1.Interval = 1600
        Form2.Form2_Load()
        Form3.Form3_Load()

        '获得计算机已经安装的串口，并将串口加载到comboBox项目，以供选择用
        Dim portNames() As String = SerialPort.GetPortNames()
        If portNames.Length < 1 Then
            MsgBox（"无可用串口，即将退出"）
            End
        Else
            For i As Integer = 0 To portNames.Length - 1
                Form3.ComboBoxName.Items.Add(portNames(i).ToString)
            Next
        End If

        '设置串口相关属性
        SerialPort1.PortName = "COM3"
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.Handshake = IO.Ports.Handshake.None

        Try
            SerialPort1.ReceivedBytesThreshold = 10
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.Open()
            '判断通信是否正常
            SendOrderReadPV()
            System.Threading.Thread.Sleep(50)
            SerialPort1_DataReceived()
        Catch
            MsgBox("通信异常")
        End Try

        ButSendPV.Enabled = True
        ButStopPV.Enabled = False
        Button2.Enabled = True
        ButSetSC.Enabled = True
        Address.Text = ".txt文件保存路径：" & Save_Address
    End Sub

    '显示结果
    Private Sub ShowString(ByVal ComData() As String)
        Label24.Text = "温度：" & vbCrLf & ComData(0)
        Label25.Text = "温度：" & vbCrLf & ComData(1)
        Label26.Text = "温度：" & vbCrLf & ComData(2)
        Label27.Text = "温度：" & vbCrLf & ComData(3)
        My.Computer.FileSystem.WriteAllText(Save_Address, Now & vbTab & ComData(0) & vbTab & ComData(1) & vbTab & ComData(2) & vbTab & ComData(3) & vbCrLf, True)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SendOrderReadPV()
        System.Threading.Thread.Sleep(200)
        Dim datastring() As String = SerialPort1_DataReceived()
        Data = datastring
        ShowString(datastring)   '文本框显示接收到的命令帧
        Change_RGB(datastring)  '刷新样品板动画帧
        Calculate_Heat_Conductivity_Coefficient(datastring) '判断是否达到准稳态，如果是，则计算导热系数
        Form2.RefreshChart1Data(datastring) '刷新chart1数据流
        Form2.RefreshChart2Data() '刷新chart2数据流
        SerialPort1.DiscardOutBuffer()
        SerialPort1.DiscardInBuffer()
        System.Threading.Thread.Sleep(200)
        Count_Time += (Timer1.Interval + 400) / 1000 '计时，以秒为单位
    End Sub
    '接收仪器应答命令帧
    Private Function SerialPort1_DataReceived()
        Dim i As Integer
        Dim ByteToRead As Integer
        Dim Inbyte() As Byte
        Dim datastring(3) As String

        ByteToRead = SerialPort1.BytesToRead
        ReDim Inbyte(ByteToRead - 1)
        SerialPort1.Read(Inbyte, 0, ByteToRead)   '读取接收缓冲区内的命令帧

        Dim data(UBound(Inbyte) - LBound(Inbyte)) As String

        If (data.Length = 21) Then
            Communicate_Status.Text = "通信：正常"
            Communicate_Status.ForeColor = Color.Green

            For i = LBound(Inbyte) To UBound(Inbyte)
                data(i) = Hex(Inbyte(i))
            Next i

            Dim channel_1_str As String
            Dim channel_1_double As Double
            Dim channel_1_String_BIN As String
            Dim channel_2_str As String
            Dim channel_2_double As Double
            Dim channel_2_String_BIN As String
            Dim channel_3_str As String
            Dim channel_3_double As Double
            Dim channel_3_String_BIN As String
            Dim channel_4_str As String
            Dim channel_4_double As Double
            Dim channel_4_String_BIN As String

            channel_1_str = data(3) & data(4)
            channel_2_str = data(5) & data(6)
            channel_3_str = data(7) & data(8)
            channel_4_str = data(9) & data(10)

            channel_1_double = Hex_2_Dec(channel_1_str)
            channel_2_double = Hex_2_Dec(channel_2_str)
            channel_3_double = Hex_2_Dec(channel_3_str)
            channel_4_double = Hex_2_Dec(channel_4_str)

            channel_1_String_BIN = Hex_2_Bin(channel_1_str)
            channel_2_String_BIN = Hex_2_Bin(channel_2_str)
            channel_3_String_BIN = Hex_2_Bin(channel_3_str)
            channel_4_String_BIN = Hex_2_Bin(channel_4_str)


            If Mid(channel_1_String_BIN, 1, 1) = "1" And Len(channel_1_String_BIN) = 16 Then
                Dim Value_1 As Double = (channel_1_double - 65536) / 10
                datastring(0) = Str(Value_1)
            Else
                Dim Value_1 As Double = (channel_1_double) / 10
                datastring(0) = Str(Value_1)
            End If

            If Mid(channel_2_String_BIN, 1, 1) = "1" And Len(channel_2_String_BIN) = 16 Then
                Dim Value_2 As Double = (channel_2_double - 65536) / 10
                datastring(1) = Str(Value_2)
            Else
                Dim Value_2 As Double = (channel_2_double) / 10
                datastring(1) = Str(Value_2)
            End If

            If Mid(channel_3_String_BIN, 1, 1) = "1" And Len(channel_3_String_BIN) = 16 Then
                Dim Value_3 As Double = (channel_3_double - 65536) / 10
                datastring(2) = Str(Value_3)
            Else
                Dim Value_3 As Double = (channel_3_double) / 10
                datastring(2) = Str(Value_3)
            End If

            If Mid(channel_4_String_BIN, 1, 1) = "1" And Len(channel_4_String_BIN) = 16 Then
                Dim Value_4 As Double = (channel_4_double - 65536) / 10
                datastring(3) = Str(Value_4)
            Else
                Dim Value_4 As Double = (channel_4_double) / 10
                datastring(3) = Str(Value_4)
            End If


        Else
            Communicate_Status.Text = "通信：异常"
            Communicate_Status.ForeColor = Color.Red
            For i = 0 To 3
                datastring(i) = "0"
            Next i

        End If

        Return datastring
    End Function

    Private Sub ButSendPV_Click(sender As Object, e As EventArgs) Handles ButSendPV.Click
        If (SerialPort1.IsOpen = False) Then
            Try
                SerialPort1.ReceivedBytesThreshold = 10
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.Open()
                '判断通信是否正常
                SendOrderReadPV()
                System.Threading.Thread.Sleep(50)
                SerialPort1_DataReceived()
            Catch
                Communicate_Status.Text = "通信：异常"
                MsgBox("通信异常")
                End
            End Try
        End If

        Timer1.Start()
        Status.Text = "状态：数据读写中"
        Status.ForeColor = Color.Green
        Form2.Status.Text = "状态：运行中"
        Form2.Status.ForeColor = Color.Green
        ButSendPV.Enabled = False
        ButStopPV.Enabled = True
        ButSetSC.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub ButStopPV_Click(sender As Object, e As EventArgs) Handles ButStopPV.Click
        Timer1.Stop()
        Status.Text = "状态：数据停止读写"
        Status.ForeColor = Color.Red
        Form2.Status.Text = "状态：停止运行"
        Form2.Status.ForeColor = Color.Red
        ButSetSC.Enabled = True
        Button3.Enabled = True
        ButSendPV.Enabled = True
        ButStopPV.Enabled = False
    End Sub

    Private Sub ButSetSC_Click(sender As Object, e As EventArgs) Handles ButSetSC.Click
        If Timer1.Enabled = True Then
            MsgBox("请停止读取PV值！")
        Else
            Timer1.Interval = Val(TxtSendCycle.Text) - 400
        End If
    End Sub
    '发送读取PV命令
    Private Sub SendOrderReadPV()
        Dim OrderPV(8) As Byte
        OrderPV(0) = Val("&H" & "01")
        OrderPV(1) = Val("&H" & "03")
        OrderPV(2) = Val("&H" & "00")
        OrderPV(3) = Val("&H" & "64")
        OrderPV(4) = Val("&H" & "00")
        OrderPV(5) = Val("&H" & "08")
        OrderPV(6) = Val("&H" & "05")
        OrderPV(7) = Val("&H" & "D3")
        SerialPort1.Write(OrderPV, 0, 8) '请求PV值命令(16进制)
    End Sub

    '十六进制转十进制
    Private Function Hex_2_Dec(ByVal num As String) As Long
        Dim i, b As Long
        num = UCase(num)
        For i = 1 To Len(num)

            Select Case Mid(num, Len(num) - i + 1, 1)
                Case "0" : b = b + 16 ^ (i - 1) * 0
                Case "1" : b = b + 16 ^ (i - 1) * 1
                Case "2" : b = b + 16 ^ (i - 1) * 2
                Case "3" : b = b + 16 ^ (i - 1) * 3
                Case "4" : b = b + 16 ^ (i - 1) * 4
                Case "5" : b = b + 16 ^ (i - 1) * 5
                Case "6" : b = b + 16 ^ (i - 1) * 6
                Case "7" : b = b + 16 ^ (i - 1) * 7
                Case "8" : b = b + 16 ^ (i - 1) * 8
                Case "9" : b = b + 16 ^ (i - 1) * 9
                Case "A" : b = b + 16 ^ (i - 1) * 10
                Case "B" : b = b + 16 ^ (i - 1) * 11
                Case "C" : b = b + 16 ^ (i - 1) * 12
                Case "D" : b = b + 16 ^ (i - 1) * 13
                Case "E" : b = b + 16 ^ (i - 1) * 14
                Case "F" : b = b + 16 ^ (i - 1) * 15
                Case Else : b = "数据错误!"
            End Select
        Next i
        Return b
    End Function

    '十六进制转二进制
    Private Function Hex_2_Bin(ByVal num As String) As String
        Dim i As Long
        Dim b As String
        num = UCase(num)
        For i = 1 To Len(num)
            Select Case Mid(num, i, 1)
                Case "0" : b = b & "0000"
                Case "1" : b = b & "0001"
                Case "2" : b = b & "0010"
                Case "3" : b = b & "0011"
                Case "4" : b = b & "0100"
                Case "5" : b = b & "0101"
                Case "6" : b = b & "0110"
                Case "7" : b = b & "0111"
                Case "8" : b = b & "1000"
                Case "9" : b = b & "1001"
                Case "A" : b = b & "1010"
                Case "B" : b = b & "1011"
                Case "C" : b = b & "1100"
                Case "D" : b = b & "1101"
                Case "E" : b = b & "1110"
                Case "F" : b = b & "1111"
                Case Else : b = "数据错误!"
            End Select
        Next i
        Return b
    End Function

    '根据读取的数据改变动画中样品的RGB值
    Private Function Change_RGB(ByVal data() As String)
        Dim R, G_Array(4), B As Integer
        R = 28
        B = 240
        '选取函数G = 4.6444t + 107.67，以相应RGB值反映温度值
        G_Array(0) = Val(data(0)) * 4.6444 + 107.67
        G_Array(1) = Val(data(1)) * 4.6444 + 107.67
        G_Array(2) = Val(data(2)) * 4.6444 + 107.67
        G_Array(3) = Val(data(3)) * 4.6444 + 107.67

        '判断G值是否合法，不合法则赋值为0
        For i = 0 To 3
            If (G_Array(i) < 0 Or G_Array(i) > 255) Then G_Array(i) = 0
        Next i

        '设置样品RGB值
        Label20.BackColor = Color.FromArgb(R, G_Array(0), B)
        Label21.BackColor = Color.FromArgb(R, G_Array(1), B)
        Label22.BackColor = Color.FromArgb(R, G_Array(2), B)
        Label23.BackColor = Color.FromArgb(R, G_Array(3), B)

    End Function

    '显示曲线按键
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Button2.Text = "显示曲线") Then
            Form2.Show()
            Button2.Text = "隐藏曲线"
        ElseIf (Button2.Text = "隐藏曲线") Then
            Form2.Hide()
            Button2.Text = "显示曲线"
        End If

        If (Timer1.Enabled = True) Then
            Form2.Status.Text = "状态：运行中"
            Form2.Status.ForeColor = Color.Green
        Else
            Form2.Status.Text = "状态：停止运行"
            Form2.Status.ForeColor = Color.Red
        End If
    End Sub

    '设置串口按键
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Button3.Text = "设置串口") Then
            Form3.Show()
            Button3.Text = "关闭设置"
        ElseIf (Button3.Text = "关闭设置") Then
            Form3.Hide()
            Button3.Text = "设置串口"
        End If
    End Sub

    '判断是否达到准稳态，如果是，则计算导热系数
    Private Function Calculate_Heat_Conductivity_Coefficient(ByVal datastring() As String)
        Dim Delta_T1 As Double = Math.Abs(Val(datastring(0)) - Val(datastring(1)))
        Dim Delta_T2 As Double = Math.Abs(Val(datastring(2)) - Val(datastring(3)))
        Dim Quasi_Steady_State_1 As Boolean = 0
        Dim Quasi_Steady_State_2 As Boolean = 0
        Dim Sum As Double = 0

        Dim i As Integer
        For i = 0 To 3
            Delta_T1_Array(i) = Delta_T1_Array(i + 1)
            Delta_T2_Array(i) = Delta_T2_Array(i + 1)
        Next

        Delta_T1_Array(4) = Delta_T1
        Delta_T2_Array(4) = Delta_T2

        If (Math.Abs(Delta_T1_Array(0) - Delta_T1_Array(1)) <= 0.3 And
            Math.Abs(Delta_T1_Array(1) - Delta_T1_Array(2)) <= 0.3 And
            Math.Abs(Delta_T1_Array(2) - Delta_T1_Array(3)) <= 0.3 And
            Math.Abs(Delta_T1_Array(3) - Delta_T1_Array(4)) <= 0.3) Then
            Quasi_Steady_State_1 = 1
        End If

        If (Math.Abs(Delta_T2_Array(0) - Delta_T2_Array(1)) <= 0.3 And
            Math.Abs(Delta_T2_Array(1) - Delta_T2_Array(2)) <= 0.3 And
            Math.Abs(Delta_T2_Array(2) - Delta_T2_Array(3)) <= 0.3 And
            Math.Abs(Delta_T2_Array(3) - Delta_T2_Array(4)) <= 0.3) Then
            Quasi_Steady_State_2 = 1
        End If

        If (Quasi_Steady_State_1 And Quasi_Steady_State_2) Then
            For i = 0 To 4
                If (Delta_T1_Array(i) <> 0) Then
                    Ratio_Of_Delta_T(i) = Delta_T2_Array(i) / Delta_T1_Array(i)
                    Sum += Ratio_Of_Delta_T(i)
                Else
                    Ratio_Of_Delta_T(i) = 9999
                    Sum += Ratio_Of_Delta_T(i)
                End If
            Next
            Heat_Conductivity_Coefficient = Str(Math.Round(6 * Sum / 5, 2))
        Else
            Heat_Conductivity_Coefficient = "---"
        End If

        If (Val(Heat_Conductivity_Coefficient) > 999) Then
            Heat_Conductivity_Coefficient = "∞"
        End If

        Label28.Text = Heat_Conductivity_Coefficient
    End Function

End Class