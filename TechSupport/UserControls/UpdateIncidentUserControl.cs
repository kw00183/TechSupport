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
    /// user control class that encapsulates the update incident controls
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class UpdateIncidentUserControl : UserControl
    {

        #region Data members

        private readonly TechnicianController technicianController;
        private readonly IncidentController incidentController;
        private readonly CustomerController customerController;

        private int loadedIncidentID;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the update incident controls
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            this.technicianController = new TechnicianController();
            this.incidentController = new IncidentController();
            this.customerController = new CustomerController();

            this.customerTextBox.ReadOnly = true;
            this.productCodeTextBox.ReadOnly = true;
            this.dateOpenedTextBox.ReadOnly = true;
            this.titleTextBox.ReadOnly = true;
            this.descriptionTextBox.ReadOnly = true;
        }

        #endregion

        #region Methods

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
                    var techID = incidentList[0].TechID;

                    if (techID == null)
                    {
                        technicianComboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        int technicianIndex = 0;
                        technicianIndex = GetTechnicianList().FindIndex(index => index.TechID == techID);
                        technicianComboBox.SelectedIndex = technicianIndex;
                    }

                    loadedIncidentID = (int)incidentList[0].IncidentID;

                    customerTextBox.Text = GetCustomerName(incidentList[0].CustomerID);
                    productCodeTextBox.Text = incidentList[0].ProductCode.Trim();
                    titleTextBox.Text = incidentList[0].Title;
                    dateOpenedTextBox.Text = incidentList[0].DateOpened.ToShortDateString();
                    descriptionTextBox.Text = incidentList[0].Description;
                    errorMessage = "";
                    this.ShowInvalidErrorMessage(errorMessage);

                    Boolean incidentClosed = this.IsIncidentClosed(incidentID);

                    if (!incidentClosed)
                    {
                        this.EnableUpdateFormElements(true);
                    }
                    else
                    {
                        this.EnableUpdateFormElements(false);

                    }
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

        private void EnableUpdateFormElements(Boolean enable)
        {
            if (enable)
            {
                this.updateButton.Enabled = true;
                this.closeButton.Enabled = true;
                this.technicianComboBox.Enabled = true;
                this.addTextTextBox.Enabled = true;
            }
            else
            {
                this.updateButton.Enabled = false;
                this.closeButton.Enabled = false;
                this.technicianComboBox.Enabled = false;
                this.addTextTextBox.Enabled = false;
            }
            
        }

        private string GetCustomerName(int customerID)
        {
            string customerName = "";
            List<Customer> customerList = customerController.GetCustomer(customerID);
            if (customerList.Count > 0)
            {
                customerName = customerList[0].Name;
            }
            return customerName;
        }

        private Boolean IsIncidentClosed(int incidentID)
        {
            Boolean incidentClosed = false;
            List<Incident> incidentList = incidentController.GetIncident(incidentID);

            if (DateTime.Parse(incidentList[0].DateClosed.ToString()).Year > 1900)
            {
                incidentClosed = true;
            }
            return incidentClosed;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            string message = "The incident cannot be updated in this form once closed. Do you still want to close the incident?";
            string title = "Close Incident";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string incidentIDEntered = incidentIDTextBox.Text;
                try
                {
                    Boolean getIncidentCheck = Int32.TryParse(incidentIDEntered, out int incidentID);
                    string errorMessage = "";

                    if (getIncidentCheck == false)
                    {
                        errorMessage = "IncidentID cannot be empty and must be a number";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                    else if (loadedIncidentID == incidentID)
                    {
                        incidentController.CloseIncident(incidentID);
                    }
                    else
                    {
                        errorMessage = "IncidentID has changed";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                }
                catch (Exception)
                {
                    string errorMessage = "Invalid entry";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.PopulateTechnicianComboBox();
            this.HideErrorMessage();
            this.incidentIDTextBox.Clear();
            this.customerTextBox.Clear();
            this.productCodeTextBox.Clear();
            this.dateOpenedTextBox.Clear();
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.addTextTextBox.Clear();
            this.technicianComboBox.Enabled = false;
            this.addTextTextBox.Enabled = false;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            this.PopulateTechnicianComboBox();

            this.EnableUpdateFormElements(false);
        }

        private void IncidentIDTextBox_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        #endregion
    }
}
