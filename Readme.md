# How to display a WebChartControl in the detail row of the ASPxGridView


<p>This example illustrates how to use a WebChartControl as a detail template when implementing master-detail ASPxGridView. To do this, a chart is added to the ASPxGridView.Templates.DetailRow template. Then in the code behind, the chart is populated with data (in the Init() method). The WebChartControl.NamingContainer property is used to obtain a GridViewDetailRowTemplateContainer and its KeyValue to filter a chart data accordingly.</p><p>Please review the <a href="http://documentation.devexpress.com/#AspNet/CustomDocument3772"><u>Master-Detail Relationship</u></a> for more information about the master-detail data presentation in the ASPxGridView</p>

<br/>


