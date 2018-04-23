Imports DevExpress.XtraCharts


Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GspDataSet.GSP' table. You can move, or remove it, as needed.
        Me.GSPTableAdapter.Fill(Me.GspDataSet.GSP)
    End Sub

    Private Sub ChartControl1_CustomDrawSeriesPoint(sender As System.Object, e As CustomDrawSeriesPointEventArgs) _
    Handles ChartControl1.CustomDrawSeriesPoint
        e.LegendText &= " (" & (CType(e.SeriesPoint.Tag, DataRowView))("GSP").ToString() & ")"
    End Sub

End Class
