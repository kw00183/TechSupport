using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// class for add incident dialog form
    /// </summary>
    public partial class AddIncidentDialog : Form
    {
        #region Data members

        private readonly IncidentAddController incidentController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the add incident form
        /// </summary>
        public AddIncidentDialog()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentAddController();
        }

        #endregion

        #region Methods

        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                var customerID = int.Parse(this.customerIDTextBox.Text);
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;

                this.incidentController.Add(new Incident(customerID, title, description));

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                this.ShowInvalidErrorMessage();
                /* MessageBox.Show("CustomerID must be number and title/description must have a value" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); */
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage()
        {
            errorMessageLabel.Text = "CustomerID must be number and fields cannot be empty";
            errorMessageLabel.ForeColor = Color.Red;
        }

        #endregion

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
    }
}
