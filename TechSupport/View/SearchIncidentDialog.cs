using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// class for search incident dialog form
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        #region Data members

        private readonly IncidentController incidentController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the search incident form
        /// </summary>
        public SearchIncidentDialog()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentController();
        }

        #endregion

        #region Methods

        private void RefreshSearchDataGrid()
        {
            this.searchDataGridView.DataSource = null;
            this.searchDataGridView.DataSource = incidentController.GetSearchIncidents();
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            using (Form addIncidentDialog = new AddIncidentDialog())
            {
                DialogResult result = addIncidentDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.RefreshSearchDataGrid();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            try
            {
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.incidentController.Search(customerID);
                this.RefreshSearchDataGrid();
            }
            catch (Exception)
            {
                this.ShowInvalidErrorMessage();
                /* MessageBox.Show("CustomerID cannot be empty" + Environment.NewLine + ex.Message,
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
            errorMessageLabel.Text = "CustomerID must be number and cannot be empty";
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        #endregion
    }
}
