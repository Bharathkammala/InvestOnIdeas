// InvestOnIdeasDashboard.Designer.cs
using System;
using System.Windows.Forms;
using System.Drawing;

namespace InvestOnIdeas
{
    partial class MainDashboard
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
        private Label lblWelcome;

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
            panelSidebar = new Panel();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            labelAppName = new Label();
            btnOverview = new Button();
            btnFeed = new Button();
            btnPostIdea = new Button();
            btnMyIdeas = new Button();
            btnCollaborations = new Button();
            btnBookmarks = new Button();
            btnProfile = new Button();
            spacerPanel = new Panel();
            btnLogout = new Button();
            panelHeader = new Panel();
            lblWelcome = new Label();
            PanelView = new Panel();
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.AutoScroll = true;
            panelSidebar.BackColor = Color.FromArgb(20, 24, 35);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Controls.Add(btnOverview);
            panelSidebar.Controls.Add(btnFeed);
            panelSidebar.Controls.Add(btnPostIdea);
            panelSidebar.Controls.Add(btnMyIdeas);
            panelSidebar.Controls.Add(btnCollaborations);
            panelSidebar.Controls.Add(btnBookmarks);
            panelSidebar.Controls.Add(btnProfile);
            panelSidebar.Controls.Add(spacerPanel);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 72);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(20);
            panelSidebar.Size = new Size(260, 978);
            panelSidebar.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Controls.Add(labelAppName);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(20, 356);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 110);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(10, 20);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(48, 48);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelAppName
            // 
            labelAppName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelAppName.ForeColor = Color.FromArgb(240, 240, 240);
            labelAppName.Location = new Point(70, 20);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(160, 48);
            labelAppName.TabIndex = 1;
            labelAppName.Text = "InvestOn Ideas";
            labelAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Transparent;
            btnOverview.Dock = DockStyle.Top;
            btnOverview.FlatAppearance.BorderSize = 0;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("Segoe UI", 10.5F);
            btnOverview.ForeColor = Color.FromArgb(200, 208, 216);
            btnOverview.Location = new Point(20, 308);
            btnOverview.Name = "btnOverview";
            btnOverview.Padding = new Padding(12, 0, 0, 0);
            btnOverview.Size = new Size(220, 48);
            btnOverview.TabIndex = 1;
            btnOverview.Text = "  Overview";
            btnOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnFeed
            // 
            btnFeed.BackColor = Color.Transparent;
            btnFeed.Dock = DockStyle.Top;
            btnFeed.FlatAppearance.BorderSize = 0;
            btnFeed.FlatStyle = FlatStyle.Flat;
            btnFeed.Font = new Font("Segoe UI", 10.5F);
            btnFeed.ForeColor = Color.FromArgb(200, 208, 216);
            btnFeed.Location = new Point(20, 260);
            btnFeed.Name = "btnFeed";
            btnFeed.Padding = new Padding(12, 0, 0, 0);
            btnFeed.Size = new Size(220, 48);
            btnFeed.TabIndex = 2;
            btnFeed.Text = "  Feed";
            btnFeed.TextAlign = ContentAlignment.MiddleLeft;
            btnFeed.UseVisualStyleBackColor = false;
            btnFeed.Click += btnFeed_Click;
            // 
            // btnPostIdea
            // 
            btnPostIdea.BackColor = Color.Transparent;
            btnPostIdea.Dock = DockStyle.Top;
            btnPostIdea.FlatAppearance.BorderSize = 0;
            btnPostIdea.FlatStyle = FlatStyle.Flat;
            btnPostIdea.Font = new Font("Segoe UI", 10.5F);
            btnPostIdea.ForeColor = Color.FromArgb(200, 208, 216);
            btnPostIdea.Location = new Point(20, 212);
            btnPostIdea.Name = "btnPostIdea";
            btnPostIdea.Padding = new Padding(12, 0, 0, 0);
            btnPostIdea.Size = new Size(220, 48);
            btnPostIdea.TabIndex = 3;
            btnPostIdea.Text = "  Post Idea";
            btnPostIdea.TextAlign = ContentAlignment.MiddleLeft;
            btnPostIdea.UseVisualStyleBackColor = false;
            btnPostIdea.Click += btnPostIdea_Click;
            // 
            // btnMyIdeas
            // 
            btnMyIdeas.BackColor = Color.Transparent;
            btnMyIdeas.Dock = DockStyle.Top;
            btnMyIdeas.FlatAppearance.BorderSize = 0;
            btnMyIdeas.FlatStyle = FlatStyle.Flat;
            btnMyIdeas.Font = new Font("Segoe UI", 10.5F);
            btnMyIdeas.ForeColor = Color.FromArgb(200, 208, 216);
            btnMyIdeas.Location = new Point(20, 164);
            btnMyIdeas.Name = "btnMyIdeas";
            btnMyIdeas.Padding = new Padding(12, 0, 0, 0);
            btnMyIdeas.Size = new Size(220, 48);
            btnMyIdeas.TabIndex = 4;
            btnMyIdeas.Text = "  My Ideas";
            btnMyIdeas.TextAlign = ContentAlignment.MiddleLeft;
            btnMyIdeas.UseVisualStyleBackColor = false;
            btnMyIdeas.Click += btnMyIdeas_Click;
            // 
            // btnCollaborations
            // 
            btnCollaborations.BackColor = Color.Transparent;
            btnCollaborations.Dock = DockStyle.Top;
            btnCollaborations.FlatAppearance.BorderSize = 0;
            btnCollaborations.FlatStyle = FlatStyle.Flat;
            btnCollaborations.Font = new Font("Segoe UI", 10.5F);
            btnCollaborations.ForeColor = Color.FromArgb(200, 208, 216);
            btnCollaborations.Location = new Point(20, 116);
            btnCollaborations.Name = "btnCollaborations";
            btnCollaborations.Padding = new Padding(12, 0, 0, 0);
            btnCollaborations.Size = new Size(220, 48);
            btnCollaborations.TabIndex = 5;
            btnCollaborations.Text = "  Collaborations";
            btnCollaborations.TextAlign = ContentAlignment.MiddleLeft;
            btnCollaborations.UseVisualStyleBackColor = false;
            btnCollaborations.Click += btnCollaborations_Click;
            // 
            // btnBookmarks
            // 
            btnBookmarks.BackColor = Color.Transparent;
            btnBookmarks.Dock = DockStyle.Top;
            btnBookmarks.FlatAppearance.BorderSize = 0;
            btnBookmarks.FlatStyle = FlatStyle.Flat;
            btnBookmarks.Font = new Font("Segoe UI", 10.5F);
            btnBookmarks.ForeColor = Color.FromArgb(200, 208, 216);
            btnBookmarks.Location = new Point(20, 68);
            btnBookmarks.Name = "btnBookmarks";
            btnBookmarks.Padding = new Padding(12, 0, 0, 0);
            btnBookmarks.Size = new Size(220, 48);
            btnBookmarks.TabIndex = 6;
            btnBookmarks.Text = "  Bookmarks";
            btnBookmarks.TextAlign = ContentAlignment.MiddleLeft;
            btnBookmarks.UseVisualStyleBackColor = false;
            btnBookmarks.Click += btnBookmarks_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10.5F);
            btnProfile.ForeColor = Color.FromArgb(200, 208, 216);
            btnProfile.Location = new Point(20, 20);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(12, 0, 0, 0);
            btnProfile.Size = new Size(220, 48);
            btnProfile.TabIndex = 7;
            btnProfile.Text = "  Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // spacerPanel
            // 
            spacerPanel.Dock = DockStyle.Fill;
            spacerPanel.Location = new Point(20, 20);
            spacerPanel.Name = "spacerPanel";
            spacerPanel.Size = new Size(220, 892);
            spacerPanel.TabIndex = 8;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(20, 912);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 46);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(16, 12, 16, 12);
            panelHeader.Size = new Size(1924, 72);
            panelHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 41, 59);
            lblWelcome.Location = new Point(379, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(252, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, <User>";
            // 
            // PanelView
            // 
            PanelView.Dock = DockStyle.Fill;
            PanelView.Location = new Point(260, 72);
            PanelView.Name = "PanelView";
            PanelView.Size = new Size(1664, 978);
            PanelView.TabIndex = 2;
            // 
            // MainDashboard
            // 
            ClientSize = new Size(1924, 1050);
            Controls.Add(PanelView);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvestOn Ideas";
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
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

        private Panel spacerPanel;
        private Panel PanelView;
    }
}
