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
    public partial class Collaborations : Form
    {
        private int currentUserId = 1; // Assume logged user is ID=1
        private Dictionary<int, string> allUsers = new(); // Simulate user list

        public Collaborations()
        {
            InitializeComponent();
        }

        private void Collaborations_Load(object sender, EventArgs e)
        {
            // Simulated users
            allUsers.Add(2, "Sarah Lee");
            allUsers.Add(3, "Ravi Kumar");
            allUsers.Add(4, "John Doe");

            foreach (var user in allUsers.Values)
            {
                listUsers.Items.Add(user);
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user first!");
                return;
            }

            string selectedUser = listUsers.SelectedItem.ToString();
            listRequests.Items.Add($"Request sent to {selectedUser} (Pending)");
            MessageBox.Show($"Collaboration request sent to {selectedUser}");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (listRequests.SelectedIndex == -1)
            {
                MessageBox.Show("Select a request to accept!");
                return;
            }

            string request = listRequests.SelectedItem.ToString();
            if (request.Contains("Pending"))
            {
                listRequests.Items[listRequests.SelectedIndex] = request.Replace("Pending", "Accepted");
                btnChat.Enabled = true;
                MessageBox.Show("Request Accepted! You can now chat.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (listRequests.SelectedIndex == -1)
            {
                MessageBox.Show("Select a request to reject!");
                return;
            }

            string request = listRequests.SelectedItem.ToString();
            if (request.Contains("Pending"))
            {
                listRequests.Items[listRequests.SelectedIndex] = request.Replace("Pending", "Rejected");
                btnChat.Enabled = false;
                MessageBox.Show("Request Rejected!");
            }
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatWindow chat = new ChatWindow();
            chat.Show();
        }
    }
}
