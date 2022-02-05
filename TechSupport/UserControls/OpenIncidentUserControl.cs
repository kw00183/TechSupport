using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class OpenIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        public OpenIncidentUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        public void RefreshOpenIncidentListView()
        {
            List<OpenIncident> openIncidentList;
            try
            {
                openIncidentList = incidentController.GetOpenIncidents();

                if (openIncidentList.Count > 0)
                {
                    OpenIncident openIncident;
                    for (int i = 0; i < openIncidentList.Count; i++)
                    {
                        openIncident = openIncidentList[i];
                        listViewOpenIncidents.Items.Add(openIncident.ProductCode.ToString());
                        listViewOpenIncidents.Items[i].SubItems.Add(openIncident.DateOpened.ToShortDateString());
                        listViewOpenIncidents.Items[i].SubItems.Add(openIncident.Customer.ToString());
                        listViewOpenIncidents.Items[i].SubItems.Add(openIncident.Technician.ToString());
                        listViewOpenIncidents.Items[i].SubItems.Add(openIncident.Title.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No Open Incidents");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void OpenIncidentListView_VisibleChanged(object sender, EventArgs e)
        {
            RefreshOpenIncidentListView();
        }
    }
}
