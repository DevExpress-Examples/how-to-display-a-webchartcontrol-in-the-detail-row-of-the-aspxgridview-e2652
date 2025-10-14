<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574412/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2652)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-chart-display-web-chart-control-in-detail-grid-row&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-chart-display-web-chart-control-in-detail-grid-row&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
