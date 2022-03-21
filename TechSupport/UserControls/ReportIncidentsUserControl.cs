using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    /// <summary>
    /// user control class that encapsulates the report open incidents assigned controls
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class ReportIncidentsUserControl : UserControl
    {
        #region Constructors

        /// <summary>
        /// constructor used to create the report incident controls
        /// </summary>
        public ReportIncidentsUserControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Data Methods

        private void AssignedOpenIncidentsReportViewer_VisibleChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TechSupportDataSet.AssignOpenIncidents' table. You can move, or remove it, as needed.
            this.assignOpenIncidentsTableAdapter.Fill(this.techSupportDataSet.AssignOpenIncidents);

            this.assignedOpenIncidentsReportViewer.RefreshReport();
        }

        #endregion
    }
}
