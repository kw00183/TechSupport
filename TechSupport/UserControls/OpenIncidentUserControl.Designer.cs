
namespace TechSupport.UserControls
{
    partial class OpenIncidentUserControl
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
            this.listViewOpenIncidents = new System.Windows.Forms.ListView();
            this.productCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOpenedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technicianHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewOpenIncidents
            // 
            this.listViewOpenIncidents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCodeHeader,
            this.dateOpenedHeader,
            this.customerHeader,
            this.technicianHeader,
            this.titleHeader});
            this.listViewOpenIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOpenIncidents.Location = new System.Drawing.Point(3, 3);
            this.listViewOpenIncidents.Name = "listViewOpenIncidents";
            this.listViewOpenIncidents.Size = new System.Drawing.Size(424, 494);
            this.listViewOpenIncidents.TabIndex = 0;
            this.listViewOpenIncidents.UseCompatibleStateImageBehavior = false;
            this.listViewOpenIncidents.View = System.Windows.Forms.View.Details;
            this.listViewOpenIncidents.VisibleChanged += new System.EventHandler(this.OpenIncidentListView_VisibleChanged);
            // 
            // productCodeHeader
            // 
            this.productCodeHeader.Text = "Product Code";
            this.productCodeHeader.Width = 91;
            // 
            // dateOpenedHeader
            // 
            this.dateOpenedHeader.Text = "Date Opened";
            this.dateOpenedHeader.Width = 105;
            // 
            // customerHeader
            // 
            this.customerHeader.Text = "Customer";
            this.customerHeader.Width = 83;
            // 
            // technicianHeader
            // 
            this.technicianHeader.Text = "Technician";
            this.technicianHeader.Width = 86;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 116;
            // 
            // OpenIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewOpenIncidents);
            this.Name = "OpenIncidentUserControl";
            this.Size = new System.Drawing.Size(430, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOpenIncidents;
        private System.Windows.Forms.ColumnHeader productCodeHeader;
        private System.Windows.Forms.ColumnHeader dateOpenedHeader;
        private System.Windows.Forms.ColumnHeader customerHeader;
        private System.Windows.Forms.ColumnHeader technicianHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
    }
}
