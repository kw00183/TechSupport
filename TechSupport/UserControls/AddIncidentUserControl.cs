using System;
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

        private readonly ProductController productController;
        private readonly CustomerController customerController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the add incident controls
        /// </summary>
        public AddIncidentUserControl()
        {
            this.InitializeComponent();
            this.productController = new ProductController();
            this.customerController = new CustomerController();

            this.PopulateProductComboBox();
            this.PopulateCustomerComboBox();
        }

        #endregion

        #region Methods

        private void PopulateProductComboBox()
        {
            var products = productController.GetAllProductCodeAndNames();
            foreach (var product in products)
            {
                productComboBox.Items.Add(product.Name);
            }
            productComboBox.SelectedIndex = 0;
        }

        private void PopulateCustomerComboBox()
        {
            var customers = customerController.GetAllCustomerIDAndNames();
            foreach (var customer in customers)
            {
                customerComboBox.Items.Add(customer.Name);
            }
            customerComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //string customerSelected = customerComboBox.GetItemText(customerComboBox.SelectedItem);
            //string productSelected = productComboBox.GetItemText(productComboBox.SelectedItem);



            try
            {
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;

                string errorMessage = "XXX";
                this.ShowInvalidErrorMessage(errorMessage);
            }
            catch (Exception)
            {
                string errorMessage = "CustomerID must be number and fields cannot be empty";
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

        private void CustomerIDTextBox_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        #endregion
    }
}
