
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
            this.assignOpenIncidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSet = new TechSupport.TechSupportDataSet();
            this.assignedOpenIncidentsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.assignOpenIncidentsTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.AssignOpenIncidentsTableAdapter();
            this.techSupportDataSetVM = new TechSupport.TechSupportDataSetVM();
            this.assignedOpenIncidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignedOpenIncidentsTableAdapter = new TechSupport.TechSupportDataSetVMTableAdapters.AssignedOpenIncidentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assignOpenIncidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedOpenIncidentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assignOpenIncidentsBindingSource
            // 
            this.assignOpenIncidentsBindingSource.DataMember = "AssignOpenIncidents";
            this.assignOpenIncidentsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignedOpenIncidentsReportViewer
            // 
            reportDataSource1.Name = "AssignedOpenIncidentsVMDataSet";
            reportDataSource1.Value = this.assignedOpenIncidentsBindingSource;
            this.assignedOpenIncidentsReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.assignedOpenIncidentsReportViewer.LocalReport.ReportEmbeddedResource = "TechSupport.AssignedOpenIncidentsVMReport.rdlc";
            this.assignedOpenIncidentsReportViewer.Location = new System.Drawing.Point(3, 3);
            this.assignedOpenIncidentsReportViewer.Name = "assignedOpenIncidentsReportViewer";
            this.assignedOpenIncidentsReportViewer.ServerReport.BearerToken = null;
            this.assignedOpenIncidentsReportViewer.Size = new System.Drawing.Size(424, 494);
            this.assignedOpenIncidentsReportViewer.TabIndex = 1;
            this.assignedOpenIncidentsReportViewer.VisibleChanged += new System.EventHandler(this.AssignedOpenIncidentsReportViewer_VisibleChanged);
            // 
            // assignOpenIncidentsTableAdapter
            // 
            this.assignOpenIncidentsTableAdapter.ClearBeforeFill = true;
            // 
            // techSupportDataSetVM
            // 
            this.techSupportDataSetVM.DataSetName = "TechSupportDataSetVM";
            this.techSupportDataSetVM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignedOpenIncidentsBindingSource
            // 
            this.assignedOpenIncidentsBindingSource.DataMember = "AssignedOpenIncidents";
            this.assignedOpenIncidentsBindingSource.DataSource = this.techSupportDataSetVM;
            // 
            // assignedOpenIncidentsTableAdapter
            // 
            this.assignedOpenIncidentsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignedOpenIncidentsReportViewer);
            this.Name = "ReportIncidentsUserControl";
            this.Size = new System.Drawing.Size(430, 500);
            ((System.ComponentModel.ISupportInitialize)(this.assignOpenIncidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedOpenIncidentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer assignedOpenIncidentsReportViewer;
        private System.Windows.Forms.BindingSource assignOpenIncidentsBindingSource;
        private TechSupportDataSet techSupportDataSet;
        private TechSupportDataSetTableAdapters.AssignOpenIncidentsTableAdapter assignOpenIncidentsTableAdapter;
        private System.Windows.Forms.BindingSource assignedOpenIncidentsBindingSource;
        private TechSupportDataSetVM techSupportDataSetVM;
        private TechSupportDataSetVMTableAdapters.AssignedOpenIncidentsTableAdapter assignedOpenIncidentsTableAdapter;
    }
}
