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
    /// user control for assigned technicians
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class TechnicianIncidentUserControl : UserControl
    {
        #region Data Members

        private Technician technician;
        private List<Technician> technicianList;
        private List<OpenIncidentAssigned> technicianOpenIncidentList;
        private TechnicianController technicianController;
        private IncidentController incidentController;

        #endregion

        #region Constructors

        /// <summary>
        /// create a TechnicianIncidentUserControl object
        /// </summary>
        public TechnicianIncidentUserControl()
        {
            InitializeComponent();
            technicianController = new TechnicianController();
            incidentController = new IncidentController();

            this.emailTextBox.ReadOnly = true;
            this.phoneTextBox.ReadOnly = true;
            this.technicianNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #endregion

        #region Methods

        private void TechnicianIncidentUserControl_Load(object sender, EventArgs e)
        {
            technicianList = technicianController.GetAssignedTechnicians();
            technicianNameComboBox.DataSource = technicianList;

            technician = technicianList[0];

            technicianOpenIncidentList = incidentController.GetTechnicianOpenIncidents(technician.TechID);
            PopulateDataGridView(technicianOpenIncidentList);
        }

        private void TechnicianNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (technicianNameComboBox.SelectedIndex < 0)
            {
                return;
            }

            technician = technicianList[technicianNameComboBox.SelectedIndex];
            technicianBindingSource.Clear();
            technicianBindingSource.Add(technician);

            technicianOpenIncidentList = incidentController.GetTechnicianOpenIncidents(technician.TechID);
            PopulateDataGridView(technicianOpenIncidentList);
        }

        private void PopulateDataGridView(List<OpenIncidentAssigned> technicianOpenIncidentList)
        {
            technicianOpenIncidentBindingSource.Clear();

            foreach (OpenIncidentAssigned go in technicianOpenIncidentList)
            {
                OpenIncidentAssigned assigned = new OpenIncidentAssigned();
                assigned.Name = go.Name;
                assigned.DateOpened = go.DateOpened.Date;
                assigned.Customer = go.Customer;
                assigned.Title = go.Title;
                technicianOpenIncidentBindingSource.Add(assigned);
            }
        }

        private void TechnicianNameComboBox_VisibleChanged(object sender, EventArgs e)
        {
            technicianList = technicianController.GetAssignedTechnicians();
            technicianNameComboBox.DataSource = technicianList;

            technician = technicianList[0];

            technicianOpenIncidentList = incidentController.GetTechnicianOpenIncidents(technician.TechID);
            PopulateDataGridView(technicianOpenIncidentList);
        }

        #endregion
    }
}
