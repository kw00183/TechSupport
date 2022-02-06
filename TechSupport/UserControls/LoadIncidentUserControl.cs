using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// user control class that encapsulates the load all incident controls
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class LoadIncidentUserControl : UserControl
    {
        #region Data members

        private readonly IncidentController incidentController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the add incident controls
        /// </summary>
        public LoadIncidentUserControl()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentController();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to refresh and load all incidents
        /// </summary>
        public void RefreshIncidentDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = this.incidentController.GetAllIncidents();
        }

        private void IncidentDataGridView_VisibleChanged(object sender, EventArgs e)
        {
            RefreshIncidentDataGrid();
        }

        #endregion
    }
}
