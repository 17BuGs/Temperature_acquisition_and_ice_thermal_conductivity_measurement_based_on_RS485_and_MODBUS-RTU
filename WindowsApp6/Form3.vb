'设置串口的窗口
Public Class Form3

    Dim addr1 As String     '地址第一位数
    Dim addr2 As String     '地址第二位数

    Public Sub Form3_Load() Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog    '设置窗体边界不可改变
        Me.MaximizeBox = False  '取消最大化
        Me.AutoSize = True      '自动调整窗口大小
        Me.ControlBox = False   '取消显示控件框
    End Sub

    '选择串口号
    Private Sub ComboBoxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxName.SelectedIndexChanged
        Form1.SerialPort1.PortName = ComboBoxName.Text
    End Sub

    '选择波特率值 
    Private Sub ComboBoxBR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBR.SelectedIndexChanged
        Form1.SerialPort1.BaudRate = Val(ComboBoxBR.Text)
    End Sub

    '选择数据位
    Private Sub ComboBoxDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDB.SelectedIndexChanged
        Form1.SerialPort1.DataBits = Val(ComboBoxDB.Text)
    End Sub

    '选择校验位
    Private Sub ComboBoxPr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPr.SelectedIndexChanged
        Select Case ComboBoxPr.Text
            Case "None"
                Form1.SerialPort1.Parity = IO.Ports.Parity.None
                Exit Select
            Case "Even"
                Form1.SerialPort1.Parity = IO.Ports.Parity.Even
                Exit Select
            Case "Odd"
                Form1.SerialPort1.Parity = IO.Ports.Parity.Odd
                Exit Select
            Case "Mark"
                Form1.SerialPort1.Parity = IO.Ports.Parity.Mark
                Exit Select
            Case "Space"
                Form1.SerialPort1.Parity = IO.Ports.Parity.Space
                Exit Select
        End Select
    End Sub

    '选择停止位
    Private Sub ComboBoxSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSP.SelectedIndexChanged
        Select Case ComboBoxSP.Text
            Case "1"
                Form1.SerialPort1.StopBits = IO.Ports.StopBits.One
                Exit Select
            Case "1.5"
                Form1.SerialPort1.StopBits = IO.Ports.StopBits.OnePointFive
                Exit Select
            Case "2"
                Form1.SerialPort1.StopBits = IO.Ports.StopBits.Two
        End Select
    End Sub

    Private Sub ComboBoxQC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxQC.SelectedIndexChanged
        Select Case ComboBoxQC.Text
            Case "None"
                Form1.SerialPort1.Handshake = IO.Ports.Handshake.None
                Exit Select
            Case "RTS"
                Form1.SerialPort1.Handshake = IO.Ports.Handshake.RequestToSend
                Exit Select
            Case "XOn/XOff"
                Form1.SerialPort1.Handshake = IO.Ports.Handshake.XOnXOff
                Exit Select
            Case "RTSXOn/XOff"
                Form1.SerialPort1.Handshake = IO.Ports.Handshake.RequestToSendXOnXOff
        End Select
    End Sub

    Private Sub ButComAddress_Click(sender As Object, e As EventArgs) Handles ButComAddress.Click
        Dim t1, t2 As Char
        t1 = Mid(TxtAddress.Text, 1, 1)
        t2 = Mid(TxtAddress.Text, 2, 1)
        addr1 = Hex(Asc(Val(t1)))
        addr2 = Hex(Asc(Val(t2)))
    End Sub
End Class