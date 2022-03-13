
namespace TechSupport.UserControls
{
    partial class TechnicianIncidentUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneLabel = new System.Windows.Forms.Label();
            this.technicianNameComboBox = new System.Windows.Forms.ComboBox();
            this.technicianNameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.technicianOpenIncidentDataGridView = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOpenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianOpenIncidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openIncidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicianOpenIncidentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianOpenIncidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(138, 91);
            this.phoneTextBox.MaxLength = 50;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(275, 26);
            this.phoneTextBox.TabIndex = 23;
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataSource = typeof(TechSupport.Model.Technician);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(69, 88);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.phoneLabel.Size = new System.Drawing.Size(55, 25);
            this.phoneLabel.TabIndex = 28;
            this.phoneLabel.Text = "Phone";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // technicianNameComboBox
            // 
            this.technicianNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Name", true));
            this.technicianNameComboBox.DataSource = this.technicianBindingSource;
            this.technicianNameComboBox.DisplayMember = "Name";
            this.technicianNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianNameComboBox.FormattingEnabled = true;
            this.technicianNameComboBox.Location = new System.Drawing.Point(137, 3);
            this.technicianNameComboBox.Name = "technicianNameComboBox";
            this.technicianNameComboBox.Size = new System.Drawing.Size(275, 28);
            this.technicianNameComboBox.TabIndex = 37;
            this.technicianNameComboBox.SelectedIndexChanged += new System.EventHandler(this.TechnicianNameComboBox_SelectedIndexChanged);
            this.technicianNameComboBox.VisibleChanged += new System.EventHandler(this.TechnicianNameComboBox_VisibleChanged);
            // 
            // technicianNameLabel
            // 
            this.technicianNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.technicianNameLabel.AutoSize = true;
            this.technicianNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianNameLabel.Location = new System.Drawing.Point(73, 0);
            this.technicianNameLabel.Name = "technicianNameLabel";
            this.technicianNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.technicianNameLabel.Size = new System.Drawing.Size(51, 25);
            this.technicianNameLabel.TabIndex = 42;
            this.technicianNameLabel.Text = "Name";
            this.technicianNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(137, 48);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(275, 26);
            this.emailTextBox.TabIndex = 39;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(76, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.emailLabel.Size = new System.Drawing.Size(48, 25);
            this.emailLabel.TabIndex = 33;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.11765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.technicianNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.technicianNameComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.phoneLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneTextBox, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.57471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.42529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 134);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // technicianOpenIncidentDataGridView
            // 
            this.technicianOpenIncidentDataGridView.AllowUserToAddRows = false;
            this.technicianOpenIncidentDataGridView.AllowUserToDeleteRows = false;
            this.technicianOpenIncidentDataGridView.AllowUserToOrderColumns = true;
            this.technicianOpenIncidentDataGridView.AutoGenerateColumns = false;
            this.technicianOpenIncidentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.technicianOpenIncidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technicianOpenIncidentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.dateOpenedDataGridViewTextBoxColumn,
            this.Customer,
            this.titleDataGridViewTextBoxColumn});
            this.technicianOpenIncidentDataGridView.DataSource = this.technicianOpenIncidentBindingSource;
            this.technicianOpenIncidentDataGridView.Location = new System.Drawing.Point(11, 149);
            this.technicianOpenIncidentDataGridView.Name = "technicianOpenIncidentDataGridView";
            this.technicianOpenIncidentDataGridView.ReadOnly = true;
            this.technicianOpenIncidentDataGridView.Size = new System.Drawing.Size(417, 347);
            this.technicianOpenIncidentDataGridView.TabIndex = 36;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Name";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // dateOpenedDataGridViewTextBoxColumn
            // 
            this.dateOpenedDataGridViewTextBoxColumn.DataPropertyName = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.HeaderText = "Date Opened";
            this.dateOpenedDataGridViewTextBoxColumn.Name = "dateOpenedDataGridViewTextBoxColumn";
            this.dateOpenedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // technicianOpenIncidentBindingSource
            // 
            this.technicianOpenIncidentBindingSource.DataSource = typeof(TechSupport.Model.OpenIncidentAssigned);
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataSource = typeof(TechSupport.Model.Incident);
            // 
            // openIncidentBindingSource
            // 
            this.openIncidentBindingSource.DataSource = typeof(TechSupport.Model.OpenIncident);
            // 
            // TechnicianIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.technicianOpenIncidentDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TechnicianIncidentUserControl";
            this.Size = new System.Drawing.Size(439, 508);
            this.Load += new System.EventHandler(this.TechnicianIncidentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicianOpenIncidentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianOpenIncidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.ComboBox technicianNameComboBox;
        private System.Windows.Forms.Label technicianNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView technicianOpenIncidentDataGridView;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.BindingSource openIncidentBindingSource;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private System.Windows.Forms.BindingSource technicianOpenIncidentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}
