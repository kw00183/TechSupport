using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class SearchIncidentDialog : Form
    {
        #region Data members

        private readonly IncidentSearchController incidentController;

        #endregion

        #region Constructors

        public SearchIncidentDialog()
        {
            InitializeComponent();
            incidentController = new IncidentSearchController();
        }

        #endregion

        #region Methods

        private void RefreshSearchDataGrid()
        {
            searchDataGridView.DataSource = null;
            searchDataGridView.DataSource = incidentController.GetSearchIncidents();
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
                RefreshSearchDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
