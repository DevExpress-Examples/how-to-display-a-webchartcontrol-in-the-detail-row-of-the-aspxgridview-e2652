using System;
using System.Web.UI;
using DevExpress.Web.ASPxGridView;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ASPxGridView1.DataBind();
            ASPxGridView1.DetailRows.ExpandRow(0);
        }
    }

    protected void WebChartControl1_Init(object sender, EventArgs e)
    {
        WebChartControl chart = (WebChartControl)sender;
        GridViewDetailRowTemplateContainer container = chart.NamingContainer as GridViewDetailRowTemplateContainer;
        int categoryId = Convert.ToInt32(container.KeyValue);
        string categoryName = ASPxGridView1.GetRowValuesByKeyValue(categoryId, new string[] { "CategoryName" }).ToString();
        Series series = new Series(categoryName, ViewType.Bar);

        series.ArgumentDataMember = "ProductName";
        series.ValueDataMembers.AddRange(new string[] { "UnitPrice" });
        chart.Series.Add(series);
        ((XYDiagram)chart.Diagram).AxisX.Label.Angle = 90;
        Session["CategoryID"] = categoryId;
        chart.DataSource = detailDataSource.Select(DataSourceSelectArguments.Empty);
        chart.DataBind();
    }

}
