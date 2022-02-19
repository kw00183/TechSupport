using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// user control class that encapsulates the add incident controls
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {
        #region Data members

        private readonly IncidentController incidentController;
        private readonly ProductController productController;
        private readonly CustomerController customerController;
        private readonly RegistrationController registrationController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the add incident controls
        /// </summary>
        public AddIncidentUserControl()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentController();
            this.productController = new ProductController();
            this.customerController = new CustomerController();
            this.registrationController = new RegistrationController();

            this.PopulateCustomerComboBox();
            this.PopulateProductComboBox();
        }

        #endregion

        #region Methods

        private void PopulateProductComboBox()
        {
            productComboBox.DataSource = productController.GetAllProductCodeAndNames();
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.DisplayMember = "Name";
            productComboBox.SelectedIndex = 0;
        }

        private void PopulateCustomerComboBox()
        {
            customerComboBox.DataSource = customerController.GetAllCustomerIDAndNames();
            customerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerComboBox.DisplayMember = "Name";
            customerComboBox.SelectedIndex = 0;
        }

        private List<CustomerIDAndName> GetCustomerList()
        {
            return customerController.GetAllCustomerIDAndNames();
        }

        private List<ProductCodeAndName> GetProductList()
        {
            return productController.GetAllProductCodeAndNames();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int customerIndexSelected = customerComboBox.SelectedIndex;
                int productIndexSelected = productComboBox.SelectedIndex;

                string productCodeSelected = GetProductList()[productIndexSelected].ProductCode;
                int customerIDSelected = GetCustomerList()[customerIndexSelected].CustomerID;

                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;

                Boolean isRegistered = this.registrationController.IsCustomerProductRegistered(customerIDSelected, productCodeSelected);

                if (isRegistered == false)
                {
                    string errorMessage = "No registration associated with the product";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if (title == "" || title == null || description == "" || description == null)
                {
                    string errorMessage = "Title and/or Description cannot be empty";
                    this.ShowInvalidErrorMessage(errorMessage);
                }

                if (isRegistered == true && String.IsNullOrEmpty(title) == false && String.IsNullOrEmpty(description) == false)
                {
                    Incident newIncident = new Incident(null, customerIDSelected, productCodeSelected, null, DateTime.Now, null, title, description);
                    this.incidentController.AddIncident(newIncident);
                    string errorMessage = "Incident Added";
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

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.PopulateCustomerComboBox();
            this.PopulateProductComboBox();
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.HideErrorMessage();
        }

        private void DescriptionTextBox_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        #endregion
    }
}
