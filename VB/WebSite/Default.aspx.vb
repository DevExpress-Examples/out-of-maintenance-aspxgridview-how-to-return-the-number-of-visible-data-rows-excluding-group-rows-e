Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		grid.DataSource = GetDataSource(50)
		grid.DataBind()
	End Sub
	Protected Sub DataBound(ByVal sender As Object, ByVal e As EventArgs)
		SetItemCount()
	End Sub
	Protected Sub PreRender(ByVal sender As Object, ByVal e As EventArgs)
		SetItemCount()
	End Sub
	Protected Sub BeforeGetCallbackResult(ByVal sender As Object, ByVal e As EventArgs)
		SetItemCount()
	End Sub
	Private Sub SetItemCount()
		Dim itemCount As Integer = CInt(Fix(grid.GetTotalSummaryValue(grid.TotalSummary("City"))))
		grid.SettingsPager.Summary.Text = "Page {0} of {1} (" & itemCount.ToString() & " items)"
	End Sub
	Private Function GetDataSource(ByVal count As Integer) As Object
		Dim result As New List(Of Object)()
		For i As Integer = 0 To count - 1
			result.Add(New With {Key .ID = i, Key .City = "City_" & i})
		Next i
		Return result
	End Function
End Class