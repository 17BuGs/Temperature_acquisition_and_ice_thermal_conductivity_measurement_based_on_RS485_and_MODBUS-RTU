<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxName = New System.Windows.Forms.ComboBox()
        Me.ComboBoxQC = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxSP = New System.Windows.Forms.ComboBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxPr = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxDB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxBR = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButComAddress = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxName)
        Me.GroupBox1.Controls.Add(Me.ComboBoxQC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSP)
        Me.GroupBox1.Controls.Add(Me.TxtAddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPr)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(401, 349)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PC串口设置"
        '
        'ComboBoxName
        '
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(115, 38)
        Me.ComboBoxName.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(208, 26)
        Me.ComboBoxName.TabIndex = 12
        Me.ComboBoxName.Text = "COM3"
        '
        'ComboBoxQC
        '
        Me.ComboBoxQC.FormattingEnabled = True
        Me.ComboBoxQC.Items.AddRange(New Object() {"None", "RTS", "XOn/XOff", "RTSXOn/XOff"})
        Me.ComboBoxQC.Location = New System.Drawing.Point(114, 259)
        Me.ComboBoxQC.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxQC.Name = "ComboBoxQC"
        Me.ComboBoxQC.Size = New System.Drawing.Size(211, 26)
        Me.ComboBoxQC.TabIndex = 11
        Me.ComboBoxQC.Text = "None"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 262)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "流控："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "通讯地址："
        '
        'ComboBoxSP
        '
        Me.ComboBoxSP.FormattingEnabled = True
        Me.ComboBoxSP.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.ComboBoxSP.Location = New System.Drawing.Point(115, 218)
        Me.ComboBoxSP.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSP.Name = "ComboBoxSP"
        Me.ComboBoxSP.Size = New System.Drawing.Size(211, 26)
        Me.ComboBoxSP.TabIndex = 9
        Me.ComboBoxSP.Text = "1"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(115, 303)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(211, 28)
        Me.TxtAddress.TabIndex = 30
        Me.TxtAddress.Text = "01"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 222)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "停止位："
        '
        'ComboBoxPr
        '
        Me.ComboBoxPr.FormattingEnabled = True
        Me.ComboBoxPr.Items.AddRange(New Object() {"None", "Even", "Odd", "Mark", "Space"})
        Me.ComboBoxPr.Location = New System.Drawing.Point(114, 174)
        Me.ComboBoxPr.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPr.Name = "ComboBoxPr"
        Me.ComboBoxPr.Size = New System.Drawing.Size(211, 26)
        Me.ComboBoxPr.TabIndex = 7
        Me.ComboBoxPr.Text = "None"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "校验位："
        '
        'ComboBoxDB
        '
        Me.ComboBoxDB.FormattingEnabled = True
        Me.ComboBoxDB.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.ComboBoxDB.Location = New System.Drawing.Point(114, 130)
        Me.ComboBoxDB.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxDB.Name = "ComboBoxDB"
        Me.ComboBoxDB.Size = New System.Drawing.Size(212, 26)
        Me.ComboBoxDB.TabIndex = 5
        Me.ComboBoxDB.Text = "8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "数据位："
        '
        'ComboBoxBR
        '
        Me.ComboBoxBR.FormattingEnabled = True
        Me.ComboBoxBR.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "19200"})
        Me.ComboBoxBR.Location = New System.Drawing.Point(114, 82)
        Me.ComboBoxBR.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxBR.Name = "ComboBoxBR"
        Me.ComboBoxBR.Size = New System.Drawing.Size(211, 26)
        Me.ComboBoxBR.TabIndex = 3
        Me.ComboBoxBR.Text = "9600"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "波特率："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "端口名称："
        '
        'ButComAddress
        '
        Me.ButComAddress.Location = New System.Drawing.Point(138, 370)
        Me.ButComAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.ButComAddress.Name = "ButComAddress"
        Me.ButComAddress.Size = New System.Drawing.Size(150, 46)
        Me.ButComAddress.TabIndex = 31
        Me.ButComAddress.Text = "保存设置"
        Me.ButComAddress.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(428, 444)
        Me.Controls.Add(Me.ButComAddress)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "pc串口设置"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents ComboBoxName As ComboBox
    Public WithEvents ComboBoxQC As ComboBox
    Public WithEvents ComboBoxSP As ComboBox
    Public WithEvents ComboBoxPr As ComboBox
    Public WithEvents ComboBoxDB As ComboBox
    Public WithEvents ComboBoxBR As ComboBox
    Friend WithEvents ButComAddress As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtAddress As TextBox
End Class
