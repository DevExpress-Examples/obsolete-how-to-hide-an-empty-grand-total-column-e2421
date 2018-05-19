Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraPivotGrid.Localization
Imports DevExpress.XtraPivotGrid

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub ASPxPivotGrid1_HtmlFieldValuePrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotHtmlFieldValuePreparedEventArgs)
		If e.IsColumn Then
			e.Cell.Style(HtmlTextWriterStyle.Padding) = "0px"
			e.Cell.Text = ""
			e.Cell.BorderStyle = BorderStyle.None
		Else
			If e.Field.AreaIndex = ASPxPivotGrid1.GetFieldCountByArea(PivotArea.RowArea) - 1 Then
				e.Cell.Style("border-right") = "none"
			End If
		End If
	End Sub
	Protected Sub ASPxPivotGrid1_HtmlCellPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotHtmlCellPreparedEventArgs)
		e.Cell.Text = ""
	End Sub
End Class
