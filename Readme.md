<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574476/19.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1411)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to display values both as real values and as percentages in a Pie chart's legend

This example demonstrates how you can force a [pie chart](https://docs.devexpress.com/WindowsForms/2967/controls-and-libraries/chart-control/series-views/2d-series-views/pie-and-donut-series-views?p=netframework)'s [legend](https://docs.devexpress.com/WindowsForms/5794/controls-and-libraries/chart-control/legends?p=netframework) to display point values both as *percentages* and as *real values*.

Specify a required pattern using the Series.[LegendTextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.LegendTextPattern?p=netframework) property (for example, *"{VP:P0} ({V:N2})"*).
