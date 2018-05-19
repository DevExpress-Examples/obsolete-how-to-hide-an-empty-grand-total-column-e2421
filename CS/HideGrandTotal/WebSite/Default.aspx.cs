using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.XtraPivotGrid.Localization;
using DevExpress.XtraPivotGrid;

public partial class _Default : System.Web.UI.Page 
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void ASPxPivotGrid1_HtmlFieldValuePrepared(object sender, DevExpress.Web.ASPxPivotGrid.PivotHtmlFieldValuePreparedEventArgs e) {
        if(e.IsColumn) {
            e.Cell.Style[HtmlTextWriterStyle.Padding] = "0px";
            e.Cell.Text = "";
            e.Cell.BorderStyle = BorderStyle.None;
        } else {
            if(e.Field.AreaIndex == ASPxPivotGrid1.GetFieldCountByArea(PivotArea.RowArea) - 1)
                e.Cell.Style["border-right"] = "none";
        }
    }
    protected void ASPxPivotGrid1_HtmlCellPrepared(object sender, DevExpress.Web.ASPxPivotGrid.PivotHtmlCellPreparedEventArgs e) {
        e.Cell.Text = "";
    }
}
