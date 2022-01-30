using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// LoginForm class used to check the username and password to access the tech support application
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class LoginForm : Form
    {
        #region Data members

        public static string usernameEntry = "";

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to initialize the LoginForm class
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Jane" && passwordTextBox.Text == "test1234")
            {
                usernameEntry = usernameTextBox.Text;
                MainDashboard mainDashboard = new MainDashboard(this);
                mainDashboard.SetUsername(usernameEntry);
                mainDashboard.Show();
                this.Hide();
            }
            else
            {
                this.ShowInvalidErrorMessage();
            }
        }

        /// <summary>
        /// method used to clear the text boxes and show login screen
        /// </summary>
        public void LogOut()
        {
            EmptyFormControls(this);
            this.Show();
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        /// <summary>
        /// method used to clear textbox entries on form
        /// </summary>
        /// <param name="control">form with textboxes to clear</param>
        public static void EmptyFormControls(Control control)
        {
            if (control is TextBox box)
            {
                box.Text = string.Empty;
            }

            for (int i = 0; i < control.Controls.Count; i++)
            {
                EmptyFormControls(control.Controls[i]);
            }
        }

        private void ShowInvalidErrorMessage()
        {
            errorMessageLabel.Text = "invalid username/password";
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
