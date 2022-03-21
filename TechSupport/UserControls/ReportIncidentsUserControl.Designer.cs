
namespace TechSupport.UserControls
{
    partial class ReportIncidentsUserControl
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.assignedOpenIncidentsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.techSupportDataSet = new TechSupport.TechSupportDataSet();
            this.assignOpenIncidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignOpenIncidentsTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.AssignOpenIncidentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignOpenIncidentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assignedOpenIncidentsReportViewer
            // 
            reportDataSource1.Name = "AssignedOpenIncidentsDataSet";
            reportDataSource1.Value = this.assignOpenIncidentsBindingSource;
            this.assignedOpenIncidentsReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.assignedOpenIncidentsReportViewer.LocalReport.ReportEmbeddedResource = "TechSupport.AssignedOpenIncidentsReport.rdlc";
            this.assignedOpenIncidentsReportViewer.Location = new System.Drawing.Point(3, 3);
            this.assignedOpenIncidentsReportViewer.Name = "assignedOpenIncidentsReportViewer";
            this.assignedOpenIncidentsReportViewer.ServerReport.BearerToken = null;
            this.assignedOpenIncidentsReportViewer.Size = new System.Drawing.Size(424, 494);
            this.assignedOpenIncidentsReportViewer.TabIndex = 1;
            this.assignedOpenIncidentsReportViewer.VisibleChanged += new System.EventHandler(this.AssignedOpenIncidentsReportViewer_VisibleChanged);
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignOpenIncidentsBindingSource
            // 
            this.assignOpenIncidentsBindingSource.DataMember = "AssignOpenIncidents";
            this.assignOpenIncidentsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // assignOpenIncidentsTableAdapter
            // 
            this.assignOpenIncidentsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignedOpenIncidentsReportViewer);
            this.Name = "ReportIncidentsUserControl";
            this.Size = new System.Drawing.Size(430, 500);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignOpenIncidentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer assignedOpenIncidentsReportViewer;
        private System.Windows.Forms.BindingSource assignOpenIncidentsBindingSource;
        private TechSupportDataSet techSupportDataSet;
        private TechSupportDataSetTableAdapters.AssignOpenIncidentsTableAdapter assignOpenIncidentsTableAdapter;
    }
}
