using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class LoadIncidentUserControl : UserControl
    {
        #region Data members

        private readonly IncidentController incidentController;

        public DialogResult DialogResult { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the add incident form
        /// </summary>
        public LoadIncidentUserControl()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentController();
        }

        #endregion

        #region Methods

        public void RefreshIncidentDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = this.incidentController.GetAllIncidents();
        }

        #endregion

        private void IncidentDataGridView_VisibleChanged(object sender, EventArgs e)
        {
            RefreshIncidentDataGrid();
        }
    }
}
