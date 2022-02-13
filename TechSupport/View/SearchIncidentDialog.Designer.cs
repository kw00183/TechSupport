
namespace TechSupport.View
{
    partial class SearchIncidentDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(254, 264);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 34);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(208, 20);
            this.customerIDTextBox.MaxLength = 50;
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(188, 29);
            this.customerIDTextBox.TabIndex = 1;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(143, 264);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 34);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(89, 22);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(113, 24);
            this.customerIDLabel.TabIndex = 12;
            this.customerIDLabel.Text = "Customer ID";
            this.customerIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(12, 90);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.Size = new System.Drawing.Size(460, 155);
            this.searchDataGridView.TabIndex = 16;
            this.searchDataGridView.VisibleChanged += new System.EventHandler(this.SearchDataGridView_VisibleChanged);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(58, 56);
            this.errorMessageLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(21, 20);
            this.errorMessageLabel.TabIndex = 17;
            this.errorMessageLabel.Text = "   ";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchIncidentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerIDLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchIncidentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Incident";
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}