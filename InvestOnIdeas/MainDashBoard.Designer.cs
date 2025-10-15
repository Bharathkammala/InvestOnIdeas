// InvestOnIdeasDashboard.Designer.cs
using System;
using System.Windows.Forms;
using System.Drawing;

namespace InvestOnIdeas
{
    partial class MainDashBoard
    {
        private System.ComponentModel.IContainer components = null;

        // Sidebar controls
        private Panel panelSidebar;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Label labelAppName;
        private Button btnOverview;
        private Button btnFeed;
        private Button btnPostIdea;
        private Button btnMyIdeas;
        private Button btnCollaborations;
        private Button btnBookmarks;
        private Button btnProfile;
        private Button btnLogout;

        // Header controls
        private Panel panelHeader;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblWelcome;
        private Button btnPostQuick;

        // Main area
        private Panel panelMain;
        private FlowLayoutPanel flowIdeas;
        private VScrollBar vScrollIdeas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Form base settings
            this.SuspendLayout();
            this.ClientSize = new Size(1280, 780);
            this.Text = "InvestOn Ideas";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            // ============================
            // Sidebar
            // ============================
            panelSidebar = new Panel();
            panelSidebar.BackColor = Color.FromArgb(20, 24, 35);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Width = 260;
            panelSidebar.Padding = new Padding(20);
            panelSidebar.AutoScroll = true;
            this.Controls.Add(panelSidebar);

            // Logo area
            panelLogo = new Panel();
            panelLogo.Height = 110;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.BackColor = Color.Transparent;
            panelSidebar.Controls.Add(panelLogo);

            pictureBoxLogo = new PictureBox();
            pictureBoxLogo.Size = new Size(48, 48);
            pictureBoxLogo.Location = new Point(10, 20);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            // pictureBoxLogo.Image = Properties.Resources.investon_logo;
            panelLogo.Controls.Add(pictureBoxLogo);

            labelAppName = new Label();
            labelAppName.Text = "InvestOn Ideas";
            labelAppName.ForeColor = Color.FromArgb(240, 240, 240);
            labelAppName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelAppName.AutoSize = false;
            labelAppName.TextAlign = ContentAlignment.MiddleLeft;
            labelAppName.Location = new Point(70, 20);
            labelAppName.Size = new Size(160, 48);
            panelLogo.Controls.Add(labelAppName);

            // ============================
            // Sidebar Buttons (explicitly created)
            // ============================
            btnOverview = new Button();
            btnOverview.Dock = DockStyle.Top;
            btnOverview.Height = 48;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.FlatAppearance.BorderSize = 0;
            btnOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnOverview.Padding = new Padding(12, 0, 0, 0);
            btnOverview.ForeColor = Color.FromArgb(200, 208, 216);
            btnOverview.BackColor = Color.Transparent;
            btnOverview.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnOverview.Text = "  Overview";
            btnOverview.Click += btnOverview_Click;
            panelSidebar.Controls.Add(btnOverview);

            btnFeed = new Button();
            btnFeed.Dock = DockStyle.Top;
            btnFeed.Height = 48;
            btnFeed.FlatStyle = FlatStyle.Flat;
            btnFeed.FlatAppearance.BorderSize = 0;
            btnFeed.TextAlign = ContentAlignment.MiddleLeft;
            btnFeed.Padding = new Padding(12, 0, 0, 0);
            btnFeed.ForeColor = Color.FromArgb(200, 208, 216);
            btnFeed.BackColor = Color.Transparent;
            btnFeed.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnFeed.Text = "  Feed";
            btnFeed.Click += btnFeed_Click;
            panelSidebar.Controls.Add(btnFeed);

            btnPostIdea = new Button();
            btnPostIdea.Dock = DockStyle.Top;
            btnPostIdea.Height = 48;
            btnPostIdea.FlatStyle = FlatStyle.Flat;
            btnPostIdea.FlatAppearance.BorderSize = 0;
            btnPostIdea.TextAlign = ContentAlignment.MiddleLeft;
            btnPostIdea.Padding = new Padding(12, 0, 0, 0);
            btnPostIdea.ForeColor = Color.FromArgb(200, 208, 216);
            btnPostIdea.BackColor = Color.Transparent;
            btnPostIdea.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnPostIdea.Text = "  Post Idea";
            btnPostIdea.Click += btnPostIdea_Click;
            panelSidebar.Controls.Add(btnPostIdea);

            btnMyIdeas = new Button();
            btnMyIdeas.Dock = DockStyle.Top;
            btnMyIdeas.Height = 48;
            btnMyIdeas.FlatStyle = FlatStyle.Flat;
            btnMyIdeas.FlatAppearance.BorderSize = 0;
            btnMyIdeas.TextAlign = ContentAlignment.MiddleLeft;
            btnMyIdeas.Padding = new Padding(12, 0, 0, 0);
            btnMyIdeas.ForeColor = Color.FromArgb(200, 208, 216);
            btnMyIdeas.BackColor = Color.Transparent;
            btnMyIdeas.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnMyIdeas.Text = "  My Ideas";
            btnMyIdeas.Click += btnMyIdeas_Click;
            panelSidebar.Controls.Add(btnMyIdeas);

