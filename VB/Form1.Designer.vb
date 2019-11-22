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
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Dim pieSeriesLabel2 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView2 As New DevExpress.XtraCharts.PieSeriesView()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.gSPTableAdapter = New PieChart.gspDataSetTableAdapters.GSPTableAdapter()
			Me.gSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gspDataSet = New PieChart.gspDataSet()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gspDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.DataAdapter = Me.gSPTableAdapter
			Me.chartControl1.DataSource = Me.gSPBindingSource
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentDataMember = "Region"
			series1.FilterCriteria = New DevExpress.Data.Filtering.BinaryOperator("Year", 2004, DevExpress.Data.Filtering.BinaryOperatorType.Equal)
			pieSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
			series1.Label = pieSeriesLabel1
			series1.LegendTextPattern = "{VP:P0} ({V:N2})"
			series1.Name = "Series 1"
			series1.ValueDataMembersSerializable = "GSP"
			series1.View = pieSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			pieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chartControl1.SeriesTemplate.Label = pieSeriesLabel2
			Me.chartControl1.SeriesTemplate.View = pieSeriesView2
			Me.chartControl1.Size = New System.Drawing.Size(649, 420)
			Me.chartControl1.TabIndex = 0
			' 
			' gSPTableAdapter
			' 
			Me.gSPTableAdapter.ClearBeforeFill = True
			' 
			' gSPBindingSource
			' 
			Me.gSPBindingSource.DataMember = "GSP"
			Me.gSPBindingSource.DataSource = Me.gspDataSet
			' 
			' gspDataSet
			' 
			Me.gspDataSet.DataSetName = "gspDataSet"
			Me.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(649, 420)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
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

