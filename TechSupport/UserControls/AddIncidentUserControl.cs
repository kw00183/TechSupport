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
    public partial class AddIncidentUserControl : UserControl
    {
        #region Data members

        private readonly IncidentController incidentController;

        public DialogResult DialogResult { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the add incident form
        /// </summary>
        public AddIncidentUserControl()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentController();
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.customerIDTextBox.Clear();
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
        }
    }
}
