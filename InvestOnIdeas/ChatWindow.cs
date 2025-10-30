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
    public partial class ChatWindow : Form
    {
        public ChatWindow()
        {
            InitializeComponent();
        }

        private void ChatWindow_Load(object sender, EventArgs e)
        {
            lblChatHeader.Text = "Chat with Collaborator";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please type a message before sending.");
                return;
            }

            // Add message to the chat window
            listMessages.Items.Add("You: " + message);
            txtMessage.Clear();

            // Simulated reply (for testing UI)
            // Later this will be replaced by database or real-time messages
            listMessages.Items.Add("Collaborator: Got it! 👍");
        }
    }
}
