
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
            this.openIncidentListview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // openIncidentListview
            // 
            this.openIncidentListview.Location = new System.Drawing.Point(15, 14);
            this.openIncidentListview.Name = "openIncidentListview";
            this.openIncidentListview.Size = new System.Drawing.Size(420, 270);
            this.openIncidentListview.TabIndex = 0;
            this.openIncidentListview.UseCompatibleStateImageBehavior = false;
            this.openIncidentListview.VisibleChanged += new System.EventHandler(this.OpenIncidentListview_VisibleChanged);
            // 
            // OpenIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openIncidentListview);
            this.Name = "OpenIncidentUserControl";
            this.Size = new System.Drawing.Size(450, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView openIncidentListview;
    }
}
