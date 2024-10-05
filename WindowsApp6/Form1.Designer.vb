<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButSendPV = New System.Windows.Forms.Button()
        Me.ButStopPV = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TxtSendCycle = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ButSetSC = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Communicate_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Address = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButSendPV
        '
        Me.ButSendPV.Enabled = False
        Me.ButSendPV.Location = New System.Drawing.Point(346, 18)
        Me.ButSendPV.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSendPV.Name = "ButSendPV"
        Me.ButSendPV.Size = New System.Drawing.Size(125, 42)
        Me.ButSendPV.TabIndex = 22
        Me.ButSendPV.Text = "开始测量"
        Me.ButSendPV.UseVisualStyleBackColor = True
        '
        'ButStopPV
        '
        Me.ButStopPV.Enabled = False
        Me.ButStopPV.Location = New System.Drawing.Point(479, 18)
        Me.ButStopPV.Margin = New System.Windows.Forms.Padding(4)
        Me.ButStopPV.Name = "ButStopPV"
        Me.ButStopPV.Size = New System.Drawing.Size(125, 42)
        Me.ButStopPV.TabIndex = 23
        Me.ButStopPV.Text = "停止测量"
        Me.ButStopPV.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1600
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'TxtSendCycle
        '
        Me.TxtSendCycle.Location = New System.Drawing.Point(120, 26)
        Me.TxtSendCycle.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSendCycle.Name = "TxtSendCycle"
        Me.TxtSendCycle.Size = New System.Drawing.Size(52, 28)
        Me.TxtSendCycle.TabIndex = 0
        Me.TxtSendCycle.Text = "2000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 30)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "测量间隔"
        '
        'ButSetSC
        '
        Me.ButSetSC.Location = New System.Drawing.Point(213, 18)
        Me.ButSetSC.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSetSC.Name = "ButSetSC"
        Me.ButSetSC.Size = New System.Drawing.Size(125, 42)
        Me.ButSetSC.TabIndex = 2
        Me.ButSetSC.Text = "设置周期"
        Me.ButSetSC.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(180, 30)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 18)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "ms"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ButSetSC)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TxtSendCycle)
        Me.GroupBox3.Controls.Add(Me.ButSendPV)
        Me.GroupBox3.Controls.Add(Me.ButStopPV)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(877, 70)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "设置"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(745, 18)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 42)
        Me.Button3.TabIndex = 76
        Me.Button3.Text = "设置串口"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(612, 18)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 42)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "显示曲线"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 415)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "箱" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "体"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(949, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 415)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "箱" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "体"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 505)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(987, 60)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "箱体"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 415)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "泡" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "沫" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "层"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(869, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 415)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "泡" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "沫" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "层"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(196, 464)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(667, 28)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "绝热胶层"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Chocolate
        Me.Label7.Font = New System.Drawing.Font("黑体", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(490, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(5, 433)
        Me.Label7.TabIndex = 57
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Chocolate
        Me.Label8.Font = New System.Drawing.Font("黑体", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(559, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(5, 433)
        Me.Label8.TabIndex = 58
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(446, 42)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "泡沫盖"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(570, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(453, 42)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "泡沫盖"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(196, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(288, 42)
        Me.Label11.TabIndex = 61
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(570, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(293, 42)
        Me.Label12.TabIndex = 62
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Coral
        Me.Label13.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(36, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 133)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "大功率" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "制冷设备"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.LightSalmon
        Me.Label15.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(869, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(154, 133)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "小功率" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "制冷设备"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(208, 147)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 281)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "冷" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "室" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label18.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(755, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 281)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "冷" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "室" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Tan
        Me.Label19.Font = New System.Drawing.Font("黑体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.Location = New System.Drawing.Point(497, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 431)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "绝" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "热" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "板"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(497, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 134)
        Me.Label20.TabIndex = 68
        Me.Label20.Text = "冰" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "面"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(527, 129)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 134)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "冰" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "面"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(497, 294)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 134)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "硅胶" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "面"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(527, 294)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 134)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "硅胶" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B面"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label24.Location = New System.Drawing.Point(343, 129)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(141, 134)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "温度：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "______"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.Location = New System.Drawing.Point(570, 129)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(141, 134)
        Me.Label25.TabIndex = 73
        Me.Label25.Text = "温度：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "______"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label26.Location = New System.Drawing.Point(343, 291)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(141, 134)
        Me.Label26.TabIndex = 74
        Me.Label26.Text = "温度：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "______"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label27.Location = New System.Drawing.Point(570, 294)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(141, 134)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "温度：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "______"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1068, 577)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "仪器结构简图"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status, Me.Communicate_Status, Me.Address})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 684)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1091, 25)
        Me.StatusStrip1.TabIndex = 77
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Status.Margin = New System.Windows.Forms.Padding(0, 4, 17, 3)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(116, 18)
        Me.Status.Text = "状态：未运行"
        '
        'Communicate_Status
        '
        Me.Communicate_Status.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Communicate_Status.Margin = New System.Windows.Forms.Padding(0, 4, 17, 3)
        Me.Communicate_Status.Name = "Communicate_Status"
        Me.Communicate_Status.Size = New System.Drawing.Size(98, 18)
        Me.Communicate_Status.Text = "通信：未知"
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Address.Margin = New System.Windows.Forms.Padding(0, 4, 17, 3)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(206, 18)
        Me.Address.Text = ".txt文件保存路径：未知"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Location = New System.Drawing.Point(898, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 70)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "导热系数"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("黑体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label28.Location = New System.Drawing.Point(20, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(139, 36)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "---"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1091, 709)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "温度采集程序"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButSendPV As Button
    Friend WithEvents ButStopPV As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtSendCycle As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ButSetSC As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Timer1 As Timer
    Public WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Communicate_Status As ToolStripStatusLabel
    Friend WithEvents Status As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Address As ToolStripStatusLabel
End Class
