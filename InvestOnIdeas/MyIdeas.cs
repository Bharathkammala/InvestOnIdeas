using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestOnIdeas
{
    public partial class MyIdeas : Form
    {
        // Example placeholder for current user ID
        private string currentUserId = "USER123";

        public MyIdeas()
        {
            InitializeComponent();
        }

        private void MyIdeas_Load(object sender, EventArgs e)
        {
            lblUserID.Text = $"User ID: {currentUserId}";
            LoadIdeas();
        }

        private void LoadIdeas()
        {
            // Temporary sample data (later connect to MySQL)
            DataTable dt = new DataTable();
            dt.Columns.Add("Idea Title");
            dt.Columns.Add("Description");
            dt.Columns.Add("Date Posted");
            dt.Columns.Add("Status");

            dt.Rows.Add("Smart Waste Bin", "IoT-based bin that detects fill level.", "2025-10-29", "Approved");
            dt.Rows.Add("Solar Bike Charger", "Portable solar-powered charger for bikes.", "2025-10-15", "Pending");

            dgvIdeas.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvIdeas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an idea to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ideaTitle = dgvIdeas.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show($"Editing idea: {ideaTitle}", "Edit Idea", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add new idea window will open here.", "Add Idea", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvIdeas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an idea to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ideaTitle = dgvIdeas.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{ideaTitle}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dgvIdeas.Rows.RemoveAt(dgvIdeas.SelectedRows[0].Index);
                MessageBox.Show("Idea deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
