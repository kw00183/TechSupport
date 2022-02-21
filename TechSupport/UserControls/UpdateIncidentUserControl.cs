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

        private int dbIncidentID;
        private int dbCustomerID;
        private string dbProductCode;
        private int dbTechID;
        private DateTime dbDateOpened;
        private string dbTitle;
        private string dbDescription;

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
            GetIncident();   
        }

        private void GetIncident()
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

                    AssignDatabaseFields(incidentList);

                    AssignTextBoxFields();

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

        private void AssignDatabaseFields(List<Incident> incidentList)
        {
            dbIncidentID = (int)incidentList[0].IncidentID;
            dbCustomerID = incidentList[0].CustomerID;
            dbProductCode = incidentList[0].ProductCode;
            dbTechID = (int)incidentList[0].TechID;
            dbDateOpened = incidentList[0].DateOpened;
            dbTitle = incidentList[0].Title;
            dbDescription = incidentList[0].Description;
        }

        private void AssignTextBoxFields()
        {
            customerTextBox.Text = GetCustomerName(dbCustomerID);
            productCodeTextBox.Text = dbProductCode.Trim();
            titleTextBox.Text = dbTitle;
            titleTextBox.ScrollBars = ScrollBars.Vertical;
            dateOpenedTextBox.Text = dbDateOpened.ToShortDateString();
            descriptionTextBox.Text = dbDescription;
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            addTextTextBox.Text = "";
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ValidateUpdateFields();
        }

        private void ValidateUpdateFields()
        {
            string incidentIDEntered = incidentIDTextBox.Text;
            string addTextTEntered = addTextTextBox.Text;
            try
            {
                Boolean getIncidentCheck = Int32.TryParse(incidentIDEntered, out int incidentID);
                string errorMessage = "";

                int technicianIndexSelected = technicianComboBox.SelectedIndex;
                int technicianSelected = GetTechnicianList()[technicianIndexSelected].TechID;

                if (getIncidentCheck == false)
                {
                    errorMessage = "IncidentID cannot be empty and must be a number";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (dbIncidentID != incidentID)
                {
                    errorMessage = "IncidentID has changed, so new entry cannot update";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (dbIncidentID == incidentID && dbDescription.Length > 2000)
                {
                    errorMessage = "Description cannot accept any more text";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (dbIncidentID == incidentID && (addTextTEntered.Length > 0 || dbTechID != technicianSelected))
                {
                    string concatAddText = "";
                    if (addTextTEntered.Length > 0)
                    {
                        concatAddText = "\r\n<" + DateTime.Now.ToString("MM/dd/yyyy") + "> " + addTextTEntered;
                    }
                    UpdateIncident(technicianSelected, concatAddText);
                }
                else
                {
                    errorMessage = "No changes made";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid entry";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void UpdateIncident(int? techID, string concatAddText)
        {
            string errorMessage;
            try
            {
                if (concatAddText != "" && dbDescription.Length <= 1800)
                {
                    if (concatAddText.Length > 200)
                    {
                        string message = "The new text to add exceeds 200 characters. Do you want to truncate it and proceed?";
                        string title = "Update Incident";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            Incident newIncident = CreateUpdateIncident(techID, concatAddText.Substring(0, 200));
                            errorMessage = "Updated description with added truncated message";
                            this.ProcessUpdate(newIncident, errorMessage);
                        }
                    }
                    else if (concatAddText.Length <= 200)
                    {
                        Incident newIncident = CreateUpdateIncident(techID, concatAddText);
                        errorMessage = "Updated description with added message";
                        this.ProcessUpdate(newIncident, errorMessage);
                    }
                }
                else if (concatAddText != "" && dbDescription.Length + concatAddText.Substring(0, 200).Trim().Length > 2000)
                {
                    errorMessage = "No more updates allowed to description";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (dbTechID != techID)
                {
                    Incident newIncident = CreateUpdateIncident(techID, concatAddText);
                    errorMessage = "Updated technician";
                    this.ProcessUpdate(newIncident, errorMessage);
                }
            }
            catch (Exception)
            {
                errorMessage = "Invalid entry";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void ProcessUpdate(Incident newIncident, string errorMessage)
        {
            incidentController.UpdateIncident(newIncident);
            GetIncident();
            this.ShowInvalidErrorMessage(errorMessage);
        }


        private Incident CreateUpdateIncident(int? techID, string concatAddText)
        {
            int? updateTechID;
            string updateDescription = concatAddText.Length == 0 ? dbDescription : dbDescription + concatAddText;
            updateTechID = techID == 0 ? null : techID;

            Incident newIncident = new Incident(
                dbIncidentID
                , dbCustomerID
                , dbProductCode
                , updateTechID
                , dbDateOpened
                , null
                , dbTitle
                , updateDescription);
            return newIncident;
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
                    else if (dbIncidentID != incidentID)
                    {
                        errorMessage = "IncidentID has changed, so new entry cannot close";
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
