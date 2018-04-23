using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace PieChart {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'gspDataSet.GSP' table. 
            // You can move, or remove it, as needed.
            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);

        }

        private void chartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText += " (" + ((DataRowView)e.SeriesPoint.Tag)["GSP"].ToString() + ")";
        }
    }
}
