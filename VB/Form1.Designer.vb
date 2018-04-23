<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PiePointOptions2 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.GspDataSet = New PieChart.gspDataSet()
        Me.GSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPTableAdapter = New PieChart.gspDataSetTableAdapters.GSPTableAdapter()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GspDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        Me.ChartControl1.DataAdapter = Me.GSPTableAdapter
        Me.ChartControl1.DataSource = Me.GSPBindingSource
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "Region"
        Series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("Year", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 2004)})
        PieSeriesLabel1.LineVisible = True
        PiePointOptions1.PointView = DevExpress.XtraCharts.PointView.Argument
        PieSeriesLabel1.PointOptions = PiePointOptions1
        PieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
        Series1.Label = PieSeriesLabel1
        PiePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent
        PiePointOptions2.ValueNumericOptions.Precision = 0
        Series1.LegendPointOptions = PiePointOptions2
        Series1.Name = "Series 1"
        Series1.SynchronizePointOptions = False
        Series1.ValueDataMembersSerializable = "GSP"
        PieSeriesView1.RuntimeExploding = False
        Series1.View = PieSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        PieSeriesLabel2.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = PieSeriesLabel2
        PieSeriesView2.RuntimeExploding = False
        Me.ChartControl1.SeriesTemplate.View = PieSeriesView2
        Me.ChartControl1.Size = New System.Drawing.Size(564, 372)
        Me.ChartControl1.TabIndex = 0
        '
        'GspDataSet
        '
        Me.GspDataSet.DataSetName = "gspDataSet"
        Me.GspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GSPBindingSource
        '
        Me.GSPBindingSource.DataMember = "GSP"
        Me.GSPBindingSource.DataSource = Me.GspDataSet
        '
        'GSPTableAdapter
        '
        Me.GSPTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 372)
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GspDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GSPTableAdapter As PieChart.gspDataSetTableAdapters.GSPTableAdapter
    Friend WithEvents GspDataSet As PieChart.gspDataSet
    Friend WithEvents GSPBindingSource As System.Windows.Forms.BindingSource

End Class
