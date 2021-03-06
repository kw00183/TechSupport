
namespace TechSupport.View
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IncidentTabs = new System.Windows.Forms.TabControl();
            this.displayOpenIncidentTab = new System.Windows.Forms.TabPage();
            this.openIncidentUserControl1 = new TechSupport.UserControls.OpenIncidentUserControl();
            this.addIncidentTab = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.updateIncidentTab = new System.Windows.Forms.TabPage();
            this.updateIncidentUserControl1 = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.technicianIncidentTab = new System.Windows.Forms.TabPage();
            this.technicianIncidentUserControl1 = new TechSupport.UserControls.TechnicianIncidentUserControl();
            this.ReportTab = new System.Windows.Forms.TabPage();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.reportIncidentsUserControl1 = new TechSupport.UserControls.ReportIncidentsUserControl();
            this.IncidentTabs.SuspendLayout();
            this.displayOpenIncidentTab.SuspendLayout();
            this.addIncidentTab.SuspendLayout();
            this.updateIncidentTab.SuspendLayout();
            this.technicianIncidentTab.SuspendLayout();
            this.ReportTab.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncidentTabs
            // 
            this.IncidentTabs.Controls.Add(this.displayOpenIncidentTab);
            this.IncidentTabs.Controls.Add(this.addIncidentTab);
            this.IncidentTabs.Controls.Add(this.updateIncidentTab);
            this.IncidentTabs.Controls.Add(this.technicianIncidentTab);
            this.IncidentTabs.Controls.Add(this.ReportTab);
            this.IncidentTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncidentTabs.Location = new System.Drawing.Point(-2, 59);
            this.IncidentTabs.Name = "IncidentTabs";
            this.IncidentTabs.SelectedIndex = 0;
            this.IncidentTabs.Size = new System.Drawing.Size(587, 654);
            this.IncidentTabs.TabIndex = 0;
            // 
            // displayOpenIncidentTab
            // 
            this.displayOpenIncidentTab.Controls.Add(this.openIncidentUserControl1);
            this.displayOpenIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.displayOpenIncidentTab.Name = "displayOpenIncidentTab";
            this.displayOpenIncidentTab.Size = new System.Drawing.Size(579, 625);
            this.displayOpenIncidentTab.TabIndex = 4;
            this.displayOpenIncidentTab.Text = "Display Open Incidents";
            this.displayOpenIncidentTab.UseVisualStyleBackColor = true;
            // 
            // openIncidentUserControl1
            // 
            this.openIncidentUserControl1.Location = new System.Drawing.Point(4, 4);
            this.openIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.openIncidentUserControl1.Name = "openIncidentUserControl1";
            this.openIncidentUserControl1.Size = new System.Drawing.Size(579, 625);
            this.openIncidentUserControl1.TabIndex = 0;
            // 
            // addIncidentTab
            // 
            this.addIncidentTab.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.addIncidentTab.Name = "addIncidentTab";
            this.addIncidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTab.Size = new System.Drawing.Size(579, 625);
            this.addIncidentTab.TabIndex = 1;
            this.addIncidentTab.Text = "Add";
            this.addIncidentTab.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(0, 4);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(575, 625);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // updateIncidentTab
            // 
            this.updateIncidentTab.Controls.Add(this.updateIncidentUserControl1);
            this.updateIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.updateIncidentTab.Name = "updateIncidentTab";
            this.updateIncidentTab.Size = new System.Drawing.Size(579, 625);
            this.updateIncidentTab.TabIndex = 5;
            this.updateIncidentTab.Text = "Update";
            this.updateIncidentTab.UseVisualStyleBackColor = true;
            // 
            // updateIncidentUserControl1
            // 
            this.updateIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.updateIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            this.updateIncidentUserControl1.Size = new System.Drawing.Size(575, 621);
            this.updateIncidentUserControl1.TabIndex = 0;
            // 
            // technicianIncidentTab
            // 
            this.technicianIncidentTab.Controls.Add(this.technicianIncidentUserControl1);
            this.technicianIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.technicianIncidentTab.Name = "technicianIncidentTab";
            this.technicianIncidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.technicianIncidentTab.Size = new System.Drawing.Size(579, 625);
            this.technicianIncidentTab.TabIndex = 6;
            this.technicianIncidentTab.Text = "View Incidents by Technician";
            this.technicianIncidentTab.UseVisualStyleBackColor = true;
            // 
            // technicianIncidentUserControl1
            // 
            this.technicianIncidentUserControl1.Location = new System.Drawing.Point(0, 5);
            this.technicianIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.technicianIncidentUserControl1.Name = "technicianIncidentUserControl1";
            this.technicianIncidentUserControl1.Size = new System.Drawing.Size(579, 625);
            this.technicianIncidentUserControl1.TabIndex = 0;
            // 
            // ReportTab
            // 
            this.ReportTab.Controls.Add(this.reportIncidentsUserControl1);
            this.ReportTab.Location = new System.Drawing.Point(4, 25);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportTab.Size = new System.Drawing.Size(579, 625);
            this.ReportTab.TabIndex = 7;
            this.ReportTab.Text = "Report";
            this.ReportTab.UseVisualStyleBackColor = true;
            // 
            // logoutLabel
            // 
            this.logoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Location = new System.Drawing.Point(33, 24);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(68, 24);
            this.logoutLabel.TabIndex = 1;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(71, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(30, 24);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "    ";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.usernameLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.logoutLabel, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(473, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(104, 48);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // reportIncidentsUserControl1
            // 
            this.reportIncidentsUserControl1.Location = new System.Drawing.Point(3, 1);
            this.reportIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportIncidentsUserControl1.Name = "reportIncidentsUserControl1";
            this.reportIncidentsUserControl1.Size = new System.Drawing.Size(587, 641);
            this.reportIncidentsUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 711);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.IncidentTabs);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboard_FormClosing);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.IncidentTabs.ResumeLayout(false);
            this.displayOpenIncidentTab.ResumeLayout(false);
            this.addIncidentTab.ResumeLayout(false);
            this.updateIncidentTab.ResumeLayout(false);
            this.technicianIncidentTab.ResumeLayout(false);
            this.ReportTab.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl IncidentTabs;
        private System.Windows.Forms.TabPage addIncidentTab;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TabPage updateIncidentTab;
        private System.Windows.Forms.TabPage displayOpenIncidentTab;
        private UserControls.OpenIncidentUserControl openIncidentUserControl1;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
        private System.Windows.Forms.TabPage technicianIncidentTab;
        private UserControls.TechnicianIncidentUserControl technicianIncidentUserControl1;
        private System.Windows.Forms.TabPage ReportTab;
        private UserControls.ReportIncidentsUserControl reportIncidentsUserControl1;
    }
}