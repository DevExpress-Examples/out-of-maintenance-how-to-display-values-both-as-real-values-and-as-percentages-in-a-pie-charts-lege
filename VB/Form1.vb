Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Designer.Native

Namespace PieChart
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'gspDataSet.GSP' table. 
			' You can move, or remove it, as needed.
			Me.gSPTableAdapter.Fill(Me.gspDataSet.GSP)

		End Sub


	End Class
End Namespace
