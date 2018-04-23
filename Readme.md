# How to display values both as real values and as percentages in a Pie chart's legend


<p>This example demonstrates how you can force a <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument2967.htm">pie chart</a>'s <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5794.htm">legend</a> to display point values both as <em>percentages</em> and as <em>real values</em>.</p>
<p>First, make sure that the <strong>Series.LegendPointOptions.PercentOptions.ValueAsPercent</strong> property is enabled. Then, set the <strong>Series.LegendPointOptions.PointView</strong> property to <strong>Values</strong>. And, handle the chart's <strong>CustomDrawSeriesPoint</strong> event in the way shown in this example.</p>
<p>A related tutorial can be found in our online documentation at <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5858.htm">How to: Show Values as Percents in the Legend of a Pie Chart</a>.<br /><br /><strong>UPDATE</strong>: In the latest version it is possible to remove the CustomDrawSeriesPoint event handler and specify a required pattern using the Series -> <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesBase_LegendTextPatterntopic">LegendTextPattern</a> property.</p>

<br/>


