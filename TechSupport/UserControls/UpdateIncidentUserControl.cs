using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : UserControl
    {

        #region Data members

        private readonly TechnicianController technicianController;
        private readonly IncidentController incidentController;

        #endregion

        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            this.technicianController = new TechnicianController();
            this.incidentController = new IncidentController();

            this.PopulateTechnicianComboBox();
        }

        private void PopulateTechnicianComboBox()
        {
            technicianComboBox.DataSource = GetTechnicianList();
            technicianComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            technicianComboBox.DisplayMember = "Name";
            technicianComboBox.SelectedIndex = 0;
        }

        private List<TechnicianIDAndName> GetTechnicianList()
        {
            List<TechnicianIDAndName> newList = technicianController.GetAllTechnicianIDAndNames();
            newList.Insert(0, new TechnicianIDAndName(0, "-- Unassigned --"));
            return newList;
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean getIncidentCheck = Int32.TryParse(incidentIDTextBox.Text, out int incidentID);
                List<Incident> incidentList = new List<Incident>();
                string errorMessage = "";

                if (getIncidentCheck == false)
                {
                    errorMessage = "IncidentID cannot be empty and must be a number";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    incidentList = incidentController.GetIncident(incidentID);
                }

                if (getIncidentCheck == true && incidentList.Count > 0)
                {
                    titleTextBox.Text = incidentList[0].Title;
                    dateOpenedTextBox.Text = incidentList[0].DateOpened.ToShortDateString();
                    descriptionTextBox.Text = incidentList[0].Description;
                    errorMessage = "";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (getIncidentCheck == true && incidentList.Count == 0)
                {
                    errorMessage = "No Incident Found";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid form entries";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage(string errorMessage)
        {
            errorMessageLabel.Text = errorMessage;
            errorMessageLabel.ForeColor = Color.Red;
        }
    }
}
