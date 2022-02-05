using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class OpenIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        public OpenIncidentUserControl()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentController();
        }

        public void RefreshOpenIncidentListView()
        {
            this.incidentController.GetOpenIncidents();
        }

        private void OpenIncidentListView_VisibleChanged(object sender, EventArgs e)
        {
            RefreshOpenIncidentListView();
        }
    }
}
