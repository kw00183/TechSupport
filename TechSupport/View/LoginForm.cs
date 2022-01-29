using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public static string usernameEntry = "";
        private MainForm mainForm;
        public LoginForm loginForm;

        public LoginForm()
        {
            InitializeComponent();
            loginForm = this;
            mainForm = null;
        }

        /// <summary>
        /// constructor used to initialize the LoginForm class
        /// </summary>
        public LoginForm(ref MainForm form)
        {
            mainForm = form;
            InitializeComponent();
            loginForm = this;
            mainForm = form;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Jane" && passwordTextBox.Text == "test1234")
            {
                usernameEntry = "Jane";
                HideErrorMessage();

                if (mainForm == null)
                {
                    mainForm = new MainForm(ref loginForm);
                }
                
                mainForm.Show();
                loginForm.Hide();
            }
            else
            {
                ShowInvalidErrorMessage();
            }
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
            if (control is TextBox)
            {
                ((TextBox)control).Text = string.Empty;
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
    }
}
