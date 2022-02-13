using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// user control class that encapsulates the search incident controls
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class SearchIncidentUserControl : UserControl
    {
        #region Data members

        private readonly IncidentController incidentController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the search incident controls
        /// </summary>
        public SearchIncidentUserControl()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentController();
        }

        #endregion

        #region Methods

        private void RefreshSearchDataGrid()
        {
            this.searchDataGridView.DataSource = null;
            
            try
            {
                int customerID = int.Parse(customerIDTextBox.Text);
                this.searchDataGridView.DataSource = incidentController.GetSearchIncidents(customerID);
            }
            catch (Exception)
            {
                string errorMessage = "CustomerID must be number and cannot be empty";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.RefreshSearchDataGrid();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.searchDataGridView.DataSource = null;
            this.customerIDTextBox.Text = "";
            this.HideErrorMessage();
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void SearchDataGridView_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        #endregion
    }
}