            btnCollaborations = new Button();
            btnCollaborations.Dock = DockStyle.Top;
            btnCollaborations.Height = 48;
            btnCollaborations.FlatStyle = FlatStyle.Flat;
            btnCollaborations.FlatAppearance.BorderSize = 0;
            btnCollaborations.TextAlign = ContentAlignment.MiddleLeft;
            btnCollaborations.Padding = new Padding(12, 0, 0, 0);
            btnCollaborations.ForeColor = Color.FromArgb(200, 208, 216);
            btnCollaborations.BackColor = Color.Transparent;
            btnCollaborations.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnCollaborations.Text = "  Collaborations";
            btnCollaborations.Click += btnCollaborations_Click;
            panelSidebar.Controls.Add(btnCollaborations);

            btnBookmarks = new Button();
            btnBookmarks.Dock = DockStyle.Top;
            btnBookmarks.Height = 48;
            btnBookmarks.FlatStyle = FlatStyle.Flat;
            btnBookmarks.FlatAppearance.BorderSize = 0;
            btnBookmarks.TextAlign = ContentAlignment.MiddleLeft;
            btnBookmarks.Padding = new Padding(12, 0, 0, 0);
            btnBookmarks.ForeColor = Color.FromArgb(200, 208, 216);
            btnBookmarks.BackColor = Color.Transparent;
            btnBookmarks.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnBookmarks.Text = "  Bookmarks";
            btnBookmarks.Click += btnBookmarks_Click;
            panelSidebar.Controls.Add(btnBookmarks);

            btnProfile = new Button();
            btnProfile.Dock = DockStyle.Top;
            btnProfile.Height = 48;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.Padding = new Padding(12, 0, 0, 0);
            btnProfile.ForeColor = Color.FromArgb(200, 208, 216);
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnProfile.Text = "  Profile";
            btnProfile.Click += btnProfile_Click;
            panelSidebar.Controls.Add(btnProfile);

            // Spacer pushes logout to bottom
            var spacerPanel = new Panel();
            spacerPanel.Dock = DockStyle.Fill;
            panelSidebar.Controls.Add(spacerPanel);

            // Logout button at bottom
            btnLogout = new Button();
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Height = 46;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.ForeColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            panelSidebar.Controls.Add(btnLogout);

            // ============================
            // Header
            // ============================
            panelHeader = new Panel();
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 72;
            panelHeader.Padding = new Padding(16, 12, 16, 12);
            panelHeader.BackColor = Color.White;
            this.Controls.Add(panelHeader);
            panelHeader.BringToFront();

            lblWelcome = new Label();
            lblWelcome.Text = "Welcome, <User>";
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 41, 59);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(280 + 20, 24);
            panelHeader.Controls.Add(lblWelcome);

            txtSearch = new TextBox();
            txtSearch.Width = 420;
            txtSearch.Height = 34;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.FromArgb(60, 60, 60);
            txtSearch.Location = new Point(520, 20);
            txtSearch.PlaceholderText = "Search ideas, categories or users...";
            panelHeader.Controls.Add(txtSearch);

            btnSearch = new Button();
            btnSearch.Size = new Size(38, 34);
            btnSearch.Location = new Point(txtSearch.Right + 8, txtSearch.Top);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.ForeColor = Color.White;
            btnSearch.Text = "🔍";
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.Click += btnSearch_Click;
            panelHeader.Controls.Add(btnSearch);

            btnPostQuick = new Button();
            btnPostQuick.Size = new Size(120, 34);
            btnPostQuick.Location = new Point(btnSearch.Right + 12, btnSearch.Top);
            btnPostQuick.Text = "Post Idea";
            btnPostQuick.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPostQuick.BackColor = Color.FromArgb(16, 185, 129);
            btnPostQuick.FlatStyle = FlatStyle.Flat;
            btnPostQuick.FlatAppearance.BorderSize = 0;
            btnPostQuick.ForeColor = Color.White;
            btnPostQuick.Click += btnPostQuick_Click;
            panelHeader.Controls.Add(btnPostQuick);

            // ============================
            // Main panel and flow panel
            // ============================
            panelMain = new Panel();
            panelMain.Dock = DockStyle.Fill;
            panelMain.BackColor = Color.FromArgb(245, 247, 250);
            panelMain.Padding = new Padding(20);
            this.Controls.Add(panelMain);
            panelMain.BringToFront();

            flowIdeas = new FlowLayoutPanel();
            flowIdeas.Dock = DockStyle.Fill;
            flowIdeas.AutoScroll = true;
            flowIdeas.WrapContents = true;
            flowIdeas.FlowDirection = FlowDirection.LeftToRight;
            flowIdeas.Padding = new Padding(8);
            flowIdeas.BackColor = Color.Transparent;
            flowIdeas.BorderStyle = BorderStyle.None;
            panelMain.Controls.Add(flowIdeas);

