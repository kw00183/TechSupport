using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// class for search incident dialog form
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        #region Data members

        private readonly IncidentSearchController incidentController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the search incident form
        /// </summary>
        public SearchIncidentDialog()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentSearchController();
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
            catch (Exception ex)
            {
                MessageBox.Show("CustomerID cannot be empty" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
