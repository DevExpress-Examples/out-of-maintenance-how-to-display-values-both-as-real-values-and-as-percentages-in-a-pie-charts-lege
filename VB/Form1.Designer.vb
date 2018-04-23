Imports Microsoft.VisualBasic
Imports System
Namespace PieChart
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SimpleDiagram1 As DevExpress.XtraCharts.SimpleDiagram = New DevExpress.XtraCharts.SimpleDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.gSPTableAdapter = New gspDataSetTableAdapters.GSPTableAdapter()
            Me.gSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gspDataSet = New gspDataSet()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gspDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.DataAdapter = Me.gSPTableAdapter
            Me.chartControl1.DataSource = Me.gSPBindingSource
            SimpleDiagram1.EqualPieSize = False
            Me.chartControl1.Diagram = SimpleDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Series1.ArgumentDataMember = "Region"
            Series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("Year", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 2004)})
            PieSeriesLabel1.Antialiasing = True
            PieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            PieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
            Series1.Label = PieSeriesLabel1
            Series1.LegendTextPattern = "{VP:P0}"
            Series1.Name = "Series 1"
            Series1.SynchronizePointOptions = False
            Series1.ValueDataMembersSerializable = "GSP"
            PieSeriesView1.RuntimeExploding = False
            PieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
            Series1.View = PieSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
            PieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.SeriesTemplate.Label = PieSeriesLabel2
            Me.chartControl1.SeriesTemplate.SynchronizePointOptions = False
            PieSeriesView2.RuntimeExploding = False
            PieSeriesView2.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
            Me.chartControl1.SeriesTemplate.View = PieSeriesView2
            Me.chartControl1.Size = New System.Drawing.Size(649, 420)
            Me.chartControl1.TabIndex = 0
            '
            'gSPTableAdapter
            '
            Me.gSPTableAdapter.ClearBeforeFill = True
            '
            'gSPBindingSource
            '
            Me.gSPBindingSource.DataMember = "GSP"
            Me.gSPBindingSource.DataSource = Me.gspDataSet
            '
            'gspDataSet
            '
            Me.gspDataSet.DataSetName = "gspDataSet"
            Me.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(649, 420)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gspDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private gSPTableAdapter As gspDataSetTableAdapters.GSPTableAdapter
		Private gspDataSet As gspDataSet
		Private gSPBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace

