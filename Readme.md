<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2652)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to display a WebChartControl in the detail row of the ASPxGridView


<p>This example illustrates how to use a WebChartControl as a detail template when implementing master-detail ASPxGridView. To do this, a chart is added to the ASPxGridView.Templates.DetailRow template. Then in the code behind, the chart is populated with data (in the Init() method). The WebChartControl.NamingContainer property is used to obtain a GridViewDetailRowTemplateContainer and its KeyValue to filter a chart data accordingly.</p><p>Please review the <a href="http://documentation.devexpress.com/#AspNet/CustomDocument3772"><u>Master-Detail Relationship</u></a> for more information about the master-detail data presentation in the ASPxGridView</p>

<br/>


