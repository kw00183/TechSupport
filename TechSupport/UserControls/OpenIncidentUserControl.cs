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
    /// <summary>
    /// user control class that encapsulates the load open incident controls
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class OpenIncidentUserControl : UserControl
    {
        #region Data Members

        private readonly IncidentController incidentController;

        #endregion

        #region Controllers

        /// <summary>
        /// constructor used to create the open incident controls
        /// </summary>
        public OpenIncidentUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to load the open incidents and loop
        /// </summary>
        public void RefreshOpenIncidentListView()
        {
            List<OpenIncident> openIncidentList;
            try
            {
                openIncidentList = incidentController.GetOpenIncidents();

                if (openIncidentList.Count > 0)
                {
                    listViewOpenIncidents.Items.Clear();
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

        #endregion
    }
}
