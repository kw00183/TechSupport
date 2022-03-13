using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class TechnicianIncidentUserControl : UserControl
    {
        private List<Technician> technicianList;
        private TechnicianController technicianController;

        public TechnicianIncidentUserControl()
        {
            InitializeComponent();
            technicianController = new TechnicianController();

            this.emailTextBox.ReadOnly = true;
            this.phoneTextBox.ReadOnly = true;
            this.technicianNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void TechnicianIncidentUserControl_Load(object sender, EventArgs e)
        {
            technicianList = technicianController.GetAssignedTechnicians();
            technicianNameComboBox.DataSource = technicianList;
        }

        private void technicianNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (technicianNameComboBox.SelectedIndex < 0)
            {
                return;
            }

            Technician technician = technicianList[technicianNameComboBox.SelectedIndex];

            technicianBindingSource.Clear();

            technicianBindingSource.Add(technician);
        }
    }
}
