using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InvestOnIdeas
{
    public partial class Profile : Form
    {
        private bool isEditing = false;

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DisableFields();
            txtName.Focus();
        }

        private void DisableFields()
        {
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            ProfileGendercomboBox.Enabled = false;
            btnConfirm.Enabled = false;
        }

        private void EnableFields()
        {
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            ProfileGendercomboBox.Enabled = true;
            btnConfirm.Enabled = true;
            txtName.Focus();
        }

        private void ProfileEditLbl_Click(object sender, EventArgs e)
        {
            EnableFields();
            isEditing = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                MessageBox.Show("Please click 'Edit' before confirming changes.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gender = ProfileGendercomboBox.Text.Trim();

            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            
            if (!Regex.IsMatch(phone, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Enter a valid 10-digit phone number (numbers only).",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select your gender.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProfileGendercomboBox.Focus();
                return;
            }

            
            MessageBox.Show("Profile updated successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DisableFields();
            isEditing = false;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
