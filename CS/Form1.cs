using System;
using System.Windows.Forms;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
// ...

namespace docCustomDataItemsNames {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.DataSource = new MySqlDataSource((SqlDataSource)report.DataSource);
            ReportDesignTool designTool = new ReportDesignTool(report);
            designTool.ShowDesignerDialog();
        }
    }
}