'绘制曲线的窗口
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form2

    Private X1(20) As String    '定义曲线1X轴变量为时间
    Private Y1(20) As Double    '定义曲线1Y轴变量为瞬时流量
    Private X2(20) As String    '定义曲线2X轴变量为时间
    Private Y2(20) As Double    '定义曲线2Y轴变量为瞬时流量
    Private X3(20) As String    '定义曲线3X轴变量为时间
    Private Y3(20) As Double    '定义曲线3Y轴变量为瞬时流量
    Private X4(20) As String    '定义曲线4X轴变量为时间
    Private Y4(20) As Double    '定义曲线4Y轴变量为瞬时流量
    Private X5(20) As String    '定义曲线5X轴变量为时间
    Private Y5(20) As Double    '定义曲线5Y轴变量为瞬时流量
    Private fluxArea As ChartArea   '定义画图区域变量
    Private fluxArea2 As ChartArea
    Private fluxLegend As Legend    '定义Legends对象
    Private fluxLegend2 As Legend
    Private fluxLine1 As Series     '定义Serial对象
    Private fluxLine2 As Series
    Private fluxLine3 As Series
    Private fluxLine4 As Series
    Private fluxLine5 As Series
    Dim Heat_Conductivity_Coefficient As Double

    Public Sub Form2_Load() Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog    '设置窗体边界不可改变
        Me.MaximizeBox = False  '取消最大化
        Me.AutoSize = True      '自动调整窗口大小
        Me.ControlBox = False   '取消显示控件框

        '初始化chart1
        InitChart1Set()
        InitChart2Set()
        InitChart1Data()
        InitChart2Data()
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        Status.Text = "状态：停止运行"
        Status.ForeColor = Color.Red
    End Sub

    '初始化Chart1对象设置
    Private Sub InitChart1Set()
        '设置控件背景色
        Chart1.BackColor = Color.Linen
        '定义标题对象变量
        Dim ChartTitle As New Title
        '设置Title信息
        With ChartTitle
            .Text = "样品温度实时曲线"
            .ForeColor = Color.Black
            .Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        '清除所有标题对象
        Chart1.Titles.Clear()
        Chart1.Titles.Add(ChartTitle)
        '清空画图区域
        Chart1.ChartAreas.Clear()
        '创建chartarea对象实例
        fluxArea = New ChartArea("fluxArea")
        '将定义的画图区域添加到chart1
        Chart1.ChartAreas.Add(fluxArea)

        '设置显示区域
        With fluxArea
            '设置背景颜色为白色
            .BackColor = Color.Linen
            '设置X轴最小值
            .AxisX.Minimum = 0
            '设置X轴最大值
            .AxisX.Maximum = 20
            '设置X轴
            .AxisX.Interval = 1
            '设置X轴标题
            .AxisX.Title = "时间/s"
            '设置X轴标题字体
            .AxisX.TitleFont = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '设置X轴线宽
            .AxisX.LineWidth = 3
            '设置X轴颜色
            .AxisX.LineColor = Color.Black
            '设置X轴线型
            .AxisX.LineDashStyle = ChartDashStyle.Solid
            '设置X轴标题对齐
            .AxisX.TitleAlignment = StringAlignment.Center
            '设置X轴标题颜色
            .AxisX.TitleForeColor = Color.Black
            '设置X轴网格刻度线
            .AxisX.MajorGrid.LineColor = Color.Black
            '设置X轴网格刻度线宽度
            .AxisX.MajorGrid.LineWidth = 1
            '设置X轴网格刻度线样式
            .AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
            '设置X轴刻度线颜色
            .AxisX.MajorTickMark.LineColor = Color.Black
            '设置X轴刻度线长度
            .AxisX.MajorTickMark.Size = 2
            '设置X轴刻度线宽度
            .AxisX.MajorTickMark.LineWidth = 2
            '设置X轴刻度线样式
            .AxisX.MajorTickMark.LineDashStyle = ChartDashStyle.Solid
            '设置X轴刻度线位置
            .AxisX.MajorTickMark.TickMarkStyle = TickMarkStyle.OutsideArea
            '设置X轴标签颜色
            .AxisX.LabelStyle.ForeColor = Color.Black

            '设置Y轴最小值
            .AxisY.Minimum = -10D
            '设置Y轴最大值
            .AxisY.Maximum = 30D
            '设置Y轴标题
            .AxisY.Title = "样品温度/℃"
            '设置Y轴标题字体
            .AxisY.TitleFont = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '设置Y轴线宽
            .AxisY.LineWidth = 3
            '设置Y轴颜色
            .AxisY.LineColor = Color.Black
            '设置Y轴线型
            .AxisY.LineDashStyle = ChartDashStyle.Solid
            '设置Y轴标题对齐
            .AxisY.TitleAlignment = StringAlignment.Center
            '设置Y轴标题颜色
            .AxisY.TitleForeColor = Color.Black
            '设置Y轴网格刻度线
            .AxisY.MajorGrid.LineColor = Color.Black
            '设置Y轴网格刻度线宽度
            .AxisY.MajorGrid.LineWidth = 1
            '设置Y轴网格刻度线样式
            .AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
            '设置Y轴刻度线颜色
            .AxisY.MajorTickMark.LineColor = Color.Black
            '设置Y轴刻度线长度
            .AxisY.MajorTickMark.Size = 2
            '设置Y轴刻度线宽度
            .AxisY.MajorTickMark.LineWidth = 2
            '设置Y轴刻度线样式
            .AxisY.MajorTickMark.LineDashStyle = ChartDashStyle.Solid
            '设置Y轴刻度线位置
            .AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.OutsideArea
            '设置Y轴标签颜色
            .AxisY.LabelStyle.ForeColor = Color.Black
        End With

        '创建Legends对象实例
        fluxLegend = New Legend("fluxLegend")
        '设置Legends对象
        With fluxLegend
            '设置图例停靠位置为自动
            .Position.Auto = True
            '设置图例对齐方式为居中
            .Alignment = StringAlignment.Center
            '设置图例停靠位置为底部
            .Docking = Docking.Bottom
            '设置图例的背景色为透明
            .BackColor = Color.Transparent
            '设置图例的字体颜色为黑色
            .ForeColor = Color.Black
            '设置图例字体
            .Font = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With

        '清除默认Legends
        Chart1.Legends.Clear()
        Chart1.Legends.Add(fluxLegend)

        '创建series对象实例
        fluxLine1 = New Series("fluxLine1")
        fluxLine2 = New Series("fluxLine2")
        fluxLine3 = New Series("fluxLine3")
        fluxLine4 = New Series("fluxLine4")

        '设置Serial对象1
        With fluxLine1
            '设置图表类型
            .ChartType = SeriesChartType.Spline
            '设置画线区域
            .ChartArea = "fluxArea"
            '设置画线的宽度
            .BorderWidth = 3
            '设置画线颜色
            .Color = Color.Blue
            '设置画线阴影
            .ShadowOffset = 0
            '设置图示文字
            .LegendText = "冰A面温度"
            '设置图例属性
            .Legend = "fluxLegend"
        End With

        '设置Serial对象2
        With fluxLine2
            '设置图表类型
            .ChartType = SeriesChartType.Spline
            '设置画线区域
            .ChartArea = "fluxArea"
            '设置画线的宽度
            .BorderWidth = 3
            '设置画线颜色
            .Color = Color.Orange
            '设置画线阴影
            .ShadowOffset = 0
            '设置图示文字
            .LegendText = "冰B面温度"
            '设置图例属性
            .Legend = "fluxLegend"
        End With

        '设置Serial对象3
        With fluxLine3
            '设置图表类型
            .ChartType = SeriesChartType.Spline
            '设置画线区域
            .ChartArea = "fluxArea"
            '设置画线的宽度
            .BorderWidth = 3
            '设置画线颜色
            .Color = Color.Green
            '设置画线阴影
            .ShadowOffset = 0
            '设置图示文字
            .LegendText = "硅胶A面温度"
            '设置图例属性
            .Legend = "fluxLegend"
        End With

        '设置Serial对象4
        With fluxLine4
            '设置图表类型
            .ChartType = SeriesChartType.Spline
            '设置画线区域
            .ChartArea = "fluxArea"
            '设置画线的宽度
            .BorderWidth = 3
            '设置画线颜色
            .Color = Color.Red
            '设置画线阴影
            .ShadowOffset = 0
            '设置图示文字
            .LegendText = "硅胶B面温度"
            '设置图例属性
            .Legend = "fluxLegend"
        End With


        '清除默认series
        Chart1.Series.Clear()
        '将定义好的曲线对象添加到chart
        Chart1.Series.Add(fluxLine1)
        Chart1.Series.Add(fluxLine2)
        Chart1.Series.Add(fluxLine3)
        Chart1.Series.Add(fluxLine4)
    End Sub

    '设置初始chart1数据
    Private Sub InitChart1Data()
        Dim i As Integer = 0
        For i = 0 To 20
            X1(i) = i
            X2(i) = i
            Y1(i) = 0
            Y2(i) = 0
            X3(i) = i
            X4(i) = i
            Y3(i) = 0
            Y4(i) = 0
        Next
        '显示数据
        Chart1.Series("fluxLine1").Points.DataBindXY(X1, Y1)
        Chart1.Series("fluxLine2").Points.DataBindXY(X2, Y2)
        Chart1.Series("fluxLine3").Points.DataBindXY(X3, Y3)
        Chart1.Series("fluxLine4").Points.DataBindXY(X4, Y4)
    End Sub

    '更新chart1数据
    Public Sub RefreshChart1Data(ByVal data() As String)
        Dim i As Integer
        For i = 0 To 19
            X1(i) = X1(i + 1)
            X2(i) = X2(i + 1)
            X3(i) = X3(i + 1)
            X4(i) = X4(i + 1)

            Y1(i) = Y1(i + 1)
            Y2(i) = Y2(i + 1)
            Y3(i) = Y3(i + 1)
            Y4(i) = Y4(i + 1)
        Next

        Y1(20) = Val(data(0))
        X1(20) = Form1.Count_Time
        Y2(20) = Val(data(1))
        X2(20) = Form1.Count_Time
        Y3(20) = Val(data(2))
        X3(20) = Form1.Count_Time
        Y4(20) = Val(data(3))
        X4(20) = Form1.Count_Time

        Chart1.Series("fluxLine1").Points.DataBindXY(X1, Y1)
        Chart1.Series("fluxLine2").Points.DataBindXY(X2, Y2)
        Chart1.Series("fluxLine3").Points.DataBindXY(X3, Y3)
        Chart1.Series("fluxLine4").Points.DataBindXY(X4, Y4)

    End Sub

    '设置曲线1是否可见
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = False) Then
            Chart1.Series("fluxLine1").Color = Color.Transparent
        ElseIf (CheckBox1.Checked = True) Then
            Chart1.Series("fluxLine1").Color = Color.Blue
        End If
    End Sub

    '设置曲线2是否可见
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = False) Then
            Chart1.Series("fluxLine2").Color = Color.Transparent
        ElseIf (CheckBox2.Checked = True) Then
            Chart1.Series("fluxLine2").Color = Color.Orange
        End If
    End Sub

    '设置曲线3是否可见
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked = False) Then
            Chart1.Series("fluxLine3").Color = Color.Transparent
        ElseIf (CheckBox3.Checked = True) Then
            Chart1.Series("fluxLine3").Color = Color.Green
        End If
    End Sub

    '设置曲线4是否可见
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked = False) Then
            Chart1.Series("fluxLine4").Color = Color.Transparent
        ElseIf (CheckBox4.Checked = True) Then
            Chart1.Series("fluxLine4").Color = Color.Red
        End If
    End Sub

    '初始化Chart2对象设置
    Private Sub InitChart2Set()
        '设置控件背景色
        Chart2.BackColor = Color.Linen
        '定义标题对象变量
        Dim ChartTitle2 As New Title
        '设置Title信息
        With ChartTitle2
            .Text = "导热系数实时曲线"
            .ForeColor = Color.Black
            .Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        '清除所有标题对象
        Chart2.Titles.Clear()
        Chart2.Titles.Add(ChartTitle2)
        '清空画图区域
        Chart2.ChartAreas.Clear()
        '创建chartarea对象实例
        fluxArea2 = New ChartArea("fluxArea2")
        '将定义的画图区域添加到chart1
        Chart2.ChartAreas.Add(fluxArea2)

        '设置显示区域
        With fluxArea2
            '设置背景颜色为白色
            .BackColor = Color.Linen
            '设置X轴最小值
            .AxisX.Minimum = 0
            '设置X轴最大值
            .AxisX.Maximum = 20
            '设置X轴
            .AxisX.Interval = 1
            '设置X轴标题
            .AxisX.Title = "时间/s"
            '设置X轴标题字体
            .AxisX.TitleFont = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '设置X轴线宽
            .AxisX.LineWidth = 3
            '设置X轴颜色
            .AxisX.LineColor = Color.Black
            '设置X轴线型
            .AxisX.LineDashStyle = ChartDashStyle.Solid
            '设置X轴标题对齐
            .AxisX.TitleAlignment = StringAlignment.Center
            '设置X轴标题颜色
            .AxisX.TitleForeColor = Color.Black
            '设置X轴网格刻度线
            .AxisX.MajorGrid.LineColor = Color.Black
            '设置X轴网格刻度线宽度
            .AxisX.MajorGrid.LineWidth = 1
            '设置X轴网格刻度线样式
            .AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
            '设置X轴刻度线颜色
            .AxisX.MajorTickMark.LineColor = Color.Black
            '设置X轴刻度线长度
            .AxisX.MajorTickMark.Size = 2
            '设置X轴刻度线宽度
            .AxisX.MajorTickMark.LineWidth = 2
            '设置X轴刻度线样式
            .AxisX.MajorTickMark.LineDashStyle = ChartDashStyle.Solid
            '设置X轴刻度线位置
            .AxisX.MajorTickMark.TickMarkStyle = TickMarkStyle.OutsideArea
            '设置X轴标签颜色
            .AxisX.LabelStyle.ForeColor = Color.Black

            '设置Y轴最小值
            .AxisY.Minimum = 0D
            '设置Y轴最大值
            .AxisY.Maximum = 5D
            '设置Y轴标题
            .AxisY.Title = "导热系数"
            '设置Y轴标题字体
            .AxisY.TitleFont = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '设置Y轴线宽
            .AxisY.LineWidth = 3
            '设置Y轴颜色
            .AxisY.LineColor = Color.Black
            '设置Y轴线型
            .AxisY.LineDashStyle = ChartDashStyle.Solid
            '设置Y轴标题对齐
            .AxisY.TitleAlignment = StringAlignment.Center
            '设置Y轴标题颜色
            .AxisY.TitleForeColor = Color.Black
            '设置Y轴网格刻度线
            .AxisY.MajorGrid.LineColor = Color.Black
            '设置Y轴网格刻度线宽度
            .AxisY.MajorGrid.LineWidth = 1
            '设置Y轴网格刻度线样式
            .AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
            '设置Y轴刻度线颜色
            .AxisY.MajorTickMark.LineColor = Color.Black
            '设置Y轴刻度线长度
            .AxisY.MajorTickMark.Size = 2
            '设置Y轴刻度线宽度
            .AxisY.MajorTickMark.LineWidth = 2
            '设置Y轴刻度线样式
            .AxisY.MajorTickMark.LineDashStyle = ChartDashStyle.Solid
            '设置Y轴刻度线位置
            .AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.OutsideArea
            '设置Y轴标签颜色
            .AxisY.LabelStyle.ForeColor = Color.Black
        End With

        '创建Legends对象实例
        fluxLegend2 = New Legend("fluxLegend2")
        '设置Legends对象
        With fluxLegend2
            '设置图例停靠位置为自动
            .Position.Auto = True
            '设置图例对齐方式为居中
            .Alignment = StringAlignment.Center
            '设置图例停靠位置为底部
            .Docking = Docking.Bottom
            '设置图例的背景色为透明
            .BackColor = Color.Transparent
            '设置图例的字体颜色为黑色
            .ForeColor = Color.Black
            '设置图例字体
            .Font = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With

        '清除默认Legends
        Chart2.Legends.Clear()
        Chart2.Legends.Add(fluxLegend2)

        '创建series对象实例
        fluxLine5 = New Series("fluxLine5")

        '设置Serial对象5
        With fluxLine5
            '设置图表类型
            .ChartType = SeriesChartType.Spline
            '设置画线区域
            .ChartArea = "fluxArea2"
            '设置画线的宽度
            .BorderWidth = 3
            '设置画线颜色
            .Color = Color.Black
            '设置画线阴影
            .ShadowOffset = 0
            '设置图示文字
            .LegendText = "导热系数"
            '设置图例属性
            .Legend = "fluxLegend2"
        End With

        '清除默认series
        Chart2.Series.Clear()
        '将定义好的曲线对象添加到chart
        Chart2.Series.Add(fluxLine5)
    End Sub

    '设置初始chart2数据
    Private Sub InitChart2Data()
        Dim i As Integer = 0
        For i = 0 To 20
            X5(i) = i
            Y5(i) = 0
        Next
        '显示数据
        Chart2.Series("fluxLine5").Points.DataBindXY(X5, Y5)
    End Sub

    '更新chart2数据
    Public Sub RefreshChart2Data()
        Dim i As Integer
        For i = 0 To 19
            X5(i) = X5(i + 1)
            Y5(i) = Y5(i + 1)
        Next

        If (Form1.Heat_Conductivity_Coefficient <> "---" And Form1.Heat_Conductivity_Coefficient <> "∞") Then
            Heat_Conductivity_Coefficient = Val(Form1.Heat_Conductivity_Coefficient)
        Else
            Heat_Conductivity_Coefficient = 0
        End If

        X5(20) = Form1.Count_Time
        Y5(20) = Heat_Conductivity_Coefficient

        Chart2.Series("fluxLine5").Points.DataBindXY(X5, Y5)
    End Sub
End Class