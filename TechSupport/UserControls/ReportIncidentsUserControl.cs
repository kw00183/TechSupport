using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class ReportIncidentsUserControl : UserControl
    {
        public ReportIncidentsUserControl()
        {
            InitializeComponent();
        }

        private void AssignedOpenIncidentsReportViewer_VisibleChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TechSupportDataSet.AssignOpenIncidents' table. You can move, or remove it, as needed.
            this.assignOpenIncidentsTableAdapter.Fill(this.techSupportDataSet.AssignOpenIncidents);

            this.assignedOpenIncidentsReportViewer.RefreshReport();
        }
    }
}
