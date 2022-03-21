using Microsoft.Reporting.WebForms;
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
            this.assignedOpenIncidentsTableAdapter.Fill(this.techSupportDataSetVM.AssignedOpenIncidents);

            this.assignedOpenIncidentsReportViewer.RefreshReport();

            this.assignedOpenIncidentsReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }

        #endregion
    }
}
