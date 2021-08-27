<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574476/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1411)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to display values both as real values and as percentages in a Pie chart's legend


<p>This example demonstrates how you can force a <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument2967.htm">pie chart</a>'s <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5794.htm">legend</a> to display point values both as <em>percentages</em> and as <em>real values</em>.</p>
<p>First, make sure that the <strong>Series.LegendPointOptions.PercentOptions.ValueAsPercent</strong> property is enabled. Then, set the <strong>Series.LegendPointOptions.PointView</strong> property to <strong>Values</strong>. And, handle the chart's <strong>CustomDrawSeriesPoint</strong> event in the way shown in this example.</p>
<p>A related tutorial can be found in our online documentation at <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5858.htm">How to: Show Values as Percents in the Legend of a Pie Chart</a>.<br /><br /><strong>UPDATE</strong>: In the latest version it is possible to remove the CustomDrawSeriesPoint event handler and specify a required pattern using the Series -> <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesBase_LegendTextPatterntopic">LegendTextPattern</a> property.</p>

<br/>


