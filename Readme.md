# ASP.NET Web Forms Chart - Display a WebChartControl in the grid detail row

This example illustrates how to use a WebChartControl as a detail template in a ASPxGridView component.

## Implementation Details

* Add a chart to the grid's [DetailRow](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewTemplates.DetailRow) template.
* Populate the chart with data (using the `Init()` method).
* Obtain a [GridViewDetailRowTemplateContainer](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewDetailRowTemplateContainer) and its [KeyValue](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewBaseRowTemplateContainer.KeyValue) using the [WebChartControl.NamingContainer](https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.control.namingcontainer#system-web-ui-control-namingcontainer) property.

## Files to Review

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Documentation

* [Master-Detail Relationship](https://docs.devexpress.com/AspNet/3772/components/grid-view/concepts/master-detail-relationship)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-display-a-webchartcontrol-in-the-detail-row-of-the-aspxgridview-e2652&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-display-a-webchartcontrol-in-the-detail-row-of-the-aspxgridview-e2652&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
