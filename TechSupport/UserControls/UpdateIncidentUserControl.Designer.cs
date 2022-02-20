
namespace TechSupport.UserControls
{
    partial class UpdateIncidentUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.incidentIDTextBox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.addTextTextBox = new System.Windows.Forms.TextBox();
            this.dateopenedTextBox = new System.Windows.Forms.TextBox();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.addTextLlabel = new System.Windows.Forms.Label();
            this.dateOpenedLabel = new System.Windows.Forms.Label();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.11765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.Controls.Add(this.customerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.errorMessageLabel, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.addTextTextBox, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateopenedTextBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.technicianComboBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.customerTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.addTextLlabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateOpenedLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.technicianLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.76119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.23881F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 376);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(62, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customerLabel.Size = new System.Drawing.Size(78, 25);
            this.customerLabel.TabIndex = 26;
            this.customerLabel.Text = "Customer";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(269, 341);
            this.errorMessageLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(21, 20);
            this.errorMessageLabel.TabIndex = 30;
            this.errorMessageLabel.Text = "   ";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(154, 179);
            this.descriptionTextBox.MaxLength = 200;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(252, 64);
            this.descriptionTextBox.TabIndex = 24;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(51, 176);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.descriptionLabel.Size = new System.Drawing.Size(89, 25);
            this.descriptionLabel.TabIndex = 29;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(102, 102);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(38, 25);
            this.titleLabel.TabIndex = 28;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(154, 105);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(252, 26);
            this.titleTextBox.TabIndex = 23;
            // 
            // productLabel
            // 
            this.productLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(76, 32);
            this.productLabel.Name = "productLabel";
            this.productLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.productLabel.Size = new System.Drawing.Size(64, 25);
            this.productLabel.TabIndex = 33;
            this.productLabel.Text = "Product";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(271, 450);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 34);
            this.clearButton.TabIndex = 33;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(63, 450);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 34);
            this.updateButton.TabIndex = 32;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(166, 450);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 34);
            this.closeButton.TabIndex = 35;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.16058F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.839416F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.incidentIDTextBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.getButton, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(409, 46);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Incident ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // incidentIDTextBox
            // 
            this.incidentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentIDTextBox.Location = new System.Drawing.Point(154, 3);
            this.incidentIDTextBox.Name = "incidentIDTextBox";
            this.incidentIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.incidentIDTextBox.TabIndex = 27;
            // 
            // getButton
            // 
            this.getButton.AutoSize = true;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getButton.Location = new System.Drawing.Point(283, 3);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(68, 34);
            this.getButton.TabIndex = 36;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // addTextTextBox
            // 
            this.addTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTextTextBox.Location = new System.Drawing.Point(154, 251);
            this.addTextTextBox.MaxLength = 200;
            this.addTextTextBox.Multiline = true;
            this.addTextTextBox.Name = "addTextTextBox";
            this.addTextTextBox.Size = new System.Drawing.Size(252, 72);
            this.addTextTextBox.TabIndex = 35;
            // 
            // dateopenedTextBox
            // 
            this.dateopenedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateopenedTextBox.Location = new System.Drawing.Point(154, 139);
            this.dateopenedTextBox.MaxLength = 200;
            this.dateopenedTextBox.Multiline = true;
            this.dateopenedTextBox.Name = "dateopenedTextBox";
            this.dateopenedTextBox.Size = new System.Drawing.Size(123, 34);
            this.dateopenedTextBox.TabIndex = 36;
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(154, 70);
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(252, 28);
            this.technicianComboBox.TabIndex = 37;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(154, 3);
            this.customerTextBox.MaxLength = 50;
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(252, 26);
            this.customerTextBox.TabIndex = 38;
            // 
            // productTextBox
            // 
            this.productTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTextBox.Location = new System.Drawing.Point(154, 35);
            this.productTextBox.MaxLength = 50;
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(252, 26);
            this.productTextBox.TabIndex = 39;
            // 
            // addTextLlabel
            // 
            this.addTextLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTextLlabel.AutoSize = true;
            this.addTextLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTextLlabel.Location = new System.Drawing.Point(46, 248);
            this.addTextLlabel.Name = "addTextLlabel";
            this.addTextLlabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.addTextLlabel.Size = new System.Drawing.Size(94, 25);
            this.addTextLlabel.TabIndex = 40;
            this.addTextLlabel.Text = "Text To Add";
            this.addTextLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateOpenedLabel
            // 
            this.dateOpenedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOpenedLabel.AutoSize = true;
            this.dateOpenedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOpenedLabel.Location = new System.Drawing.Point(35, 136);
            this.dateOpenedLabel.Name = "dateOpenedLabel";
            this.dateOpenedLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.dateOpenedLabel.Size = new System.Drawing.Size(105, 25);
            this.dateOpenedLabel.TabIndex = 41;
            this.dateOpenedLabel.Text = "Date Opened";
            this.dateOpenedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // technicianLabel
            // 
            this.technicianLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianLabel.Location = new System.Drawing.Point(55, 67);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.technicianLabel.Size = new System.Drawing.Size(85, 25);
            this.technicianLabel.TabIndex = 42;
            this.technicianLabel.Text = "Technician";
            this.technicianLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Name = "UpdateIncidentUserControl";
            this.Size = new System.Drawing.Size(430, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incidentIDTextBox;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.TextBox addTextTextBox;
        private System.Windows.Forms.TextBox dateopenedTextBox;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label addTextLlabel;
        private System.Windows.Forms.Label dateOpenedLabel;
        private System.Windows.Forms.Label technicianLabel;
    }
}
