Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace PieChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'gspDataSet.GSP' table. 
            ' You can move, or remove it, as needed.
            Me.gSPTableAdapter.Fill(Me.gspDataSet.GSP)

        End Sub

		Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
			e.LegendText &= " (" & (CType(e.SeriesPoint.Tag, DataRowView))("GSP").ToString() & ")"
		End Sub
	End Class
End Namespace
