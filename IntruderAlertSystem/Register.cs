using Alarm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://stackoverflow.com/questions/3005732/showing-a-hidden-form

namespace IntruderAlertSystem {
    public partial class Register : Form {
        private static Register register = null;
        String errorMessage = "";
        public Register() {
            InitializeComponent();
        }

        public static Form getInstance() {
            if (register == null) {
                register = new Register();
            }

            return register;
        }


        private bool checkUname()
        {
            //Sql to check usernames
            return true;
        }


        private void btnRegister_Click(object sender, EventArgs e) {
            if (uNameTxt.Text == "" || passwordTxt.Text == "" || passwordTxt2.Text == "")
            {
                MessageBox.Show("All fields are mandatory, please fill them in.", "One or more fields are blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bool unique = dbstuff.uniqueUsername(uNameTxt.Text); // flag for unique Username 

            if (!(passwordTxt.Text == passwordTxt2.Text) || !unique)
            {
                //MessageBox.Show("test", "test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!unique)
                {
                    errorMessage += String.Format("Username is already taken, please try again.", uNameTxt.Text);
                    MessageBox.Show(errorMessage, "Username taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (!(passwordTxt.Text == passwordTxt2.Text))
                {
                    errorMessage += String.Format("The passwords do not match. Please enter your password again.");
                    MessageBox.Show(errorMessage, "Verify Passwords", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else {
                // create a new user in the database

                // create a new salt, hash password and store both in db
                // http://stackoverflow.com/questions/17185739/saving-byte-array-to-mysql

                // clear the data so a new user can login
                byte[] salt = Encryption.GenerateSalt();
                byte[] pw = Encryption.ComputePasswordHash(passwordTxt.Text, salt);
                // create a new salt, hash password and store both in db
                dbstuff.createUser(uNameTxt.Text, pw, salt);

                MessageBox.Show("Your acccount has been created successfully. You may now login.",
                    "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                uNameTxt.Clear();
                passwordTxt2.Clear();
                passwordTxt.Clear();

                Login.getInstance().Show();
                this.Hide();
            }
            //  Login.getInstance().Show();
            // this.Hide();
        }

    }
}
