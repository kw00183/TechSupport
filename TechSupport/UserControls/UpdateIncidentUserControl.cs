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
        private DateTime? dateClosed;

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

        private bool IsIncidentClosed(int incidentID)
        {
            bool incidentClosed = false;
            Incident incident = incidentController.GetIncident(incidentID);

            if (DateTime.Parse(incident.DateClosed.ToString()).Year > 1900)
            {
                incidentClosed = true;
            }
            return incidentClosed;
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
                bool getIncidentCheck = Int32.TryParse(incidentIDTextBox.Text, out int incidentID);
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
                    dateClosed = incident.DateClosed;
                }

                if (getIncidentCheck == true && incident.CustomerID > 0)
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

                    bool incidentClosed = this.IsIncidentClosed(incidentID);

                    if (incidentClosed == false)
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
            incident.DateClosed = dateClosed;
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

        private void EnableUpdateFormElements(bool enable)
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ProcessUpdate();
        }

        private int GetTechIDSelected()
        {
            int technicianIndexSelected = technicianComboBox.SelectedIndex;
            return GetTechnicianList()[technicianIndexSelected].TechID;
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

        private void ProcessUpdate()
        {
            string addTextEntered = addTextTextBox.Text;
            string errorMessage;
            try
            {
                Incident newIncident = new Incident
                {
                    IncidentID = incident.IncidentID
                };
                this.PutIncidentData(newIncident, CreateAddTextConcatenation());

                int newDescriptionLength = incident.Description.Length + CreateAddTextConcatenation().Length;

                if (incident.Description.Length >= 200 && addTextEntered.Length > 0)
                {
                    errorMessage = "Description cannot accept any more text";
                    addTextTextBox.Text = "";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if ((addTextEntered.Length > 0 || incident.TechID != GetTechIDSelected()) &&
                    newDescriptionLength > 200 && CreateAddTextConcatenation().Length > 0)
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

                        incidentController.UpdateIncident(incident, newIncident);
                        GetIncident();
                        errorMessage = "Updated description with added truncated message";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                }
                else if ((addTextEntered.Length > 0 || incident.TechID != GetTechIDSelected()) && 
                    newDescriptionLength <= 200 && CreateAddTextConcatenation().Length > 0)
                {
                    string addText = CreateAddTextConcatenation();
                    this.PutIncidentData(newIncident, addText);

                    incidentController.UpdateIncident(incident, newIncident);
                    GetIncident();
                    errorMessage = "Updated description with added message";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (incident.TechID != GetTechIDSelected())
                {
                    string addText = CreateAddTextConcatenation();
                    this.PutIncidentData(newIncident, addText);

                    incidentController.UpdateIncident(incident, newIncident);
                    GetIncident();
                    errorMessage = "Updated technician";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (!incidentController.UpdateIncident(incident, newIncident))
                {
                    GetIncident();
                    errorMessage = "Description, Technician or Status has changed by another user, so cannot update";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (addTextEntered.Length == 0 && incident.TechID == GetTechIDSelected())
                {
                    GetIncident();
                    errorMessage = "No changes made";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    incidentController.UpdateIncident(incident, newIncident);
                    GetIncident();
                    errorMessage = "Incident Updated";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                errorMessage = "Invalid update";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ProcessClose();
        }

        private void ProcessClose()
        {
            int technicianIndexSelected = technicianComboBox.SelectedIndex;

            Incident newIncident = new Incident
            {
                IncidentID = incident.IncidentID
            };
            this.PutIncidentData(newIncident, CreateAddTextConcatenation());

            string message = "The incident cannot be updated in this form once closed. Do you still want to close the incident?";
            string title = "Close Incident";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string errorMessage;

                    if (GetTechnicianList()[technicianIndexSelected].TechID == 0)
                    {
                        GetIncident();
                        errorMessage = "Cannot close incident without assigning technician";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                    else if (!incidentController.CloseIncident(incident, newIncident))
                    {
                        GetIncident();
                        errorMessage = "Incident has already been closed";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                    else
                    {
                        incidentController.CloseIncident(incident, newIncident);
                        GetIncident();
                        errorMessage = "Incident closed";
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

        #endregion
    }
}
