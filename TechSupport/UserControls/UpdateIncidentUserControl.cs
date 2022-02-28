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

        private Incident incident;
        private int customerID;
        private DateTime dateOpened;

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

            ClearForm();
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
            GetIncident();
        }

        private void GetIncident()
        {
            try
            {
                Boolean getIncidentCheck = Int32.TryParse(incidentIDTextBox.Text, out int incidentID);
                incident = new Incident();
                string errorMessage = "";

                if (getIncidentCheck == false)
                {
                    errorMessage = "IncidentID cannot be empty and must be a number";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    incident = incidentController.GetIncident(incidentID);
                    customerID = incident.CustomerID;
                    dateOpened = incident.DateOpened;
                }

                if (getIncidentCheck == true)
                {
                    var techID = incident.TechID;

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

                    DisplayIncidentData();

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
                else if (getIncidentCheck == true)
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

        private void PutIncidentData(Incident incident, string addText)
        {
            incident.CustomerID = customerID;
            incident.ProductCode = productCodeTextBox.Text;
            incident.TechID = GetTechIDSelected();
            incident.DateOpened = dateOpened;
            incident.DateClosed = null;
            incident.Title = titleTextBox.Text;
            incident.Description = descriptionTextBox.Text + addText;
        }

        private void DisplayIncidentData()
        {
            customerTextBox.Text = GetCustomerName(incident.CustomerID);
            productCodeTextBox.Text = incident.ProductCode.Trim();
            titleTextBox.Text = incident.Title;
            titleTextBox.ScrollBars = ScrollBars.Vertical;
            dateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
            descriptionTextBox.Text = incident.Description;
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            addTextTextBox.Text = "";
            addTextTextBox.ScrollBars = ScrollBars.Vertical;
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
            Incident incident = incidentController.GetIncident(incidentID);

            if (DateTime.Parse(incident.DateClosed.ToString()).Year > 1900)
            {
                incidentClosed = true;
            }
            return incidentClosed;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ValidateUpdate();
        }

        private int GetTechIDSelected()
        {
            int technicianIndexSelected = technicianComboBox.SelectedIndex;
            return GetTechnicianList()[technicianIndexSelected].TechID;
        }

        private void ValidateUpdate()
        {
            string incidentIDEntered = incidentIDTextBox.Text;
            string addTextEntered = addTextTextBox.Text;
            try
            {
                Boolean getIncidentCheck = Int32.TryParse(incidentIDEntered, out int incidentID);
                string errorMessage = "";

                if (getIncidentCheck == false)
                {
                    errorMessage = "IncidentID cannot be empty and must be a number";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (IsIncidentClosed(incidentID))
                {
                    GetIncident();
                    errorMessage = "Incident was closed by another user";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (incident.IncidentID == incidentID && addTextEntered.Length == 0 && incident.TechID == GetTechIDSelected())
                {
                    errorMessage = "Cannot update as no changes made";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (incident.IncidentID == incidentID && incident.Description.Length >= 200 && addTextEntered.Length > 0)
                {
                    errorMessage = "Description cannot accept any more text";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (incident.IncidentID == incidentID && (addTextEntered.Length > 0 || incident.TechID != GetTechIDSelected()))
                {
                    TryUpdateIncident();
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid validation";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private string CreateAddTextConcatenation()
        {
            string concatAddText = "";
            string addTextEntered = addTextTextBox.Text;
            if (addTextEntered.Length > 0)
            {
                concatAddText = "\r\n<" + DateTime.Now.ToString("MM/dd/yyyy") + "> " + addTextEntered;
            }
            return concatAddText;
        }

        private void TryUpdateIncident()
        {
            string errorMessage;
            try
            {
                Incident newIncident = new Incident();
                newIncident.IncidentID = incident.IncidentID;

                int newDescriptionLength = incident.Description.Length + CreateAddTextConcatenation().Length;
                if (newDescriptionLength > 200 && CreateAddTextConcatenation().Length > 0)
                {
                    string message = "The new text to add exceeds allowed characters. Do you want to truncate it and proceed?";
                    string title = "Update Incident";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    
                    int truncatedConcatAddTextLength = 200 - incident.Description.Length;
                    
                    if (result == DialogResult.Yes)
                    {
                        string addText = CreateAddTextConcatenation().Substring(0, truncatedConcatAddTextLength);
                        this.PutIncidentData(newIncident, addText);
                        errorMessage = "Updated description with added truncated message";
                        this.ProcessUpdate(incident, newIncident, errorMessage);
                    }
                }
                else if (newDescriptionLength <= 200 && CreateAddTextConcatenation().Length > 0)
                {
                    string addText = CreateAddTextConcatenation();
                    this.PutIncidentData(newIncident, addText);
                    errorMessage = "Updated description with added message";
                    this.ProcessUpdate(incident, newIncident, errorMessage);
                }
                else if (incident.TechID != GetTechIDSelected())
                {
                    string addText = CreateAddTextConcatenation();
                    this.PutIncidentData(newIncident, addText);
                    errorMessage = "Updated technician";
                    this.ProcessUpdate(incident, newIncident, errorMessage);
                }
            }
            catch (Exception)
            {
                errorMessage = "Invalid update";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void ProcessUpdate(Incident oldIncident, Incident newIncident, string errorMessage)
        {
            try
            {
                Boolean isIncidentUpdated = incidentController.UpdateIncident(oldIncident, newIncident);

                if (!isIncidentUpdated)
                {
                    GetIncident();
                    errorMessage = "Description or Technician has changed by another user, so new entry cannot update";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    GetIncident();
                    errorMessage = "Updated";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
            }
            catch (Exception)
            {
                errorMessage = "Invalid update";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            int technicianIndexSelected = technicianComboBox.SelectedIndex;

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
                    else if (incident.IncidentID != incidentID)
                    {
                        errorMessage = "IncidentID has changed, so new entry cannot close";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                    else if (IsIncidentClosed(incidentID))
                    {
                        GetIncident();
                        errorMessage = "Incident was closed by another user";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                    else if (GetTechnicianList()[technicianIndexSelected].TechID == 0)
                    {
                        errorMessage = "Cannot close incident without assigning technician";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                    else
                    {
                        incidentController.CloseIncident(incidentID);
                        GetIncident();
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
            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
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

        private void IncidentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.PopulateTechnicianComboBox();
            this.HideErrorMessage();
            this.customerTextBox.Clear();
            this.productCodeTextBox.Clear();
            this.dateOpenedTextBox.Clear();
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.addTextTextBox.Clear();
            this.technicianComboBox.Enabled = false;
            this.addTextTextBox.Enabled = false;
            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
        }
    }
}