            // optional sample card (runtime should create actual cards)
            var sampleCard = CreateIdeaCardPlaceholder();
            flowIdeas.Controls.Add(sampleCard);

            vScrollIdeas = new VScrollBar();
            vScrollIdeas.Dock = DockStyle.Right;
            vScrollIdeas.Width = 16;
            vScrollIdeas.Visible = false;
            panelMain.Controls.Add(vScrollIdeas);

            this.ResumeLayout(false);
        }
        #endregion

        #region Helper: placeholder card (kept outside InitializeComponent)
        private Panel CreateIdeaCardPlaceholder()
        {
            var card = new Panel();
            card.Width = 340;
            card.Height = 180;
            card.Margin = new Padding(12);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.None;
            card.Padding = new Padding(12);
            card.Cursor = Cursors.Hand;

            var lblTitle = new Label();
            lblTitle.Text = "AI-powered Crop Health Monitoring";
            lblTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 24, 35);
            lblTitle.AutoEllipsis = true;
            lblTitle.Location = new Point(12, 8);
            lblTitle.Size = new Size(card.Width - 36, 28);
            card.Controls.Add(lblTitle);

            var lblDesc = new Label();
            lblDesc.Text = "A lightweight IoT + ML system to detect crop disease early and recommend treatments.";
            lblDesc.Font = new Font("Segoe UI", 9F);
            lblDesc.ForeColor = Color.FromArgb(90, 102, 120);
            lblDesc.Location = new Point(12, 42);
            lblDesc.Size = new Size(card.Width - 36, 60);
            lblDesc.AutoEllipsis = true;
            card.Controls.Add(lblDesc);

            var lblMeta = new Label();
            lblMeta.Text = "Category: Agriculture  •  Posted by: Rahul  •  2 days ago";
            lblMeta.Font = new Font("Segoe UI", 8.5F);
            lblMeta.ForeColor = Color.FromArgb(150, 160, 180);
            lblMeta.Location = new Point(12, 106);
            lblMeta.Size = new Size(card.Width - 36, 18);
            card.Controls.Add(lblMeta);

            var btnLike = new Button();
            btnLike.Text = "Like";
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.BackColor = Color.Transparent;
            btnLike.ForeColor = Color.FromArgb(37, 99, 235);
            btnLike.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLike.Location = new Point(12, 132);
            btnLike.Size = new Size(60, 30);
            card.Controls.Add(btnLike);

            var btnComment = new Button();
            btnComment.Text = "Comment";
            btnComment.FlatStyle = FlatStyle.Flat;
            btnComment.FlatAppearance.BorderSize = 0;
            btnComment.BackColor = Color.Transparent;
            btnComment.ForeColor = Color.FromArgb(30, 30, 30);
            btnComment.Font = new Font("Segoe UI", 9F);
            btnComment.Location = new Point(82, 132);
            btnComment.Size = new Size(80, 30);
            card.Controls.Add(btnComment);

            var btnBookmark = new Button();
            btnBookmark.Text = "Bookmark";
            btnBookmark.FlatStyle = FlatStyle.Flat;
            btnBookmark.FlatAppearance.BorderSize = 0;
            btnBookmark.BackColor = Color.Transparent;
            btnBookmark.ForeColor = Color.FromArgb(90, 102, 120);
            btnBookmark.Font = new Font("Segoe UI", 9F);
            btnBookmark.Location = new Point(170, 132);
            btnBookmark.Size = new Size(90, 30);
            card.Controls.Add(btnBookmark);

            var btnCollaborate = new Button();
            btnCollaborate.Text = "Collaborate";
            btnCollaborate.FlatStyle = FlatStyle.Flat;
            btnCollaborate.BackColor = Color.FromArgb(16, 185, 129);
            btnCollaborate.ForeColor = Color.White;
            btnCollaborate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCollaborate.Location = new Point(card.Width - 110, 128);
            btnCollaborate.Size = new Size(98, 34);
            btnCollaborate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            card.Controls.Add(btnCollaborate);

            return card;
        }
        #endregion

        #region Event handler stubs
        private void btnOverview_Click(object sender, EventArgs e) { }
        private void btnFeed_Click(object sender, EventArgs e) { }
        private void btnPostIdea_Click(object sender, EventArgs e) { }
        private void btnMyIdeas_Click(object sender, EventArgs e) { }
        private void btnCollaborations_Click(object sender, EventArgs e) { }
        private void btnBookmarks_Click(object sender, EventArgs e) { }
        private void btnProfile_Click(object sender, EventArgs e) { }
        private void btnLogout_Click(object sender, EventArgs e) { }
        private void btnSearch_Click(object sender, EventArgs e) { }
        private void btnPostQuick_Click(object sender, EventArgs e) { }
        #endregion
    }
}
