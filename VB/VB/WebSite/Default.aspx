﻿<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v10.1, Version=10.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
			DataSourceID="AccessDataSource1" 
			onhtmlcellprepared="ASPxPivotGrid1_HtmlCellPrepared" 
			onhtmlfieldvalueprepared="ASPxPivotGrid1_HtmlFieldValuePrepared">
			<Fields>
				<dx:PivotGridField ID="fieldCategoryName" Area="RowArea" AreaIndex="0" FieldName="CategoryName">
				</dx:PivotGridField>
				<dx:PivotGridField ID="fieldProductName" Area="RowArea" AreaIndex="1" FieldName="ProductName">
				</dx:PivotGridField>
			</Fields>
			<OptionsView ShowColumnHeaders="False" ShowDataHeaders="False" 
				ShowFilterHeaders="False" />
			<Styles>
				<ColumnAreaStyle>
					<Paddings Padding="0px" />
				</ColumnAreaStyle>
				<CellStyle>
					<Paddings Padding="0px" />
				</CellStyle>
			</Styles>
		</dx:ASPxPivotGrid>
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
			SelectCommand="SELECT * FROM [ProductReports]"></asp:AccessDataSource>
	</div>
	</form>
</body>
</html>