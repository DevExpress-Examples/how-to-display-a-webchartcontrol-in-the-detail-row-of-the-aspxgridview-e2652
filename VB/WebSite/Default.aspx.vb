Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxGridView1.DataBind()
			ASPxGridView1.DetailRows.ExpandRow(0)
		End If
	End Sub

	Protected Sub WebChartControl1_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim chart As WebChartControl = CType(sender, WebChartControl)
		Dim container As GridViewDetailRowTemplateContainer = TryCast(chart.NamingContainer, GridViewDetailRowTemplateContainer)
		Dim categoryId As Integer = Convert.ToInt32(container.KeyValue)
		Dim categoryName As String = ASPxGridView1.GetRowValuesByKeyValue(categoryId, New String() { "CategoryName" }).ToString()
		Dim series As New Series(categoryName, ViewType.Bar)

		series.ArgumentDataMember = "ProductName"
		series.ValueDataMembers.AddRange(New String() { "UnitPrice" })
		chart.Series.Add(series)
		CType(chart.Diagram, XYDiagram).AxisX.Label.Angle = 90
		Session("CategoryID") = categoryId
		chart.DataSource = detailDataSource.Select(DataSourceSelectArguments.Empty)
		chart.DataBind()
	End Sub

End Class
