
namespace TechSupport.UserControls
{
    partial class AddIncidentUserControl
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
            this.clearButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(248, 449);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 34);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(145, 107);
            this.descriptionTextBox.MaxLength = 200;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(246, 189);
            this.descriptionTextBox.TabIndex = 24;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.Description_TextChanged);
            this.descriptionTextBox.VisibleChanged += new System.EventHandler(this.DescriptionTextBox_VisibleChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(40, 104);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.descriptionLabel.Size = new System.Drawing.Size(89, 25);
            this.descriptionLabel.TabIndex = 29;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(145, 73);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(246, 26);
            this.titleTextBox.TabIndex = 23;
            this.titleTextBox.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(85, 449);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(146, 34);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Create Incident";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(91, 70);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(38, 25);
            this.titleLabel.TabIndex = 28;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(51, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customerLabel.Size = new System.Drawing.Size(78, 25);
            this.customerLabel.TabIndex = 26;
            this.customerLabel.Text = "Customer";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.30769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.Controls.Add(this.customerComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.errorMessageLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.productLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.productComboBox, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 427);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // customerComboBox
            // 
            this.customerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(145, 3);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(246, 28);
            this.customerComboBox.TabIndex = 32;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(257, 354);
            this.errorMessageLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(21, 20);
            this.errorMessageLabel.TabIndex = 30;
            this.errorMessageLabel.Text = "   ";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productLabel
            // 
            this.productLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(65, 36);
            this.productLabel.Name = "productLabel";
            this.productLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.productLabel.Size = new System.Drawing.Size(64, 25);
            this.productLabel.TabIndex = 33;
            this.productLabel.Text = "Product";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productComboBox
            // 
            this.productComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(145, 39);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(246, 28);
            this.productComboBox.TabIndex = 34;
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(430, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.ComboBox productComboBox;
    }
}
