﻿
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
            this.addIncidentTab = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.loadIncidentTab = new System.Windows.Forms.TabPage();
            this.loadIncidentUserControl1 = new TechSupport.UserControls.LoadIncidentUserControl();
            this.searchIncidentTab = new System.Windows.Forms.TabPage();
            this.searchIncidentUserControl1 = new TechSupport.UserControls.SearchIncidentUserControl();
            this.displayOpenIncidentTab = new System.Windows.Forms.TabPage();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IncidentTabs.SuspendLayout();
            this.addIncidentTab.SuspendLayout();
            this.loadIncidentTab.SuspendLayout();
            this.searchIncidentTab.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncidentTabs
            // 
            this.IncidentTabs.Controls.Add(this.addIncidentTab);
            this.IncidentTabs.Controls.Add(this.loadIncidentTab);
            this.IncidentTabs.Controls.Add(this.searchIncidentTab);
            this.IncidentTabs.Controls.Add(this.displayOpenIncidentTab);
            this.IncidentTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncidentTabs.Location = new System.Drawing.Point(-2, 59);
            this.IncidentTabs.Name = "IncidentTabs";
            this.IncidentTabs.SelectedIndex = 0;
            this.IncidentTabs.Size = new System.Drawing.Size(587, 404);
            this.IncidentTabs.TabIndex = 0;
            // 
            // addIncidentTab
            // 
            this.addIncidentTab.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.addIncidentTab.Name = "addIncidentTab";
            this.addIncidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTab.Size = new System.Drawing.Size(579, 375);
            this.addIncidentTab.TabIndex = 1;
            this.addIncidentTab.Text = "Add Incident";
            this.addIncidentTab.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(-12, 0);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(607, 379);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // loadIncidentTab
            // 
            this.loadIncidentTab.Controls.Add(this.loadIncidentUserControl1);
            this.loadIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.loadIncidentTab.Name = "loadIncidentTab";
            this.loadIncidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.loadIncidentTab.Size = new System.Drawing.Size(579, 375);
            this.loadIncidentTab.TabIndex = 2;
            this.loadIncidentTab.Text = "Load Incidents";
            this.loadIncidentTab.UseVisualStyleBackColor = true;
            // 
            // loadIncidentUserControl1
            // 
            this.loadIncidentUserControl1.Location = new System.Drawing.Point(-13, 1);
            this.loadIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.loadIncidentUserControl1.Name = "loadIncidentUserControl1";
            this.loadIncidentUserControl1.Size = new System.Drawing.Size(611, 379);
            this.loadIncidentUserControl1.TabIndex = 0;
            // 
            // searchIncidentTab
            // 
            this.searchIncidentTab.Controls.Add(this.searchIncidentUserControl1);
            this.searchIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.searchIncidentTab.Name = "searchIncidentTab";
            this.searchIncidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchIncidentTab.Size = new System.Drawing.Size(579, 375);
            this.searchIncidentTab.TabIndex = 3;
            this.searchIncidentTab.Text = "Search Incidents";
            this.searchIncidentTab.UseVisualStyleBackColor = true;
            // 
            // searchIncidentUserControl1
            // 
            this.searchIncidentUserControl1.Location = new System.Drawing.Point(-12, 3);
            this.searchIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.searchIncidentUserControl1.Name = "searchIncidentUserControl1";
            this.searchIncidentUserControl1.Size = new System.Drawing.Size(601, 384);
            this.searchIncidentUserControl1.TabIndex = 0;
            // 
            // displayOpenIncidentTab
            // 
            this.displayOpenIncidentTab.Location = new System.Drawing.Point(4, 25);
            this.displayOpenIncidentTab.Name = "displayOpenIncidentTab";
            this.displayOpenIncidentTab.Size = new System.Drawing.Size(579, 375);
            this.displayOpenIncidentTab.TabIndex = 4;
            this.displayOpenIncidentTab.Text = "Display Open Incidents";
            this.displayOpenIncidentTab.UseVisualStyleBackColor = true;
            // 
            // logoutLabel
            // 
            this.logoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Location = new System.Drawing.Point(33, 26);
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(468, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(104, 53);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.IncidentTabs);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboard_FormClosing);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.IncidentTabs.ResumeLayout(false);
            this.addIncidentTab.ResumeLayout(false);
            this.loadIncidentTab.ResumeLayout(false);
            this.searchIncidentTab.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl IncidentTabs;
        private System.Windows.Forms.TabPage addIncidentTab;
        private System.Windows.Forms.TabPage loadIncidentTab;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TabPage searchIncidentTab;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private UserControls.LoadIncidentUserControl loadIncidentUserControl1;
        private UserControls.SearchIncidentUserControl searchIncidentUserControl1;
        private System.Windows.Forms.TabPage displayOpenIncidentTab;
    }
}