Imports System
Imports System.Windows.Forms
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.UI
' ...

Namespace docCustomDataItemsNames
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			report.DataSource = New MySqlDataSource(CType(report.DataSource, SqlDataSource))
			Dim designTool As New ReportDesignTool(report)
			designTool.ShowDesignerDialog()
		End Sub
	End Class
End Namespace