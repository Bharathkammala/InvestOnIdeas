namespace InvestOnIdeas
{
    partial class Collaborations
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

        private void InitializeComponent()
        {
            lblUsers = new Label();
            listUsers = new ListBox();
            btnSendRequest = new Button();
            lblRequests = new Label();
            listRequests = new ListBox();
            btnAccept = new Button();
            btnReject = new Button();
            btnChat = new Button();
            SuspendLayout();

            lblUsers.Text = "Available Users";
            lblUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsers.Location = new Point(50, 30);

            listUsers.Location = new Point(50, 70);
            listUsers.Size = new Size(250, 200);

            btnSendRequest.Text = "Send Request";
            btnSendRequest.Location = new Point(50, 290);
            btnSendRequest.Size = new Size(250, 35);
            btnSendRequest.Click += btnSendRequest_Click;

            lblRequests.Text = "Collaboration Requests";
            lblRequests.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRequests.Location = new Point(400, 30);

            listRequests.Location = new Point(400, 70);
            listRequests.Size = new Size(250, 200);

            btnAccept.Text = "Accept";
            btnAccept.Location = new Point(400, 290);
            btnAccept.Click += btnAccept_Click;

            btnReject.Text = "Reject";
            btnReject.Location = new Point(500, 290);
            btnReject.Click += btnReject_Click;

            btnChat.Text = "Open Chat";
            btnChat.Location = new Point(450, 340);
            btnChat.Click += btnChat_Click;
            btnChat.Enabled = false;

            Controls.Add(lblUsers);
            Controls.Add(listUsers);
            Controls.Add(btnSendRequest);
            Controls.Add(lblRequests);
            Controls.Add(listRequests);
            Controls.Add(btnAccept);
            Controls.Add(btnReject);
            Controls.Add(btnChat);

            Text = "Collaborations";
            ClientSize = new Size(720, 420);
            ResumeLayout(false);
        }

        private Label lblUsers, lblRequests;
        private ListBox listUsers, listRequests;
        private Button btnSendRequest, btnAccept, btnReject, btnChat;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "Collaborations";
        //}

        #endregion
    }
}