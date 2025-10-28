using System;
using System.Windows.Forms;
using System.Drawing;

namespace InvestOnIdeas
{
    partial class TimelineFeed : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private TextBox txtSearch;
        private Button btnCreatePost;
        private Button btnFilter;
        private FlowLayoutPanel flowFeed;
        private Label lblTitle;
        private Button btnReload;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.txtSearch = new TextBox();
            this.btnFilter = new Button();
            this.btnCreatePost = new Button();
            this.btnReload = new Button(); 
            this.flowFeed = new FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // Modern color variables
            var primaryColor = Color.FromArgb(59, 130, 246);
            var backgroundColor = Color.FromArgb(249, 250, 251);
            var cardColor = Color.White;
            var textPrimary = Color.FromArgb(17, 24, 39);
            var textSecondary = Color.FromArgb(107, 114, 128);
            var borderColor = Color.FromArgb(229, 231, 235);

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = cardColor;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.btnReload);
            this.panelHeader.Controls.Add(this.btnFilter);
            this.panelHeader.Controls.Add(this.btnCreatePost);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Margin = new Padding(3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new Padding(32, 16, 32, 16);
            this.panelHeader.Size = new Size(1300, 80);
            this.panelHeader.TabIndex = 0;

            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblTitle.ForeColor = primaryColor;
            this.lblTitle.Location = new Point(32, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(298, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "InvestOnIdeas";

            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.txtSearch.BackColor = backgroundColor;
            this.txtSearch.BorderStyle = BorderStyle.FixedSingle;
            this.txtSearch.Font = new Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = textPrimary;
            this.txtSearch.Location = new Point(580, 20);
            this.txtSearch.Size = new Size(340, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Search ideas...";
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);

            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnFilter.BackColor = backgroundColor;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = FlatStyle.Flat;
            this.btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.btnFilter.ForeColor = textSecondary;
            this.btnFilter.Location = new Point(1040, 20);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new Size(90, 34);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new EventHandler(this.btnFilter_Click);

            //
            //btnReload
            //
            this.btnReload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnReload.BackColor = backgroundColor;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = FlatStyle.Flat;
            this.btnReload.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.btnReload.ForeColor = textSecondary;
            this.btnReload.Location = new Point(940, 20);
            this.btnReload.Size = new Size(90, 34);  // 👈 Adjust position before Filter
            this.btnReload.Name = "btnReload";
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload 🔄";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new EventHandler(this.btnReload_Click);

            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnCreatePost.BackColor = primaryColor;
            this.btnCreatePost.FlatAppearance.BorderSize = 0;
            this.btnCreatePost.FlatStyle = FlatStyle.Flat;
            this.btnCreatePost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCreatePost.ForeColor = Color.White;
            this.btnCreatePost.Location = new Point(1140, 20);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new Size(120, 34);
            this.btnCreatePost.TabIndex = 3;
            this.btnCreatePost.Text = "Post Idea";
            this.btnCreatePost.UseVisualStyleBackColor = false;
            this.btnCreatePost.Click += new EventHandler(this.btnCreatePost_Click);

            // 
            // flowFeed
            // 
            this.flowFeed.AutoScroll = true;
            this.flowFeed.BackColor = backgroundColor;
            this.flowFeed.Dock = DockStyle.Fill;
            this.flowFeed.FlowDirection = FlowDirection.TopDown;
            this.flowFeed.Location = new Point(0, 80);
            this.flowFeed.Name = "flowFeed";
            this.flowFeed.Padding = new Padding(80, 32, 80, 32);
            this.flowFeed.Size = new Size(1300, 868);
            this.flowFeed.TabIndex = 0;
            this.flowFeed.WrapContents = false;

            // 
            // TimelineFeed
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = backgroundColor;
            this.ClientSize = new Size(1300, 948);
            this.Controls.Add(this.flowFeed);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "TimelineFeed";
            this.Text = "InvestOnIdeas - Timeline";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}